using Microsoft.EntityFrameworkCore;
using MotorbikeServices.BLL.DTOs;
using MotorbikeServices.DAL;
using MotorbikeServices.DAL.Models;
using MotorbikeServices.DAL.Models.Maintenance;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MotorbikeServices.BLL.Services
{
    public class QuanLyBaoDuongService
    {
        // 1. Lấy danh sách xe của User
        public List<UserXeDTO> GetDanhSachXeByUser(int userId)
        {
            using (var db = new AppDbContext())
            {
                var listXe = db.UserXes
                    .Include(x => x.DongXe)
                        .ThenInclude(d => d.HangXe)
                    .Where(x => x.UserId == userId)
                    .ToList();

                var result = new List<UserXeDTO>();
                int stt = 1;

                foreach (var x in listXe)
                {
                    result.Add(new UserXeDTO
                    {
                        Id = x.Id,
                        STT = stt++,
                        TenHangXe = x.DongXe?.HangXe?.TenHang ?? "Xe",
                        TenDongXe = x.DongXe?.TenDongXe ?? "",
                        BienSoXe = x.BienSoXe ?? "Chưa có BS",
                        HangXeId = x.DongXe?.HangXeId ?? 0,
                        DongXeId = x.DongXeId,
                        NgayMuaXe = x.NgayMuaXe
                    });
                }

                return result;
            }
        }

        // 2. Lấy danh sách lịch bảo dưỡng riêng của từng xe (Tự động khởi tạo nếu chưa có)
        public List<LichBaoDuongDTO> GetLichBaoDuongByXe(int userXeId, int dongXeId)
        {
            using (var db = new AppDbContext())
            {
                var userXe = db.UserXes.FirstOrDefault(x => x.Id == userXeId);
                if (userXe == null) return new List<LichBaoDuongDTO>();

                // A. Kiểm tra xem chiếc xe này đã có bản ghi trong QuyChuanXeNguoiDungs chưa
                var listQuyChuanUser = db.QuyChuanXeNguoiDungs
                    .Include(q => q.QuyChuanBaoDuong)
                    .Where(q => q.UserXeId == userXeId)
                    .ToList();

                // B. Nếu chưa có -> Tự động copy từ QuyChuanBaoDuong gán sang với ngày mặc định = NgayMuaXe
                if (!listQuyChuanUser.Any())
                {
                    var listQuyChuanGoc = db.QuyChuanBaoDuongs
                        .Where(q => q.DongXeId == dongXeId)
                        .ToList();

                    foreach (var qcGoc in listQuyChuanGoc)
                    {
                        var qcMoi = new QuyChuanXeNguoiDung
                        {
                            UserXeId = userXeId,
                            QuyChuanBaoDuongId = qcGoc.Id,
                            NgayBaoDuongLanCuoi = userXe.NgayMuaXe
                        };
                        db.QuyChuanXeNguoiDungs.Add(qcMoi);
                    }
                    db.SaveChanges();

                    // Re-query sau khi khởi tạo
                    listQuyChuanUser = db.QuyChuanXeNguoiDungs
                        .Include(q => q.QuyChuanBaoDuong)
                        .Where(q => q.UserXeId == userXeId)
                        .ToList();
                }

                // C. Tính toán hiển thị lên DTO
                var result = new List<LichBaoDuongDTO>();
                int stt = 1;

                foreach (var qc in listQuyChuanUser)
                {
                    int soThang = qc.QuyChuanBaoDuong?.SoThang ?? 1;
                    DateTime ngayLanCuoi = qc.NgayBaoDuongLanCuoi;
                    DateTime ngayTiepTheo = ngayLanCuoi.AddMonths(soThang);

                    int soNgayConLai = (ngayTiepTheo.Date - DateTime.Now.Date).Days;
                    string tinhTrang;
                    int mucDoCanhBao;

                    if (soNgayConLai < 0)
                    {
                        tinhTrang = $"Quá hạn {Math.Abs(soNgayConLai)} ngày";
                        mucDoCanhBao = 2; // Đỏ
                    }
                    else if (soNgayConLai <= 5)
                    {
                        tinhTrang = $"Sắp tới hạn (còn {soNgayConLai} ngày)";
                        mucDoCanhBao = 1; // Vàng
                    }
                    else
                    {
                        tinhTrang = $"Còn hạn ({soNgayConLai} ngày)";
                        mucDoCanhBao = 0; // Thường
                    }

                    result.Add(new LichBaoDuongDTO
                    {
                        STT = stt++,
                        QuyChuanXeNguoiDungId = qc.Id,
                        TenQuyChuan = qc.QuyChuanBaoDuong?.TenQuyChuan ?? "Bảo dưỡng định kỳ",
                        DinhKyBaoDuong = $"{soThang} tháng",
                        SoThangDinhKy = soThang,
                        NgayBaoDuongLanCuoi = ngayLanCuoi,
                        NgayBaoDuongTiepTheo = ngayTiepTheo,
                        TinhTrang = tinhTrang,
                        MucDoCanhBao = mucDoCanhBao
                    });
                }

                return result;
            }
        }

        // 3. Hàm Cập Nhật Ngày Bảo Dưỡng do Người dùng chủ động chọn
        public bool CapNhatNgayBaoDuong(int quyChuanXeNguoiDungId, DateTime ngayMoi)
        {
            using (var db = new AppDbContext())
            {
                var item = db.QuyChuanXeNguoiDungs.FirstOrDefault(q => q.Id == quyChuanXeNguoiDungId);
                if (item != null)
                {
                    item.NgayBaoDuongLanCuoi = ngayMoi;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }
    }
}
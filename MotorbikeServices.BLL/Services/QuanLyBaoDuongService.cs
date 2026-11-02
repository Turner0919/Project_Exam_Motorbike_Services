using Microsoft.EntityFrameworkCore;
using MotorbikeServices.BLL.DTOs;
using MotorbikeServices.DAL;
using MotorbikeServices.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MotorbikeServices.BLL.Services
{
    public class QuanLyBaoDuongService
    {
        // 1. Lấy danh sách các xe mà User đang sở hữu
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
                    // Đã map đúng tên thuộc tính trong Model UserXe của dự án
                    string tenHang = x.DongXe?.HangXe?.TenHang ?? "Xe";
                    string tenDong = x.DongXe?.TenDongXe ?? "";
                    string bienSo = x.BienSoXe ?? "Chưa có BS";

                    result.Add(new UserXeDTO
                    {
                        Id = x.Id,
                        STT = stt++,
                        TenHangXe = tenHang,
                        TenDongXe = tenDong,
                        BienSoXe = bienSo,
                        HangXeId = x.DongXe?.HangXeId ?? 0,
                        DongXeId = x.DongXeId,
                        NgayMuaXe = x.NgayMuaXe
                    });
                }

                return result;
            }
        }

        // 2. Tính toán lịch bảo dưỡng định kỳ theo từng dòng xe của User
        public List<LichBaoDuongDTO> GetLichBaoDuongByXe(int userXeId, int dongXeId)
        {
            using (var db = new AppDbContext())
            {
                // Lấy các quy chuẩn định kỳ thuộc Dòng xe này
                var listQuyChuan = db.QuyChuanBaoDuongs
                    .Where(q => q.DongXeId == dongXeId)
                    .ToList();

                var result = new List<LichBaoDuongDTO>();
                int stt = 1;

                // Lấy ngày mua xe làm mốc bảo dưỡng ban đầu
                DateTime ngayMocMacDinh = DateTime.Now.AddMonths(-1);
                var userXe = db.UserXes.FirstOrDefault(x => x.Id == userXeId);
                if (userXe != null && userXe.NgayMuaXe != default)
                {
                    ngayMocMacDinh = userXe.NgayMuaXe;
                }

                foreach (var qc in listQuyChuan)
                {
                    DateTime ngayLanCuoi = ngayMocMacDinh;

                    // Lấy số tháng quy chuẩn (sử dụng SoThang trong QuyChuanBaoDuong.cs)
                    int soThang = qc.SoThang;

                    // Tự động tính ngày tiếp theo = Ngày bảo dưỡng lần cuối + Số tháng định kỳ
                    DateTime ngayTiepTheo = ngayLanCuoi.AddMonths(soThang);

                    // Tính độ chênh lệch số ngày so với hôm nay
                    int soNgayConLai = (ngayTiepTheo.Date - DateTime.Now.Date).Days;

                    string tinhTrang;
                    int mucDoCanhBao;

                    if (soNgayConLai < 0)
                    {
                        tinhTrang = $"Quá hạn {Math.Abs(soNgayConLai)} ngày";
                        mucDoCanhBao = 2; // Mức 2: Quá hạn (Hiển thị Đỏ)
                    }
                    else if (soNgayConLai <= 5)
                    {
                        tinhTrang = $"Sắp tới hạn (còn {soNgayConLai} ngày)";
                        mucDoCanhBao = 1; // Mức 1: Sắp tới hạn (Hiển thị Vàng)
                    }
                    else
                    {
                        tinhTrang = $"Còn hạn ({soNgayConLai} ngày)";
                        mucDoCanhBao = 0; // Mức 0: An toàn (Hiển thị Bình thường)
                    }

                    result.Add(new LichBaoDuongDTO
                    {
                        STT = stt++,
                        QuyChuanId = qc.Id,
                        TenQuyChuan = qc.TenQuyChuan ?? "Bảo dưỡng định kỳ",
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
    }
}
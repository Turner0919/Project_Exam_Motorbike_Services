using Microsoft.EntityFrameworkCore;
using MotorbikeServices.BLL.DTOs;
using MotorbikeServices.DAL;
using MotorbikeServices.DAL.Models;
using MotorbikeServices.DAL.Models.Maintenance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MotorbikeServices.BLL.Services
{
    public class QuanLyBaoDuongService
    {
        private readonly KiemTraDonService _kiemTraDonService = new KiemTraDonService();
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
        // 6. Lấy thông tin hồ sơ xe & lịch bảo dưỡng của User để gửi cho AI trả lời
        public string GetThongTinBaoDuongUserForAI(int userId)
        {
            var sb = new StringBuilder();

            using (var db = new AppDbContext())
            {
                // --- PHẦN 1: LẤY THÔNG TIN XE VÀ LỊCH BẢO DƯỠNG ---
                var listXe = db.UserXes
                    .Include(x => x.DongXe)
                        .ThenInclude(d => d.HangXe)
                    .Where(x => x.UserId == userId)
                    .ToList();

                sb.AppendLine($"=== HỒ SƠ XE VÀ LỊCH BẢO DƯỠNG KHÁCH HÀNG (UserId: {userId}) ===");
                if (!listXe.Any())
                {
                    sb.AppendLine("Khách hàng chưa đăng ký chiếc xe nào trong hệ thống.");
                }
                else
                {
                    foreach (var xe in listXe)
                    {
                        string tenHang = xe.DongXe?.HangXe?.TenHang ?? "Xe";
                        string tenDong = xe.DongXe?.TenDongXe ?? "";
                        string bienSo = xe.BienSoXe ?? "Chưa có BS";
                        sb.AppendLine($"- Chiếc xe: {tenHang} {tenDong} | Biển số: {bienSo} | Ngày mua: {xe.NgayMuaXe:dd/MM/yyyy}");

                        var listQuyChuanUser = db.QuyChuanXeNguoiDungs
                            .Include(q => q.QuyChuanBaoDuong)
                            .Where(q => q.UserXeId == xe.Id)
                            .ToList();

                        foreach (var qc in listQuyChuanUser)
                        {
                            int soThang = qc.QuyChuanBaoDuong?.SoThang ?? 1;
                            string tenQuyChuan = qc.QuyChuanBaoDuong?.TenQuyChuan ?? "Bảo dưỡng định kỳ";
                            DateTime ngayLanCuoi = qc.NgayBaoDuongLanCuoi;
                            DateTime ngayTiepTheo = ngayLanCuoi.AddMonths(soThang);

                            int soNgayConLai = (ngayTiepTheo.Date - DateTime.Now.Date).Days;
                            string tinhTrang;

                            if (soNgayConLai < 0)
                                tinhTrang = $"Quá hạn {Math.Abs(soNgayConLai)} ngày";
                            else if (soNgayConLai <= 5)
                                tinhTrang = $"Sắp tới hạn (còn {soNgayConLai} ngày)";
                            else
                                tinhTrang = $"Còn hạn ({soNgayConLai} ngày)";

                            sb.AppendLine($"  + Hạng mục: {tenQuyChuan} | Bảo dưỡng lần cuối: {ngayLanCuoi:dd/MM/yyyy} | Hạn tiếp theo: {ngayTiepTheo:dd/MM/yyyy} | Trạng thái: {tinhTrang}");
                        }
                    }
                }
            }

            // --- PHẦN 2: LẤY DANH SÁCH ĐƠN ĐÃ ĐẶT TỪ KiemTraDonService ---
            try
            {
                var listHoaDon = _kiemTraDonService.GetDanhSachHoaDonUser(userId); // Gọi trực tiếp từ KiemTraDonService

                sb.AppendLine("\n=== DANH SÁCH ĐƠN DỊCH VỤ / HÓA ĐƠN ĐÃ ĐẶT ===");
                if (listHoaDon == null || listHoaDon.Count == 0)
                {
                    sb.AppendLine("Khách hàng chưa có đơn đặt hàng hoặc dịch vụ nào.");
                }
                else
                {
                    foreach (var hd in listHoaDon)
                    {
                        sb.AppendLine($"- Mã đơn: {hd.MaHoaDon} | Cửa hàng: {hd.CuaHang} | Địa chỉ: {hd.DiaChiCuaHang} | Ngày đặt: {hd.NgayDat:dd/MM/yyyy HH:mm} | Tổng tiền: {hd.TongTien:N0} VNĐ | Trạng thái: {hd.TrangThai}");

                        // Thêm chi tiết các xe và sản phẩm dịch vụ trong đơn đó
                        if (hd.ChiTiets != null && hd.ChiTiets.Count > 0)
                        {
                            foreach (var ct in hd.ChiTiets)
                            {
                                sb.AppendLine($"   + Chi tiết: Xe {ct.TenXe} (BS: {ct.BienSo}) | Dịch vụ/SP: {ct.DichVuSanPham} | Số lượng: {ct.SoLuong} | Đơn giá: {ct.DonGia:N0} VNĐ");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                sb.AppendLine($"\nLỗi khi truy vấn đơn hàng: {ex.Message}");
            }

            return sb.ToString();
        }
     }
}

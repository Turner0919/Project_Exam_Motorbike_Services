using Microsoft.EntityFrameworkCore;
using MotorbikeServices.BLL.DTOs;
using MotorbikeServices.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotorbikeServices.BLL.Services
{
    public class CuaHangBaoDuongService
    {
        // 1. Lấy danh sách hóa đơn thuộc Cửa hàng (nhanVienId)
        public List<CuaHangBaoDuongDTO> GetDanhSachBaoDuongByCuaHang(int nhanVienId)
        {
            using (var db = new AppDbContext())
            {
                // 1. Lấy danh sách Hóa đơn của Cửa hàng
                var listHoaDon = db.HoaDons
                    .Include(h => h.ChiTietHoaDons)
                        .ThenInclude(ct => ct.SanPham)
                    .Where(h => h.NhanVienId == nhanVienId)
                    .OrderByDescending(h => h.NgayTao)
                    .ToList();

                // 2. Lấy danh sách UserId có trong các hóa đơn đó
                var userIds = listHoaDon.Select(h => h.UserId).Distinct().ToList();

                // 3. Truy vấn bảng UserUses để lấy Họ tên, SĐT, Email chuẩn từ CSDL
                var dictUserUse = db.UserUses
                    .Where(u => userIds.Contains(u.UserId))
                    .ToDictionary(u => u.UserId, u => u);

                var result = new List<CuaHangBaoDuongDTO>();

                foreach (var hd in listHoaDon)
                {
                    // Tìm thông tin UserUse tương ứng với UserId của hóa đơn
                    dictUserUse.TryGetValue(hd.UserId, out var userUse);

                    var dto = new CuaHangBaoDuongDTO
                    {
                        MaHoaDon = hd.Id,
                        TenKhach = userUse?.HoTen ?? "Khách hàng",
                        SoDienThoai = userUse?.SoDienThoai ?? "",
                        EmailKH = userUse?.Email ?? "",
                        NgayDat = hd.NgayTao,
                        TongTien = hd.TongTien,
                        TrangThai = hd.TrangThai
                    };

                    int stt = 1;
                    foreach (var ct in hd.ChiTietHoaDons)
                    {
                        dto.ChiTiets.Add(new CuaHangChiTietDTO
                        {
                            STT = stt++,
                            ThongTinXe = ct.TenXe,
                            BienSoXe = ct.BienSo,
                            SanPhamDichVu = ct.SanPham?.TenSanPham ?? "",
                            SoLuong = ct.SoLuong,
                            DonGia = ct.DonGia
                        });
                    }

                    result.Add(dto);
                }

                return result;
            }
        }

        // 2. Duyệt đơn hàng (Chuyển trạng thái từ "Chờ xác nhận" -> "Đã duyệt")
        public (bool IsSuccess, string Message) DuyetDonHang(int hoaDonId)
        {
            using (var db = new AppDbContext())
            {
                var hoaDon = db.HoaDons.FirstOrDefault(h => h.Id == hoaDonId);
                if (hoaDon == null)
                    return (false, "Không tìm thấy hóa đơn cần duyệt!");

                if (hoaDon.TrangThai == "Đã hủy")
                    return (false, "Đơn hàng đã bị hủy, không thể duyệt!");

                if (hoaDon.TrangThai == "Đã duyệt")
                    return (false, "Đơn hàng này đã được duyệt trước đó rồi!");

                hoaDon.TrangThai = "Đã duyệt";
                db.SaveChanges();

                return (true, $"Đã duyệt đơn hàng #{hoaDonId} thành công!");
            }
        }

        // 3. Hủy đơn hàng phía Cửa hàng & Hoàn trả số lượng tồn kho
        public (bool IsSuccess, string Message) HuyDonHangPhiaCuaHang(int hoaDonId)
        {
            using (var db = new AppDbContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var hoaDon = db.HoaDons
                            .Include(h => h.ChiTietHoaDons)
                            .FirstOrDefault(h => h.Id == hoaDonId);

                        if (hoaDon == null)
                            return (false, "Không tìm thấy hóa đơn cần hủy!");

                        if (hoaDon.TrangThai == "Đã hủy")
                            return (false, "Đơn hàng này đã ở trạng thái hủy!");

                        // Cập nhật trạng thái
                        hoaDon.TrangThai = "Đã hủy";

                        // Hoàn trả lại số lượng tồn kho cho sản phẩm
                        foreach (var ct in hoaDon.ChiTietHoaDons)
                        {
                            var sp = db.SanPhams.FirstOrDefault(s => s.Id == ct.SanPhamId);
                            if (sp != null)
                            {
                                sp.SoLuongTon += ct.SoLuong; // Cộng trả kho
                            }
                        }

                        db.SaveChanges();
                        transaction.Commit();

                        return (true, $"Đã hủy đơn hàng #{hoaDonId} và hoàn trả lại số lượng tồn kho!");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return (false, "Có lỗi xảy ra khi hủy đơn: " + ex.Message);
                    }
                }
            }
        }
    }
}

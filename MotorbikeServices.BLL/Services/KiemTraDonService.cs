using MotorbikeServices.BLL.DTOs;
using MotorbikeServices.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace MotorbikeServices.BLL.Services
{
    public class KiemTraDonService
    {
        // 1. Lấy danh sách Hóa đơn & Chi tiết của User hiện tại
        public List<HoaDonKiemTraDTO> GetDanhSachHoaDonUser(int userId)
        {
            using (var db = new AppDbContext())
            {
                var list = db.HoaDons
                    .Include(h => h.NhanVienUse)
                        .ThenInclude(n => n.DiaChi)
                    .Include(h => h.ChiTietHoaDons)
                        .ThenInclude(ct => ct.SanPham)
                    .Where(h => h.UserId == userId)
                    .OrderByDescending(h => h.NgayTao)
                    .ToList();

                var result = new List<HoaDonKiemTraDTO>();

                foreach (var hd in list)
                {
                    string diaChiFull = hd.NhanVienUse?.DiaChi != null
                        ? $"{hd.NhanVienUse.SoCuaHang} {hd.NhanVienUse.TenDuong}, {hd.NhanVienUse.DiaChi.PhuongXa}, {hd.NhanVienUse.DiaChi.TinhTP}".Trim(' ', ',')
                        : hd.NhanVienUse?.TenDuong ?? "";

                    var dto = new HoaDonKiemTraDTO
                    {
                        MaHoaDon = hd.Id,
                        CuaHang = hd.NhanVienUse?.TenCuaHang ?? "Cửa hàng",
                        DiaChiCuaHang = diaChiFull,
                        NgayDat = hd.NgayTao,
                        TongTien = hd.TongTien,
                        TrangThai = hd.TrangThai
                    };

                    int stt = 1;
                    foreach (var ct in hd.ChiTietHoaDons)
                    {
                        dto.ChiTiets.Add(new ChiTietDichVuDTO
                        {
                            STT = stt++,
                            TenXe = ct.TenXe,
                            BienSo = ct.BienSo,
                            DichVuSanPham = ct.SanPham?.TenSanPham ?? "",
                            SoLuong = ct.SoLuong,
                            DonGia = ct.DonGia
                        });
                    }

                    result.Add(dto);
                }

                return result;
            }
        }

        // 2. Hủy đơn hàng (Chỉ cho phép khi Trạng Thái == "Chờ xác nhận")
        public (bool IsSuccess, string Message) HuyDonHang(int hoaDonId, int userId)
        {
            using (var db = new AppDbContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var hoaDon = db.HoaDons
                            .Include(h => h.ChiTietHoaDons)
                            .FirstOrDefault(h => h.Id == hoaDonId && h.UserId == userId);

                        if (hoaDon == null)
                            return (false, "Không tìm thấy hóa đơn cần hủy!");

                        // KIỂM TRA ĐIỀU KIỆN TRẠNG THÁI
                        if (hoaDon.TrangThai != "Chờ xác nhận")
                        {
                            return (false, $"Đơn hàng đã ở trạng thái '{hoaDon.TrangThai}', không thể hủy!");
                        }

                        // Cập nhật trạng thái Hóa đơn sang "Đã hủy"
                        hoaDon.TrangThai = "Đã hủy";

                        // Hoàn trả lại Số lượng tồn cho các Sản phẩm trong đơn
                        foreach (var ct in hoaDon.ChiTietHoaDons)
                        {
                            var sp = db.SanPhams.FirstOrDefault(s => s.Id == ct.SanPhamId);
                            if (sp != null)
                            {
                                sp.SoLuongTon += ct.SoLuong; // Cộng trả lại kho
                            }
                        }

                        db.SaveChanges();
                        transaction.Commit();

                        return (true, "Đã hủy đơn hàng thành công và hoàn trả số lượng tồn!");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return (false, "Lỗi khi hủy đơn hàng: " + ex.Message);
                    }
                }
            }
        }
    }
}

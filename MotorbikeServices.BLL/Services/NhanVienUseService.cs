using MotorbikeServices.BLL.DTOs;
using MotorbikeServices.DAL.Models;
using MotorbikeServices.DAL.Models.Maintenance;
using MotorbikeServices.DAL.Models.Store;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MotorbikeServices.BLL.Services
{
    public class NhanVienUseService
    {
        // 1. Lấy danh sách Tỉnh/TP (Không trùng lặp) từ bảng DiaChis
        public List<string> GetDanhSachTinhTP()
        {
            using (var db = new AppDbContext())
            {
                return db.DiaChis.Select(d => d.TinhTP).Distinct().ToList();
            }
        }

        // 2. Lấy danh sách Phường/Xã dựa theo Tỉnh/TP đã chọn
        public List<DiaChi> GetDanhSachPhuongByTinh(string tinhTP)
        {
            using (var db = new AppDbContext())
            {
                return db.DiaChis.Where(d => d.TinhTP == tinhTP).ToList();
            }
        }

        // 3. Lấy thông tin cửa hàng theo NhanVienId
        public NhanVienUseDTO GetThongTinCuaHang(int nhanVienId)
        {
            using (var db = new AppDbContext())
            {
                var nv = db.NhanViens.FirstOrDefault(n => n.Id == nhanVienId);
                if (nv == null) return null!;

                var nvUse = db.NhanVienUses
                    .Include(u => u.DiaChi)
                    .FirstOrDefault(u => u.NhanVienId == nhanVienId);

                return new NhanVienUseDTO
                {
                    NhanVienId = nhanVienId,
                    TenTaiKhoan = nv.TenTaiKhoan,
                    TenCuaHang = nvUse?.TenCuaHang ?? "",
                    TrangThai = nvUse?.TrangThai ?? "",
                    DiaChiId = nvUse?.DiaChiId,
                    TinhTP = nvUse?.DiaChi?.TinhTP ?? "",
                    PhuongXa = nvUse?.DiaChi?.PhuongXa ?? "",
                    TenDuong = nvUse?.TenDuong ?? "",
                    SoCuaHang = nvUse?.SoCuaHang ?? ""
                };
            }
        }

        // 4. Lưu / Cập nhật thông tin Cửa hàng
        public (bool IsSuccess, string Message) CapNhatThongTinCuaHang(NhanVienUseDTO dto)
        {
            using (var db = new AppDbContext())
            {
                var nvUse = db.NhanVienUses.FirstOrDefault(u => u.NhanVienId == dto.NhanVienId);
                if (nvUse == null)
                {
                    nvUse = new NhanVienUse { NhanVienId = dto.NhanVienId };
                    db.NhanVienUses.Add(nvUse);
                }

                nvUse.TenCuaHang = dto.TenCuaHang.Trim();
                nvUse.TrangThai = dto.TrangThai.Trim();
                nvUse.DiaChiId = dto.DiaChiId;
                nvUse.TenDuong = dto.TenDuong.Trim();
                nvUse.SoCuaHang = dto.SoCuaHang.Trim();

                db.SaveChanges();
                return (true, "Cập nhật thông tin cửa hàng thành công!");
            }
        }
    }
}

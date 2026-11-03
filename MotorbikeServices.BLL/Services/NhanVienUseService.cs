
using MotorbikeServices.BLL.DTOs;
using MotorbikeServices.DAL.Models;
using MotorbikeServices.DAL.Models.Maintenance;
using MotorbikeServices.DAL.Models.Store;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MotorbikeServices.BLL.Services
{
    public class NhanVienUseService
    {
        // 1. Lấy danh sách Tỉnh/TP
        public List<string> GetDanhSachTinhTP()
        {
            using (var db = new AppDbContext())
            {
                return db.DiaChis
                    .Select(d => d.TinhTP)
                    .Distinct()
                    .ToList();
            }
        }

        // 2. Lấy danh sách Phường/Xã theo Tỉnh/TP
        public List<DiaChi> GetDanhSachPhuongByTinh(string tinhTP)
        {
            using (var db = new AppDbContext())
            {
                return db.DiaChis
                    .Where(d => d.TinhTP == tinhTP)
                    .ToList();
            }
        }

        // 3. Lấy thông tin cửa hàng theo NhanVienId
        public NhanVienUseDTO GetThongTinCuaHang(int nhanVienId)
        {
            using (var db = new AppDbContext())
            {
                var nv = db.NhanViens
                    .FirstOrDefault(n => n.Id == nhanVienId);

                if (nv == null)
                    return null!;

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

        // 4. Lưu / Cập nhật thông tin cửa hàng
        public (bool IsSuccess, string Message) CapNhatThongTinCuaHang(
            NhanVienUseDTO dto)
        {
            using (var db = new AppDbContext())
            {
                var nvUse = db.NhanVienUses
                    .FirstOrDefault(u => u.NhanVienId == dto.NhanVienId);

                if (nvUse == null)
                {
                    nvUse = new NhanVienUse
                    {
                        NhanVienId = dto.NhanVienId
                    };

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

        // 5. Lấy danh sách tất cả cửa hàng dành cho Admin
        public List<NhanVienUseDTO> GetDanhSachCuaHang()
        {
            using (var db = new AppDbContext())
            {
                return db.NhanVienUses
                    .Include(u => u.NhanVien)
                    .Include(u => u.DiaChi)
                    .OrderBy(u => u.NhanVienId)
                    .Select(u => new NhanVienUseDTO
                    {
                        NhanVienId = u.NhanVienId,
                        TenTaiKhoan = u.NhanVien.TenTaiKhoan,
                        TenCuaHang = u.TenCuaHang ?? "",
                        TrangThai = u.TrangThai ?? "",
                        DiaChiId = u.DiaChiId,
                        TinhTP = u.DiaChi != null
                            ? u.DiaChi.TinhTP
                            : "",
                        PhuongXa = u.DiaChi != null
                            ? u.DiaChi.PhuongXa
                            : "",
                        TenDuong = u.TenDuong ?? "",
                        SoCuaHang = u.SoCuaHang ?? ""
                    })
                    .ToList();
            }
        }

        // 6. Chỉ cập nhật trạng thái hoạt động của cửa hàng
        public (bool IsSuccess, string Message) CapNhatTrangThaiCuaHang(
            int nhanVienId,
            string trangThai)
        {
            // Kiểm tra trạng thái hợp lệ
            if (trangThai != "Đang hoạt động" &&
                trangThai != "Tạm ngừng hoạt động")
            {
                return (false, "Trạng thái cửa hàng không hợp lệ.");
            }

            using (var db = new AppDbContext())
            {
                var cuaHang = db.NhanVienUses
                    .FirstOrDefault(u => u.NhanVienId == nhanVienId);

                if (cuaHang == null)
                {
                    return (false, "Không tìm thấy cửa hàng cần cập nhật.");
                }

                cuaHang.TrangThai = trangThai;

                db.SaveChanges();

                return (true, "Cập nhật trạng thái cửa hàng thành công.");
            }
        }
        // Lấy Tên Cửa Hàng dựa theo NhanVienId đang đăng nhập
        public string GetTenCuaHangByNhanVienId(int nhanVienId)
        {
            using (var db = new AppDbContext())
            {
                var nvUse = db.NhanVienUses.FirstOrDefault(x => x.NhanVienId == nhanVienId);
                if (nvUse != null && !string.IsNullOrWhiteSpace(nvUse.TenCuaHang))
                {
                    return nvUse.TenCuaHang;
                }
                return "DAIDAIMOTOR"; // Tên mặc định dự phòng
            }
        }
    }
}

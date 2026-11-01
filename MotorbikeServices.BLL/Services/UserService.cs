using MotorbikeServices.DAL;
using MotorbikeServices.DAL.Models;
using MotorbikeServices.DAL.Models.Account;
using MotorbikeServices.DAL.Models.Maintenance;
using Microsoft.EntityFrameworkCore; // BẮT BỘC: Để sử dụng được hàm .Include()
using System;
using System.Collections.Generic;
using System.Linq;

namespace MotorbikeServices.BLL.Services
{
    public class UserService
    {
        // 1. Lấy thông tin cá nhân của User dựa vào UserId (JOIN kèm bảng DiaChi)
        public UserUse? GetUserProfile(int userId)
        {
            using (var db = new AppDbContext())
            {
                // BẮT BỘC PHẢI CÓ .Include(u => u.DiaChi) để lấy tên Tỉnh/Phường từ bảng DiaChis
                return db.UserUses
                    .Include(u => u.DiaChi)
                    .FirstOrDefault(u => u.UserId == userId);
            }
        }

        // 2. Lấy danh sách Tỉnh/TP (Không trùng lặp) từ bảng DiaChis
        public List<string> GetDanhSachTinhTP()
        {
            using (var db = new AppDbContext())
            {
                return db.DiaChis.Select(d => d.TinhTP).Distinct().ToList();
            }
        }

        // 3. Lấy danh sách Phường/Xã thuộc Tỉnh/TP được chọn
        public List<DiaChi> GetDanhSachPhuongByTinh(string tinhTP)
        {
            using (var db = new AppDbContext())
            {
                return db.DiaChis.Where(d => d.TinhTP == tinhTP).ToList();
            }
        }

        // 4. Cập nhật hoặc Thêm mới thông tin cá nhân (Lưu DiaChiId, TenDuong, SoNha)
        public bool SaveOrUpdateProfile(int userId, string hoTen, DateTime? ngaySinh, string gioiTinh, string sdt, string email, int? diaChiId, string tenDuong, string soNha)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var profile = db.UserUses.FirstOrDefault(u => u.UserId == userId);

                    if (profile == null)
                    {
                        // Lần đầu cập nhật -> Tạo mới bản ghi
                        profile = new UserUse
                        {
                            UserId = userId,
                            HoTen = string.IsNullOrWhiteSpace(hoTen) ? null : hoTen.Trim(),
                            NgaySinh = ngaySinh,
                            GioiTinh = string.IsNullOrWhiteSpace(gioiTinh) ? null : gioiTinh,
                            SoDienThoai = string.IsNullOrWhiteSpace(sdt) ? null : sdt.Trim(),
                            Email = string.IsNullOrWhiteSpace(email) ? null : email.Trim(),

                            // Thông tin địa chỉ nơi ở
                            DiaChiId = diaChiId,
                            TenDuong = string.IsNullOrWhiteSpace(tenDuong) ? null : tenDuong.Trim(),
                            SoNha = string.IsNullOrWhiteSpace(soNha) ? null : soNha.Trim()
                        };
                        db.UserUses.Add(profile);
                    }
                    else
                    {
                        // Đã có -> Cập nhật thông tin
                        profile.HoTen = string.IsNullOrWhiteSpace(hoTen) ? null : hoTen.Trim();
                        profile.NgaySinh = ngaySinh;
                        profile.GioiTinh = string.IsNullOrWhiteSpace(gioiTinh) ? null : gioiTinh;
                        profile.SoDienThoai = string.IsNullOrWhiteSpace(sdt) ? null : sdt.Trim();
                        profile.Email = string.IsNullOrWhiteSpace(email) ? null : email.Trim();

                        // Cập nhật thông tin địa chỉ nơi ở
                        profile.DiaChiId = diaChiId;
                        profile.TenDuong = string.IsNullOrWhiteSpace(tenDuong) ? null : tenDuong.Trim();
                        profile.SoNha = string.IsNullOrWhiteSpace(soNha) ? null : soNha.Trim();
                    }

                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
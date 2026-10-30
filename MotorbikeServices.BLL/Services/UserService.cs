using MotorbikeServices.DAL;
using MotorbikeServices.DAL.Models;
using MotorbikeServices.DAL.Models.Account;
using System;
using System.Linq;

namespace MotorbikeServices.BLL.Services
{
    public class UserService
    {
        public UserUse? GetUserProfile(int userId) // Lấy thông tin cá nhân của User dựa vào UserId
        {
            using (var db = new AppDbContext())
            {
                return db.UserUses.FirstOrDefault(u => u.UserId == userId);
            }
        }
        public bool SaveOrUpdateProfile(int userId, string hoTen, DateTime? ngaySinh, string gioiTinh, string sdt, string email)         // Cập nhật hoặc Thêm mới thông tin cá nhân
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var profile = db.UserUses.FirstOrDefault(u => u.UserId == userId);

                    if (profile == null)
                    {
                        profile = new UserUse // Lần đầu cập nhật -> Tạo mới bản ghi
                        {
                            UserId = userId,
                            HoTen = string.IsNullOrWhiteSpace(hoTen) ? null : hoTen.Trim(),
                            NgaySinh = ngaySinh,
                            GioiTinh = string.IsNullOrWhiteSpace(gioiTinh) ? null : gioiTinh,
                            SoDienThoai = string.IsNullOrWhiteSpace(sdt) ? null : sdt.Trim(),
                            Email = string.IsNullOrWhiteSpace(email) ? null : email.Trim()
                        };
                        db.UserUses.Add(profile);
                    }
                    else // Cho phép để rỗng    
                    {
                        profile.HoTen = string.IsNullOrWhiteSpace(hoTen) ? null : hoTen.Trim();
                        profile.NgaySinh = ngaySinh;
                        profile.GioiTinh = string.IsNullOrWhiteSpace(gioiTinh) ? null : gioiTinh;
                        profile.SoDienThoai = string.IsNullOrWhiteSpace(sdt) ? null : sdt.Trim();
                        profile.Email = string.IsNullOrWhiteSpace(email) ? null : email.Trim();
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
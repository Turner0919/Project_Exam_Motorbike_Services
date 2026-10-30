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
    public class UserXeService
    {
        // 1. Lấy danh sách Hãng xe cho Combobox Hãng xe
        public List<HangXe> GetDanhSachHangXe()
        {
            using (var db = new AppDbContext())
            {
                return db.HangXes.ToList();
            }
        }

        // 2. Lấy danh sách Dòng xe thuộc về 1 Hãng xe
        public List<DongXe> GetDanhSachDongXeByHang(int hangXeId)
        {
            using (var db = new AppDbContext())
            {
                return db.DongXes.Where(d => d.HangXeId == hangXeId).ToList();
            }
        }

        // 3. Lấy danh sách xe của Người dùng (Tự suy ra Hãng xe qua Dòng xe)
        public List<UserXeDTO> GetDanhSachXeByUser(int userId)
        {
            using (var db = new AppDbContext())
            {
                var list = db.UserXes
                    .Include(x => x.DongXe)
                        .ThenInclude(d => d.HangXe)
                    .Where(x => x.UserId == userId)
                    .ToList();

                var resultList = new List<UserXeDTO>();
                int stt = 1;

                foreach (var x in list)
                {
                    resultList.Add(new UserXeDTO
                    {
                        Id = x.Id,
                        STT = stt++,
                        TenHangXe = x.DongXe?.HangXe?.TenHang ?? "N/A",
                        TenDongXe = x.DongXe?.TenDongXe ?? "N/A",
                        BienSoXe = !string.IsNullOrEmpty(x.BienSoXe) ? x.BienSoXe : "Trống",
                        NgayMuaXe = x.NgayMuaXe,
                        HangXeId = x.DongXe?.HangXeId ?? 0,
                        DongXeId = x.DongXeId
                    });
                }

                return resultList;
            }
        }

        // 4. Thêm xe mới cho Người dùng
        public (bool IsSuccess, string Message) ThemXe(int userId, int dongXeId, string bienSoXe, DateTime ngayMuaXe)
        {
            if (string.IsNullOrWhiteSpace(bienSoXe))
                return (false, "Vui lòng nhập Biển số xe!");

            using (var db = new AppDbContext())
            {
                bool isExist = db.UserXes.Any(x => x.UserId == userId && x.BienSoXe == bienSoXe.Trim().ToUpper());
                if (isExist)
                    return (false, "Biển số xe này đã được đăng ký trong tài khoản của bạn!");

                var xeMoi = new UserXe
                {
                    UserId = userId,
                    DongXeId = dongXeId,
                    BienSoXe = bienSoXe.Trim().ToUpper(),
                    NgayMuaXe = ngayMuaXe
                };

                db.UserXes.Add(xeMoi);
                db.SaveChanges();
                return (true, "Thêm xe mới thành công!");
            }
        }

        // 5. Cập nhật thông tin xe
        public (bool IsSuccess, string Message) SuaXe(int userXeId, int dongXeId, string bienSoXe, DateTime ngayMuaXe)
        {
            if (string.IsNullOrWhiteSpace(bienSoXe))
                return (false, "Vui lòng nhập Biển số xe!");

            using (var db = new AppDbContext())
            {
                var xe = db.UserXes.FirstOrDefault(x => x.Id == userXeId);
                if (xe == null)
                    return (false, "Không tìm thấy thông tin xe cần sửa!");

                xe.DongXeId = dongXeId;
                xe.BienSoXe = bienSoXe.Trim().ToUpper();
                xe.NgayMuaXe = ngayMuaXe;

                db.SaveChanges();
                return (true, "Cập nhật thông tin xe thành công!");
            }
        }

        // 6. Xóa xe
        public (bool IsSuccess, string Message) XoaXe(int userXeId)
        {
            using (var db = new AppDbContext())
            {
                var xe = db.UserXes.FirstOrDefault(x => x.Id == userXeId);
                if (xe == null)
                    return (false, "Không tìm thấy thông tin xe cần xóa!");

                db.UserXes.Remove(xe);
                db.SaveChanges();
                return (true, "Xóa xe thành công!");
            }
        }
    }
}
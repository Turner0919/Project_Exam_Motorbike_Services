using System.Collections.Generic;
using System.Linq;
using MotorbikeServices.BLL.DTOs;
using MotorbikeServices.DAL.Models;

namespace MotorbikeServices.BLL.Services
{
    public class ThongKeTongQuanService
    {
        public ThongKeTongQuanDTO LayThongKeTongQuan()
        {
            using (var db = new AppDbContext())
            {
                var ketQua = new ThongKeTongQuanDTO
                {
                    // Các thẻ thống kê tổng quan
                    TongHangXe = db.HangXes.Count(),
                    TongDongXe = db.DongXes.Count(),
                    TongQuyChuan = db.QuyChuanBaoDuongs.Count(),

                    // Dự án có ba bảng tài khoản độc lập: Admin, User và Nhân viên.
                    TongTaiKhoan = db.Admins.Count()
                                  + db.Users.Count()
                                  + db.NhanViens.Count(),

                    // Lấy 8 hãng có nhiều dòng xe nhất để biểu đồ không quá dày.
                    DongXeTheoHang =
                        (from dongXe in db.DongXes
                         join hangXe in db.HangXes
                             on dongXe.HangXeId equals hangXe.Id
                         group dongXe by hangXe.TenHang into nhom
                         select new DuLieuBieuDoDTO
                         {
                             Nhan = nhom.Key,
                             GiaTri = nhom.Count()
                         })
                        .OrderByDescending(x => x.GiaTri)
                        .ThenBy(x => x.Nhan)
                        .Take(8)
                        .ToList(),

                    // Cơ cấu tài khoản theo ba vai trò.
                    TaiKhoanTheoVaiTro = new List<DuLieuBieuDoDTO>
                    {
                        new DuLieuBieuDoDTO { Nhan = "Admin", GiaTri = db.Admins.Count() },
                        new DuLieuBieuDoDTO { Nhan = "User", GiaTri = db.Users.Count() },
                        new DuLieuBieuDoDTO { Nhan = "Nhân viên", GiaTri = db.NhanViens.Count() }
                    }
                };

                // Phân bố quy chuẩn theo số tháng bảo dưỡng.
                ketQua.QuyChuanTheoChuKy = db.QuyChuanBaoDuongs
                    .GroupBy(q => q.SoThang)
                    .Select(nhom => new
                    {
                        SoThang = nhom.Key,
                        SoLuong = nhom.Count()
                    })
                    .OrderBy(x => x.SoThang)
                    .ToList()
                    .Select(x => new DuLieuBieuDoDTO
                    {
                        Nhan = x.SoThang + " tháng",
                        GiaTri = x.SoLuong
                    })
                    .ToList();

                // Gom các trạng thái cửa hàng; giá trị rỗng được thể hiện riêng.
                ketQua.CuaHangTheoTrangThai = db.NhanVienUses
                    .GroupBy(c => c.TrangThai)
                    .Select(nhom => new
                    {
                        TrangThai = nhom.Key,
                        SoLuong = nhom.Count()
                    })
                    .ToList()
                    .GroupBy(x => string.IsNullOrWhiteSpace(x.TrangThai)
                        ? "Chưa thiết lập"
                        : x.TrangThai.Trim())
                    .Select(nhom => new DuLieuBieuDoDTO
                    {
                        Nhan = nhom.Key,
                        GiaTri = nhom.Sum(x => x.SoLuong)
                    })
                    .OrderByDescending(x => x.GiaTri)
                    .ToList();

                return ketQua;
            }
        }
    }
}

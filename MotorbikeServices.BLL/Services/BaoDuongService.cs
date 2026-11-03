using MotorbikeServices.BLL.DTOs;
using MotorbikeServices.DAL.Models;
using MotorbikeServices.DAL.Models.Maintenance;
using MotorbikeServices.DAL.Models.Store;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace MotorbikeServices.BLL.Services
{
    public class BaoDuongService
    {
        // 1. Giữ hàng: Trừ trực tiếp số lượng tồn trong SQL khi người dùng bấm Thêm vào giỏ
        public (bool IsSuccess, string Message) TruKhoTamThoi(int sanPhamId, int soLuongTru)
        {
            using (var db = new AppDbContext())
            {
                var sp = db.SanPhams.FirstOrDefault(s => s.Id == sanPhamId);
                if (sp == null)
                    return (false, "Sản phẩm không tồn tại!");

                if (sp.SoLuongTon < soLuongTru)
                    return (false, $"Số lượng tồn kho không đủ (chỉ còn {sp.SoLuongTon})!");

                sp.SoLuongTon -= soLuongTru;
                db.SaveChanges();
                return (true, "Đã tạm giữ số lượng tồn thành công!");
            }
        }

        // 2. Hoàn trả kho: Cộng lại số lượng tồn khi bấm Xóa khỏi giỏ hoặc Hủy giỏ hàng
        public void HoanTraKhoTamThoi(int sanPhamId, int soLuongTra)
        {
            using (var db = new AppDbContext())
            {
                var sp = db.SanPhams.FirstOrDefault(s => s.Id == sanPhamId);
                if (sp != null)
                {
                    sp.SoLuongTon += soLuongTra;
                    db.SaveChanges();
                }
            }
        }
        // 1. Lấy thông tin địa chỉ cá nhân của User
        public (string TinhTP, string PhuongXa) GetDiaChiUser(int userId)
        {
            using (var db = new AppDbContext())
            {
                var userUse = db.UserUses.Include(u => u.DiaChi).FirstOrDefault(u => u.UserId == userId);
                if (userUse?.DiaChi != null)
                {
                    return (userUse.DiaChi.TinhTP, userUse.DiaChi.PhuongXa);
                }
                return ("", "");
            }
        }

        // 2. Lấy danh sách xe của User từ UserXe.cs
        public List<UserXe> GetDanhSachXeUser(int userId) // Lấy danh sách xe của User (JOIN kèm Dòng xe và Hãng xe)
        {
            using (var db = new AppDbContext())
            {
                return db.UserXes
                    .Include(x => x.DongXe)
                        .ThenInclude(d => d.HangXe)
                    .Where(x => x.UserId == userId)
                    .ToList();
            }
        }

        // 3. Tìm các cửa hàng trùng Tỉnh & Phường và có trạng thái "Đang hoạt động"
        public List<NhanVienUse> GetCuaHangHoatDongByDiaChi(string tinhTP, string phuongXa)
        {
            using (var db = new AppDbContext())
            {
                return db.NhanVienUses
                    .Include(n => n.DiaChi)
                    .Where(n => n.TrangThai == "Đang hoạt động" &&
                                n.DiaChi != null &&
                                n.DiaChi.TinhTP == tinhTP &&
                                n.DiaChi.PhuongXa == phuongXa)
                    .ToList();
            }
        }

        // 4. Lấy danh sách sản phẩm thuộc cửa hàng đã chọn
        public List<SanPham> GetSanPhamByCuaHang(int nhanVienId)
        {
            using (var db = new AppDbContext())
            {
                return db.SanPhams.Where(sp => sp.NhanVienId == nhanVienId && sp.SoLuongTon > 0).ToList();
            }
        }

        // 5. ĐẶT HÀNG: Tạo Hóa đơn, lưu Chi tiết hóa đơn và GIẢM SỐ LƯỢNG TỒN của Sản phẩm
        public (bool IsSuccess, string Message) DatHangBaoDuong(int userId, int nhanVienId, List<BaoDuongItemDTO> items)
        {
            if (items == null || items.Count == 0)
                return (false, "Giỏ hàng đăng ký bảo dưỡng đang trống!");

            using (var db = new AppDbContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        // Kiểm tra tồn kho lần cuối trước khi trừ
                        foreach (var item in items)
                        {
                            var spDb = db.SanPhams.FirstOrDefault(s => s.Id == item.SanPhamId);
                            if (spDb == null)
                                return (false, $"Sản phẩm '{item.TenSanPham}' không còn tồn tại!");

                            if (spDb.SoLuongTon < item.SoLuong)
                                return (false, $"Sản phẩm '{item.TenSanPham}' chỉ còn tồn {spDb.SoLuongTon} (Không đủ số lượng đặt)!");
                        }

                        // Tính tổng tiền
                        decimal tongTien = items.Sum(i => i.ThanhTien);

                        // Tạo Hóa đơn mới
                        var hoaDon = new HoaDon
                        {
                            UserId = userId,
                            NhanVienId = nhanVienId,
                            NgayTao = DateTime.Now,
                            TongTien = tongTien,
                            TrangThai = "Chờ xác nhận"
                        };
                        db.HoaDons.Add(hoaDon);
                        db.SaveChanges(); // Lưu để sinh HoaDon.Id

                        // Tạo Chi tiết hóa đơn & Trừ số lượng tồn sản phẩm
                        foreach (var item in items)
                        {
                            var ct = new ChiTietHoaDon
                            {
                                HoaDonId = hoaDon.Id,
                                SanPhamId = item.SanPhamId,
                                TenXe = $"{item.HangXe} {item.LoaiXe}".Trim(),
                                BienSo = item.BienSo,
                                SoLuong = item.SoLuong,
                                DonGia = item.DonGia
                            };
                            db.ChiTietHoaDons.Add(ct);

                            // Giảm số lượng tồn trong CSDL
                            var sp = db.SanPhams.First(s => s.Id == item.SanPhamId);
                            sp.SoLuongTon -= item.SoLuong;
                        }

                        db.SaveChanges();
                        transaction.Commit();

                        return (true, "Đăng ký bảo dưỡng thành công!");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return (false, "Có lỗi xảy ra khi xử lý đơn hàng: " + ex.Message);
                    }
                }
            }
        }
        
    }
}

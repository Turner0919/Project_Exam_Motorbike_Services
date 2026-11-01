using MotorbikeServices.BLL.DTOs;
using MotorbikeServices.DAL;
using MotorbikeServices.DAL.Models;
using MotorbikeServices.DAL.Models.Store;
using System.Collections.Generic;
using System.Linq;

namespace MotorbikeServices.BLL.Services
{
    public class SanPhamService
    {
        // 1. Lấy danh sách sản phẩm theo ID Cửa hàng / Nhân viên
        public List<SanPhamDTO> GetSanPhamByNhanVien(int nhanVienId)
        {
            using (var db = new AppDbContext())
            {
                var list = db.SanPhams
                    .Where(sp => sp.NhanVienId == nhanVienId)
                    .ToList();

                int stt = 1;
                return list.Select(sp => new SanPhamDTO
                {
                    Id = sp.Id,
                    STT = stt++,
                    MaSP = sp.MaSP,
                    TenSanPham = sp.TenSanPham,
                    DonGia = sp.DonGia,
                    SoLuongTon = sp.SoLuongTon,
                    NhanVienId = sp.NhanVienId
                }).ToList();
            }
        }

        // 2. Thêm mới sản phẩm (Kiểm tra không trùng MaSP trong cùng Cửa hàng)
        public (bool IsSuccess, string Message) ThemSanPham(int nhanVienId, string maSP, string tenSP, decimal donGia, int soLuongTon)
        {
            if (string.IsNullOrWhiteSpace(maSP) || string.IsNullOrWhiteSpace(tenSP))
                return (false, "Vui lòng nhập Mã và Tên sản phẩm!");

            string maSPFormat = maSP.Trim().ToUpper();

            using (var db = new AppDbContext())
            {
                // Kiểm tra xem Mã SP đã tồn tại trong cửa hàng chưa
                bool isExist = db.SanPhams.Any(sp => sp.NhanVienId == nhanVienId && sp.MaSP == maSPFormat);
                if (isExist)
                    return (false, $"Mã sản phẩm '{maSPFormat}' đã tồn tại trong cửa hàng!");

                var spMoi = new SanPham
                {
                    NhanVienId = nhanVienId,
                    MaSP = maSPFormat,
                    TenSanPham = tenSP.Trim(),
                    DonGia = donGia,
                    SoLuongTon = soLuongTon
                };

                db.SanPhams.Add(spMoi);
                db.SaveChanges();
                return (true, "Thêm sản phẩm thành công!");
            }
        }

        // 3. Sửa thông tin sản phẩm (KHÔNG CHO SỬA MaSP)
        public (bool IsSuccess, string Message) SuaSanPham(int spId, string tenSP, decimal donGia, int soLuongTon)
        {
            if (string.IsNullOrWhiteSpace(tenSP))
                return (false, "Vui lòng nhập Tên sản phẩm!");

            using (var db = new AppDbContext())
            {
                var sp = db.SanPhams.FirstOrDefault(s => s.Id == spId);
                if (sp == null)
                    return (false, "Không tìm thấy sản phẩm cần sửa!");

                // Chỉ cập nhật Tên, Giá và Số lượng tồn (Giữ nguyên MaSP)
                sp.TenSanPham = tenSP.Trim();
                sp.DonGia = donGia;
                sp.SoLuongTon = soLuongTon;

                db.SaveChanges();
                return (true, "Cập nhật sản phẩm thành công!");
            }
        }

        // 4. Xóa sản phẩm (Sau khi xóa có thể thêm lại MaSP đó bình thường)
        public (bool IsSuccess, string Message) XoaSanPham(int spId)
        {
            using (var db = new AppDbContext())
            {
                var sp = db.SanPhams.FirstOrDefault(s => s.Id == spId);
                if (sp == null)
                    return (false, "Không tìm thấy sản phẩm cần xóa!");

                db.SanPhams.Remove(sp);
                db.SaveChanges();
                return (true, "Xóa sản phẩm thành công!");
            }
        }
    }
}
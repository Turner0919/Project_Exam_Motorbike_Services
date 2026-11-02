using System;
using System.Collections.Generic;
using System.Text;

namespace MotorbikeServices.BLL.DTOs
{
    // DTO hiển thị bảng trên (Danh Sách Đăng Ký)
    public class CuaHangBaoDuongDTO
    {
        public int MaHoaDon { get; set; }
        public string TenKhach { get; set; } = string.Empty;
        public string SoDienThoai { get; set; } = string.Empty;
        public string EmailKH { get; set; } = string.Empty;
        public DateTime NgayDat { get; set; }
        public decimal TongTien { get; set; }
        public string TrangThai { get; set; } = string.Empty;

        public List<CuaHangChiTietDTO> ChiTiets { get; set; } = new List<CuaHangChiTietDTO>();
    }

    // DTO hiển thị bảng dưới (Danh Sách Chi Tiết Đăng Ký)
    public class CuaHangChiTietDTO
    {
        public int STT { get; set; }
        public string ThongTinXe { get; set; } = string.Empty;
        public string BienSoXe { get; set; } = string.Empty;
        public string SanPhamDichVu { get; set; } = string.Empty;
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
    }
}

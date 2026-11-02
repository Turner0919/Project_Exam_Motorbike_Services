using System;
using System.Collections.Generic;
using System.Text;

namespace MotorbikeServices.BLL.DTOs
{
    // DTO hiển thị bảng trên (Danh Sách Dịch Vụ)
    public class HoaDonKiemTraDTO
    {
        public int MaHoaDon { get; set; }
        public string CuaHang { get; set; } = string.Empty;
        public string DiaChiCuaHang { get; set; } = string.Empty;
        public DateTime NgayDat { get; set; }
        public decimal TongTien { get; set; }
        public string TrangThai { get; set; } = string.Empty;

        public List<ChiTietDichVuDTO> ChiTiets { get; set; } = new List<ChiTietDichVuDTO>();
    }

    // DTO hiển thị bảng dưới (Danh Sách Chi Tiết Dịch Vụ)
    public class ChiTietDichVuDTO
    {
        public int STT { get; set; }
        public string TenXe { get; set; } = string.Empty;
        public string BienSo { get; set; } = string.Empty;
        public string DichVuSanPham { get; set; } = string.Empty;
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
    }
}

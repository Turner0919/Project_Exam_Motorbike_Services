using System;
using System.Collections.Generic;
using System.Text;

namespace MotorbikeServices.BLL.DTOs
{
    public class BaoDuongItemDTO
    {
        public string HangXe { get; set; } = string.Empty;
        public string LoaiXe { get; set; } = string.Empty;
        public string BienSo { get; set; } = string.Empty;
        public int SanPhamId { get; set; }
        public string TenSanPham { get; set; } = string.Empty;
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien => SoLuong * DonGia;
    }
}

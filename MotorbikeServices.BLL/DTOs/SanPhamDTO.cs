using System;
using System.Collections.Generic;
using System.Text;

namespace MotorbikeServices.BLL.DTOs
{
    public class SanPhamDTO
    {
        public int Id { get; set; }
        public int STT { get; set; }
        public string MaSP { get; set; } = string.Empty;
        public string TenSanPham { get; set; } = string.Empty;
        public decimal DonGia { get; set; }
        public int SoLuongTon { get; set; }
        public int NhanVienId { get; set; }
    }
}

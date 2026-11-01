using System;
using System.Collections.Generic;
using System.Text;

namespace MotorbikeServices.BLL.DTOs
{
    public class NhanVienUseDTO
    {
        public int NhanVienId { get; set; }
        public string TenTaiKhoan { get; set; } = string.Empty;
        public string TenCuaHang { get; set; } = string.Empty;
        public string TrangThai { get; set; } = string.Empty;
        public int? DiaChiId { get; set; }
        public string TinhTP { get; set; } = string.Empty;
        public string PhuongXa { get; set; } = string.Empty;
        public string TenDuong { get; set; } = string.Empty;
        public string SoCuaHang { get; set; } = string.Empty;
    }
}

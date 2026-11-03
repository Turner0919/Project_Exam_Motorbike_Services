using System.Collections.Generic;

namespace MotorbikeServices.BLL.DTOs
{
    public class ThongKeTongQuanDTO
    {
        public int TongHangXe { get; set; }
        public int TongDongXe { get; set; }
        public int TongQuyChuan { get; set; }
        public int TongTaiKhoan { get; set; }

        public List<DuLieuBieuDoDTO> DongXeTheoHang { get; set; } = new();
        public List<DuLieuBieuDoDTO> TaiKhoanTheoVaiTro { get; set; } = new();
        public List<DuLieuBieuDoDTO> QuyChuanTheoChuKy { get; set; } = new();
        public List<DuLieuBieuDoDTO> CuaHangTheoTrangThai { get; set; } = new();
    }

    public class DuLieuBieuDoDTO
    {
        public string Nhan { get; set; } = string.Empty;
        public int GiaTri { get; set; }
    }
}

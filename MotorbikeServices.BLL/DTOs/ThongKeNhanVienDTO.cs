namespace MotorbikeServices.BLL.DTOs
{
    public class ThongKeNhanVienDTO
    {
        public int DonChoXacNhan { get; set; }
        public int DonDaHoanThanh { get; set; }
        public decimal DoanhThuThang { get; set; }
        public int SanPhamSapHet { get; set; }
        public List<ThongKeTrangThaiDTO> DanhSachTrangThai { get; set; } = new List<ThongKeTrangThaiDTO>();
    }

    public class ThongKeTrangThaiDTO
    {
        public string TrangThai { get; set; } = string.Empty;
        public int SoLuong { get; set; }
    }
}

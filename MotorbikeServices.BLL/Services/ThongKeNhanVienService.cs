using MotorbikeServices.BLL.DTOs;
using MotorbikeServices.DAL.Models;

namespace MotorbikeServices.BLL.Services
{
    public class ThongKeNhanVienService
    {
        public ThongKeNhanVienDTO LayThongKe(int nhanVienId)
        {
            using (var db = new AppDbContext())
            {
                var danhSachHoaDon = db.HoaDons
                    .Where(h => h.NhanVienId == nhanVienId)
                    .ToList();

                var ketQua = new ThongKeNhanVienDTO
                {
                    DonChoXacNhan = danhSachHoaDon.Count(
                        h => h.TrangThai == "Chờ xác nhận"),

                    DonDaHoanThanh = danhSachHoaDon.Count(
                        h => h.TrangThai == "Đã hoàn thành"),

                    DonDaHuy = danhSachHoaDon.Count(
                        h => h.TrangThai == "Đã hủy"),

                    TongDoanhThu = danhSachHoaDon
                        .Where(h => h.TrangThai == "Đã hoàn thành")
                        .Sum(h => h.TongTien)
                };

                string[] cacTrangThai =
                {
                    "Chờ xác nhận",
                    "Đã hoàn thành",
                    "Đã hủy"
                };

                foreach (string trangThai in cacTrangThai)
                {
                    ketQua.DanhSachTrangThai.Add(
                        new ThongKeTrangThaiDTO
                        {
                            TrangThai = trangThai,
                            SoLuong = danhSachHoaDon.Count(
                                h => h.TrangThai == trangThai)
                        });
                }

                return ketQua;
            }
        }
    }
}
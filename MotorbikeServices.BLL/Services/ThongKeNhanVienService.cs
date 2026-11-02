using MotorbikeServices.BLL.DTOs;
using MotorbikeServices.DAL.Models;

namespace MotorbikeServices.BLL.Services
{
    public class ThongKeNhanVienService
    {
        private const int MucTonKhoThap = 5;

        public ThongKeNhanVienDTO LayThongKe(int nhanVienId)
        {
            using (var db = new AppDbContext())
            {
                DateTime ngayHienTai = DateTime.Today;
                var danhSachHoaDon = db.HoaDons
                    .Where(h => h.NhanVienId == nhanVienId)
                    .ToList();

                var ketQua = new ThongKeNhanVienDTO
                {
                    DonChoXacNhan = danhSachHoaDon.Count(h => h.TrangThai == "Chờ xác nhận"),
                    DonDaHoanThanh = danhSachHoaDon.Count(h => h.TrangThai == "Đã hoàn thành"),
                    DoanhThuThang = danhSachHoaDon
                        .Where(h => h.TrangThai == "Đã hoàn thành" &&
                                    h.NgayTao.Month == ngayHienTai.Month &&
                                    h.NgayTao.Year == ngayHienTai.Year)
                        .Sum(h => (decimal?)h.TongTien) ?? 0,
                    SanPhamSapHet = db.SanPhams
                        .Count(sp => sp.NhanVienId == nhanVienId && sp.SoLuongTon <= MucTonKhoThap)
                };

                string[] cacTrangThai = { "Chờ xác nhận", "Đã hoàn thành", "Đã hủy" };
                foreach (string trangThai in cacTrangThai)
                {
                    ketQua.DanhSachTrangThai.Add(new ThongKeTrangThaiDTO
                    {
                        TrangThai = trangThai,
                        SoLuong = danhSachHoaDon.Count(h => h.TrangThai == trangThai)
                    });
                }

                return ketQua;
            }
        }
    }
}

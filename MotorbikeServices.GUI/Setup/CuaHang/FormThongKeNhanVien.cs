using MotorbikeServices.BLL.DTOs;
using MotorbikeServices.BLL.Services;
using ScottPlot.WinForms;

namespace MotorbikeServices.GUI.Setup.CuaHang
{
    public class FormThongKeNhanVien : Form
    {
        private readonly int _nhanVienId;
        private readonly ThongKeNhanVienService _thongKeService = new ThongKeNhanVienService();
        private readonly Label _lblChoXacNhan = new Label();
        private readonly Label _lblHoanThanh = new Label();
        private readonly Label _lblDoanhThu = new Label();
        private readonly Label _lblTonKhoThap = new Label();
        private readonly FormsPlot _bieuDoTrangThai = new FormsPlot();

        public FormThongKeNhanVien(int nhanVienId)
        {
            _nhanVienId = nhanVienId;
            KhoiTaoGiaoDien();
            Load += FormThongKeNhanVien_Load;
        }

        private void KhoiTaoGiaoDien()
        {
            Text = "Thống kê cửa hàng";
            BackColor = Color.White;
            Padding = new Padding(20);

            var lblTieuDe = new Label
            {
                Text = "THỐNG KÊ CỬA HÀNG",
                Dock = DockStyle.Top,
                Height = 42,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(21, 54, 91),
                TextAlign = ContentAlignment.MiddleLeft
            };

            var pnlThe = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 126,
                ColumnCount = 4,
                Padding = new Padding(0, 8, 0, 8)
            };
            for (int i = 0; i < 4; i++)
                pnlThe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));

            pnlThe.Controls.Add(TaoTheThongKe("Đơn chờ xác nhận", _lblChoXacNhan, Color.FromArgb(255, 193, 7)), 0, 0);
            pnlThe.Controls.Add(TaoTheThongKe("Đơn đã hoàn thành", _lblHoanThanh, Color.FromArgb(40, 167, 69)), 1, 0);
            pnlThe.Controls.Add(TaoTheThongKe("Doanh thu tháng", _lblDoanhThu, Color.FromArgb(0, 123, 255)), 2, 0);
            pnlThe.Controls.Add(TaoTheThongKe("Sản phẩm sắp hết", _lblTonKhoThap, Color.FromArgb(220, 53, 69)), 3, 0);

            var pnlBieuDo = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(0, 12, 0, 0)
            };
            var lblBieuDo = new Label
            {
                Text = "Số đơn theo trạng thái",
                Dock = DockStyle.Top,
                Height = 30,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(21, 54, 91)
            };
            _bieuDoTrangThai.Dock = DockStyle.Fill;
            pnlBieuDo.Controls.Add(_bieuDoTrangThai);
            pnlBieuDo.Controls.Add(lblBieuDo);

            Controls.Add(pnlBieuDo);
            Controls.Add(pnlThe);
            Controls.Add(lblTieuDe);
        }

        private static Panel TaoTheThongKe(string tieuDe, Label lblGiaTri, Color mauVien)
        {
            var pnlThe = new Panel
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(6),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(12)
            };
            var lblTieuDe = new Label
            {
                Text = tieuDe,
                Dock = DockStyle.Top,
                Height = 28,
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                ForeColor = Color.DimGray
            };
            lblGiaTri.Dock = DockStyle.Fill;
            lblGiaTri.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblGiaTri.ForeColor = mauVien;
            lblGiaTri.TextAlign = ContentAlignment.MiddleLeft;
            pnlThe.Controls.Add(lblGiaTri);
            pnlThe.Controls.Add(lblTieuDe);
            return pnlThe;
        }

        private void FormThongKeNhanVien_Load(object? sender, EventArgs e)
        {
            TaiThongKe();
        }

        private void TaiThongKe()
        {
            try
            {
                ThongKeNhanVienDTO thongKe = _thongKeService.LayThongKe(_nhanVienId);
                _lblChoXacNhan.Text = thongKe.DonChoXacNhan.ToString();
                _lblHoanThanh.Text = thongKe.DonDaHoanThanh.ToString();
                _lblDoanhThu.Text = $"{thongKe.DoanhThuThang:#,##0} đ";
                _lblTonKhoThap.Text = thongKe.SanPhamSapHet.ToString();
                VeBieuDo(thongKe.DanhSachTrangThai);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải thống kê: " + ex.Message,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VeBieuDo(List<ThongKeTrangThaiDTO> danhSachTrangThai)
        {
            double[] viTri = Enumerable.Range(0, danhSachTrangThai.Count).Select(i => (double)i).ToArray();
            double[] soLuong = danhSachTrangThai.Select(x => (double)x.SoLuong).ToArray();
            string[] nhan = danhSachTrangThai.Select(x => x.TrangThai).ToArray();

            _bieuDoTrangThai.Plot.Clear();
            _bieuDoTrangThai.Plot.Add.Bars(viTri, soLuong);
            _bieuDoTrangThai.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(viTri, nhan);
            _bieuDoTrangThai.Plot.YLabel("Số lượng đơn");
            _bieuDoTrangThai.Plot.Title("Tình trạng đơn bảo dưỡng");
            _bieuDoTrangThai.Plot.Axes.Margins(bottom: 0);
            _bieuDoTrangThai.Refresh();
        }
    }
}

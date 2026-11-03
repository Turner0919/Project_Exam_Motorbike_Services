using System;
using System.Windows.Forms;
using MotorbikeServices.BLL.Services;

namespace MotorbikeServices.GUI.AdminControls
{
    public partial class UcDashboard : UserControl
    {
        private readonly ThongKeTongQuanService _thongKeService = new ThongKeTongQuanService();

        public UcDashboard()
        {
            InitializeComponent();
            Load += UcDashboard_Load;
        }

        private void UcDashboard_Load(object sender, EventArgs e)
        {
            TaiDuLieuTongQuan();
        }

        private void TaiDuLieuTongQuan()
        {
            try
            {
                var thongKe = _thongKeService.LayThongKeTongQuan();

                lblCardHangXeValue.Text = thongKe.TongHangXe.ToString("N0");
                lblCardDongXeValue.Text = thongKe.TongDongXe.ToString("N0");
                lblCardQuyChuanValue.Text = thongKe.TongQuyChuan.ToString("N0");
                lblCardTaiKhoanValue.Text = thongKe.TongTaiKhoan.ToString("N0");

                bieuDoDongXeTheoHang.CapNhatDuLieu(thongKe.DongXeTheoHang);
                bieuDoTaiKhoan.CapNhatDuLieu(thongKe.TaiKhoanTheoVaiTro);
                bieuDoQuyChuan.CapNhatDuLieu(thongKe.QuyChuanTheoChuKy);
                bieuDoCuaHang.CapNhatDuLieu(thongKe.CuaHangTheoTrangThai);
            }
            catch (Exception ex)
            {
                lblCardHangXeValue.Text = "--";
                lblCardDongXeValue.Text = "--";
                lblCardQuyChuanValue.Text = "--";
                lblCardTaiKhoanValue.Text = "--";

                bieuDoDongXeTheoHang.CapNhatDuLieu(null);
                bieuDoTaiKhoan.CapNhatDuLieu(null);
                bieuDoQuyChuan.CapNhatDuLieu(null);
                bieuDoCuaHang.CapNhatDuLieu(null);

                MessageBox.Show(
                    "Không thể tải dữ liệu Dashboard:\n" + ex.Message,
                    "Lỗi tải dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}


using System;
using System.Windows.Forms;
using MotorbikeServices.DAL.Models;

namespace MotorbikeServices.GUI.AdminControls
{
    public partial class UcDashboard : UserControl
    {
        public UcDashboard()
        {
            InitializeComponent();

            // Tải số liệu thực tế khi mở Dashboard
            Load += UcDashboard_Load;
        }

        private void UcDashboard_Load(object sender, EventArgs e)
        {
            TaiDuLieuTongQuan();
        }

        // =========================================
        // TẢI DỮ LIỆU THỐNG KÊ TỪ DATABASE
        // =========================================
        private void TaiDuLieuTongQuan()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    // Đếm tổng số hãng xe
                    int tongHangXe = db.HangXes.Count();

                    // Đếm tổng số dòng xe
                    int tongDongXe = db.DongXes.Count();

                    // Đếm tổng số quy chuẩn bảo dưỡng
                    int tongQuyChuan = db.QuyChuanBaoDuongs.Count();

                    // Tổng số tài khoản Admin và User
                    int tongTaiKhoan =
                        db.Admins.Count() +
                        db.Users.Count();

                    // Cập nhật giao diện
                    lblCardHangXeValue.Text =
                        tongHangXe.ToString("N0");

                    lblCardDongXeValue.Text =
                        tongDongXe.ToString("N0");

                    lblCardQuyChuanValue.Text =
                        tongQuyChuan.ToString("N0");

                    lblCardTaiKhoanValue.Text =
                        tongTaiKhoan.ToString("N0");
                }

                // Thông báo trạng thái cập nhật
                lblRecentActivityDescription.Text =
                    "Số liệu thống kê đã được cập nhật từ cơ sở dữ liệu.";
            }
            catch (Exception ex)
            {
                // Nếu xảy ra lỗi, không hiển thị số liệu mẫu
                lblCardHangXeValue.Text = "--";
                lblCardDongXeValue.Text = "--";
                lblCardQuyChuanValue.Text = "--";
                lblCardTaiKhoanValue.Text = "--";

                lblRecentActivityDescription.Text =
                    "Không thể tải dữ liệu thống kê.";

                MessageBox.Show(
                    "Không thể tải dữ liệu Dashboard:\n" + ex.Message,
                    "Lỗi tải dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}

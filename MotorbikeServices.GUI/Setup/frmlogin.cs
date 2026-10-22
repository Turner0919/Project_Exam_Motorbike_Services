using MotorbikeServices.BLL.Services;
using MotorbikeServices.GUI.Setup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MotorbikeServices.GUI.SETUP
{
    public partial class frmlogin : Form
    {
        private readonly AuthService _authService = new AuthService();
        private Image[] danhSachAnh;
        private string[] danhSachThongDiep;
        private int currentIndex = 0;
        public frmlogin()
        {
            InitializeComponent();
            InitData();
            danhSachAnh = new Image[]
            {
               Properties.Resources.img1,
               Properties.Resources.img2,
               Properties.Resources.img3
            };
            danhSachThongDiep = new string[]
            {
                "Xe như là người bạn trong cuộc sống",
                "Quản lý và theo dõi tình trạng xe",
                "Hỗ trợ am hiểu và chuyên nghiệp"
            };
            HienThiSlide(0);
        }
        private void InitData()
        {
            cboSoHuu.Items.Clear();
            cboSoHuu.Items.Add("User");
            cboSoHuu.Items.Add("Admin");
            cboSoHuu.SelectedIndex = 0;
        }
        private void cboSoHuu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = cboSoHuu.SelectedItem?.ToString() ?? "";

            if (selectedRole == "Admin")
            {
                // Nếu là Admin -> Mờ/Vô hiệu hóa link Quên mật khẩu
                linklblQuenMatKhau.Enabled = false;
            }
            else
            {
                // Nếu là User -> Bật lại bình thường
                linklblQuenMatKhau.Enabled = true;
            }
        }
        private void HienThiSlide(int index)
        {
            if (danhSachAnh.Length > 0 && index < danhSachAnh.Length)
            {
                pictureBox1.Image = danhSachAnh[index];
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (danhSachThongDiep.Length > 0 && index < danhSachThongDiep.Length)
            {
                lblThongDiep.Text = danhSachThongDiep[index];
            }
        }
        private void frmlogin_Load(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= danhSachAnh.Length) currentIndex = 0;
            HienThiSlide(currentIndex);
        }

        private void linklblDangKyTaiKhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmsignup Frmsignup = new frmsignup();
            Frmsignup.ShowDialog();
        }

        private void linklblQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string username = txtTaiKhoan.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập tên Tài khoản vào ô 'Tài Khoản' trước khi nhấn Quên mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
                return;
            }

            frmchangepassword formChangePass = new frmchangepassword(username);
            formChangePass.ShowDialog();
        }
        // push 
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // 1. Xóa các dấu lỗi đỏ cũ trước khi kiểm tra lại
            errorProvider1.SetError(txtTaiKhoan, "");
            errorProvider1.SetError(txtMatKhau, "");

            string username = txtTaiKhoan.Text.Trim();
            string password = txtMatKhau.Text;
            string role = cboSoHuu.SelectedItem?.ToString() ?? "";

            // 2. Validate ngay tại GUI nếu chưa nhập
            bool hasError = false;

            if (string.IsNullOrWhiteSpace(username))
            {
                errorProvider1.SetError(txtTaiKhoan, "Vui lòng nhập Tài khoản!");
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                errorProvider1.SetError(txtMatKhau, "Vui lòng nhập Mật khẩu!");
                hasError = true;
            }

            // Nếu chưa nhập đủ thì dừng lại, không gọi xuống BLL/Database
            if (hasError) return;

            // 3. Gọi hàm BLL kiểm tra đăng nhập
            var result = _authService.DangNhap(username, password, role);

            if (result.IsSuccess)
            {
                //MessageBox.Show(result.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (role == "Admin")
                {
                    frmaccountadmin formAdmin = new frmaccountadmin();
                    this.Hide();
                    formAdmin.ShowDialog();
                    this.Show();
                }
                else
                {
                    frmaccountuser formUser = new frmaccountuser();
                    this.Hide();
                    formUser.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                // Sai tài khoản/mật khẩu -> Hiển thị dấu X đỏ ở cả 2 ô
                string errorMsg = "Mat Khau hoac tai khoan chua dung";
                errorProvider1.SetError(txtTaiKhoan, errorMsg);
                errorProvider1.SetError(txtMatKhau, errorMsg);
            }
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

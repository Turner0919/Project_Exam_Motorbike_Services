using MotorbikeServices.BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MotorbikeServices.GUI.SETUP
{
    public partial class frmsignup : Form
    {
        private readonly AuthService _authService = new AuthService();
        public frmsignup()
        {
            InitializeComponent();
            InitData();
        }
        private void InitData()
        {
            // Nạp dữ liệu cho ComboBox
            cboTaoSoHuu.Items.Clear();
            cboTaoSoHuu.Items.Add("User");
            cboTaoSoHuu.Items.Add("Admin");
            cboTaoSoHuu.SelectedIndex = 0; // Mặc định chọn User
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void cboTaoSoHuu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = cboTaoSoHuu.SelectedItem?.ToString() ?? "";

            if (selectedRole == "User")
            {
                // Nếu chọn User: Khóa ô KeyAdmin, mở ô Câu hỏi & Đáp án
                txtKeyAdmin.Enabled = false;
                txtKeyAdmin.Clear();

                txtDatCauHoi.Enabled = true;
                txtDapAnChoCauHoi.Enabled = true;
            }
            else if (selectedRole == "Admin")
            {
                // Nếu chọn Admin: Mở ô KeyAdmin, khóa ô Câu hỏi & Đáp án
                txtKeyAdmin.Enabled = true;

                txtDatCauHoi.Enabled = false;
                txtDatCauHoi.Clear();
                txtDapAnChoCauHoi.Enabled = false;
                txtDapAnChoCauHoi.Clear();
            }
        }
        private void frmsignup_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaoTaiKhoan.Text.Trim();
            string matKhau = txtMatKhau.Text;
            string xacNhanMK = txtXacNhanMatKhau.Text;
            string role = cboTaoSoHuu.SelectedItem?.ToString() ?? "";

            if (role == "Admin")
            {
                string keyAdmin = txtKeyAdmin.Text.Trim();
                var result = _authService.DangKyAdmin(taiKhoan, matKhau, xacNhanMK, keyAdmin);

                MessageBox.Show(result.Message, "Thông báo", MessageBoxButtons.OK,
                    result.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                if (result.IsSuccess) this.Close();
            }
            else if (role == "User")
            {
                string cauHoi = txtDatCauHoi.Text.Trim();
                string dapAn = txtDapAnChoCauHoi.Text.Trim();

                var result = _authService.DangKyUser(taiKhoan, matKhau, xacNhanMK, cauHoi, dapAn);

                MessageBox.Show(result.Message, "Thông báo", MessageBoxButtons.OK,
                    result.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                if (result.IsSuccess) this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

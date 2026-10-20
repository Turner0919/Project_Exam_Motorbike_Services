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
    public partial class frmchangepassword : Form
    {
        private readonly AuthService _authService = new AuthService();
        private readonly string _username;
        private bool _isVerified = false; // Trạng thái đã xác minh đáp án đúng hay chưa
        public frmchangepassword(string username)
        {
            InitializeComponent();
            _username = username;

            LoadQuestion();
            LockResetPasswordFields(true); // Ban đầu khóa phần đổi mật khẩu
        }
        private void LockResetPasswordFields(bool isLocked)
        {
            txtDatLaiMatKhau.Enabled = !isLocked;
            txtXacNhanMatKhau1.Enabled = !isLocked;
            btnXacNhanDatLai.Enabled = !isLocked;
        }

        private void LoadQuestion()
        {
            string? question = _authService.LayCauHoiBaoMat(_username);
            if (string.IsNullOrEmpty(question))
            {
                MessageBox.Show("Tài khoản này không tồn tại hoặc là Admin (Admin không dùng câu hỏi khôi phục)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                lblCauHoi.Text = question;
            }
        }
        private void frmchangepassword_Load(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string dapAn = txtDapAn.Text.Trim();
            if (_authService.KiemTraDapAnBaoMat(_username, dapAn))
            {
                MessageBox.Show("Xác minh thành công! Vui lòng nhập mật khẩu mới bên dưới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _isVerified = true;

                LockResetPasswordFields(false); // Mở khóa cho nhập MK mới
                txtDapAn.Enabled = false;
                btnXacNhan.Enabled = false;
            }
            else
            {
                MessageBox.Show("Đáp án câu hỏi bảo mật không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXacNhanDatLai_Click(object sender, EventArgs e)
        {
            if (!_isVerified) return;

            string newPass = txtDatLaiMatKhau.Text;
            string confirmPass = txtXacNhanMatKhau1.Text;

            var result = _authService.DatLaiMatKhau(_username, newPass, confirmPass);

            MessageBox.Show(result.Message, "Thông báo", MessageBoxButtons.OK,
                result.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (result.IsSuccess) this.Close();
        }
    }
}

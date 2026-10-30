using MotorbikeServices.BLL.Services;
using MotorbikeServices.DAL.Models.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MotorbikeServices.GUI.Setup
{
    public partial class frmttcn : Form
    {
        private readonly UserService _userService = new UserService();
        private readonly int _currentUserId; // ID của người dùng hiện tại
        public frmttcn(int userId)
        {
            InitializeComponent();
            _currentUserId = userId;
        }
        private void frmttcn_Load(object sender, EventArgs e)
        {
            LoadUserProfile();
        }
        // 1. Tải dữ liệu lên Form khi mở
        private void LoadUserProfile()
        {
            UserUse? profile = _userService.GetUserProfile(_currentUserId);

            if (profile != null)
            {
                txtHoTen.Text = profile.HoTen ?? "";
                txtSDT.Text = profile.SoDienThoai ?? "";
                txtEmail.Text = profile.Email ?? "";

                if (profile.NgaySinh.HasValue)
                {
                    dtpNgaySinh.Value = profile.NgaySinh.Value;
                    dtpNgaySinh.Checked = true;
                }
                else
                {
                    dtpNgaySinh.Value = DateTime.Now;
                    dtpNgaySinh.Checked = false; // Để trống ngày sinh nếu null
                }

                if (profile.GioiTinh == "Nam")
                    rdoNam.Checked = true;
                else if (profile.GioiTinh == "Nữ")
                    rdoNu.Checked = true;
                else
                {
                    rdoNam.Checked = false;
                    rdoNu.Checked = false;
                }
            }
            else
            {
                // Tài khoản mới chưa có dữ liệu -> Đặt rỗng mặc định
                txtHoTen.Clear();
                txtSDT.Clear();
                txtEmail.Clear();
                rdoNam.Checked = false;
                rdoNu.Checked = false;
                dtpNgaySinh.Value = DateTime.Now;
                dtpNgaySinh.Checked = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;
            string sdt = txtSDT.Text;
            string email = txtEmail.Text;

            DateTime? ngaySinh = dtpNgaySinh.Checked ? dtpNgaySinh.Value : (DateTime?)null;

            string gioiTinh = "";
            if (rdoNam.Checked) gioiTinh = "Nam";
            else if (rdoNu.Checked) gioiTinh = "Nữ";

            bool result = _userService.SaveOrUpdateProfile(_currentUserId, hoTen, ngaySinh, gioiTinh, sdt, email);

            if (result)
            {
                MessageBox.Show("Cập nhật thông tin cá nhân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUserProfile(); // Tải lại giao diện
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi lưu thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

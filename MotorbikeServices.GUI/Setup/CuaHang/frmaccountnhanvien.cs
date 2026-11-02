using MotorbikeServices.DAL.Models.Account;
using MotorbikeServices.GUI.Setup.CuaHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MotorbikeServices.GUI.Setup.CuaHang
{
    public partial class frmaccountnhanvien : Form
    {
        private readonly int _currentNhanVienId;
        public frmaccountnhanvien(int nhanVienId)
        {
            InitializeComponent();
            _currentNhanVienId = nhanVienId;
        }
        private void OpenChildForm(Form childForm)
        {

            panelXam.Controls.Clear();

            childForm.TopLevel = false;                          // Bắt buộc: Tắt tính năng cửa sổ độc lập
            childForm.FormBorderStyle = FormBorderStyle.None;    // Bắt buộc: Bỏ thanh tiêu đề X / Minimize
            childForm.Dock = DockStyle.Fill;                     // Bắt buộc: Giãn hết kích thước ô xám

            panelXam.Controls.Add(childForm);
            panelXam.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void mnuThongTinCaNhan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongTinCuaHang(_currentNhanVienId));
        }

        private void mnuTrangChu_Click(object sender, EventArgs e)
        {
            panelXam.Controls.Clear();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuQuanLySanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLySanPham(_currentNhanVienId));
        }

        private void thongKeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongKeNhanVien(_currentNhanVienId));
        }
    }
}

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
        private Image[] danhSachAnh;
        private string[] danhSachThongDiep;
        private int currentIndex = 0;
        public frmlogin()
        {
            InitializeComponent();

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
            frmchangepassword Frmchangepassword = new frmchangepassword();
            Frmchangepassword.ShowDialog();
        }
    }
}

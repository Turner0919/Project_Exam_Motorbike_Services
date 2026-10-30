using MotorbikeServices.GUI.SETUP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MotorbikeServices.GUI.Setup
{

    public partial class frmaccountuser : Form
    {
        private readonly int _currentUserId;
        public frmaccountuser()
        {
            InitializeComponent();
        }
        public frmaccountuser(int userId) : this()
        {
            _currentUserId = userId;
        }
        private readonly Color colorDarkSidebar = Color.FromArgb(24, 34, 52); 

        private readonly Color colorLightBlack = Color.FromArgb(50, 50, 50);
        private void frmaccountuser_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            btnThongTinCaNhan.Visible = true;
            btnDangKyXeMoi.Visible = true;
            btnLichSuSuaChua.Visible = true;
            btnGopY.Visible = true;
            panel1.Visible = true;
            panel1.BringToFront();
          

        }

        private void btn1_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmttcn(_currentUserId), panelMain);
            ShowHomeButtonOnly();
        }
        private void OpenChildForm(Form childForm, Panel panelMain)
        {
            panelMain.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;


            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            //childForm.BringToFront();
            childForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmGopY(), panelMain);
            ShowHomeButtonOnly();
        }


        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void ShowHomeButtonOnly()
        {

            button2.Visible = true;
            btnThongTinCaNhan.Visible = false;
            btnDangKyXeMoi.Visible = false;
            btnLichSuSuaChua.Visible = false;
            btnGopY.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            button2.Visible = false;
            btnThongTinCaNhan.Visible = true;
            btnDangKyXeMoi.Visible = true;
            btnLichSuSuaChua.Visible = true;
            btnGopY.Visible = true;
        }

        private void btnDangKyXeMoi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formDangKyXe(_currentUserId), panelMain);
            ShowHomeButtonOnly();
        }

        private void btnLichSuSuaChua_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLichSuSuaChua(), panelMain);
            ShowHomeButtonOnly();
        }

        private void btnThuNho_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất khỏi hệ thống?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            { 
                this.Close();
            }
        }

   

      
    }
  
}

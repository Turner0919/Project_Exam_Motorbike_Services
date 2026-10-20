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
        public frmaccountuser()
        {
            InitializeComponent();
        }

        private void frmaccountuser_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            frmttcn TTCN = new frmttcn();
            pictureBox1.Controls.Clear(); // xoa giao dien cu
            TTCN.TopLevel = false; // khong hien thi duoi dang cua so doc lap
            TTCN.FormBorderStyle = FormBorderStyle.None; // bo thanh tieu de
            TTCN.Dock = DockStyle.Fill; //tu dong fill
            pictureBox1.Controls.Add(TTCN);
            TTCN.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
 
    }
}

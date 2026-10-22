using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MotorbikeServices.GUI.AdminControls
{
    public partial class UcQuyChuan : UserControl
    {
        public UcQuyChuan()
        {
            InitializeComponent();

            BackColor = Color.White;

            Label lblTitle = new Label();
            lblTitle.Text = "Quy chuẩn bảo dưỡng";
            lblTitle.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(25, 45, 80);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(10, 10);

            Label lblDescription = new Label();
            lblDescription.Text =
                "Quản lý mốc bảo dưỡng theo số km và chi phí dự kiến.";
            lblDescription.Font = new Font("Segoe UI", 10);
            lblDescription.ForeColor = Color.Gray;
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(12, 55);

            Controls.Add(lblTitle);
            Controls.Add(lblDescription);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvQuyChuan_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

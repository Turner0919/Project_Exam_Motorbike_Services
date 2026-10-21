using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MotorbikeServices.GUI.AdminControls
{
    public partial class UcAccount : UserControl
    {
        public UcAccount()
        {
            InitializeComponent();

            BackColor = Color.White;

            Label lblTitle = new Label();
            lblTitle.Text = "Quản lý tài khoản";
            lblTitle.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(25, 45, 80);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(10, 10);

            Label lblDescription = new Label();
            lblDescription.Text =
                "Theo dõi tài khoản và quản lý trạng thái hoạt động.";
            lblDescription.Font = new Font("Segoe UI", 10);
            lblDescription.ForeColor = Color.Gray;
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(12, 55);

            Controls.Add(lblTitle);
            Controls.Add(lblDescription);
        }
    }
}

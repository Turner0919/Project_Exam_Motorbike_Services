using System;
using System.Windows.Forms;
using MotorbikeServices.GUI.AdminControls;

namespace MotorbikeServices.GUI.Setup
{
    public partial class frmaccountadmin : Form
    {
        public frmaccountadmin()
        {
            InitializeComponent();

            LoadPage(new UcDashboard());
        }

        private void LoadPage(UserControl page)
        {
            pnlContent.Controls.Clear();

            page.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(page);
        }
    }
}
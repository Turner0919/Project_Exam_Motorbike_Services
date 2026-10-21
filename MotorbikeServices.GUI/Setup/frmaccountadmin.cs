using System;
using System.Windows.Forms;
using MotorbikeServices.GUI.AdminControls;
using System.Drawing;

namespace MotorbikeServices.GUI.Setup
{
    public partial class frmaccountadmin : Form
    {
        public frmaccountadmin()
        {
            InitializeComponent();

            LoadPage(new UcDashboard());
            SetActiveButton(btnDashboard);
        }

        private void LoadPage(UserControl page)
        {
            pnlContent.Controls.Clear();

            page.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(page);
        }



        private void SetActiveButton(Button selectedButton)
        {
            Button[] sidebarButtons =
            {
        btnDashboard,
        btnHangXe,
        btnQuyChuan,
        btnAccount
    };

            // Màu nút chưa được chọn
            Color normalColor = Color.FromArgb(36, 69, 103);

            // Màu khi rê chuột lên nút chưa chọn
            Color hoverColor = Color.FromArgb(48, 88, 128);

            // Màu nút đang được chọn
            Color activeColor = Color.FromArgb(55, 126, 184);

            // Màu khi rê chuột lên nút đang chọn
            Color activeHoverColor = Color.FromArgb(68, 140, 198);

            foreach (Button btn in sidebarButtons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.UseVisualStyleBackColor = false;

                btn.BackColor = normalColor;
                btn.ForeColor = Color.FromArgb(240, 245, 250);
                btn.Font = new Font(
                    "Segoe UI", 9, FontStyle.Regular);

                btn.FlatAppearance.MouseOverBackColor = hoverColor;
                btn.FlatAppearance.MouseDownBackColor = activeColor;
            }

            // Đánh dấu nút đang được chọn
            selectedButton.BackColor = activeColor;
            selectedButton.ForeColor = Color.White;
            selectedButton.Font = new Font(
                "Segoe UI", 9, FontStyle.Bold);

            selectedButton.FlatAppearance.MouseOverBackColor =
                activeHoverColor;

            selectedButton.FlatAppearance.MouseDownBackColor =
                activeHoverColor;
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadPage(new UcDashboard());
            SetActiveButton(btnDashboard);
        }

        private void btnHangXe_Click(object sender, EventArgs e)
        {
            LoadPage(new UcHangXe());
            SetActiveButton(btnHangXe);
        }

        private void btnQuyChuan_Click(object sender, EventArgs e)
        {
            LoadPage(new UcQuyChuan());
            SetActiveButton(btnQuyChuan);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            LoadPage(new UcAccount());
            SetActiveButton(btnAccount);
        }
    }
}
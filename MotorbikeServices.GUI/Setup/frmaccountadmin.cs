using System;
using System.Windows.Forms;
using MotorbikeServices.GUI.AdminControls;
using System.Drawing;

namespace MotorbikeServices.GUI.Setup
{
    public partial class frmaccountadmin : Form
    {
        private Button activeButton;
        public frmaccountadmin()
        {
            InitializeComponent();

            SetupSidebar();
            LoadPage(new UcDashboard());
            SetActiveButton(btnDashboard);
        }

        private void SetupSidebar()
        {

            Button[] sidebarButtons =
            {
                btnDashboard,
                btnHangXe,
                btnQuyChuan,
                btnAccount
            };

            foreach (Button btn in sidebarButtons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.UseVisualStyleBackColor = false;

                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.TextImageRelation = TextImageRelation.Overlay;
                btn.Padding = new Padding(12, 0, 4, 0);

                btn.AutoSize = false;
                btn.Height = 44;
                btn.Width = 250;

                btn.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                btn.Cursor = Cursors.Hand;

                // Không để hiệu ứng nhấn làm thay đổi màu nền ngoài ý muốn
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(68, 140, 198);

                btn.MouseEnter -= SidebarButton_MouseEnter;
                btn.MouseLeave -= SidebarButton_MouseLeave;

                btn.MouseEnter += SidebarButton_MouseEnter;
                btn.MouseLeave += SidebarButton_MouseLeave;
            }
        }

        private void LoadPage(UserControl page)
        {
            pnlContent.Controls.Clear();

            page.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(page);
        }



        private void SetActiveButton(Button selectedButton)
        {
            activeButton = selectedButton;

            Button[] sidebarButtons =
            {
                btnDashboard,
                btnHangXe,
                btnQuyChuan,
                btnAccount
            };

            Color normalColor = Color.FromArgb(36, 69, 103);
            Color activeColor = Color.FromArgb(55, 126, 184);

            foreach (Button btn in sidebarButtons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.UseVisualStyleBackColor = false;

                btn.BackColor = normalColor;
                btn.ForeColor = Color.FromArgb(205, 218, 235);
                btn.Font = new Font("Segoe UI", 9F, FontStyle.Regular);

                btn.FlatAppearance.MouseOverBackColor =
                    Color.FromArgb(48, 88, 128);

                btn.FlatAppearance.MouseDownBackColor =
                    Color.FromArgb(55, 126, 184);
            }

            // Giữ trạng thái nổi bật cho nút đang được chọn.
            selectedButton.BackColor = activeColor;
            selectedButton.ForeColor = Color.White;
            selectedButton.Font = new Font(
                "Segoe UI", 9F, FontStyle.Bold);

            selectedButton.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(68, 140, 198);

            selectedButton.FlatAppearance.MouseDownBackColor =
                Color.FromArgb(68, 140, 198);
        }

        private void SidebarButton_MouseEnter(object sender, EventArgs e)
        {
            if (sender is not Button btn) return;

            btn.ForeColor = Color.White;
            btn.BackColor = Color.FromArgb(55, 105, 150);
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        }

        private void SidebarButton_MouseLeave(object sender, EventArgs e)
        {
            if (sender is not Button btn) return;

            if (btn == activeButton)
            {
                btn.BackColor = Color.FromArgb(55, 126, 184);
                btn.ForeColor = Color.White;
            }
            else
            {
                btn.BackColor = Color.FromArgb(36, 69, 103);
                btn.ForeColor = Color.FromArgb(205, 218, 235);
            }
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

        private void btnHoiAI_Click(object sender, EventArgs e)
        {
            frmAIChat formAI = new frmAIChat();
            formAI.ShowDialog();
        }
    }
}
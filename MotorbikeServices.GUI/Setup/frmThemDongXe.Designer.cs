
using System.Drawing;
using System.Windows.Forms;

namespace MotorbikeServices.GUI.Setup
{
    partial class frmThemDongXe
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblTenDongXe;
        private Label lblHangXe;

        private TextBox txtTenDongXe;
        private ComboBox cboHangXe;

        private Button btnLuu;
        private Button btnHuy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblTenDongXe = new Label();
            lblHangXe = new Label();

            txtTenDongXe = new TextBox();
            cboHangXe = new ComboBox();

            btnLuu = new Button();
            btnHuy = new Button();

            SuspendLayout();

            // Form
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(480, 260);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thông tin dòng xe";

            // Tiêu đề
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font(
                "Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(25, 45, 80);
            lblTitle.Location = new Point(25, 18);
            lblTitle.Text = "Thông tin dòng xe";

            // Nhãn tên dòng xe
            lblTenDongXe.AutoSize = true;
            lblTenDongXe.Font = new Font("Segoe UI", 10F);
            lblTenDongXe.Location = new Point(28, 75);
            lblTenDongXe.Text = "Tên dòng xe:";

            // Ô nhập tên dòng xe
            txtTenDongXe.Font = new Font("Segoe UI", 10F);
            txtTenDongXe.Location = new Point(145, 70);
            txtTenDongXe.Size = new Size(300, 30);
            txtTenDongXe.MaxLength = 100;

            // Nhãn hãng xe
            lblHangXe.AutoSize = true;
            lblHangXe.Font = new Font("Segoe UI", 10F);
            lblHangXe.Location = new Point(28, 125);
            lblHangXe.Text = "Hãng xe:";

            // ComboBox chọn hãng xe
            cboHangXe.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHangXe.Font = new Font("Segoe UI", 10F);
            cboHangXe.Location = new Point(145, 120);
            cboHangXe.Size = new Size(300, 30);

            // Nút lưu
            btnLuu.BackColor = Color.FromArgb(55, 126, 184);
            btnLuu.ForeColor = Color.White;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.Font = new Font(
                "Segoe UI", 9F, FontStyle.Bold);
            btnLuu.Location = new Point(255, 185);
            btnLuu.Size = new Size(90, 38);
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;

            // Nút hủy
            btnHuy.BackColor = Color.FromArgb(25, 45, 80);
            btnHuy.ForeColor = Color.White;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.Font = new Font(
                "Segoe UI", 9F, FontStyle.Bold);
            btnHuy.Location = new Point(355, 185);
            btnHuy.Size = new Size(90, 38);
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.DialogResult = DialogResult.Cancel;

            // Thêm control vào Form
            Controls.Add(lblTitle);
            Controls.Add(lblTenDongXe);
            Controls.Add(txtTenDongXe);
            Controls.Add(lblHangXe);
            Controls.Add(cboHangXe);
            Controls.Add(btnLuu);
            Controls.Add(btnHuy);

            AcceptButton = btnLuu;
            CancelButton = btnHuy;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}

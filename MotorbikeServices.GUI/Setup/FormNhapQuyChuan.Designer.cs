
namespace MotorbikeServices.GUI.AdminControls
{
    partial class FormNhapQuyChuan
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblLoaiXe;
        private System.Windows.Forms.Label lblTenQuyChuan;
        private System.Windows.Forms.Label lblSoKm;
        private System.Windows.Forms.Label lblChiPhi;
        private System.Windows.Forms.Label lblMoTa;

        private System.Windows.Forms.ComboBox cboLoaiXe;
        private System.Windows.Forms.TextBox txtTenQuyChuan;
        private System.Windows.Forms.NumericUpDown numSoKm;
        private System.Windows.Forms.NumericUpDown numChiPhi;
        private System.Windows.Forms.TextBox txtMoTa;

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTieuDe = new System.Windows.Forms.Label();
            lblLoaiXe = new System.Windows.Forms.Label();
            lblTenQuyChuan = new System.Windows.Forms.Label();
            lblSoKm = new System.Windows.Forms.Label();
            lblChiPhi = new System.Windows.Forms.Label();
            lblMoTa = new System.Windows.Forms.Label();

            cboLoaiXe = new System.Windows.Forms.ComboBox();
            txtTenQuyChuan = new System.Windows.Forms.TextBox();
            numSoKm = new System.Windows.Forms.NumericUpDown();
            numChiPhi = new System.Windows.Forms.NumericUpDown();
            txtMoTa = new System.Windows.Forms.TextBox();

            btnLuu = new System.Windows.Forms.Button();
            btnHuy = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)numSoKm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numChiPhi).BeginInit();

            SuspendLayout();

            // Form
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(460, 430);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Thông tin quy chuẩn bảo dưỡng";

            // Tiêu đề
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new System.Drawing.Font(
                "Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(25, 45, 80);
            lblTieuDe.Location = new System.Drawing.Point(25, 20);
            lblTieuDe.Text = "Thông tin quy chuẩn";

            // Loại xe
            lblLoaiXe.AutoSize = true;
            lblLoaiXe.Location = new System.Drawing.Point(30, 85);
            lblLoaiXe.Text = "Loại xe";

            cboLoaiXe.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboLoaiXe.Location = new System.Drawing.Point(155, 80);
            cboLoaiXe.Size = new System.Drawing.Size(265, 28);
            cboLoaiXe.Items.AddRange(new object[]
            {
                "Xe tay ga",
                "Xe số"
            });

            // Tên quy chuẩn
            lblTenQuyChuan.AutoSize = true;
            lblTenQuyChuan.Location = new System.Drawing.Point(30, 135);
            lblTenQuyChuan.Text = "Tên quy chuẩn";

            txtTenQuyChuan.Location = new System.Drawing.Point(155, 130);
            txtTenQuyChuan.Size = new System.Drawing.Size(265, 27);
            txtTenQuyChuan.MaxLength = 150;

            // Số km
            lblSoKm.AutoSize = true;
            lblSoKm.Location = new System.Drawing.Point(30, 185);
            lblSoKm.Text = "Số km";

            numSoKm.Location = new System.Drawing.Point(155, 180);
            numSoKm.Size = new System.Drawing.Size(265, 27);
            numSoKm.Minimum = 1;
            numSoKm.Maximum = 1000000;
            numSoKm.ThousandsSeparator = true;

            // Chi phí
            lblChiPhi.AutoSize = true;
            lblChiPhi.Location = new System.Drawing.Point(30, 235);
            lblChiPhi.Text = "Chi phí (VNĐ)";

            numChiPhi.Location = new System.Drawing.Point(155, 230);
            numChiPhi.Size = new System.Drawing.Size(265, 27);
            numChiPhi.Minimum = 0;
            numChiPhi.Maximum = 1000000000;
            numChiPhi.ThousandsSeparator = true;

            // Mô tả
            lblMoTa.AutoSize = true;
            lblMoTa.Location = new System.Drawing.Point(30, 285);
            lblMoTa.Text = "Mô tả";

            txtMoTa.Location = new System.Drawing.Point(155, 280);
            txtMoTa.Size = new System.Drawing.Size(265, 65);
            txtMoTa.Multiline = true;
            txtMoTa.MaxLength = 500;

            // Nút Lưu
            btnLuu.Location = new System.Drawing.Point(220, 365);
            btnLuu.Size = new System.Drawing.Size(90, 38);
            btnLuu.Text = "Lưu";
            btnLuu.BackColor = System.Drawing.Color.FromArgb(55, 126, 184);
            btnLuu.ForeColor = System.Drawing.Color.White;
            btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLuu.Click += btnLuu_Click;

            // Nút Hủy
            btnHuy.Location = new System.Drawing.Point(320, 365);
            btnHuy.Size = new System.Drawing.Size(100, 38);
            btnHuy.Text = "Hủy";
            btnHuy.BackColor = System.Drawing.Color.LightGray;
            btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            btnHuy.Click += btnHuy_Click;

            // Thêm controls
            Controls.AddRange(new System.Windows.Forms.Control[]
            {
                lblTieuDe,
                lblLoaiXe,
                lblTenQuyChuan,
                lblSoKm,
                lblChiPhi,
                lblMoTa,
                cboLoaiXe,
                txtTenQuyChuan,
                numSoKm,
                numChiPhi,
                txtMoTa,
                btnLuu,
                btnHuy
            });

            AcceptButton = btnLuu;
            CancelButton = btnHuy;

            ((System.ComponentModel.ISupportInitialize)numSoKm).EndInit();
            ((System.ComponentModel.ISupportInitialize)numChiPhi).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }
    }
}

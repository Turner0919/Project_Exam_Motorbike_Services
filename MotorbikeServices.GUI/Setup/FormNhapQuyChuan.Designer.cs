
namespace MotorbikeServices.GUI.AdminControls
{
    partial class FormNhapQuyChuan
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblLoaiXe;
        private System.Windows.Forms.Label lblTenQuyChuan;
        private System.Windows.Forms.Label lblSoThang;
        private System.Windows.Forms.Label lblMoTa;

        private System.Windows.Forms.ComboBox cboLoaiXe;
        private System.Windows.Forms.TextBox txtTenQuyChuan;
        private System.Windows.Forms.NumericUpDown numSoThang;
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
            lblTieuDe = new Label();
            lblLoaiXe = new Label();
            lblTenQuyChuan = new Label();
            lblSoThang = new Label();
            lblMoTa = new Label();
            cboLoaiXe = new ComboBox();
            txtTenQuyChuan = new TextBox();
            numSoThang = new NumericUpDown();
            txtMoTa = new TextBox();
            btnLuu = new Button();
            btnHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)numSoThang).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(25, 45, 80);
            lblTieuDe.Location = new Point(25, 20);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(279, 37);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Thông tin quy chuẩn";
            // 
            // lblLoaiXe
            // 
            lblLoaiXe.AutoSize = true;
            lblLoaiXe.Location = new Point(30, 85);
            lblLoaiXe.Name = "lblLoaiXe";
            lblLoaiXe.Size = new Size(124, 20);
            lblLoaiXe.TabIndex = 1;
            lblLoaiXe.Text = "Dòng xe áp dụng";
            // 
            // lblTenQuyChuan
            // 
            lblTenQuyChuan.AutoSize = true;
            lblTenQuyChuan.Location = new Point(30, 135);
            lblTenQuyChuan.Name = "lblTenQuyChuan";
            lblTenQuyChuan.Size = new Size(103, 20);
            lblTenQuyChuan.TabIndex = 2;
            lblTenQuyChuan.Text = "Tên quy chuẩn";
            // 
            // lblSoThang
            // 
            lblSoThang.AutoSize = true;
            lblSoThang.Location = new Point(30, 185);
            lblSoThang.Name = "lblSoThang";
            lblSoThang.Size = new Size(71, 20);
            lblSoThang.TabIndex = 3;
            lblSoThang.Text = "Số tháng";
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Location = new Point(30, 235);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(48, 20);
            lblMoTa.TabIndex = 4;
            lblMoTa.Text = "Mô tả";
            // 
            // cboLoaiXe
            // 
            cboLoaiXe.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiXe.Location = new Point(155, 80);
            cboLoaiXe.Name = "cboLoaiXe";
            cboLoaiXe.Size = new Size(265, 28);
            cboLoaiXe.TabIndex = 6;
            // 
            // txtTenQuyChuan
            // 
            txtTenQuyChuan.Location = new Point(155, 130);
            txtTenQuyChuan.MaxLength = 150;
            txtTenQuyChuan.Name = "txtTenQuyChuan";
            txtTenQuyChuan.Size = new Size(265, 27);
            txtTenQuyChuan.TabIndex = 7;
            // 
            // numSoThang
            // 
            numSoThang.Location = new Point(155, 180);
            numSoThang.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numSoThang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoThang.Name = "numSoThang";
            numSoThang.Size = new Size(265, 27);
            numSoThang.TabIndex = 8;
            numSoThang.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(155, 230);
            txtMoTa.MaxLength = 500;
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(265, 65);
            txtMoTa.TabIndex = 9;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(55, 126, 184);
            btnLuu.Cursor = Cursors.Hand;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(220, 315);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(90, 38);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.LightGray;
            btnHuy.Cursor = Cursors.Hand;
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Location = new Point(320, 315);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(100, 38);
            btnHuy.TabIndex = 11;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormNhapQuyChuan
            // 
            AcceptButton = btnLuu;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnHuy;
            ClientSize = new Size(460, 380);
            Controls.Add(lblTieuDe);
            Controls.Add(lblLoaiXe);
            Controls.Add(lblTenQuyChuan);
            Controls.Add(lblSoThang);
            Controls.Add(lblMoTa);
            Controls.Add(cboLoaiXe);
            Controls.Add(txtTenQuyChuan);
            Controls.Add(numSoThang);
            Controls.Add(txtMoTa);
            Controls.Add(btnLuu);
            Controls.Add(btnHuy);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormNhapQuyChuan";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thông tin quy chuẩn bảo dưỡng";
            ((System.ComponentModel.ISupportInitialize)numSoThang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

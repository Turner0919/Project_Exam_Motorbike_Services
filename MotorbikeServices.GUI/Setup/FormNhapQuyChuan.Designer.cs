
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
            lblTieuDe = new Label();
            lblLoaiXe = new Label();
            lblTenQuyChuan = new Label();
            lblSoKm = new Label();
            lblChiPhi = new Label();
            lblMoTa = new Label();
            cboLoaiXe = new ComboBox();
            txtTenQuyChuan = new TextBox();
            numSoKm = new NumericUpDown();
            numChiPhi = new NumericUpDown();
            txtMoTa = new TextBox();
            btnLuu = new Button();
            btnHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)numSoKm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numChiPhi).BeginInit();
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
            // lblSoKm
            // 
            lblSoKm.AutoSize = true;
            lblSoKm.Location = new Point(30, 185);
            lblSoKm.Name = "lblSoKm";
            lblSoKm.Size = new Size(50, 20);
            lblSoKm.TabIndex = 3;
            lblSoKm.Text = "Số km";
            // 
            // lblChiPhi
            // 
            lblChiPhi.AutoSize = true;
            lblChiPhi.Location = new Point(30, 235);
            lblChiPhi.Name = "lblChiPhi";
            lblChiPhi.Size = new Size(100, 20);
            lblChiPhi.TabIndex = 4;
            lblChiPhi.Text = "Chi phí (VNĐ)";
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Location = new Point(30, 285);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(48, 20);
            lblMoTa.TabIndex = 5;
            lblMoTa.Text = "Mô tả";
            // 
            // cboLoaiXe
            // 
            cboLoaiXe.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiXe.Items.AddRange(new object[] { "Xe tay ga", "Xe số" });
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
            // numSoKm
            // 
            numSoKm.Location = new Point(155, 180);
            numSoKm.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numSoKm.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoKm.Name = "numSoKm";
            numSoKm.Size = new Size(265, 27);
            numSoKm.TabIndex = 8;
            numSoKm.ThousandsSeparator = true;
            numSoKm.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numChiPhi
            // 
            numChiPhi.Location = new Point(155, 230);
            numChiPhi.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numChiPhi.Name = "numChiPhi";
            numChiPhi.Size = new Size(265, 27);
            numChiPhi.TabIndex = 9;
            numChiPhi.ThousandsSeparator = true;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(155, 280);
            txtMoTa.MaxLength = 500;
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(265, 65);
            txtMoTa.TabIndex = 10;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(55, 126, 184);
            btnLuu.Cursor = Cursors.Hand;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(220, 365);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(90, 38);
            btnLuu.TabIndex = 11;
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
            btnHuy.Location = new Point(320, 365);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(100, 38);
            btnHuy.TabIndex = 12;
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
            ClientSize = new Size(460, 430);
            Controls.Add(lblTieuDe);
            Controls.Add(lblLoaiXe);
            Controls.Add(lblTenQuyChuan);
            Controls.Add(lblSoKm);
            Controls.Add(lblChiPhi);
            Controls.Add(lblMoTa);
            Controls.Add(cboLoaiXe);
            Controls.Add(txtTenQuyChuan);
            Controls.Add(numSoKm);
            Controls.Add(numChiPhi);
            Controls.Add(txtMoTa);
            Controls.Add(btnLuu);
            Controls.Add(btnHuy);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormNhapQuyChuan";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thông tin quy chuẩn bảo dưỡng";
            ((System.ComponentModel.ISupportInitialize)numSoKm).EndInit();
            ((System.ComponentModel.ISupportInitialize)numChiPhi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

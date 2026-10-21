using static System.Net.Mime.MediaTypeNames;

namespace MotorbikeServices.GUI
{
    partial class frmThemHangXe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTen = new System.Windows.Forms.Label();
            txtTenHang = new System.Windows.Forms.TextBox();
            lblQuocGia = new System.Windows.Forms.Label();
            txtQuocGia = new System.Windows.Forms.TextBox();
            btnLuu = new System.Windows.Forms.Button();
            btnHuy = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblTen.ForeColor = System.Drawing.Color.FromArgb(25, 45, 80);
            lblTen.Location = new System.Drawing.Point(25, 25);
            lblTen.Name = "lblTen";
            lblTen.Size = new System.Drawing.Size(123, 19);
            lblTen.TabIndex = 0;
            lblTen.Text = "Tên hãng xe (*):";
            // 
            // txtTenHang
            // 
            txtTenHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtTenHang.Location = new System.Drawing.Point(25, 50);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.PlaceholderText = "Nhập tên hãng (tối đa 100 ký tự)...";
            txtTenHang.Size = new System.Drawing.Size(330, 25);
            txtTenHang.TabIndex = 1;
            // 
            // lblQuocGia
            // 
            lblQuocGia.AutoSize = true;
            lblQuocGia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblQuocGia.ForeColor = System.Drawing.Color.FromArgb(25, 45, 80);
            lblQuocGia.Location = new System.Drawing.Point(25, 95);
            lblQuocGia.Name = "lblQuocGia";
            lblQuocGia.Size = new System.Drawing.Size(74, 19);
            lblQuocGia.TabIndex = 2;
            lblQuocGia.Text = "Quốc gia:";
            // 
            // txtQuocGia
            // 
            txtQuocGia.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtQuocGia.Location = new System.Drawing.Point(25, 120);
            txtQuocGia.Name = "txtQuocGia";
            txtQuocGia.PlaceholderText = "Nhập quốc gia (ví dụ: Nhật Bản, Ý...)";
            txtQuocGia.Size = new System.Drawing.Size(330, 25);
            txtQuocGia.TabIndex = 3;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = System.Drawing.Color.FromArgb(55, 126, 184);
            btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnLuu.ForeColor = System.Drawing.Color.White;
            btnLuu.Location = new System.Drawing.Point(175, 165);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new System.Drawing.Size(90, 35);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += BtnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = System.Drawing.Color.FromArgb(120, 120, 120);
            btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnHuy.ForeColor = System.Drawing.Color.White;
            btnHuy.Location = new System.Drawing.Point(275, 165);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new System.Drawing.Size(80, 35);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += BtnHuy_Click;
            // 
            // frmThemHangXe
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            ClientSize = new System.Drawing.Size(384, 221);
            Controls.Add(lblTen);
            Controls.Add(txtTenHang);
            Controls.Add(lblQuocGia);
            Controls.Add(txtQuocGia);
            Controls.Add(btnLuu);
            Controls.Add(btnHuy);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmThemHangXe";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Thêm hãng xe mới";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label lblQuocGia;
        private System.Windows.Forms.TextBox txtQuocGia;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}
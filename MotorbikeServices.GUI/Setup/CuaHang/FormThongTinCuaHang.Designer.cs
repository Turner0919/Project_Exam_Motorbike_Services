namespace MotorbikeServices.GUI.Setup.CuaHang
{
    partial class FormThongTinCuaHang
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtTenCuaHang = new TextBox();
            label3 = new Label();
            cboTrangThai = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cboTinhTP = new ComboBox();
            cboPhuong = new ComboBox();
            button1 = new Button();
            label9 = new Label();
            lblTaiKhoan = new Label();
            txtTenDuong = new TextBox();
            txtSoCuaHang = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 128, 128);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(642, 66);
            label1.TabIndex = 4;
            label1.Text = "THÔNG TIN TÀI KHOẢN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 138);
            label2.Name = "label2";
            label2.Size = new Size(160, 25);
            label2.TabIndex = 5;
            label2.Text = "TÊN CỬA HÀNG:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtTenCuaHang
            // 
            txtTenCuaHang.Location = new Point(221, 140);
            txtTenCuaHang.Name = "txtTenCuaHang";
            txtTenCuaHang.Size = new Size(325, 23);
            txtTenCuaHang.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 193);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 8;
            label3.Text = "TRẠNG THÁI:";
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(221, 198);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(172, 23);
            cboTrangThai.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(55, 252);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 11;
            label4.Text = "ĐỊA CHỈ:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(159, 381);
            label5.Name = "label5";
            label5.Size = new Size(88, 17);
            label5.TabIndex = 12;
            label5.Text = "Số Cửa Hàng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(161, 342);
            label6.Name = "label6";
            label6.Size = new Size(51, 17);
            label6.TabIndex = 13;
            label6.Text = "Đường:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(161, 305);
            label7.Name = "label7";
            label7.Size = new Size(56, 17);
            label7.TabIndex = 14;
            label7.Text = "Phường:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(161, 263);
            label8.Name = "label8";
            label8.Size = new Size(54, 17);
            label8.TabIndex = 15;
            label8.Text = "TP/Tỉnh:";
            // 
            // cboTinhTP
            // 
            cboTinhTP.FormattingEnabled = true;
            cboTinhTP.Location = new Point(253, 257);
            cboTinhTP.Name = "cboTinhTP";
            cboTinhTP.Size = new Size(293, 23);
            cboTinhTP.TabIndex = 20;
            cboTinhTP.SelectedIndexChanged += cboTinhTP_SelectedIndexChanged;
            // 
            // cboPhuong
            // 
            cboPhuong.FormattingEnabled = true;
            cboPhuong.Location = new Point(253, 299);
            cboPhuong.Name = "cboPhuong";
            cboPhuong.Size = new Size(293, 23);
            cboPhuong.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(253, 433);
            button1.Name = "button1";
            button1.Size = new Size(148, 43);
            button1.TabIndex = 22;
            button1.Text = "CẬP NHẬT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(57, 94);
            label9.Name = "label9";
            label9.Size = new Size(161, 25);
            label9.TabIndex = 23;
            label9.Text = "TÊN TÀI KHOẢN:";
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTaiKhoan.Location = new Point(221, 94);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(86, 20);
            lblTaiKhoan.TabIndex = 24;
            lblTaiKhoan.Text = "lblTaiKhoan";
            // 
            // txtTenDuong
            // 
            txtTenDuong.Location = new Point(253, 342);
            txtTenDuong.Name = "txtTenDuong";
            txtTenDuong.Size = new Size(293, 23);
            txtTenDuong.TabIndex = 25;
            // 
            // txtSoCuaHang
            // 
            txtSoCuaHang.Location = new Point(253, 381);
            txtSoCuaHang.Name = "txtSoCuaHang";
            txtSoCuaHang.Size = new Size(293, 23);
            txtSoCuaHang.TabIndex = 26;
            // 
            // FormThongTinCuaHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 510);
            Controls.Add(txtSoCuaHang);
            Controls.Add(txtTenDuong);
            Controls.Add(lblTaiKhoan);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(cboPhuong);
            Controls.Add(cboTinhTP);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cboTrangThai);
            Controls.Add(label3);
            Controls.Add(txtTenCuaHang);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormThongTinCuaHang";
            Text = "FormThongTinCuaHang";
            Load += FormThongTinCuaHang_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtTenCuaHang;
        private Label label3;
        private ComboBox cboTrangThai;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox4;
        private ComboBox cboTinhTP;
        private ComboBox cboPhuong;
        private Button button1;
        private Label label9;
        private Label lblTaiKhoan;
        private TextBox txtTenDuong;
        private TextBox txtSoCuaHang;
    }
}
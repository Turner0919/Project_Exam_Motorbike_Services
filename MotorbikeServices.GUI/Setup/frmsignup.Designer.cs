namespace MotorbikeServices.GUI.SETUP
{
    partial class frmsignup
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            btnHuy = new Button();
            btnDangKy = new Button();
            txtDapAnChoCauHoi = new TextBox();
            label8 = new Label();
            txtDatCauHoi = new TextBox();
            label7 = new Label();
            txtXacNhanMatKhau = new TextBox();
            label6 = new Label();
            txtMatKhau = new TextBox();
            label5 = new Label();
            txtKeyAdmin = new TextBox();
            label4 = new Label();
            cboTaoSoHuu = new ComboBox();
            label3 = new Label();
            txtTaoTaiKhoan = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(882, 565);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnHuy);
            panel1.Controls.Add(btnDangKy);
            panel1.Controls.Add(txtDapAnChoCauHoi);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtDatCauHoi);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtXacNhanMatKhau);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtKeyAdmin);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cboTaoSoHuu);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtTaoTaiKhoan);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(444, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 559);
            panel1.TabIndex = 0;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.DarkGray;
            btnHuy.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnHuy.ForeColor = SystemColors.ButtonHighlight;
            btnHuy.Location = new Point(215, 487);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(146, 52);
            btnHuy.TabIndex = 17;
            btnHuy.Text = "HỦY";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.FromArgb(0, 0, 192);
            btnDangKy.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDangKy.ForeColor = SystemColors.ButtonHighlight;
            btnDangKy.Location = new Point(63, 487);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(146, 52);
            btnDangKy.TabIndex = 16;
            btnDangKy.Text = "ĐĂNG KÝ";
            btnDangKy.UseVisualStyleBackColor = false;
            // 
            // txtDapAnChoCauHoi
            // 
            txtDapAnChoCauHoi.Location = new Point(12, 443);
            txtDapAnChoCauHoi.Name = "txtDapAnChoCauHoi";
            txtDapAnChoCauHoi.PlaceholderText = "Viết thường, không dấu, không khoảng cách...";
            txtDapAnChoCauHoi.Size = new Size(395, 27);
            txtDapAnChoCauHoi.TabIndex = 15;
            txtDapAnChoCauHoi.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label8.Location = new Point(12, 415);
            label8.Name = "label8";
            label8.Size = new Size(169, 25);
            label8.TabIndex = 14;
            label8.Text = "Đáp án cho câu hỏi:";
            // 
            // txtDatCauHoi
            // 
            txtDatCauHoi.Location = new Point(12, 385);
            txtDatCauHoi.Name = "txtDatCauHoi";
            txtDatCauHoi.PlaceholderText = "Dành cho trường hợp quên mật khẩu...";
            txtDatCauHoi.Size = new Size(395, 27);
            txtDatCauHoi.TabIndex = 13;
            txtDatCauHoi.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label7.Location = new Point(12, 357);
            label7.Name = "label7";
            label7.Size = new Size(106, 25);
            label7.TabIndex = 12;
            label7.Text = "Đặt câu hỏi:";
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Location = new Point(12, 327);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.Size = new Size(395, 27);
            txtXacNhanMatKhau.TabIndex = 11;
            txtXacNhanMatKhau.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label6.Location = new Point(12, 299);
            label6.Name = "label6";
            label6.Size = new Size(171, 25);
            label6.TabIndex = 10;
            label6.Text = "Xác Nhận Mật Khẩu:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(12, 269);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PlaceholderText = "Tối thiểu 8 ký tự...";
            txtMatKhau.Size = new Size(395, 27);
            txtMatKhau.TabIndex = 9;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label5.Location = new Point(12, 241);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 8;
            label5.Text = "Mật Khẩu:";
            // 
            // txtKeyAdmin
            // 
            txtKeyAdmin.Location = new Point(12, 211);
            txtKeyAdmin.Name = "txtKeyAdmin";
            txtKeyAdmin.PlaceholderText = "Key do Boss cung cấp...";
            txtKeyAdmin.Size = new Size(395, 27);
            txtKeyAdmin.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.Location = new Point(12, 183);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 6;
            label4.Text = "Key Admin:";
            // 
            // cboTaoSoHuu
            // 
            cboTaoSoHuu.FormattingEnabled = true;
            cboTaoSoHuu.Items.AddRange(new object[] { "User", "Admin" });
            cboTaoSoHuu.Location = new Point(12, 152);
            cboTaoSoHuu.Name = "cboTaoSoHuu";
            cboTaoSoHuu.Size = new Size(171, 28);
            cboTaoSoHuu.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 4;
            label3.Text = "Tạo Sở Hữu:";
            label3.Click += label3_Click;
            // 
            // txtTaoTaiKhoan
            // 
            txtTaoTaiKhoan.Location = new Point(12, 94);
            txtTaoTaiKhoan.Name = "txtTaoTaiKhoan";
            txtTaoTaiKhoan.Size = new Size(395, 27);
            txtTaoTaiKhoan.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 2;
            label2.Text = "Tạo Tài Khoản:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16.8F, FontStyle.Bold);
            label1.ForeColor = Color.Chocolate;
            label1.Location = new Point(52, 15);
            label1.Name = "label1";
            label1.Size = new Size(318, 38);
            label1.TabIndex = 1;
            label1.Text = "ĐĂNG KÝ TÀI KHOẢN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.anhsuaxe;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(435, 559);
            panel2.TabIndex = 1;
            // 
            // frmsignup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 565);
            Controls.Add(tableLayoutPanel1);
            Name = "frmsignup";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đăng Ký Tài Khoản";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private ComboBox cboTaoSoHuu;
        private Label label3;
        private TextBox txtTaoTaiKhoan;
        private Label label2;
        private TextBox txtKeyAdmin;
        private Label label4;
        private TextBox txtMatKhau;
        private Label label5;
        private TextBox txtXacNhanMatKhau;
        private Label label6;
        private Label label7;
        private TextBox txtDapAnChoCauHoi;
        private Label label8;
        private TextBox txtDatCauHoi;
        private Button btnHuy;
        private Button btnDangKy;
    }
}
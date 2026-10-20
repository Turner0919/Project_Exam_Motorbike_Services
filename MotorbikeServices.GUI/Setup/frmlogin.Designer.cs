namespace MotorbikeServices.GUI.SETUP
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            linklblQuenMatKhau = new LinkLabel();
            btnDangNhap = new Button();
            cboSoHuu = new ComboBox();
            label4 = new Label();
            txtMatKhau = new TextBox();
            txtTaiKhoan = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            lblThongDiep = new Label();
            pictureBox1 = new PictureBox();
            linklblDangKyTaiKhoan = new LinkLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel5 = new Panel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(96, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(726, 471);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(726, 471);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(linklblQuenMatKhau);
            panel2.Controls.Add(btnDangNhap);
            panel2.Controls.Add(cboSoHuu);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtMatKhau);
            panel2.Controls.Add(txtTaiKhoan);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(366, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(357, 465);
            panel2.TabIndex = 0;
            // 
            // linklblQuenMatKhau
            // 
            linklblQuenMatKhau.AutoSize = true;
            linklblQuenMatKhau.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            linklblQuenMatKhau.Location = new Point(115, 392);
            linklblQuenMatKhau.Name = "linklblQuenMatKhau";
            linklblQuenMatKhau.Size = new Size(109, 20);
            linklblQuenMatKhau.TabIndex = 8;
            linklblQuenMatKhau.TabStop = true;
            linklblQuenMatKhau.Text = "Quên mật khẩu";
            linklblQuenMatKhau.LinkClicked += linklblQuenMatKhau_LinkClicked;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(0, 192, 0);
            btnDangNhap.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDangNhap.ForeColor = SystemColors.ButtonHighlight;
            btnDangNhap.Location = new Point(97, 343);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(148, 46);
            btnDangNhap.TabIndex = 7;
            btnDangNhap.Text = "ĐĂNG NHẬP";
            btnDangNhap.UseVisualStyleBackColor = false;
            // 
            // cboSoHuu
            // 
            cboSoHuu.FormattingEnabled = true;
            cboSoHuu.Items.AddRange(new object[] { "User", "Admin" });
            cboSoHuu.Location = new Point(14, 226);
            cboSoHuu.Name = "cboSoHuu";
            cboSoHuu.Size = new Size(167, 28);
            cboSoHuu.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.Location = new Point(14, 266);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 5;
            label4.Text = "Mật Khẩu:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(14, 294);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(304, 27);
            txtMatKhau.TabIndex = 4;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(14, 151);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(304, 27);
            txtTaiKhoan.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.Location = new Point(14, 198);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 2;
            label3.Text = "Sở Hữu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(14, 123);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Tài Khoản:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14.8F, FontStyle.Bold);
            label1.ForeColor = Color.Chocolate;
            label1.Location = new Point(14, 42);
            label1.Name = "label1";
            label1.Size = new Size(326, 35);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP TÀI KHOẢN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(lblThongDiep);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(linklblDangKyTaiKhoan);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(357, 465);
            panel3.TabIndex = 1;
            // 
            // lblThongDiep
            // 
            lblThongDiep.Anchor = AnchorStyles.None;
            lblThongDiep.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            lblThongDiep.ForeColor = Color.Cornsilk;
            lblThongDiep.Location = new Point(0, 343);
            lblThongDiep.Name = "lblThongDiep";
            lblThongDiep.Size = new Size(357, 23);
            lblThongDiep.TabIndex = 11;
            lblThongDiep.Text = "label5";
            lblThongDiep.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(54, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 230);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // linklblDangKyTaiKhoan
            // 
            linklblDangKyTaiKhoan.Anchor = AnchorStyles.None;
            linklblDangKyTaiKhoan.AutoSize = true;
            linklblDangKyTaiKhoan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            linklblDangKyTaiKhoan.LinkColor = Color.FromArgb(224, 224, 224);
            linklblDangKyTaiKhoan.Location = new Point(64, 430);
            linklblDangKyTaiKhoan.Name = "linklblDangKyTaiKhoan";
            linklblDangKyTaiKhoan.Size = new Size(225, 23);
            linklblDangKyTaiKhoan.TabIndex = 9;
            linklblDangKyTaiKhoan.TabStop = true;
            linklblDangKyTaiKhoan.Text = "Đăng Ký Tài Khoản Sử Dụng";
            linklblDangKyTaiKhoan.TextAlign = ContentAlignment.BottomCenter;
            linklblDangKyTaiKhoan.LinkClicked += linklblDangKyTaiKhoan_LinkClicked;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 3500;
            timer1.Tick += timer1_Tick;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(80, 0, 0, 0);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(920, 567);
            panel5.TabIndex = 1;
            // 
            // frmlogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.picturelogin1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(920, 567);
            Controls.Add(panel1);
            Controls.Add(panel5);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmlogin";
            Text = "ỨNG DỤNG QUẢN DƯỠNG VÀ QUẢN LÝ";
            WindowState = FormWindowState.Maximized;
            Load += frmlogin_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private TextBox txtTaiKhoan;
        private Label label3;
        private Button btnDangNhap;
        private ComboBox cboSoHuu;
        private Label label4;
        private TextBox txtMatKhau;
        private LinkLabel linklblQuenMatKhau;
        private LinkLabel linklblDangKyTaiKhoan;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Label lblThongDiep;
        private Panel panel4;
        private Panel panel5;
    }
}
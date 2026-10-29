namespace MotorbikeServices.GUI.Setup
{
    partial class frmaccountuser
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
            btnThuNho = new Button();
            btnDangKyXeMoi = new Button();
            lblLogo = new Label();
            btnLichSuSuaChua = new Button();
            btnThongTinCaNhan = new Button();
            btnGopY = new Button();
            lblSubtitle = new Label();
            button2 = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            button5 = new Button();
            panelMain = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnThuNho
            // 
            btnThuNho.BackgroundImageLayout = ImageLayout.None;
            btnThuNho.Location = new Point(23, 34);
            btnThuNho.Name = "btnThuNho";
            btnThuNho.Size = new Size(62, 62);
            btnThuNho.TabIndex = 13;
            btnThuNho.Text = "☰";
            btnThuNho.UseVisualStyleBackColor = true;
            btnThuNho.Click += btnThuNho_Click;
            // 
            // btnDangKyXeMoi
            // 
            btnDangKyXeMoi.BackColor = Color.Transparent;
            btnDangKyXeMoi.Location = new Point(0, 242);
            btnDangKyXeMoi.Name = "btnDangKyXeMoi";
            btnDangKyXeMoi.Size = new Size(230, 61);
            btnDangKyXeMoi.TabIndex = 1;
            btnDangKyXeMoi.Text = "🚗 Đăng ký xe mới";
            btnDangKyXeMoi.UseVisualStyleBackColor = false;
            btnDangKyXeMoi.Click += btnDangKyXeMoi_Click;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.BackColor = Color.Transparent;
            lblLogo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(3, 18);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(168, 38);
            lblLogo.TabIndex = 2;
            lblLogo.Text = "VehicleCare";
            // 
            // btnLichSuSuaChua
            // 
            btnLichSuSuaChua.BackColor = Color.Transparent;
            btnLichSuSuaChua.Location = new Point(-3, 309);
            btnLichSuSuaChua.Name = "btnLichSuSuaChua";
            btnLichSuSuaChua.Size = new Size(233, 61);
            btnLichSuSuaChua.TabIndex = 2;
            btnLichSuSuaChua.Text = "🛠️ Lịch sử sửa chữa ";
            btnLichSuSuaChua.UseVisualStyleBackColor = false;
            btnLichSuSuaChua.Click += btnLichSuSuaChua_Click;
            // 
            // btnThongTinCaNhan
            // 
            btnThongTinCaNhan.BackColor = Color.Transparent;
            btnThongTinCaNhan.Location = new Point(0, 175);
            btnThongTinCaNhan.Name = "btnThongTinCaNhan";
            btnThongTinCaNhan.Size = new Size(230, 61);
            btnThongTinCaNhan.TabIndex = 3;
            btnThongTinCaNhan.Text = "👤 Thông tin cá nhân";
            btnThongTinCaNhan.UseVisualStyleBackColor = false;
            btnThongTinCaNhan.Click += btnThongTinCaNhan_Click;
            // 
            // btnGopY
            // 
            btnGopY.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGopY.Location = new Point(-3, 376);
            btnGopY.Name = "btnGopY";
            btnGopY.Size = new Size(233, 58);
            btnGopY.TabIndex = 12;
            btnGopY.Text = "Góp ý";
            btnGopY.UseVisualStyleBackColor = true;
            btnGopY.Click += button1_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.LightSteelBlue;
            lblSubtitle.Location = new Point(177, 34);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(39, 17);
            lblSubtitle.TabIndex = 3;
            lblSubtitle.Text = "USER";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Location = new Point(0, 99);
            button2.Name = "button2";
            button2.Size = new Size(230, 61);
            button2.TabIndex = 5;
            button2.Text = "Trở về trang chủ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 41, 59);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(lblSubtitle);
            panel2.Controls.Add(btnGopY);
            panel2.Controls.Add(btnThongTinCaNhan);
            panel2.Controls.Add(btnLichSuSuaChua);
            panel2.Controls.Add(lblLogo);
            panel2.Controls.Add(btnDangKyXeMoi);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 625);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(btnThuNho);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 125);
            panel1.TabIndex = 2;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.Location = new Point(857, 32);
            button5.Name = "button5";
            button5.Size = new Size(73, 64);
            button5.TabIndex = 14;
            button5.Text = "->";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(3, 134);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(951, 500);
            panelMain.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panelMain, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(230, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(957, 625);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // frmaccountuser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 625);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel2);
            Name = "frmaccountuser";
            Text = "Menu User";
            WindowState = FormWindowState.Maximized;
            Load += frmaccountuser_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnThuNho;
        private Button btnDangKyXeMoi;
        private Label lblLogo;
        private Button btnLichSuSuaChua;
        private Button btnThongTinCaNhan;
        private Button btnGopY;
        private Label lblSubtitle;
        private Button button2;
        private Panel panel2;
        private Panel panel1;
        private Panel panelMain;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button5;
    }
}
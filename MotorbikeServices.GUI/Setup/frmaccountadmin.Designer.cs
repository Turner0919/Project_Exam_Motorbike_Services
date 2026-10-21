namespace MotorbikeServices.GUI.Setup
{
    partial class frmaccountadmin
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
            tlpMain = new TableLayoutPanel();
            pnlHeader = new Panel();
            btnProfile = new Button();
            lblSubtitle = new Label();
            lblLogo = new Label();
            pnlSidebar = new Panel();
            btnAccount = new Button();
            btnQuyChuan = new Button();
            btnHangXe = new Button();
            btnDashboard = new Button();
            lblMenuTitle = new Label();
            pnlContent = new Panel();
            tlpMain.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(pnlHeader, 0, 0);
            tlpMain.Controls.Add(pnlSidebar, 0, 1);
            tlpMain.Controls.Add(pnlContent, 1, 1);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Margin = new Padding(0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 2;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1082, 603);
            tlpMain.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(21, 54, 91);
            tlpMain.SetColumnSpan(pnlHeader, 2);
            pnlHeader.Controls.Add(btnProfile);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblLogo);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1082, 60);
            pnlHeader.TabIndex = 0;
            // 
            // btnProfile
            // 
            btnProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfile.ForeColor = Color.White;
            btnProfile.Location = new Point(979, 16);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(100, 36);
            btnProfile.TabIndex = 2;
            btnProfile.Text = "Admin";
            btnProfile.UseVisualStyleBackColor = true;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.LightSteelBlue;
            lblSubtitle.Location = new Point(194, 30);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(117, 17);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "ADMINISTRATION";
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.BackColor = Color.Transparent;
            lblLogo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(20, 14);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(168, 38);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "VehicleCare";
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(25, 57, 94);
            pnlSidebar.Controls.Add(btnAccount);
            pnlSidebar.Controls.Add(btnQuyChuan);
            pnlSidebar.Controls.Add(btnHangXe);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblMenuTitle);
            pnlSidebar.Dock = DockStyle.Fill;
            pnlSidebar.Location = new Point(0, 60);
            pnlSidebar.Margin = new Padding(0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 543);
            pnlSidebar.TabIndex = 1;
            // 
            // btnAccount
            // 
            btnAccount.Cursor = Cursors.Hand;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            btnAccount.ForeColor = Color.White;
            btnAccount.Location = new Point(10, 205);
            btnAccount.Name = "btnAccount";
            btnAccount.Padding = new Padding(12, 0, 0, 0);
            btnAccount.Size = new Size(200, 44);
            btnAccount.TabIndex = 4;
            btnAccount.Text = "Quản lý tài khoản";
            btnAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnQuyChuan
            // 
            btnQuyChuan.Cursor = Cursors.Hand;
            btnQuyChuan.FlatAppearance.BorderSize = 0;
            btnQuyChuan.FlatStyle = FlatStyle.Flat;
            btnQuyChuan.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            btnQuyChuan.ForeColor = Color.White;
            btnQuyChuan.Location = new Point(10, 155);
            btnQuyChuan.Name = "btnQuyChuan";
            btnQuyChuan.Padding = new Padding(12, 0, 0, 0);
            btnQuyChuan.Size = new Size(200, 44);
            btnQuyChuan.TabIndex = 3;
            btnQuyChuan.Text = "Quy chuẩn bảo dưỡng";
            btnQuyChuan.TextAlign = ContentAlignment.MiddleLeft;
            btnQuyChuan.UseVisualStyleBackColor = true;
            btnQuyChuan.Click += btnQuyChuan_Click;
            // 
            // btnHangXe
            // 
            btnHangXe.Cursor = Cursors.Hand;
            btnHangXe.FlatAppearance.BorderSize = 0;
            btnHangXe.FlatStyle = FlatStyle.Flat;
            btnHangXe.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            btnHangXe.ForeColor = Color.White;
            btnHangXe.Location = new Point(10, 105);
            btnHangXe.Name = "btnHangXe";
            btnHangXe.Padding = new Padding(12, 0, 0, 0);
            btnHangXe.Size = new Size(200, 44);
            btnHangXe.TabIndex = 2;
            btnHangXe.Text = "Hãng xe và dòng xe";
            btnHangXe.TextAlign = ContentAlignment.MiddleLeft;
            btnHangXe.UseVisualStyleBackColor = true;
            btnHangXe.Click += btnHangXe_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(25, 57, 94);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(10, 55);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(12, 0, 0, 0);
            btnDashboard.Size = new Size(200, 44);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Tổng quan";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblMenuTitle
            // 
            lblMenuTitle.AutoSize = true;
            lblMenuTitle.BackColor = Color.Transparent;
            lblMenuTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuTitle.ForeColor = Color.LightSteelBlue;
            lblMenuTitle.Location = new Point(18, 24);
            lblMenuTitle.Name = "lblMenuTitle";
            lblMenuTitle.Size = new Size(155, 20);
            lblMenuTitle.TabIndex = 0;
            lblMenuTitle.Text = "QUẢN LÝ HỆ THỐNG";
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(223, 63);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(20);
            pnlContent.Size = new Size(856, 537);
            pnlContent.TabIndex = 2;
            // 
            // frmaccountadmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            ClientSize = new Size(1082, 603);
            Controls.Add(tlpMain);
            MinimumSize = new Size(1100, 650);
            Name = "frmaccountadmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VehicleCare Admin";
            WindowState = FormWindowState.Maximized;
            tlpMain.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Panel pnlHeader;
        private Panel pnlSidebar;
        private Panel pnlContent;
        private Button btnProfile;
        private Label lblSubtitle;
        private Label lblLogo;
        private Button btnHangXe;
        private Button btnDashboard;
        private Label lblMenuTitle;
        private Button btnQuyChuan;
        private Button btnAccount;
    }
}
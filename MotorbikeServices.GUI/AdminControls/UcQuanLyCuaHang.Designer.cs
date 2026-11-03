using System.Drawing;
using System.Windows.Forms;

namespace MotorbikeServices.GUI.AdminControls
{
    partial class UcQuanLyCuaHang
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel tlpMain;
        private Panel pnlHeader;

        private Label lblTitle;
        private Label lblDescription;

        private TableLayoutPanel tlpStatistics;

        private Panel pnlTongSo;
        private Panel pnlDangHoatDong;
        private Panel pnlTamNgung;

        private Label lblTongSoTitle;
        private Label lblTongSoValue;

        private Label lblDangHoatDongTitle;
        private Label lblDangHoatDongValue;

        private Label lblTamNgungTitle;
        private Label lblTamNgungValue;

        private TableLayoutPanel tlpFilter;

        private Label lblTimKiem;
        private TextBox txtTimKiem;

        private Label lblLocTrangThai;
        private ComboBox cboTrangThai;

        private Button btnLamMoi;

        private DataGridView dgvCuaHang;

        private DataGridViewTextBoxColumn colTenCuaHang;
        private DataGridViewTextBoxColumn colTaiKhoan;
        private DataGridViewTextBoxColumn colTinhTP;
        private DataGridViewTextBoxColumn colPhuongXa;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewTextBoxColumn colTrangThai;
        private DataGridViewButtonColumn colThaoTac;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tlpMain = new TableLayoutPanel();
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblDescription = new Label();
            tlpStatistics = new TableLayoutPanel();
            pnlTongSo = new Panel();
            lblTongSoValue = new Label();
            lblTongSoTitle = new Label();
            pnlDangHoatDong = new Panel();
            lblDangHoatDongValue = new Label();
            lblDangHoatDongTitle = new Label();
            pnlTamNgung = new Panel();
            lblTamNgungValue = new Label();
            lblTamNgungTitle = new Label();
            tlpFilter = new TableLayoutPanel();
            txtTimKiem = new TextBox();
            cboTrangThai = new ComboBox();
            btnLamMoi = new Button();
            lblTimKiem = new Label();
            lblLocTrangThai = new Label();
            dgvCuaHang = new DataGridView();
            colThaoTac = new DataGridViewButtonColumn();
            tlpMain.SuspendLayout();
            pnlHeader.SuspendLayout();
            tlpStatistics.SuspendLayout();
            pnlTongSo.SuspendLayout();
            pnlDangHoatDong.SuspendLayout();
            pnlTamNgung.SuspendLayout();
            tlpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCuaHang).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.BackColor = Color.FromArgb(245, 248, 252);
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(pnlHeader, 0, 0);
            tlpMain.Controls.Add(tlpStatistics, 0, 1);
            tlpMain.Controls.Add(tlpFilter, 0, 2);
            tlpMain.Controls.Add(dgvCuaHang, 0, 3);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Margin = new Padding(0);
            tlpMain.Name = "tlpMain";
            tlpMain.Padding = new Padding(22, 16, 22, 18);
            tlpMain.RowCount = 4;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 118F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1341, 675);
            tlpMain.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(245, 248, 252);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblDescription);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(22, 16);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1297, 78);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(25, 54, 87);
            lblTitle.Location = new Point(2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(298, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quản lý cửa hàng";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9.5F);
            lblDescription.ForeColor = Color.FromArgb(105, 121, 140);
            lblDescription.Location = new Point(5, 47);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(424, 21);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Theo dõi thông tin và trạng thái hoạt động của các cửa hàng";
            // 
            // tlpStatistics
            // 
            tlpStatistics.BackColor = Color.FromArgb(245, 248, 252);
            tlpStatistics.ColumnCount = 3;
            tlpStatistics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.333F));
            tlpStatistics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.333F));
            tlpStatistics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.334F));
            tlpStatistics.Controls.Add(pnlTongSo, 0, 0);
            tlpStatistics.Controls.Add(pnlDangHoatDong, 1, 0);
            tlpStatistics.Controls.Add(pnlTamNgung, 2, 0);
            tlpStatistics.Dock = DockStyle.Fill;
            tlpStatistics.Location = new Point(22, 94);
            tlpStatistics.Margin = new Padding(0);
            tlpStatistics.Name = "tlpStatistics";
            tlpStatistics.RowCount = 1;
            tlpStatistics.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpStatistics.Size = new Size(1297, 118);
            tlpStatistics.TabIndex = 1;
            // 
            // pnlTongSo
            // 
            pnlTongSo.BackColor = Color.FromArgb(231, 240, 252);
            pnlTongSo.Controls.Add(lblTongSoValue);
            pnlTongSo.Controls.Add(lblTongSoTitle);
            pnlTongSo.Dock = DockStyle.Fill;
            pnlTongSo.Location = new Point(0, 4);
            pnlTongSo.Margin = new Padding(0, 4, 8, 4);
            pnlTongSo.Name = "pnlTongSo";
            pnlTongSo.Padding = new Padding(16, 10, 12, 8);
            pnlTongSo.Size = new Size(424, 110);
            pnlTongSo.TabIndex = 0;
            // 
            // lblTongSoValue
            // 
            lblTongSoValue.Dock = DockStyle.Fill;
            lblTongSoValue.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblTongSoValue.ForeColor = Color.FromArgb(25, 54, 87);
            lblTongSoValue.Location = new Point(16, 40);
            lblTongSoValue.Name = "lblTongSoValue";
            lblTongSoValue.Size = new Size(396, 62);
            lblTongSoValue.TabIndex = 0;
            lblTongSoValue.Text = "0";
            lblTongSoValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTongSoTitle
            // 
            lblTongSoTitle.Dock = DockStyle.Top;
            lblTongSoTitle.Font = new Font("Segoe UI", 9F);
            lblTongSoTitle.ForeColor = Color.FromArgb(49, 87, 125);
            lblTongSoTitle.Location = new Point(16, 10);
            lblTongSoTitle.Name = "lblTongSoTitle";
            lblTongSoTitle.Size = new Size(396, 30);
            lblTongSoTitle.TabIndex = 1;
            lblTongSoTitle.Text = "TỔNG SỐ CỬA HÀNG";
            lblTongSoTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlDangHoatDong
            // 
            pnlDangHoatDong.BackColor = Color.FromArgb(230, 245, 237);
            pnlDangHoatDong.Controls.Add(lblDangHoatDongValue);
            pnlDangHoatDong.Controls.Add(lblDangHoatDongTitle);
            pnlDangHoatDong.Dock = DockStyle.Fill;
            pnlDangHoatDong.Location = new Point(436, 4);
            pnlDangHoatDong.Margin = new Padding(4);
            pnlDangHoatDong.Name = "pnlDangHoatDong";
            pnlDangHoatDong.Padding = new Padding(16, 10, 12, 8);
            pnlDangHoatDong.Size = new Size(424, 110);
            pnlDangHoatDong.TabIndex = 1;
            // 
            // lblDangHoatDongValue
            // 
            lblDangHoatDongValue.Dock = DockStyle.Fill;
            lblDangHoatDongValue.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblDangHoatDongValue.ForeColor = Color.FromArgb(35, 145, 83);
            lblDangHoatDongValue.Location = new Point(16, 40);
            lblDangHoatDongValue.Name = "lblDangHoatDongValue";
            lblDangHoatDongValue.Size = new Size(396, 62);
            lblDangHoatDongValue.TabIndex = 0;
            lblDangHoatDongValue.Text = "0";
            lblDangHoatDongValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDangHoatDongTitle
            // 
            lblDangHoatDongTitle.Dock = DockStyle.Top;
            lblDangHoatDongTitle.Font = new Font("Segoe UI", 9F);
            lblDangHoatDongTitle.ForeColor = Color.FromArgb(43, 117, 76);
            lblDangHoatDongTitle.Location = new Point(16, 10);
            lblDangHoatDongTitle.Name = "lblDangHoatDongTitle";
            lblDangHoatDongTitle.Size = new Size(396, 30);
            lblDangHoatDongTitle.TabIndex = 1;
            lblDangHoatDongTitle.Text = "ĐANG HOẠT ĐỘNG";
            lblDangHoatDongTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlTamNgung
            // 
            pnlTamNgung.BackColor = Color.FromArgb(255, 243, 224);
            pnlTamNgung.Controls.Add(lblTamNgungValue);
            pnlTamNgung.Controls.Add(lblTamNgungTitle);
            pnlTamNgung.Dock = DockStyle.Fill;
            pnlTamNgung.Location = new Point(872, 4);
            pnlTamNgung.Margin = new Padding(8, 4, 0, 4);
            pnlTamNgung.Name = "pnlTamNgung";
            pnlTamNgung.Padding = new Padding(16, 10, 12, 8);
            pnlTamNgung.Size = new Size(425, 110);
            pnlTamNgung.TabIndex = 2;
            // 
            // lblTamNgungValue
            // 
            lblTamNgungValue.Dock = DockStyle.Fill;
            lblTamNgungValue.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblTamNgungValue.ForeColor = Color.FromArgb(211, 128, 35);
            lblTamNgungValue.Location = new Point(16, 40);
            lblTamNgungValue.Name = "lblTamNgungValue";
            lblTamNgungValue.Size = new Size(397, 62);
            lblTamNgungValue.TabIndex = 0;
            lblTamNgungValue.Text = "0";
            lblTamNgungValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTamNgungTitle
            // 
            lblTamNgungTitle.Dock = DockStyle.Top;
            lblTamNgungTitle.Font = new Font("Segoe UI", 9F);
            lblTamNgungTitle.ForeColor = Color.FromArgb(155, 93, 30);
            lblTamNgungTitle.Location = new Point(16, 10);
            lblTamNgungTitle.Name = "lblTamNgungTitle";
            lblTamNgungTitle.Size = new Size(397, 30);
            lblTamNgungTitle.TabIndex = 1;
            lblTamNgungTitle.Text = "TẠM NGỪNG HOẠT ĐỘNG";
            lblTamNgungTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpFilter
            // 
            tlpFilter.ColumnCount = 5;
            tlpFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tlpFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            tlpFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tlpFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            tlpFilter.Controls.Add(txtTimKiem, 1, 0);
            tlpFilter.Controls.Add(cboTrangThai, 3, 0);
            tlpFilter.Controls.Add(btnLamMoi, 4, 0);
            tlpFilter.Controls.Add(lblTimKiem, 0, 0);
            tlpFilter.Controls.Add(lblLocTrangThai, 2, 0);
            tlpFilter.Dock = DockStyle.Fill;
            tlpFilter.Location = new Point(22, 212);
            tlpFilter.Margin = new Padding(0);
            tlpFilter.Name = "tlpFilter";
            tlpFilter.Padding = new Padding(0, 8, 0, 5);
            tlpFilter.RowCount = 1;
            tlpFilter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFilter.Size = new Size(1297, 62);
            tlpFilter.TabIndex = 2;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Dock = DockStyle.Fill;
            txtTimKiem.Font = new Font("Segoe UI", 9.5F);
            txtTimKiem.Location = new Point(80, 10);
            txtTimKiem.Margin = new Padding(0, 2, 12, 2);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tên cửa hàng, tài khoản, địa chỉ...";
            txtTimKiem.Size = new Size(795, 29);
            txtTimKiem.TabIndex = 1;
            // 
            // cboTrangThai
            // 
            cboTrangThai.Dock = DockStyle.Fill;
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Font = new Font("Segoe UI", 9.5F);
            cboTrangThai.Items.AddRange(new object[] { "Tất cả trạng thái", "Đang hoạt động", "Tạm ngừng hoạt động" });
            cboTrangThai.Location = new Point(972, 10);
            cboTrangThai.Margin = new Padding(0, 2, 12, 2);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(208, 29);
            cboTrangThai.TabIndex = 3;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(230, 237, 246);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = Color.FromArgb(25, 54, 87);
            btnLamMoi.Location = new Point(1192, 9);
            btnLamMoi.Margin = new Padding(0, 1, 0, 1);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(93, 30);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "↻  Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // lblTimKiem
            // 
            lblTimKiem.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            lblTimKiem.ForeColor = Color.FromArgb(25, 54, 87);
            lblTimKiem.Location = new Point(3, 8);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(74, 31);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Tìm kiếm:";
            lblTimKiem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLocTrangThai
            // 
            lblLocTrangThai.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            lblLocTrangThai.ForeColor = Color.FromArgb(25, 54, 87);
            lblLocTrangThai.Location = new Point(890, 8);
            lblLocTrangThai.Name = "lblLocTrangThai";
            lblLocTrangThai.Size = new Size(79, 31);
            lblLocTrangThai.TabIndex = 2;
            lblLocTrangThai.Text = "Trạng thái:";
            lblLocTrangThai.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvCuaHang
            // 
            dgvCuaHang.AllowUserToAddRows = false;
            dgvCuaHang.AllowUserToDeleteRows = false;
            dgvCuaHang.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(247, 249, 252);
            dgvCuaHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCuaHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCuaHang.BackgroundColor = Color.White;
            dgvCuaHang.BorderStyle = BorderStyle.None;
            dgvCuaHang.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCuaHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(25, 54, 87);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCuaHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCuaHang.ColumnHeadersHeight = 44;
            dgvCuaHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCuaHang.Columns.AddRange(new DataGridViewColumn[] { colThaoTac });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(55, 65, 80);
            dataGridViewCellStyle4.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(220, 235, 250);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(25, 54, 87);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvCuaHang.DefaultCellStyle = dataGridViewCellStyle4;
            dgvCuaHang.Dock = DockStyle.Fill;
            dgvCuaHang.EnableHeadersVisualStyles = false;
            dgvCuaHang.GridColor = Color.FromArgb(226, 233, 241);
            dgvCuaHang.Location = new Point(22, 277);
            dgvCuaHang.Margin = new Padding(0, 3, 0, 0);
            dgvCuaHang.MultiSelect = false;
            dgvCuaHang.Name = "dgvCuaHang";
            dgvCuaHang.ReadOnly = true;
            dgvCuaHang.RowHeadersVisible = false;
            dgvCuaHang.RowHeadersWidth = 51;
            dgvCuaHang.RowTemplate.Height = 42;
            dgvCuaHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCuaHang.Size = new Size(1297, 380);
            dgvCuaHang.TabIndex = 3;
            // 
            // colThaoTac
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(231, 240, 252);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(52, 127, 193);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(220, 235, 250);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(25, 54, 87);
            colThaoTac.DefaultCellStyle = dataGridViewCellStyle3;
            colThaoTac.FillWeight = 85F;
            colThaoTac.FlatStyle = FlatStyle.Flat;
            colThaoTac.HeaderText = "Thao tác";
            colThaoTac.MinimumWidth = 95;
            colThaoTac.Name = "colThaoTac";
            colThaoTac.ReadOnly = true;
            colThaoTac.Text = "Thay đổi";
            colThaoTac.UseColumnTextForButtonValue = true;
            // 
            // UcQuanLyCuaHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 252);
            Controls.Add(tlpMain);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(800, 500);
            Name = "UcQuanLyCuaHang";
            Size = new Size(1341, 675);
            tlpMain.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tlpStatistics.ResumeLayout(false);
            pnlTongSo.ResumeLayout(false);
            pnlDangHoatDong.ResumeLayout(false);
            pnlTamNgung.ResumeLayout(false);
            tlpFilter.ResumeLayout(false);
            tlpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCuaHang).EndInit();
            ResumeLayout(false);
        }
    }
}
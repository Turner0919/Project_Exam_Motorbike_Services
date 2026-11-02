
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

        private Panel pnlFilter;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Label lblLocTrangThai;
        private ComboBox cboTrangThai;

        private DataGridView dgvCuaHang;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tlpMain = new TableLayoutPanel();
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblDescription = new Label();
            tlpStatistics = new TableLayoutPanel();
            pnlTongSo = new Panel();
            lblTongSoTitle = new Label();
            lblTongSoValue = new Label();
            pnlDangHoatDong = new Panel();
            lblDangHoatDongTitle = new Label();
            lblDangHoatDongValue = new Label();
            pnlTamNgung = new Panel();
            lblTamNgungTitle = new Label();
            lblTamNgungValue = new Label();
            pnlFilter = new Panel();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            lblLocTrangThai = new Label();
            cboTrangThai = new ComboBox();
            dgvCuaHang = new DataGridView();
            colTenCuaHang = new DataGridViewTextBoxColumn();
            colTaiKhoan = new DataGridViewTextBoxColumn();
            colTinhTP = new DataGridViewTextBoxColumn();
            colPhuongXa = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            colThaoTac = new DataGridViewButtonColumn();
            tlpMain.SuspendLayout();
            pnlHeader.SuspendLayout();
            tlpStatistics.SuspendLayout();
            pnlTongSo.SuspendLayout();
            pnlDangHoatDong.SuspendLayout();
            pnlTamNgung.SuspendLayout();
            pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCuaHang).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(pnlHeader, 0, 0);
            tlpMain.Controls.Add(tlpStatistics, 0, 1);
            tlpMain.Controls.Add(pnlFilter, 0, 2);
            tlpMain.Controls.Add(dgvCuaHang, 0, 3);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.Padding = new Padding(20, 15, 20, 15);
            tlpMain.RowCount = 4;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 115F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1519, 534);
            tlpMain.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Transparent;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblDescription);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(23, 18);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1473, 69);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(21, 54, 91);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(257, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quản lý cửa hàng";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F);
            lblDescription.ForeColor = Color.FromArgb(110, 120, 135);
            lblDescription.Location = new Point(3, 39);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(410, 20);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Theo dõi thông tin và trạng thái hoạt động của các cửa hàng";
            // 
            // tlpStatistics
            // 
            tlpStatistics.ColumnCount = 3;
            tlpStatistics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpStatistics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpStatistics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tlpStatistics.Controls.Add(pnlTongSo, 0, 0);
            tlpStatistics.Controls.Add(pnlDangHoatDong, 1, 0);
            tlpStatistics.Controls.Add(pnlTamNgung, 2, 0);
            tlpStatistics.Dock = DockStyle.Fill;
            tlpStatistics.Location = new Point(23, 93);
            tlpStatistics.Name = "tlpStatistics";
            tlpStatistics.Padding = new Padding(0, 5, 0, 5);
            tlpStatistics.RowCount = 1;
            tlpStatistics.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpStatistics.Size = new Size(1473, 109);
            tlpStatistics.TabIndex = 1;
            // 
            // pnlTongSo
            // 
            pnlTongSo.BackColor = Color.White;
            pnlTongSo.Controls.Add(lblTongSoTitle);
            pnlTongSo.Controls.Add(lblTongSoValue);
            pnlTongSo.Dock = DockStyle.Fill;
            pnlTongSo.Location = new Point(0, 5);
            pnlTongSo.Margin = new Padding(0, 0, 8, 0);
            pnlTongSo.Name = "pnlTongSo";
            pnlTongSo.Padding = new Padding(15);
            pnlTongSo.Size = new Size(482, 99);
            pnlTongSo.TabIndex = 0;
            // 
            // lblTongSoTitle
            // 
            lblTongSoTitle.AutoSize = true;
            lblTongSoTitle.Font = new Font("Segoe UI", 9F);
            lblTongSoTitle.ForeColor = Color.FromArgb(100, 110, 125);
            lblTongSoTitle.Location = new Point(15, 15);
            lblTongSoTitle.Name = "lblTongSoTitle";
            lblTongSoTitle.Size = new Size(127, 20);
            lblTongSoTitle.TabIndex = 0;
            lblTongSoTitle.Text = "Tổng số cửa hàng";
            // 
            // lblTongSoValue
            // 
            lblTongSoValue.AutoSize = true;
            lblTongSoValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTongSoValue.ForeColor = Color.FromArgb(21, 54, 91);
            lblTongSoValue.Location = new Point(12, 39);
            lblTongSoValue.Name = "lblTongSoValue";
            lblTongSoValue.Size = new Size(43, 50);
            lblTongSoValue.TabIndex = 1;
            lblTongSoValue.Text = "0";
            // 
            // pnlDangHoatDong
            // 
            pnlDangHoatDong.BackColor = Color.White;
            pnlDangHoatDong.Controls.Add(lblDangHoatDongTitle);
            pnlDangHoatDong.Controls.Add(lblDangHoatDongValue);
            pnlDangHoatDong.Dock = DockStyle.Fill;
            pnlDangHoatDong.Location = new Point(494, 5);
            pnlDangHoatDong.Margin = new Padding(4, 0, 4, 0);
            pnlDangHoatDong.Name = "pnlDangHoatDong";
            pnlDangHoatDong.Padding = new Padding(15);
            pnlDangHoatDong.Size = new Size(482, 99);
            pnlDangHoatDong.TabIndex = 1;
            // 
            // lblDangHoatDongTitle
            // 
            lblDangHoatDongTitle.AutoSize = true;
            lblDangHoatDongTitle.Font = new Font("Segoe UI", 9F);
            lblDangHoatDongTitle.ForeColor = Color.FromArgb(100, 110, 125);
            lblDangHoatDongTitle.Location = new Point(15, 15);
            lblDangHoatDongTitle.Name = "lblDangHoatDongTitle";
            lblDangHoatDongTitle.Size = new Size(118, 20);
            lblDangHoatDongTitle.TabIndex = 0;
            lblDangHoatDongTitle.Text = "Đang hoạt động";
            // 
            // lblDangHoatDongValue
            // 
            lblDangHoatDongValue.AutoSize = true;
            lblDangHoatDongValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblDangHoatDongValue.ForeColor = Color.FromArgb(39, 174, 96);
            lblDangHoatDongValue.Location = new Point(12, 39);
            lblDangHoatDongValue.Name = "lblDangHoatDongValue";
            lblDangHoatDongValue.Size = new Size(43, 50);
            lblDangHoatDongValue.TabIndex = 1;
            lblDangHoatDongValue.Text = "0";
            // 
            // pnlTamNgung
            // 
            pnlTamNgung.BackColor = Color.White;
            pnlTamNgung.Controls.Add(lblTamNgungTitle);
            pnlTamNgung.Controls.Add(lblTamNgungValue);
            pnlTamNgung.Dock = DockStyle.Fill;
            pnlTamNgung.Location = new Point(988, 5);
            pnlTamNgung.Margin = new Padding(8, 0, 0, 0);
            pnlTamNgung.Name = "pnlTamNgung";
            pnlTamNgung.Padding = new Padding(15);
            pnlTamNgung.Size = new Size(485, 99);
            pnlTamNgung.TabIndex = 2;
            // 
            // lblTamNgungTitle
            // 
            lblTamNgungTitle.AutoSize = true;
            lblTamNgungTitle.Font = new Font("Segoe UI", 9F);
            lblTamNgungTitle.ForeColor = Color.FromArgb(100, 110, 125);
            lblTamNgungTitle.Location = new Point(15, 15);
            lblTamNgungTitle.Name = "lblTamNgungTitle";
            lblTamNgungTitle.Size = new Size(158, 20);
            lblTamNgungTitle.TabIndex = 0;
            lblTamNgungTitle.Text = "Tạm ngừng hoạt động";
            // 
            // lblTamNgungValue
            // 
            lblTamNgungValue.AutoSize = true;
            lblTamNgungValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTamNgungValue.ForeColor = Color.FromArgb(230, 145, 45);
            lblTamNgungValue.Location = new Point(12, 39);
            lblTamNgungValue.Name = "lblTamNgungValue";
            lblTamNgungValue.Size = new Size(43, 50);
            lblTamNgungValue.TabIndex = 1;
            lblTamNgungValue.Text = "0";
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = Color.Transparent;
            pnlFilter.Controls.Add(lblTimKiem);
            pnlFilter.Controls.Add(txtTimKiem);
            pnlFilter.Controls.Add(lblLocTrangThai);
            pnlFilter.Controls.Add(cboTrangThai);
            pnlFilter.Dock = DockStyle.Fill;
            pnlFilter.Location = new Point(23, 208);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(1473, 59);
            pnlFilter.TabIndex = 2;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTimKiem.ForeColor = Color.FromArgb(60, 70, 85);
            lblTimKiem.Location = new Point(0, 20);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(78, 20);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 9F);
            txtTimKiem.Location = new Point(85, 15);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên cửa hàng hoặc tài khoản...";
            txtTimKiem.Size = new Size(280, 27);
            txtTimKiem.TabIndex = 0;
            // 
            // lblLocTrangThai
            // 
            lblLocTrangThai.AutoSize = true;
            lblLocTrangThai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLocTrangThai.ForeColor = Color.FromArgb(60, 70, 85);
            lblLocTrangThai.Location = new Point(390, 20);
            lblLocTrangThai.Name = "lblLocTrangThai";
            lblLocTrangThai.Size = new Size(84, 20);
            lblLocTrangThai.TabIndex = 1;
            lblLocTrangThai.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Font = new Font("Segoe UI", 9F);
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Tất cả trạng thái", "Đang hoạt động", "Tạm ngừng hoạt động" });
            cboTrangThai.Location = new Point(480, 15);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(220, 28);
            cboTrangThai.TabIndex = 1;
            // 
            // dgvCuaHang
            // 
            dgvCuaHang.AllowUserToAddRows = false;
            dgvCuaHang.AllowUserToDeleteRows = false;
            dgvCuaHang.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 253);
            dgvCuaHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCuaHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCuaHang.BackgroundColor = Color.White;
            dgvCuaHang.BorderStyle = BorderStyle.None;
            dgvCuaHang.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCuaHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(21, 54, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCuaHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCuaHang.ColumnHeadersHeight = 45;
            dgvCuaHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCuaHang.Columns.AddRange(new DataGridViewColumn[] { colTenCuaHang, colTaiKhoan, colTinhTP, colPhuongXa, colDiaChi, colTrangThai, colThaoTac });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(55, 65, 80);
            dataGridViewCellStyle3.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(225, 239, 252);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(21, 54, 91);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCuaHang.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCuaHang.Dock = DockStyle.Fill;
            dgvCuaHang.EnableHeadersVisualStyles = false;
            dgvCuaHang.GridColor = Color.FromArgb(235, 238, 243);
            dgvCuaHang.Location = new Point(23, 273);
            dgvCuaHang.MultiSelect = false;
            dgvCuaHang.Name = "dgvCuaHang";
            dgvCuaHang.ReadOnly = true;
            dgvCuaHang.RowHeadersVisible = false;
            dgvCuaHang.RowHeadersWidth = 51;
            dgvCuaHang.RowTemplate.Height = 42;
            dgvCuaHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCuaHang.Size = new Size(1473, 243);
            dgvCuaHang.TabIndex = 2;
            // 
            // colTenCuaHang
            // 
            colTenCuaHang.DataPropertyName = "TenCuaHang";
            colTenCuaHang.FillWeight = 150F;
            colTenCuaHang.HeaderText = "Tên cửa hàng";
            colTenCuaHang.MinimumWidth = 6;
            colTenCuaHang.Name = "colTenCuaHang";
            colTenCuaHang.ReadOnly = true;
            // 
            // colTaiKhoan
            // 
            colTaiKhoan.DataPropertyName = "TenTaiKhoan";
            colTaiKhoan.FillWeight = 90F;
            colTaiKhoan.HeaderText = "Tài khoản";
            colTaiKhoan.MinimumWidth = 6;
            colTaiKhoan.Name = "colTaiKhoan";
            colTaiKhoan.ReadOnly = true;
            // 
            // colTinhTP
            // 
            colTinhTP.DataPropertyName = "TinhTP";
            colTinhTP.FillWeight = 105F;
            colTinhTP.HeaderText = "Tỉnh / Thành phố";
            colTinhTP.MinimumWidth = 6;
            colTinhTP.Name = "colTinhTP";
            colTinhTP.ReadOnly = true;
            // 
            // colPhuongXa
            // 
            colPhuongXa.DataPropertyName = "PhuongXa";
            colPhuongXa.HeaderText = "Phường / Xã";
            colPhuongXa.MinimumWidth = 6;
            colPhuongXa.Name = "colPhuongXa";
            colPhuongXa.ReadOnly = true;
            // 
            // colDiaChi
            // 
            colDiaChi.DataPropertyName = "DiaChiDayDu";
            colDiaChi.FillWeight = 140F;
            colDiaChi.HeaderText = "Địa chỉ";
            colDiaChi.MinimumWidth = 6;
            colDiaChi.Name = "colDiaChi";
            colDiaChi.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.FillWeight = 110F;
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // colThaoTac
            // 
            colThaoTac.FillWeight = 85F;
            colThaoTac.FlatStyle = FlatStyle.Flat;
            colThaoTac.HeaderText = "Thao tác";
            colThaoTac.MinimumWidth = 6;
            colThaoTac.Name = "colThaoTac";
            colThaoTac.ReadOnly = true;
            colThaoTac.Text = "Thay đổi";
            colThaoTac.UseColumnTextForButtonValue = true;
            // 
            // UcQuanLyCuaHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            Controls.Add(tlpMain);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(800, 500);
            Name = "UcQuanLyCuaHang";
            Size = new Size(1519, 534);
            tlpMain.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tlpStatistics.ResumeLayout(false);
            pnlTongSo.ResumeLayout(false);
            pnlTongSo.PerformLayout();
            pnlDangHoatDong.ResumeLayout(false);
            pnlDangHoatDong.PerformLayout();
            pnlTamNgung.ResumeLayout(false);
            pnlTamNgung.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCuaHang).EndInit();
            ResumeLayout(false);
        }

        private DataGridViewTextBoxColumn colTenCuaHang;
        private DataGridViewTextBoxColumn colTaiKhoan;
        private DataGridViewTextBoxColumn colTinhTP;
        private DataGridViewTextBoxColumn colPhuongXa;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewTextBoxColumn colTrangThai;
        private DataGridViewButtonColumn colThaoTac;
    }
}

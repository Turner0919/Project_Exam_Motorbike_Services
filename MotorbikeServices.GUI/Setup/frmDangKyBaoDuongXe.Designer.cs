namespace MotorbikeServices.GUI.Setup
{
    partial class frmDangKyBaoDuongXe
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            label1 = new Label();
            lblHangXe = new Label();
            cboHangXe = new ComboBox();
            label2 = new Label();
            cboLoaiXe = new ComboBox();
            label3 = new Label();
            cboBienSo = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cboTinhTP = new ComboBox();
            cboPhuong = new ComboBox();
            dgvCuaHang = new DataGridView();
            TenCuaHang = new DataGridViewTextBoxColumn();
            SoCuaHang = new DataGridViewTextBoxColumn();
            TenDuong = new DataGridViewTextBoxColumn();
            label7 = new Label();
            cboSanPham = new ComboBox();
            label8 = new Label();
            nudSoLuong = new NumericUpDown();
            btnThem = new Button();
            btnXoaKhoiGio = new Button();
            dgvGioHang = new DataGridView();
            HangXe = new DataGridViewTextBoxColumn();
            LoaiXe = new DataGridViewTextBoxColumn();
            BienSo = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            lblTongTien = new Label();
            btnDatHang = new Button();
            btnLamMoi = new Button();
            lblSoLuongHoaDon = new Label();
            lblSoLuongCuaHang = new Label();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCuaHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 192, 0);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1663, 125);
            label1.TabIndex = 1;
            label1.Text = "Đăng Ký Bảo Dưỡng";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHangXe
            // 
            lblHangXe.Anchor = AnchorStyles.None;
            lblHangXe.AutoSize = true;
            lblHangXe.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblHangXe.Location = new Point(25, 157);
            lblHangXe.Name = "lblHangXe";
            lblHangXe.Size = new Size(83, 23);
            lblHangXe.TabIndex = 2;
            lblHangXe.Text = "Hãng Xe:";
            // 
            // cboHangXe
            // 
            cboHangXe.Anchor = AnchorStyles.None;
            cboHangXe.FormattingEnabled = true;
            cboHangXe.Location = new Point(114, 156);
            cboHangXe.Name = "cboHangXe";
            cboHangXe.Size = new Size(301, 28);
            cboHangXe.TabIndex = 3;
            cboHangXe.SelectedIndexChanged += cboHangXe_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(25, 215);
            label2.Name = "label2";
            label2.Size = new Size(73, 23);
            label2.TabIndex = 4;
            label2.Text = "Loại Xe:";
            // 
            // cboLoaiXe
            // 
            cboLoaiXe.Anchor = AnchorStyles.None;
            cboLoaiXe.FormattingEnabled = true;
            cboLoaiXe.Location = new Point(114, 215);
            cboLoaiXe.Name = "cboLoaiXe";
            cboLoaiXe.Size = new Size(301, 28);
            cboLoaiXe.TabIndex = 5;
            cboLoaiXe.SelectedIndexChanged += cboLoaiXe_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(25, 276);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 6;
            label3.Text = "Biển Số:";
            // 
            // cboBienSo
            // 
            cboBienSo.Anchor = AnchorStyles.None;
            cboBienSo.FormattingEnabled = true;
            cboBienSo.Location = new Point(114, 276);
            cboBienSo.Name = "cboBienSo";
            cboBienSo.Size = new Size(301, 28);
            cboBienSo.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(433, 155);
            label4.Name = "label4";
            label4.Size = new Size(205, 23);
            label4.TabIndex = 8;
            label4.Text = "Tìm Địa Chỉ Bảo Dưỡng:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label5.Location = new Point(654, 156);
            label5.Name = "label5";
            label5.Size = new Size(73, 23);
            label5.TabIndex = 9;
            label5.Text = "Tỉnh/TP:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label6.Location = new Point(654, 214);
            label6.Name = "label6";
            label6.Size = new Size(74, 23);
            label6.TabIndex = 10;
            label6.Text = "Phường:";
            // 
            // cboTinhTP
            // 
            cboTinhTP.Anchor = AnchorStyles.None;
            cboTinhTP.FormattingEnabled = true;
            cboTinhTP.Location = new Point(733, 154);
            cboTinhTP.Name = "cboTinhTP";
            cboTinhTP.Size = new Size(301, 28);
            cboTinhTP.TabIndex = 11;
            cboTinhTP.SelectedIndexChanged += cboTinhTP_SelectedIndexChanged;
            // 
            // cboPhuong
            // 
            cboPhuong.Anchor = AnchorStyles.None;
            cboPhuong.FormattingEnabled = true;
            cboPhuong.Location = new Point(733, 214);
            cboPhuong.Name = "cboPhuong";
            cboPhuong.Size = new Size(301, 28);
            cboPhuong.TabIndex = 12;
            cboPhuong.SelectedIndexChanged += cboPhuong_SelectedIndexChanged;
            // 
            // dgvCuaHang
            // 
            dgvCuaHang.Anchor = AnchorStyles.None;
            dgvCuaHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Blue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = Color.Blue;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCuaHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCuaHang.ColumnHeadersHeight = 29;
            dgvCuaHang.Columns.AddRange(new DataGridViewColumn[] { TenCuaHang, SoCuaHang, TenDuong });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCuaHang.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCuaHang.EnableHeadersVisualStyles = false;
            dgvCuaHang.Location = new Point(1054, 173);
            dgvCuaHang.Name = "dgvCuaHang";
            dgvCuaHang.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCuaHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCuaHang.RowHeadersVisible = false;
            dgvCuaHang.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = Color.White;
            dgvCuaHang.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvCuaHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCuaHang.Size = new Size(597, 249);
            dgvCuaHang.TabIndex = 13;
            dgvCuaHang.CellClick += dgvCuaHang_CellClick;
            dgvCuaHang.CellFormatting += dgv_CellFormatting;
            // 
            // TenCuaHang
            // 
            TenCuaHang.DataPropertyName = "TenCuaHang";
            TenCuaHang.HeaderText = "Tên Cửa Hàng";
            TenCuaHang.MinimumWidth = 6;
            TenCuaHang.Name = "TenCuaHang";
            TenCuaHang.ReadOnly = true;
            // 
            // SoCuaHang
            // 
            SoCuaHang.DataPropertyName = "SoCuaHang";
            SoCuaHang.HeaderText = "Số Cửa Hàng";
            SoCuaHang.MinimumWidth = 6;
            SoCuaHang.Name = "SoCuaHang";
            SoCuaHang.ReadOnly = true;
            // 
            // TenDuong
            // 
            TenDuong.DataPropertyName = "TenDuong";
            TenDuong.HeaderText = "Tên Đường";
            TenDuong.MinimumWidth = 6;
            TenDuong.Name = "TenDuong";
            TenDuong.ReadOnly = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.Location = new Point(433, 272);
            label7.Name = "label7";
            label7.Size = new Size(178, 23);
            label7.TabIndex = 14;
            label7.Text = "Sản Phẩm Cửa Hàng:";
            // 
            // cboSanPham
            // 
            cboSanPham.Anchor = AnchorStyles.None;
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(617, 276);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(417, 28);
            cboSanPham.TabIndex = 15;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label8.Location = new Point(577, 334);
            label8.Name = "label8";
            label8.Size = new Size(34, 23);
            label8.TabIndex = 16;
            label8.Text = "SL:";
            // 
            // nudSoLuong
            // 
            nudSoLuong.Anchor = AnchorStyles.None;
            nudSoLuong.Location = new Point(618, 330);
            nudSoLuong.Margin = new Padding(3, 4, 3, 4);
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(110, 27);
            nudSoLuong.TabIndex = 17;
            nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.BackColor = Color.Blue;
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(577, 369);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(154, 53);
            btnThem.TabIndex = 18;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoaKhoiGio
            // 
            btnXoaKhoiGio.Anchor = AnchorStyles.None;
            btnXoaKhoiGio.BackColor = Color.Red;
            btnXoaKhoiGio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaKhoiGio.ForeColor = Color.White;
            btnXoaKhoiGio.Location = new Point(737, 369);
            btnXoaKhoiGio.Margin = new Padding(3, 4, 3, 4);
            btnXoaKhoiGio.Name = "btnXoaKhoiGio";
            btnXoaKhoiGio.Size = new Size(154, 53);
            btnXoaKhoiGio.TabIndex = 19;
            btnXoaKhoiGio.Text = "Xóa Khỏi Giỏ";
            btnXoaKhoiGio.UseVisualStyleBackColor = false;
            btnXoaKhoiGio.Click += btnXoaKhoiGio_Click;
            // 
            // dgvGioHang
            // 
            dgvGioHang.Anchor = AnchorStyles.None;
            dgvGioHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Blue;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle5.SelectionForeColor = Color.Blue;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvGioHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvGioHang.ColumnHeadersHeight = 29;
            dgvGioHang.Columns.AddRange(new DataGridViewColumn[] { HangXe, LoaiXe, BienSo, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvGioHang.DefaultCellStyle = dataGridViewCellStyle6;
            dgvGioHang.EnableHeadersVisualStyles = false;
            dgvGioHang.Location = new Point(25, 452);
            dgvGioHang.Name = "dgvGioHang";
            dgvGioHang.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvGioHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvGioHang.RowHeadersVisible = false;
            dgvGioHang.RowHeadersWidth = 51;
            dataGridViewCellStyle8.ForeColor = Color.White;
            dgvGioHang.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvGioHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGioHang.Size = new Size(1138, 287);
            dgvGioHang.TabIndex = 20;
            dgvGioHang.CellFormatting += dgv_CellFormatting;
            // 
            // HangXe
            // 
            HangXe.HeaderText = "Hãng Xe";
            HangXe.MinimumWidth = 6;
            HangXe.Name = "HangXe";
            HangXe.ReadOnly = true;
            // 
            // LoaiXe
            // 
            LoaiXe.HeaderText = "Loại Xe";
            LoaiXe.MinimumWidth = 6;
            LoaiXe.Name = "LoaiXe";
            LoaiXe.ReadOnly = true;
            // 
            // BienSo
            // 
            BienSo.HeaderText = "Biển Số";
            BienSo.MinimumWidth = 6;
            BienSo.Name = "BienSo";
            BienSo.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "TenCuaHang";
            dataGridViewTextBoxColumn1.HeaderText = "Sản Phẩm";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "SoCuaHang";
            dataGridViewTextBoxColumn2.HeaderText = "Số Lượng";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "TenDuong";
            dataGridViewTextBoxColumn3.HeaderText = "Đơn Giá";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // lblTongTien
            // 
            lblTongTien.Anchor = AnchorStyles.None;
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTien.ForeColor = Color.Red;
            lblTongTien.Location = new Point(1249, 452);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(206, 41);
            lblTongTien.TabIndex = 21;
            lblTongTien.Text = "Tổng tiền: 0đ";
            // 
            // btnDatHang
            // 
            btnDatHang.Anchor = AnchorStyles.None;
            btnDatHang.BackColor = Color.Green;
            btnDatHang.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDatHang.ForeColor = SystemColors.ControlLightLight;
            btnDatHang.Location = new Point(1249, 516);
            btnDatHang.Margin = new Padding(3, 4, 3, 4);
            btnDatHang.Name = "btnDatHang";
            btnDatHang.Size = new Size(206, 68);
            btnDatHang.TabIndex = 22;
            btnDatHang.Text = "Đặt Hàng";
            btnDatHang.UseVisualStyleBackColor = false;
            btnDatHang.Click += btnDatHang_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.None;
            btnLamMoi.BackColor = SystemColors.ControlDarkDark;
            btnLamMoi.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(1249, 592);
            btnLamMoi.Margin = new Padding(3, 4, 3, 4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(206, 68);
            btnLamMoi.TabIndex = 23;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // lblSoLuongHoaDon
            // 
            lblSoLuongHoaDon.Anchor = AnchorStyles.None;
            lblSoLuongHoaDon.AutoSize = true;
            lblSoLuongHoaDon.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            lblSoLuongHoaDon.ForeColor = Color.Blue;
            lblSoLuongHoaDon.Location = new Point(25, 416);
            lblSoLuongHoaDon.Name = "lblSoLuongHoaDon";
            lblSoLuongHoaDon.Size = new Size(216, 23);
            lblSoLuongHoaDon.TabIndex = 24;
            lblSoLuongHoaDon.Text = "Số Lượng Của Hóa Đơn: 0";
            // 
            // lblSoLuongCuaHang
            // 
            lblSoLuongCuaHang.Anchor = AnchorStyles.None;
            lblSoLuongCuaHang.AutoSize = true;
            lblSoLuongCuaHang.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            lblSoLuongCuaHang.ForeColor = Color.Blue;
            lblSoLuongCuaHang.Location = new Point(1054, 138);
            lblSoLuongCuaHang.Name = "lblSoLuongCuaHang";
            lblSoLuongCuaHang.Size = new Size(281, 23);
            lblSoLuongCuaHang.TabIndex = 25;
            lblSoLuongCuaHang.Text = "Số Lượng Cửa Hàng Hoạt Động: 0";
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.None;
            btnLoad.BackColor = Color.DarkGray;
            btnLoad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoad.ForeColor = Color.White;
            btnLoad.Location = new Point(897, 369);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(137, 53);
            btnLoad.TabIndex = 26;
            btnLoad.Text = "LOAD";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // frmDangKyBaoDuongXe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1663, 751);
            Controls.Add(btnLoad);
            Controls.Add(lblSoLuongCuaHang);
            Controls.Add(lblSoLuongHoaDon);
            Controls.Add(btnLamMoi);
            Controls.Add(btnDatHang);
            Controls.Add(lblTongTien);
            Controls.Add(dgvGioHang);
            Controls.Add(btnXoaKhoiGio);
            Controls.Add(btnThem);
            Controls.Add(nudSoLuong);
            Controls.Add(label8);
            Controls.Add(cboSanPham);
            Controls.Add(label7);
            Controls.Add(dgvCuaHang);
            Controls.Add(cboPhuong);
            Controls.Add(cboTinhTP);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cboBienSo);
            Controls.Add(label3);
            Controls.Add(cboLoaiXe);
            Controls.Add(label2);
            Controls.Add(cboHangXe);
            Controls.Add(lblHangXe);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmDangKyBaoDuongXe";
            Text = "frmDangKyBaoDuongXe";
            FormClosing += frmDangKyBaoDuongXe_FormClosing;
            Load += frmDangKyBaoDuongXe_Load;
            Shown += frmDangKyBaoDuongXe_Shown;
            ((System.ComponentModel.ISupportInitialize)dgvCuaHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblHangXe;
        private ComboBox cboHangXe;
        private Label label2;
        private ComboBox cboLoaiXe;
        private Label label3;
        private ComboBox cboBienSo;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cboTinhTP;
        private ComboBox cboPhuong;
        private DataGridView dgvCuaHang;
        private DataGridViewTextBoxColumn TenCuaHang;
        private DataGridViewTextBoxColumn SoCuaHang;
        private DataGridViewTextBoxColumn TenDuong;
        private Label label7;
        private ComboBox cboSanPham;
        private Label label8;
        private NumericUpDown nudSoLuong;
        private Button btnThem;
        private Button btnXoaKhoiGio;
        private DataGridView dgvGioHang;
        private DataGridViewTextBoxColumn HangXe;
        private DataGridViewTextBoxColumn LoaiXe;
        private DataGridViewTextBoxColumn BienSo;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Label lblTongTien;
        private Button btnDatHang;
        private Button btnLamMoi;
        private Label lblSoLuongHoaDon;
        private Label lblSoLuongCuaHang;
        private Button btnLoad;
    }
}
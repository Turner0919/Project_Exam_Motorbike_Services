namespace MotorbikeServices.GUI.Setup.CuaHang
{
    partial class FormDanhSachBaoDuong
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            label1 = new Label();
            dgvDanhSachDangKy = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            NgayTao = new DataGridViewTextBoxColumn();
            NgayDat = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            dgvChiTietDangKy = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            TenXe = new DataGridViewTextBoxColumn();
            BienSo = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            btnDuyetDon = new Button();
            btnHuyDon = new Button();
            btnLamMoi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachDangKy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietDangKy).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.OliveDrab;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(856, 88);
            label1.TabIndex = 6;
            label1.Text = "DANH SÁCH BẢO DƯỠNG";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvDanhSachDangKy
            // 
            dgvDanhSachDangKy.Anchor = AnchorStyles.None;
            dgvDanhSachDangKy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Blue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = Color.Blue;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDanhSachDangKy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDanhSachDangKy.ColumnHeadersHeight = 29;
            dgvDanhSachDangKy.Columns.AddRange(new DataGridViewColumn[] { Id, HoTen, SoDienThoai, NgayTao, NgayDat, TongTien, TrangThai });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDanhSachDangKy.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDanhSachDangKy.EnableHeadersVisualStyles = false;
            dgvDanhSachDangKy.Location = new Point(12, 124);
            dgvDanhSachDangKy.Name = "dgvDanhSachDangKy";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvDanhSachDangKy.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvDanhSachDangKy.RowHeadersVisible = false;
            dgvDanhSachDangKy.RowHeadersWidth = 51;
            dataGridViewCellStyle5.ForeColor = Color.White;
            dgvDanhSachDangKy.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvDanhSachDangKy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachDangKy.Size = new Size(832, 228);
            dgvDanhSachDangKy.TabIndex = 22;
            dgvDanhSachDangKy.CellClick += dgvDanhSachDangKy_CellClick;
            dgvDanhSachDangKy.CellFormatting += dgvSanPham_CellFormatting;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Mã Hóa Đơn";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Tên Khách Hàng";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            // 
            // SoDienThoai
            // 
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.HeaderText = "Số Điện Thoại";
            SoDienThoai.MinimumWidth = 6;
            SoDienThoai.Name = "SoDienThoai";
            // 
            // NgayTao
            // 
            NgayTao.DataPropertyName = "Email";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy HH:mm";
            NgayTao.DefaultCellStyle = dataGridViewCellStyle2;
            NgayTao.HeaderText = "Email KH";
            NgayTao.MinimumWidth = 6;
            NgayTao.Name = "NgayTao";
            // 
            // NgayDat
            // 
            NgayDat.DataPropertyName = "NgayDat";
            NgayDat.HeaderText = "Ngày Đặt";
            NgayDat.MinimumWidth = 6;
            NgayDat.Name = "NgayDat";
            // 
            // TongTien
            // 
            TongTien.HeaderText = "Tổng Tiền";
            TongTien.MinimumWidth = 6;
            TongTien.Name = "TongTien";
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.HeaderText = "Trạng Thái";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            // 
            // dgvChiTietDangKy
            // 
            dgvChiTietDangKy.Anchor = AnchorStyles.None;
            dgvChiTietDangKy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Blue;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle6.SelectionForeColor = Color.Blue;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvChiTietDangKy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvChiTietDangKy.ColumnHeadersHeight = 29;
            dgvChiTietDangKy.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, TenXe, BienSo, TenSanPham, SoLuong, DonGia });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvChiTietDangKy.DefaultCellStyle = dataGridViewCellStyle8;
            dgvChiTietDangKy.EnableHeadersVisualStyles = false;
            dgvChiTietDangKy.Location = new Point(12, 449);
            dgvChiTietDangKy.Name = "dgvChiTietDangKy";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvChiTietDangKy.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvChiTietDangKy.RowHeadersVisible = false;
            dgvChiTietDangKy.RowHeadersWidth = 51;
            dataGridViewCellStyle10.ForeColor = Color.White;
            dgvChiTietDangKy.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvChiTietDangKy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietDangKy.Size = new Size(832, 219);
            dgvChiTietDangKy.TabIndex = 23;
            dgvChiTietDangKy.CellFormatting += dgvSanPham_CellFormatting;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "STT";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // TenXe
            // 
            TenXe.DataPropertyName = "TenXe";
            TenXe.HeaderText = "Thông Tin Xe";
            TenXe.MinimumWidth = 6;
            TenXe.Name = "TenXe";
            // 
            // BienSo
            // 
            BienSo.DataPropertyName = "BienSo";
            BienSo.HeaderText = "Biển Số Xe";
            BienSo.MinimumWidth = 6;
            BienSo.Name = "BienSo";
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            dataGridViewCellStyle7.Format = "dd/MM/yyyy HH:mm";
            TenSanPham.DefaultCellStyle = dataGridViewCellStyle7;
            TenSanPham.HeaderText = "Sản Phẩm/Dịch Vụ";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số Lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn Giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(171, 23);
            label2.TabIndex = 24;
            label2.Text = "Danh Sách Đăng Ký:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(12, 423);
            label3.Name = "label3";
            label3.Size = new Size(238, 23);
            label3.TabIndex = 25;
            label3.Text = "Danh Sách Chi Tiết Đăng Ký:";
            // 
            // btnDuyetDon
            // 
            btnDuyetDon.Anchor = AnchorStyles.None;
            btnDuyetDon.BackColor = Color.Yellow;
            btnDuyetDon.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDuyetDon.ForeColor = Color.Black;
            btnDuyetDon.Location = new Point(340, 368);
            btnDuyetDon.Name = "btnDuyetDon";
            btnDuyetDon.Size = new Size(164, 54);
            btnDuyetDon.TabIndex = 26;
            btnDuyetDon.Text = "DUYỆT ĐƠN";
            btnDuyetDon.UseVisualStyleBackColor = false;
            btnDuyetDon.Click += btnDuyetDon_Click;
            // 
            // btnHuyDon
            // 
            btnHuyDon.Anchor = AnchorStyles.None;
            btnHuyDon.BackColor = Color.Red;
            btnHuyDon.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnHuyDon.ForeColor = Color.Gainsboro;
            btnHuyDon.Location = new Point(510, 368);
            btnHuyDon.Name = "btnHuyDon";
            btnHuyDon.Size = new Size(164, 54);
            btnHuyDon.TabIndex = 27;
            btnHuyDon.Text = "HỦY ĐƠN";
            btnHuyDon.UseVisualStyleBackColor = false;
            btnHuyDon.Click += btnHuyDon_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.None;
            btnLamMoi.BackColor = Color.Gray;
            btnLamMoi.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLamMoi.ForeColor = Color.WhiteSmoke;
            btnLamMoi.Location = new Point(680, 368);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(164, 54);
            btnLamMoi.TabIndex = 28;
            btnLamMoi.Text = "LÀM MỚI";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // FormDanhSachBaoDuong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 680);
            Controls.Add(btnLamMoi);
            Controls.Add(btnHuyDon);
            Controls.Add(btnDuyetDon);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvChiTietDangKy);
            Controls.Add(dgvDanhSachDangKy);
            Controls.Add(label1);
            Name = "FormDanhSachBaoDuong";
            Text = "FormDanhSachBaoDuong";
            Load += FormDanhSachBaoDuong_Load;
            Shown += FormDanhSachBaoDuong_Shown;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachDangKy).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietDangKy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvDanhSachDangKy;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn NgayTao;
        private DataGridViewTextBoxColumn NgayDat;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewTextBoxColumn TrangThai;
        private DataGridView dgvChiTietDangKy;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn TenXe;
        private DataGridViewTextBoxColumn BienSo;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private Label label2;
        private Label label3;
        private Button btnDuyetDon;
        private Button btnHuyDon;
        private Button btnLamMoi;
    }
}
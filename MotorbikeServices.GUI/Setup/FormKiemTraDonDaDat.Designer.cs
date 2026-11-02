namespace MotorbikeServices.GUI.Setup
{
    partial class FormKiemTraDonDaDat
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
            dgvHoaDon = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            TenCuaHang = new DataGridViewTextBoxColumn();
            DiaChiCuaHang = new DataGridViewTextBoxColumn();
            NgayTao = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            label2 = new Label();
            dgvChiTiet = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            BienSo = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            label3 = new Label();
            btnHuyDon = new Button();
            btnLamMoi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
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
            label1.Size = new Size(1663, 104);
            label1.TabIndex = 2;
            label1.Text = "Kiểm Tra Đơn Đã Đặt";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.Anchor = AnchorStyles.None;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Blue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = Color.Blue;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHoaDon.ColumnHeadersHeight = 29;
            dgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { Id, TenCuaHang, DiaChiCuaHang, NgayTao, TongTien, TrangThai });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle3;
            dgvHoaDon.EnableHeadersVisualStyles = false;
            dgvHoaDon.Location = new Point(41, 130);
            dgvHoaDon.Name = "dgvHoaDon";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvHoaDon.RowHeadersVisible = false;
            dgvHoaDon.RowHeadersWidth = 51;
            dataGridViewCellStyle5.ForeColor = Color.White;
            dgvHoaDon.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.Size = new Size(1585, 219);
            dgvHoaDon.TabIndex = 21;
            dgvHoaDon.CellClick += dgvHoaDon_CellClick;
            dgvHoaDon.CellFormatting += dgv_CellFormatting;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Mã Hóa Đơn";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            // 
            // TenCuaHang
            // 
            TenCuaHang.DataPropertyName = "TenCuaHang";
            TenCuaHang.HeaderText = "Cửa Hàng";
            TenCuaHang.MinimumWidth = 6;
            TenCuaHang.Name = "TenCuaHang";
            // 
            // DiaChiCuaHang
            // 
            DiaChiCuaHang.DataPropertyName = "DiaChiCuaHang";
            DiaChiCuaHang.HeaderText = "Địa Chỉ Cửa Hàng";
            DiaChiCuaHang.MinimumWidth = 6;
            DiaChiCuaHang.Name = "DiaChiCuaHang";
            // 
            // NgayTao
            // 
            NgayTao.DataPropertyName = "NgayTao";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy HH:mm";
            NgayTao.DefaultCellStyle = dataGridViewCellStyle2;
            NgayTao.HeaderText = "Ngày Đặt";
            NgayTao.MinimumWidth = 6;
            NgayTao.Name = "NgayTao";
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "TongTien";
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
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(41, 104);
            label2.Name = "label2";
            label2.Size = new Size(166, 23);
            label2.TabIndex = 22;
            label2.Text = "Danh Sách Dịch Vụ:";
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.Anchor = AnchorStyles.None;
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Blue;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle6.SelectionForeColor = Color.Blue;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvChiTiet.ColumnHeadersHeight = 29;
            dgvChiTiet.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, BienSo, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, DonGia });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvChiTiet.DefaultCellStyle = dataGridViewCellStyle8;
            dgvChiTiet.EnableHeadersVisualStyles = false;
            dgvChiTiet.Location = new Point(41, 452);
            dgvChiTiet.Name = "dgvChiTiet";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvChiTiet.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvChiTiet.RowHeadersVisible = false;
            dgvChiTiet.RowHeadersWidth = 51;
            dataGridViewCellStyle10.ForeColor = Color.White;
            dgvChiTiet.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTiet.Size = new Size(1585, 287);
            dgvChiTiet.TabIndex = 23;
            dgvChiTiet.CellFormatting += dgv_CellFormatting;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "STT";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "TenXe";
            dataGridViewTextBoxColumn2.HeaderText = "Tên Xe";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // BienSo
            // 
            BienSo.DataPropertyName = "BienSo";
            BienSo.HeaderText = "Biển Số";
            BienSo.MinimumWidth = 6;
            BienSo.Name = "BienSo";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "TenSanPham";
            dataGridViewCellStyle7.Format = "dd/MM/yyyy HH:mm";
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewTextBoxColumn4.HeaderText = "Dịch Vụ/Sản Phẩm";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "TongTien";
            dataGridViewTextBoxColumn5.HeaderText = "Số Lượng";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn Giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(41, 426);
            label3.Name = "label3";
            label3.Size = new Size(233, 23);
            label3.TabIndex = 24;
            label3.Text = "Danh Sách Chi Tiết Dịch Vụ:";
            // 
            // btnHuyDon
            // 
            btnHuyDon.Anchor = AnchorStyles.None;
            btnHuyDon.BackColor = Color.Red;
            btnHuyDon.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnHuyDon.ForeColor = Color.White;
            btnHuyDon.Location = new Point(1314, 373);
            btnHuyDon.Name = "btnHuyDon";
            btnHuyDon.Size = new Size(158, 52);
            btnHuyDon.TabIndex = 25;
            btnHuyDon.Text = "HỦY ĐƠN";
            btnHuyDon.UseVisualStyleBackColor = false;
            btnHuyDon.Click += btnHuyDon_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.None;
            btnLamMoi.BackColor = Color.Navy;
            btnLamMoi.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(1478, 373);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(148, 52);
            btnLamMoi.TabIndex = 26;
            btnLamMoi.Text = "LÀM MỚI";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // FormKiemTraDonDaDat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1663, 751);
            Controls.Add(btnLamMoi);
            Controls.Add(btnHuyDon);
            Controls.Add(label3);
            Controls.Add(dgvChiTiet);
            Controls.Add(label2);
            Controls.Add(dgvHoaDon);
            Controls.Add(label1);
            Name = "FormKiemTraDonDaDat";
            Text = "FormKiemTraDonDaDat";
            Load += FormKiemTraDonDaDat_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvHoaDon;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn TenCuaHang;
        private DataGridViewTextBoxColumn DiaChiCuaHang;
        private DataGridViewTextBoxColumn NgayTao;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewTextBoxColumn TrangThai;
        private Label label2;
        private DataGridView dgvChiTiet;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn BienSo;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn DonGia;
        private Label label3;
        private Button btnHuyDon;
        private Button btnLamMoi;
    }
}
namespace MotorbikeServices.GUI.Setup.AllUser
{
    partial class FormQuanLyBaoDuong
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
            label1 = new Label();
            txtBienSoXe = new TextBox();
            txtHangXe = new TextBox();
            btnLamMoi = new Button();
            txtTenQuyChuanDangChon = new TextBox();
            label6 = new Label();
            btnCapNhat = new Button();
            dtpCapNhatNgayBaoDuong = new DateTimePicker();
            label7 = new Label();
            txtLoaiXe = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cboSttDanhSachXe = new ComboBox();
            lblHangXe = new Label();
            dgvLichBaoDuong = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            TenQuyChuan = new DataGridViewTextBoxColumn();
            SoThangDinhKy = new DataGridViewTextBoxColumn();
            NgayBaoDuongGanNhat = new DataGridViewTextBoxColumn();
            NgayBaoDuongTiepTheo = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            lblThongBaoTrangThai = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLichBaoDuong).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DarkOrchid;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1663, 125);
            label1.TabIndex = 3;
            label1.Text = "Quản Lý Bảo Dưỡng";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBienSoXe
            // 
            txtBienSoXe.Anchor = AnchorStyles.None;
            txtBienSoXe.Location = new Point(202, 325);
            txtBienSoXe.Margin = new Padding(3, 4, 3, 4);
            txtBienSoXe.Name = "txtBienSoXe";
            txtBienSoXe.Size = new Size(268, 27);
            txtBienSoXe.TabIndex = 55;
            // 
            // txtHangXe
            // 
            txtHangXe.Anchor = AnchorStyles.None;
            txtHangXe.Location = new Point(202, 240);
            txtHangXe.Margin = new Padding(3, 4, 3, 4);
            txtHangXe.Name = "txtHangXe";
            txtHangXe.Size = new Size(268, 27);
            txtHangXe.TabIndex = 54;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.None;
            btnLamMoi.BackColor = Color.FromArgb(192, 255, 255);
            btnLamMoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.Location = new Point(1128, 296);
            btnLamMoi.Margin = new Padding(3, 4, 3, 4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(159, 55);
            btnLamMoi.TabIndex = 53;
            btnLamMoi.Text = "LÀM MỚI";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // txtTenQuyChuanDangChon
            // 
            txtTenQuyChuanDangChon.Anchor = AnchorStyles.None;
            txtTenQuyChuanDangChon.Location = new Point(1025, 183);
            txtTenQuyChuanDangChon.Margin = new Padding(3, 4, 3, 4);
            txtTenQuyChuanDangChon.Name = "txtTenQuyChuanDangChon";
            txtTenQuyChuanDangChon.Size = new Size(337, 27);
            txtTenQuyChuanDangChon.TabIndex = 52;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(775, 183);
            label6.Name = "label6";
            label6.Size = new Size(228, 23);
            label6.TabIndex = 51;
            label6.Text = "Tên Quy Chuẩn Đang Chọn:";
            // 
            // btnCapNhat
            // 
            btnCapNhat.Anchor = AnchorStyles.None;
            btnCapNhat.BackColor = Color.FromArgb(0, 192, 0);
            btnCapNhat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhat.Location = new Point(962, 296);
            btnCapNhat.Margin = new Padding(3, 4, 3, 4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(159, 55);
            btnCapNhat.TabIndex = 50;
            btnCapNhat.Text = "CẬP NHẬT";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // dtpCapNhatNgayBaoDuong
            // 
            dtpCapNhatNgayBaoDuong.Anchor = AnchorStyles.None;
            dtpCapNhatNgayBaoDuong.Location = new Point(1025, 232);
            dtpCapNhatNgayBaoDuong.Margin = new Padding(3, 4, 3, 4);
            dtpCapNhatNgayBaoDuong.Name = "dtpCapNhatNgayBaoDuong";
            dtpCapNhatNgayBaoDuong.Size = new Size(337, 27);
            dtpCapNhatNgayBaoDuong.TabIndex = 49;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.Location = new Point(775, 236);
            label7.Name = "label7";
            label7.Size = new Size(233, 23);
            label7.TabIndex = 48;
            label7.Text = "Cập Nhật Ngày Bảo Dưỡng:";
            // 
            // txtLoaiXe
            // 
            txtLoaiXe.Anchor = AnchorStyles.None;
            txtLoaiXe.Location = new Point(202, 283);
            txtLoaiXe.Margin = new Padding(3, 4, 3, 4);
            txtLoaiXe.Name = "txtLoaiXe";
            txtLoaiXe.Size = new Size(268, 27);
            txtLoaiXe.TabIndex = 47;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(46, 283);
            label5.Name = "label5";
            label5.Size = new Size(73, 23);
            label5.TabIndex = 46;
            label5.Text = "Loại Xe:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(46, 241);
            label4.Name = "label4";
            label4.Size = new Size(83, 23);
            label4.TabIndex = 45;
            label4.Text = "Hãng Xe:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(46, 325);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 44;
            label3.Text = "Biển Số Xe:";
            // 
            // cboSttDanhSachXe
            // 
            cboSttDanhSachXe.Anchor = AnchorStyles.None;
            cboSttDanhSachXe.FormattingEnabled = true;
            cboSttDanhSachXe.Location = new Point(202, 188);
            cboSttDanhSachXe.Name = "cboSttDanhSachXe";
            cboSttDanhSachXe.Size = new Size(172, 28);
            cboSttDanhSachXe.TabIndex = 43;
            cboSttDanhSachXe.SelectedIndexChanged += cboSttDanhSachXe_SelectedIndexChanged;
            // 
            // lblHangXe
            // 
            lblHangXe.Anchor = AnchorStyles.None;
            lblHangXe.AutoSize = true;
            lblHangXe.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblHangXe.Location = new Point(46, 189);
            lblHangXe.Name = "lblHangXe";
            lblHangXe.Size = new Size(159, 23);
            lblHangXe.TabIndex = 42;
            lblHangXe.Text = "STT Danh Sách Xe:";
            // 
            // dgvLichBaoDuong
            // 
            dgvLichBaoDuong.Anchor = AnchorStyles.None;
            dgvLichBaoDuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Blue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = Color.Blue;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLichBaoDuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLichBaoDuong.ColumnHeadersHeight = 29;
            dgvLichBaoDuong.Columns.AddRange(new DataGridViewColumn[] { STT, TenQuyChuan, SoThangDinhKy, NgayBaoDuongGanNhat, NgayBaoDuongTiepTheo, TrangThai });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLichBaoDuong.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLichBaoDuong.EnableHeadersVisualStyles = false;
            dgvLichBaoDuong.Location = new Point(46, 455);
            dgvLichBaoDuong.Name = "dgvLichBaoDuong";
            dgvLichBaoDuong.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvLichBaoDuong.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvLichBaoDuong.RowHeadersVisible = false;
            dgvLichBaoDuong.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = Color.White;
            dgvLichBaoDuong.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvLichBaoDuong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLichBaoDuong.Size = new Size(1506, 353);
            dgvLichBaoDuong.TabIndex = 41;
            dgvLichBaoDuong.CellClick += dgvLichBaoDuong_CellClick;
            dgvLichBaoDuong.CellFormatting += dgvLichBaoDuong_CellFormatting;
            // 
            // STT
            // 
            STT.DataPropertyName = "STT";
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.ReadOnly = true;
            // 
            // TenQuyChuan
            // 
            TenQuyChuan.DataPropertyName = "TenQuyChuan";
            TenQuyChuan.HeaderText = "Tên Quy Chuẩn";
            TenQuyChuan.MinimumWidth = 6;
            TenQuyChuan.Name = "TenQuyChuan";
            TenQuyChuan.ReadOnly = true;
            // 
            // SoThangDinhKy
            // 
            SoThangDinhKy.DataPropertyName = "SoThangDinhKy";
            SoThangDinhKy.HeaderText = "Định Kỳ Bảo Dưỡng";
            SoThangDinhKy.MinimumWidth = 6;
            SoThangDinhKy.Name = "SoThangDinhKy";
            SoThangDinhKy.ReadOnly = true;
            // 
            // NgayBaoDuongGanNhat
            // 
            NgayBaoDuongGanNhat.DataPropertyName = "NgayBaoDuongGanNhat";
            NgayBaoDuongGanNhat.HeaderText = "Ngày Bảo Dưỡng Lần Cuối";
            NgayBaoDuongGanNhat.MinimumWidth = 6;
            NgayBaoDuongGanNhat.Name = "NgayBaoDuongGanNhat";
            NgayBaoDuongGanNhat.ReadOnly = true;
            // 
            // NgayBaoDuongTiepTheo
            // 
            NgayBaoDuongTiepTheo.DataPropertyName = "NgayBaoDuongTiepTheo";
            NgayBaoDuongTiepTheo.HeaderText = "Ngày Bảo Dưỡng Tiếp Theo";
            NgayBaoDuongTiepTheo.MinimumWidth = 6;
            NgayBaoDuongTiepTheo.Name = "NgayBaoDuongTiepTheo";
            NgayBaoDuongTiepTheo.ReadOnly = true;
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.HeaderText = "Tình Trạng";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            TrangThai.ReadOnly = true;
            // 
            // lblThongBaoTrangThai
            // 
            lblThongBaoTrangThai.Anchor = AnchorStyles.None;
            lblThongBaoTrangThai.AutoSize = true;
            lblThongBaoTrangThai.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblThongBaoTrangThai.Location = new Point(46, 412);
            lblThongBaoTrangThai.Name = "lblThongBaoTrangThai";
            lblThongBaoTrangThai.Size = new Size(207, 25);
            lblThongBaoTrangThai.TabIndex = 40;
            lblThongBaoTrangThai.Text = "lblThongBaoTrangThai";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 147);
            label2.Name = "label2";
            label2.Size = new Size(222, 23);
            label2.TabIndex = 39;
            label2.Text = "Chọn chiếc xe cần kiểm tra:";
            // 
            // FormQuanLyBaoDuong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1663, 872);
            Controls.Add(txtBienSoXe);
            Controls.Add(txtHangXe);
            Controls.Add(btnLamMoi);
            Controls.Add(txtTenQuyChuanDangChon);
            Controls.Add(label6);
            Controls.Add(btnCapNhat);
            Controls.Add(dtpCapNhatNgayBaoDuong);
            Controls.Add(label7);
            Controls.Add(txtLoaiXe);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cboSttDanhSachXe);
            Controls.Add(lblHangXe);
            Controls.Add(dgvLichBaoDuong);
            Controls.Add(lblThongBaoTrangThai);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormQuanLyBaoDuong";
            Text = "FormQuanLyBaoDuong";
            Load += FormQuanLyBaoDuong_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLichBaoDuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBienSoXe;
        private TextBox txtHangXe;
        private Button btnLamMoi;
        private TextBox txtTenQuyChuanDangChon;
        private Label label6;
        private Button btnCapNhat;
        private DateTimePicker dtpCapNhatNgayBaoDuong;
        private Label label7;
        private TextBox txtLoaiXe;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cboSttDanhSachXe;
        private Label lblHangXe;
        private DataGridView dgvLichBaoDuong;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn TenQuyChuan;
        private DataGridViewTextBoxColumn SoThangDinhKy;
        private DataGridViewTextBoxColumn NgayBaoDuongGanNhat;
        private DataGridViewTextBoxColumn NgayBaoDuongTiepTheo;
        private DataGridViewTextBoxColumn TrangThai;
        private Label lblThongBaoTrangThai;
        private Label label2;
    }
}
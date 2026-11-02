namespace MotorbikeServices.GUI.Setup
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            btnDatLichBaoDuong = new Button();
            lblThongBaoTrangThai = new Label();
            dgvLichBaoDuong = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            TenQuyChuan = new DataGridViewTextBoxColumn();
            SoThangDinhKy = new DataGridViewTextBoxColumn();
            NgayBaoDuongGanNhat = new DataGridViewTextBoxColumn();
            NgayBaoDuongTiepTheo = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            cboBienSo = new ComboBox();
            label3 = new Label();
            cboLoaiXe = new ComboBox();
            label4 = new Label();
            cboDanhSachXe = new ComboBox();
            lblHangXe = new Label();
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
            label1.TabIndex = 2;
            label1.Text = "Quản Lý Bảo Dưỡng";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 147);
            label2.Name = "label2";
            label2.Size = new Size(188, 20);
            label2.TabIndex = 3;
            label2.Text = "Chọn chiếc xe cần kiểm tra:";
            // 
            // btnDatLichBaoDuong
            // 
            btnDatLichBaoDuong.Location = new Point(794, 199);
            btnDatLichBaoDuong.Name = "btnDatLichBaoDuong";
            btnDatLichBaoDuong.Size = new Size(387, 29);
            btnDatLichBaoDuong.TabIndex = 5;
            btnDatLichBaoDuong.Text = "ĐẶT LỊCH BẢO DƯỠNG NGAY";
            btnDatLichBaoDuong.UseVisualStyleBackColor = true;
            btnDatLichBaoDuong.Click += btnDatLichBaoDuong_Click;
            // 
            // lblThongBaoTrangThai
            // 
            lblThongBaoTrangThai.AutoSize = true;
            lblThongBaoTrangThai.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblThongBaoTrangThai.Location = new Point(547, 236);
            lblThongBaoTrangThai.Name = "lblThongBaoTrangThai";
            lblThongBaoTrangThai.Size = new Size(207, 25);
            lblThongBaoTrangThai.TabIndex = 6;
            lblThongBaoTrangThai.Text = "lblThongBaoTrangThai";
            // 
            // dgvLichBaoDuong
            // 
            dgvLichBaoDuong.Anchor = AnchorStyles.None;
            dgvLichBaoDuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Blue;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle5.SelectionForeColor = Color.Blue;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvLichBaoDuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvLichBaoDuong.ColumnHeadersHeight = 29;
            dgvLichBaoDuong.Columns.AddRange(new DataGridViewColumn[] { STT, TenQuyChuan, SoThangDinhKy, NgayBaoDuongGanNhat, NgayBaoDuongTiepTheo, TrangThai });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvLichBaoDuong.DefaultCellStyle = dataGridViewCellStyle6;
            dgvLichBaoDuong.EnableHeadersVisualStyles = false;
            dgvLichBaoDuong.Location = new Point(41, 360);
            dgvLichBaoDuong.Name = "dgvLichBaoDuong";
            dgvLichBaoDuong.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvLichBaoDuong.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvLichBaoDuong.RowHeadersVisible = false;
            dgvLichBaoDuong.RowHeadersWidth = 51;
            dataGridViewCellStyle8.ForeColor = Color.White;
            dgvLichBaoDuong.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvLichBaoDuong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLichBaoDuong.Size = new Size(1371, 287);
            dgvLichBaoDuong.TabIndex = 21;
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
            // cboBienSo
            // 
            cboBienSo.Anchor = AnchorStyles.None;
            cboBienSo.FormattingEnabled = true;
            cboBienSo.Location = new Point(173, 297);
            cboBienSo.Name = "cboBienSo";
            cboBienSo.Size = new Size(301, 28);
            cboBienSo.TabIndex = 27;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(84, 297);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 26;
            label3.Text = "Biển Số:";
            // 
            // cboLoaiXe
            // 
            cboLoaiXe.Anchor = AnchorStyles.None;
            cboLoaiXe.FormattingEnabled = true;
            cboLoaiXe.Location = new Point(173, 236);
            cboLoaiXe.Name = "cboLoaiXe";
            cboLoaiXe.Size = new Size(301, 28);
            cboLoaiXe.TabIndex = 25;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(84, 236);
            label4.Name = "label4";
            label4.Size = new Size(73, 23);
            label4.TabIndex = 24;
            label4.Text = "Loại Xe:";
            // 
            // cboDanhSachXe
            // 
            cboDanhSachXe.Anchor = AnchorStyles.None;
            cboDanhSachXe.FormattingEnabled = true;
            cboDanhSachXe.Location = new Point(173, 177);
            cboDanhSachXe.Name = "cboDanhSachXe";
            cboDanhSachXe.Size = new Size(301, 28);
            cboDanhSachXe.TabIndex = 23;
            // 
            // lblHangXe
            // 
            lblHangXe.Anchor = AnchorStyles.None;
            lblHangXe.AutoSize = true;
            lblHangXe.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblHangXe.Location = new Point(84, 178);
            lblHangXe.Name = "lblHangXe";
            lblHangXe.Size = new Size(83, 23);
            lblHangXe.TabIndex = 22;
            lblHangXe.Text = "Hãng Xe:";
            // 
            // FormQuanLyBaoDuong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1663, 751);
            Controls.Add(cboBienSo);
            Controls.Add(label3);
            Controls.Add(cboLoaiXe);
            Controls.Add(label4);
            Controls.Add(cboDanhSachXe);
            Controls.Add(lblHangXe);
            Controls.Add(dgvLichBaoDuong);
            Controls.Add(lblThongBaoTrangThai);
            Controls.Add(btnDatLichBaoDuong);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormQuanLyBaoDuong";
            Text = "FormQuanLyBaoDuong";
            Load += FormQuanLyBaoDuong_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLichBaoDuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnDatLichBaoDuong;
        private Label lblThongBaoTrangThai;
        private DataGridView dgvLichBaoDuong;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn TenQuyChuan;
        private DataGridViewTextBoxColumn SoThangDinhKy;
        private DataGridViewTextBoxColumn NgayBaoDuongGanNhat;
        private DataGridViewTextBoxColumn NgayBaoDuongTiepTheo;
        private DataGridViewTextBoxColumn TrangThai;
        private ComboBox cboBienSo;
        private Label label3;
        private ComboBox cboLoaiXe;
        private Label label4;
        private ComboBox cboDanhSachXe;
        private Label lblHangXe;
    }
}
namespace MotorbikeServices.GUI.Setup.CuaHang
{
    partial class FormQuanLySanPham
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
            lblTongSoSanPham = new Label();
            dgvDanhSachSanPham = new DataGridView();
            MaSP = new DataGridViewTextBoxColumn();
            TenSP = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            SLTon = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtSoLuongTon = new TextBox();
            txtDonGia = new TextBox();
            txtTenSanPham = new TextBox();
            txtMaSP = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSanPham).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Goldenrod;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(749, 66);
            label1.TabIndex = 5;
            label1.Text = "QUAN LY SAN PHAM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTongSoSanPham
            // 
            lblTongSoSanPham.AutoSize = true;
            lblTongSoSanPham.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTongSoSanPham.ForeColor = Color.FromArgb(0, 0, 192);
            lblTongSoSanPham.Location = new Point(256, 80);
            lblTongSoSanPham.Name = "lblTongSoSanPham";
            lblTongSoSanPham.Size = new Size(118, 15);
            lblTongSoSanPham.TabIndex = 8;
            lblTongSoSanPham.Text = "Tổng số sản phẩm: 0";
            // 
            // dgvDanhSachSanPham
            // 
            dgvDanhSachSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Blue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = Color.Blue;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDanhSachSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDanhSachSanPham.ColumnHeadersHeight = 29;
            dgvDanhSachSanPham.Columns.AddRange(new DataGridViewColumn[] { MaSP, TenSP, DonGia, SLTon });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDanhSachSanPham.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDanhSachSanPham.EnableHeadersVisualStyles = false;
            dgvDanhSachSanPham.Location = new Point(256, 97);
            dgvDanhSachSanPham.Margin = new Padding(3, 2, 3, 2);
            dgvDanhSachSanPham.Name = "dgvDanhSachSanPham";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDanhSachSanPham.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDanhSachSanPham.RowHeadersVisible = false;
            dgvDanhSachSanPham.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = Color.White;
            dgvDanhSachSanPham.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvDanhSachSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachSanPham.Size = new Size(480, 377);
            dgvDanhSachSanPham.TabIndex = 7;
            dgvDanhSachSanPham.CellClick += dgvDanhSachSanPham_CellClick;
            dgvDanhSachSanPham.CellFormatting += dgvSanPham_CellFormatting;
            // 
            // MaSP
            // 
            MaSP.HeaderText = "Mã SP";
            MaSP.MinimumWidth = 6;
            MaSP.Name = "MaSP";
            // 
            // TenSP
            // 
            TenSP.HeaderText = "Tên Sản Phẩm";
            TenSP.MinimumWidth = 6;
            TenSP.Name = "TenSP";
            // 
            // DonGia
            // 
            DonGia.HeaderText = "Đơn Giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            // 
            // SLTon
            // 
            SLTon.HeaderText = "SL Tồn";
            SLTon.MinimumWidth = 6;
            SLTon.Name = "SLTon";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSoLuongTon);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(txtMaSP);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(12, 80);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(226, 394);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Sản Phẩm";
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = SystemColors.ControlDark;
            btnLamMoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(109, 308);
            btnLamMoi.Margin = new Padding(3, 2, 3, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(89, 46);
            btnLamMoi.TabIndex = 10;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(14, 308);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(89, 46);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.RoyalBlue;
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(109, 259);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(89, 46);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(0, 192, 0);
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(14, 258);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(89, 46);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label5.Location = new Point(14, 192);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 7;
            label5.Text = "Số lượng tồn:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.Location = new Point(14, 136);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Đơn giá:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.Location = new Point(14, 85);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 5;
            label3.Text = "Tên sản phẩm:";
            // 
            // txtSoLuongTon
            // 
            txtSoLuongTon.Location = new Point(14, 210);
            txtSoLuongTon.Margin = new Padding(3, 2, 3, 2);
            txtSoLuongTon.Name = "txtSoLuongTon";
            txtSoLuongTon.Size = new Size(197, 23);
            txtSoLuongTon.TabIndex = 4;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(14, 154);
            txtDonGia.Margin = new Padding(3, 2, 3, 2);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(197, 23);
            txtDonGia.TabIndex = 3;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(14, 103);
            txtTenSanPham.Margin = new Padding(3, 2, 3, 2);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(197, 23);
            txtTenSanPham.TabIndex = 2;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(14, 54);
            txtMaSP.Margin = new Padding(3, 2, 3, 2);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(120, 23);
            txtMaSP.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(14, 36);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã SP:";
            // 
            // FormQuanLySanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 510);
            Controls.Add(lblTongSoSanPham);
            Controls.Add(dgvDanhSachSanPham);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FormQuanLySanPham";
            Text = "FormQuanLySanPham";
            Load += FormQuanLySanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSanPham).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTongSoSanPham;
        private DataGridView dgvDanhSachSanPham;
        private DataGridViewTextBoxColumn MaSP;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn SLTon;
        private GroupBox groupBox1;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtSoLuongTon;
        private TextBox txtDonGia;
        private TextBox txtTenSanPham;
        private TextBox txtMaSP;
        private Label label2;
    }
}
namespace MotorbikeServices.GUI.Setup
{
    partial class formDangKyXe
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            dtpNgayMuaXe = new DateTimePicker();
            lblTongSoXe = new Label();
            cboDongXe = new ComboBox();
            label4 = new Label();
            dgvDanhSachXe = new DataGridView();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label2 = new Label();
            cboHangXe = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            txtBienSoXe = new TextBox();
            STT = new DataGridViewTextBoxColumn();
            TenHangXe = new DataGridViewTextBoxColumn();
            TenDongXe = new DataGridViewTextBoxColumn();
            BienSoXe = new DataGridViewTextBoxColumn();
            NgayMuaXe = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachXe).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1663, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(136, 14, 79);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1663, 125);
            label1.TabIndex = 0;
            label1.Text = "Đăng ký xe mới/ Cập nhật xe cũ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.FromArgb(255, 255, 128);
            panel2.Controls.Add(dtpNgayMuaXe);
            panel2.Controls.Add(lblTongSoXe);
            panel2.Controls.Add(cboDongXe);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dgvDanhSachXe);
            panel2.Controls.Add(btnLamMoi);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cboHangXe);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtBienSoXe);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(1663, 626);
            panel2.TabIndex = 1;
            // 
            // dtpNgayMuaXe
            // 
            dtpNgayMuaXe.Location = new Point(190, 284);
            dtpNgayMuaXe.Name = "dtpNgayMuaXe";
            dtpNgayMuaXe.Size = new Size(242, 27);
            dtpNgayMuaXe.TabIndex = 28;
            // 
            // lblTongSoXe
            // 
            lblTongSoXe.AutoSize = true;
            lblTongSoXe.BackColor = Color.White;
            lblTongSoXe.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            lblTongSoXe.ForeColor = Color.Red;
            lblTongSoXe.Location = new Point(479, 26);
            lblTongSoXe.Name = "lblTongSoXe";
            lblTongSoXe.Size = new Size(215, 31);
            lblTongSoXe.TabIndex = 27;
            lblTongSoXe.Text = "Tổng số Chiếc Xe: 0";
            // 
            // cboDongXe
            // 
            cboDongXe.FormattingEnabled = true;
            cboDongXe.Location = new Point(190, 160);
            cboDongXe.Name = "cboDongXe";
            cboDongXe.Size = new Size(242, 28);
            cboDongXe.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(60, 154);
            label4.Name = "label4";
            label4.Size = new Size(112, 31);
            label4.TabIndex = 25;
            label4.Text = "Dòng Xe:";
            // 
            // dgvDanhSachXe
            // 
            dgvDanhSachXe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Blue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDanhSachXe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDanhSachXe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachXe.Columns.AddRange(new DataGridViewColumn[] { STT, TenHangXe, TenDongXe, BienSoXe, NgayMuaXe });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvDanhSachXe.DefaultCellStyle = dataGridViewCellStyle7;
            dgvDanhSachXe.EnableHeadersVisualStyles = false;
            dgvDanhSachXe.Location = new Point(479, 60);
            dgvDanhSachXe.Name = "dgvDanhSachXe";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.Blue;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvDanhSachXe.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvDanhSachXe.RowHeadersVisible = false;
            dgvDanhSachXe.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dgvDanhSachXe.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvDanhSachXe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachXe.Size = new Size(1172, 516);
            dgvDanhSachXe.TabIndex = 24;
            dgvDanhSachXe.CellClick += dgvDanhSachXe_CellClick;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = SystemColors.ActiveBorder;
            btnLamMoi.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(224, 464);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(179, 70);
            btnLamMoi.TabIndex = 23;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(39, 464);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(179, 70);
            btnXoa.TabIndex = 22;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(192, 64, 0);
            btnSua.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(224, 388);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(179, 70);
            btnSua.TabIndex = 21;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Lime;
            btnThem.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(39, 388);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(179, 70);
            btnThem.TabIndex = 20;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(12, 280);
            label2.Name = "label2";
            label2.Size = new Size(160, 31);
            label2.TabIndex = 19;
            label2.Text = "Ngày mua xe:";
            // 
            // cboHangXe
            // 
            cboHangXe.FormattingEnabled = true;
            cboHangXe.Location = new Point(190, 91);
            cboHangXe.Name = "cboHangXe";
            cboHangXe.Size = new Size(242, 28);
            cboHangXe.TabIndex = 17;
            cboHangXe.SelectedIndexChanged += cboHangXe_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(60, 88);
            label5.Name = "label5";
            label5.Size = new Size(111, 31);
            label5.TabIndex = 16;
            label5.Text = "Hãng Xe:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(38, 220);
            label3.Name = "label3";
            label3.Size = new Size(134, 31);
            label3.TabIndex = 13;
            label3.Text = "Biển Số Xe:";
            // 
            // txtBienSoXe
            // 
            txtBienSoXe.Location = new Point(190, 220);
            txtBienSoXe.Name = "txtBienSoXe";
            txtBienSoXe.Size = new Size(242, 27);
            txtBienSoXe.TabIndex = 12;
            // 
            // STT
            // 
            dataGridViewCellStyle2.ForeColor = Color.Black;
            STT.DefaultCellStyle = dataGridViewCellStyle2;
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            // 
            // TenHangXe
            // 
            dataGridViewCellStyle3.ForeColor = Color.Black;
            TenHangXe.DefaultCellStyle = dataGridViewCellStyle3;
            TenHangXe.HeaderText = "Hãng Xe";
            TenHangXe.MinimumWidth = 6;
            TenHangXe.Name = "TenHangXe";
            // 
            // TenDongXe
            // 
            dataGridViewCellStyle4.ForeColor = Color.Black;
            TenDongXe.DefaultCellStyle = dataGridViewCellStyle4;
            TenDongXe.HeaderText = "Dòng Xe";
            TenDongXe.MinimumWidth = 6;
            TenDongXe.Name = "TenDongXe";
            // 
            // BienSoXe
            // 
            dataGridViewCellStyle5.ForeColor = Color.Black;
            BienSoXe.DefaultCellStyle = dataGridViewCellStyle5;
            BienSoXe.HeaderText = "Biển Số Xe";
            BienSoXe.MinimumWidth = 6;
            BienSoXe.Name = "BienSoXe";
            // 
            // NgayMuaXe
            // 
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.Format = "dd/MM/yyyy";
            NgayMuaXe.DefaultCellStyle = dataGridViewCellStyle6;
            NgayMuaXe.HeaderText = "Ngày Mua Xe";
            NgayMuaXe.MinimumWidth = 6;
            NgayMuaXe.Name = "NgayMuaXe";
            // 
            // formDangKyXe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1663, 751);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "formDangKyXe";
            Text = "formDangKyXe";
            Load += formDangKyXe_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachXe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private ComboBox cboHangXe;
        private Label label5;
        private Label label3;
        private TextBox txtBienSoXe;
        private TextBox txtChuXe;
        private Label label7;
        private Button btnThem;
        private Button btnSua;
        private Button btnLamMoi;
        private Button btnXoa;
        private DataGridView dgvDanhSachXe;
        private ComboBox cboDongXe;
        private Label label4;
        private Label lblTongSoXe;
        private DateTimePicker dtpNgayMuaXe;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn TenHangXe;
        private DataGridViewTextBoxColumn TenDongXe;
        private DataGridViewTextBoxColumn BienSoXe;
        private DataGridViewTextBoxColumn NgayMuaXe;
    }
}
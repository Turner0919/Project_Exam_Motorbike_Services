namespace MotorbikeServices.GUI.AdminControls
{
    partial class UcAccount
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cboVaiTro;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThemAdmin;
        private System.Windows.Forms.Button btnThemUser;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblTongTaiKhoan;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.GroupBox grpChiTiet;
        private System.Windows.Forms.Label lblTenTaiKhoanTitle;
        private System.Windows.Forms.Label lblChiTietTenTaiKhoan;
        private System.Windows.Forms.Label lblVaiTroTitle;
        private System.Windows.Forms.Label lblChiTietVaiTro;
        private System.Windows.Forms.Label lblHoTenTitle;
        private System.Windows.Forms.Label lblChiTietHoTen;
        private System.Windows.Forms.Label lblSoDienThoaiTitle;
        private System.Windows.Forms.Label lblChiTietSoDienThoai;
        private System.Windows.Forms.Label lblEmailTitle;
        private System.Windows.Forms.Label lblChiTietEmail;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            lblMoTa = new Label();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            cboVaiTro = new ComboBox();
            btnLamMoi = new Button();
            btnThemAdmin = new Button();
            btnThemUser = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            lblTongTaiKhoan = new Label();
            dgvTaiKhoan = new DataGridView();
            grpChiTiet = new GroupBox();
            lblTenTaiKhoanTitle = new Label();
            lblChiTietTenTaiKhoan = new Label();
            lblVaiTroTitle = new Label();
            lblChiTietVaiTro = new Label();
            lblHoTenTitle = new Label();
            lblChiTietHoTen = new Label();
            lblSoDienThoaiTitle = new Label();
            lblChiTietSoDienThoai = new Label();
            lblEmailTitle = new Label();
            lblChiTietEmail = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            grpChiTiet.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(25, 45, 80);
            lblTieuDe.Location = new Point(25, 20);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(363, 46);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Font = new Font("Segoe UI", 10F);
            lblMoTa.ForeColor = Color.Gray;
            lblMoTa.Location = new Point(28, 65);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(437, 23);
            lblMoTa.TabIndex = 1;
            lblMoTa.Text = "Quản lý CRUD tài khoản User; tài khoản Admin chỉ xem.";
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTimKiem.Location = new Point(28, 112);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(91, 23);
            lblTimKiem.TabIndex = 2;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 10F);
            txtTimKiem.Location = new Point(110, 108);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên tài khoản...";
            txtTimKiem.Size = new Size(260, 30);
            txtTimKiem.TabIndex = 3;
            // 
            // cboVaiTro
            // 
            cboVaiTro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVaiTro.Font = new Font("Segoe UI", 10F);
            cboVaiTro.Location = new Point(385, 108);
            cboVaiTro.Name = "cboVaiTro";
            cboVaiTro.Size = new Size(125, 31);
            cboVaiTro.TabIndex = 4;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(525, 106);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(90, 32);
            btnLamMoi.TabIndex = 5;
            btnLamMoi.Text = "Làm mới";
            // 
            // btnThemAdmin
            // 
            btnThemAdmin.Location = new Point(0, 0);
            btnThemAdmin.Name = "btnThemAdmin";
            btnThemAdmin.Size = new Size(75, 23);
            btnThemAdmin.TabIndex = 0;
            btnThemAdmin.Visible = false;
            // 
            // btnThemUser
            // 
            btnThemUser.BackColor = Color.FromArgb(55, 126, 184);
            btnThemUser.FlatAppearance.BorderSize = 0;
            btnThemUser.FlatStyle = FlatStyle.Flat;
            btnThemUser.ForeColor = Color.White;
            btnThemUser.Location = new Point(28, 150);
            btnThemUser.Name = "btnThemUser";
            btnThemUser.Size = new Size(120, 34);
            btnThemUser.TabIndex = 6;
            btnThemUser.Text = "+ Thêm User";
            btnThemUser.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.Enabled = false;
            btnSua.Location = new Point(158, 150);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 34);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(190, 60, 60);
            btnXoa.Enabled = false;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(258, 150);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 34);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // lblTongTaiKhoan
            // 
            lblTongTaiKhoan.AutoSize = true;
            lblTongTaiKhoan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTongTaiKhoan.Location = new Point(28, 195);
            lblTongTaiKhoan.Name = "lblTongTaiKhoan";
            lblTongTaiKhoan.Size = new Size(151, 20);
            lblTongTaiKhoan.TabIndex = 9;
            lblTongTaiKhoan.Text = "Tổng số tài khoản: 0";
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.AllowUserToAddRows = false;
            dgvTaiKhoan.AllowUserToDeleteRows = false;
            dgvTaiKhoan.AllowUserToResizeRows = false;
            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaiKhoan.BackgroundColor = Color.White;
            dgvTaiKhoan.BorderStyle = BorderStyle.None;
            dgvTaiKhoan.ColumnHeadersHeight = 29;
            dgvTaiKhoan.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dgvTaiKhoan.Location = new Point(28, 220);
            dgvTaiKhoan.MultiSelect = false;
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.ReadOnly = true;
            dgvTaiKhoan.RowHeadersVisible = false;
            dgvTaiKhoan.RowHeadersWidth = 51;
            dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaiKhoan.Size = new Size(920, 235);
            dgvTaiKhoan.TabIndex = 10;
            // 
            // grpChiTiet
            // 
            grpChiTiet.Controls.Add(lblTenTaiKhoanTitle);
            grpChiTiet.Controls.Add(lblChiTietTenTaiKhoan);
            grpChiTiet.Controls.Add(lblVaiTroTitle);
            grpChiTiet.Controls.Add(lblChiTietVaiTro);
            grpChiTiet.Controls.Add(lblHoTenTitle);
            grpChiTiet.Controls.Add(lblChiTietHoTen);
            grpChiTiet.Controls.Add(lblSoDienThoaiTitle);
            grpChiTiet.Controls.Add(lblChiTietSoDienThoai);
            grpChiTiet.Controls.Add(lblEmailTitle);
            grpChiTiet.Controls.Add(lblChiTietEmail);
            grpChiTiet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpChiTiet.Location = new Point(28, 470);
            grpChiTiet.Name = "grpChiTiet";
            grpChiTiet.Size = new Size(920, 150);
            grpChiTiet.TabIndex = 11;
            grpChiTiet.TabStop = false;
            grpChiTiet.Text = "Thông tin tài khoản";
            // 
            // lblTenTaiKhoanTitle
            // 
            lblTenTaiKhoanTitle.AutoSize = true;
            lblTenTaiKhoanTitle.Location = new Point(20, 30);
            lblTenTaiKhoanTitle.Name = "lblTenTaiKhoanTitle";
            lblTenTaiKhoanTitle.Size = new Size(122, 23);
            lblTenTaiKhoanTitle.TabIndex = 0;
            lblTenTaiKhoanTitle.Text = "Tên tài khoản:";
            // 
            // lblChiTietTenTaiKhoan
            // 
            lblChiTietTenTaiKhoan.AutoSize = true;
            lblChiTietTenTaiKhoan.Location = new Point(150, 30);
            lblChiTietTenTaiKhoan.Name = "lblChiTietTenTaiKhoan";
            lblChiTietTenTaiKhoan.Size = new Size(94, 23);
            lblChiTietTenTaiKhoan.TabIndex = 1;
            lblChiTietTenTaiKhoan.Text = "Chưa chọn";
            // 
            // lblVaiTroTitle
            // 
            lblVaiTroTitle.AutoSize = true;
            lblVaiTroTitle.Location = new Point(500, 30);
            lblVaiTroTitle.Name = "lblVaiTroTitle";
            lblVaiTroTitle.Size = new Size(68, 23);
            lblVaiTroTitle.TabIndex = 2;
            lblVaiTroTitle.Text = "Vai trò:";
            // 
            // lblChiTietVaiTro
            // 
            lblChiTietVaiTro.AutoSize = true;
            lblChiTietVaiTro.Location = new Point(590, 30);
            lblChiTietVaiTro.Name = "lblChiTietVaiTro";
            lblChiTietVaiTro.Size = new Size(94, 23);
            lblChiTietVaiTro.TabIndex = 3;
            lblChiTietVaiTro.Text = "Chưa chọn";
            // 
            // lblHoTenTitle
            // 
            lblHoTenTitle.AutoSize = true;
            lblHoTenTitle.Location = new Point(20, 65);
            lblHoTenTitle.Name = "lblHoTenTitle";
            lblHoTenTitle.Size = new Size(69, 23);
            lblHoTenTitle.TabIndex = 4;
            lblHoTenTitle.Text = "Họ tên:";
            // 
            // lblChiTietHoTen
            // 
            lblChiTietHoTen.AutoSize = true;
            lblChiTietHoTen.Location = new Point(150, 65);
            lblChiTietHoTen.Name = "lblChiTietHoTen";
            lblChiTietHoTen.Size = new Size(27, 23);
            lblChiTietHoTen.TabIndex = 5;
            lblChiTietHoTen.Text = "—";
            // 
            // lblSoDienThoaiTitle
            // 
            lblSoDienThoaiTitle.AutoSize = true;
            lblSoDienThoaiTitle.Location = new Point(500, 65);
            lblSoDienThoaiTitle.Name = "lblSoDienThoaiTitle";
            lblSoDienThoaiTitle.Size = new Size(121, 23);
            lblSoDienThoaiTitle.TabIndex = 6;
            lblSoDienThoaiTitle.Text = "Số điện thoại:";
            // 
            // lblChiTietSoDienThoai
            // 
            lblChiTietSoDienThoai.AutoSize = true;
            lblChiTietSoDienThoai.Location = new Point(620, 65);
            lblChiTietSoDienThoai.Name = "lblChiTietSoDienThoai";
            lblChiTietSoDienThoai.Size = new Size(27, 23);
            lblChiTietSoDienThoai.TabIndex = 7;
            lblChiTietSoDienThoai.Text = "—";
            // 
            // lblEmailTitle
            // 
            lblEmailTitle.AutoSize = true;
            lblEmailTitle.Location = new Point(20, 100);
            lblEmailTitle.Name = "lblEmailTitle";
            lblEmailTitle.Size = new Size(59, 23);
            lblEmailTitle.TabIndex = 8;
            lblEmailTitle.Text = "Email:";
            // 
            // lblChiTietEmail
            // 
            lblChiTietEmail.AutoSize = true;
            lblChiTietEmail.Location = new Point(150, 100);
            lblChiTietEmail.Name = "lblChiTietEmail";
            lblChiTietEmail.Size = new Size(27, 23);
            lblChiTietEmail.TabIndex = 9;
            lblChiTietEmail.Text = "—";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Tên tài khoản";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Vai trò";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Họ tên";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Số điện thoại";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Email";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // UcAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(lblTieuDe);
            Controls.Add(lblMoTa);
            Controls.Add(lblTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(cboVaiTro);
            Controls.Add(btnLamMoi);
            Controls.Add(btnThemUser);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(lblTongTaiKhoan);
            Controls.Add(dgvTaiKhoan);
            Controls.Add(grpChiTiet);
            Name = "UcAccount";
            Size = new Size(1401, 604);
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            grpChiTiet.ResumeLayout(false);
            grpChiTiet.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

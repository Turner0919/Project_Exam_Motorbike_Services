using System.Drawing;
using System.Windows.Forms;

namespace MotorbikeServices.GUI.AdminControls
{
    partial class UcAccount
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTieuDe;
        private Label lblMoTa;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private ComboBox cboVaiTro;
        private Button btnLamMoi;
        private Button btnThemAdmin;
        private Button btnThemUser;
        private Button btnSua;
        private Button btnXoa;

        // Bốn thẻ thống kê
        private Panel pnlCardTong;
        private Panel pnlCardAdmin;
        private Panel pnlCardUser;
        private Panel pnlCardNhanVien;

        private Label lblCardTongTitle;
        private Label lblCardTongValue;
        private Label lblCardTongHint;

        private Label lblCardAdminTitle;
        private Label lblCardAdminValue;
        private Label lblCardAdminHint;

        private Label lblCardUserTitle;
        private Label lblCardUserValue;
        private Label lblCardUserHint;

        private Label lblCardNhanVienTitle;
        private Label lblCardNhanVienValue;
        private Label lblCardNhanVienHint;

        // Các khu vực bố cục
        private TableLayoutPanel tlpRoot;
        private TableLayoutPanel tlpCards;
        private TableLayoutPanel tlpFilter;
        private TableLayoutPanel tlpContent;
        private TableLayoutPanel tlpDanhSach;
        private TableLayoutPanel tlpChiTiet;

        private Panel pnlHeader;
        private Panel pnlDanhSach;

        // Danh sách tài khoản
        private Label lblDanhSachTitle;
        private Label lblTongTaiKhoan;
        private DataGridView dgvTaiKhoan;

        // Chi tiết tài khoản
        private GroupBox grpChiTiet;
        private Label lblTenTaiKhoanTitle;
        private Label lblChiTietTenTaiKhoan;
        private Label lblVaiTroTitle;
        private Label lblChiTietVaiTro;
        private Label lblHoTenTitle;
        private Label lblChiTietHoTen;
        private Label lblSoDienThoaiTitle;
        private Label lblChiTietSoDienThoai;
        private Label lblEmailTitle;
        private Label lblChiTietEmail;
        private Label lblChiTietGhiChu;

        private FlowLayoutPanel flpChiTietButtons;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tlpRoot = new TableLayoutPanel();
            pnlHeader = new Panel();
            lblTieuDe = new Label();
            lblMoTa = new Label();
            tlpCards = new TableLayoutPanel();
            pnlCardTong = new Panel();
            lblCardTongTitle = new Label();
            lblCardTongValue = new Label();
            lblCardTongHint = new Label();
            pnlCardAdmin = new Panel();
            lblCardAdminTitle = new Label();
            lblCardAdminValue = new Label();
            lblCardAdminHint = new Label();
            pnlCardUser = new Panel();
            lblCardUserTitle = new Label();
            lblCardUserValue = new Label();
            lblCardUserHint = new Label();
            pnlCardNhanVien = new Panel();
            lblCardNhanVienTitle = new Label();
            lblCardNhanVienValue = new Label();
            lblCardNhanVienHint = new Label();
            tlpFilter = new TableLayoutPanel();
            cboVaiTro = new ComboBox();
            btnLamMoi = new Button();
            txtTimKiem = new TextBox();
            lblTimKiem = new Label();
            tlpContent = new TableLayoutPanel();
            pnlDanhSach = new Panel();
            tlpDanhSach = new TableLayoutPanel();
            lblDanhSachTitle = new Label();
            lblTongTaiKhoan = new Label();
            dgvTaiKhoan = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            grpChiTiet = new GroupBox();
            tlpChiTiet = new TableLayoutPanel();
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
            lblChiTietGhiChu = new Label();
            flpChiTietButtons = new FlowLayoutPanel();
            btnXoa = new Button();
            btnSua = new Button();
            btnThemAdmin = new Button();
            btnThemUser = new Button();
            tlpRoot.SuspendLayout();
            pnlHeader.SuspendLayout();
            tlpCards.SuspendLayout();
            pnlCardTong.SuspendLayout();
            pnlCardAdmin.SuspendLayout();
            pnlCardUser.SuspendLayout();
            pnlCardNhanVien.SuspendLayout();
            tlpFilter.SuspendLayout();
            tlpContent.SuspendLayout();
            pnlDanhSach.SuspendLayout();
            tlpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            grpChiTiet.SuspendLayout();
            tlpChiTiet.SuspendLayout();
            flpChiTietButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tlpRoot
            // 
            tlpRoot.BackColor = Color.FromArgb(245, 248, 252);
            tlpRoot.ColumnCount = 1;
            tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRoot.Controls.Add(pnlHeader, 0, 0);
            tlpRoot.Controls.Add(tlpCards, 0, 1);
            tlpRoot.Controls.Add(tlpFilter, 0, 2);
            tlpRoot.Controls.Add(tlpContent, 0, 3);
            tlpRoot.Dock = DockStyle.Fill;
            tlpRoot.Location = new Point(0, 0);
            tlpRoot.Margin = new Padding(0);
            tlpRoot.Name = "tlpRoot";
            tlpRoot.Padding = new Padding(22, 16, 22, 18);
            tlpRoot.RowCount = 4;
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 112F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRoot.Size = new Size(1330, 692);
            tlpRoot.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(245, 248, 252);
            pnlHeader.Controls.Add(lblTieuDe);
            pnlHeader.Controls.Add(lblMoTa);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(22, 16);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1286, 76);
            pnlHeader.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe.ForeColor = Color.FromArgb(25, 54, 87);
            lblTieuDe.Location = new Point(2, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(301, 46);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Quản lý tài khoản";
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Font = new Font("Segoe UI", 9.5F);
            lblMoTa.ForeColor = Color.FromArgb(105, 121, 140);
            lblMoTa.Location = new Point(5, 47);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(324, 21);
            lblMoTa.TabIndex = 1;
            lblMoTa.Text = "Theo dõi và quản lý tài khoản trong hệ thống.";
            // 
            // tlpCards
            // 
            tlpCards.BackColor = Color.FromArgb(245, 248, 252);
            tlpCards.ColumnCount = 4;
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.Controls.Add(pnlCardTong, 0, 0);
            tlpCards.Controls.Add(pnlCardAdmin, 1, 0);
            tlpCards.Controls.Add(pnlCardUser, 2, 0);
            tlpCards.Controls.Add(pnlCardNhanVien, 3, 0);
            tlpCards.Dock = DockStyle.Fill;
            tlpCards.Location = new Point(22, 92);
            tlpCards.Margin = new Padding(0);
            tlpCards.Name = "tlpCards";
            tlpCards.RowCount = 1;
            tlpCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCards.Size = new Size(1286, 112);
            tlpCards.TabIndex = 1;
            // 
            // pnlCardTong
            // 
            pnlCardTong.BackColor = Color.FromArgb(231, 240, 252);
            pnlCardTong.Controls.Add(lblCardTongTitle);
            pnlCardTong.Controls.Add(lblCardTongValue);
            pnlCardTong.Controls.Add(lblCardTongHint);
            pnlCardTong.Dock = DockStyle.Fill;
            pnlCardTong.Location = new Point(0, 4);
            pnlCardTong.Margin = new Padding(0, 4, 8, 4);
            pnlCardTong.Name = "pnlCardTong";
            pnlCardTong.Size = new Size(313, 104);
            pnlCardTong.TabIndex = 0;
            // 
            // lblCardTongTitle
            // 
            lblCardTongTitle.AutoSize = true;
            lblCardTongTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCardTongTitle.ForeColor = Color.FromArgb(49, 87, 125);
            lblCardTongTitle.Location = new Point(15, 10);
            lblCardTongTitle.Name = "lblCardTongTitle";
            lblCardTongTitle.Size = new Size(139, 20);
            lblCardTongTitle.TabIndex = 0;
            lblCardTongTitle.Text = "TỔNG TÀI KHOẢN";
            // 
            // lblCardTongValue
            // 
            lblCardTongValue.AutoSize = true;
            lblCardTongValue.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            lblCardTongValue.ForeColor = Color.FromArgb(25, 54, 87);
            lblCardTongValue.Location = new Point(14, 29);
            lblCardTongValue.Name = "lblCardTongValue";
            lblCardTongValue.Size = new Size(43, 50);
            lblCardTongValue.TabIndex = 1;
            lblCardTongValue.Text = "0";
            // 
            // lblCardTongHint
            // 
            lblCardTongHint.AutoSize = true;
            lblCardTongHint.Font = new Font("Segoe UI", 8.5F);
            lblCardTongHint.ForeColor = Color.FromArgb(105, 121, 140);
            lblCardTongHint.Location = new Point(17, 76);
            lblCardTongHint.Name = "lblCardTongHint";
            lblCardTongHint.Size = new Size(95, 20);
            lblCardTongHint.TabIndex = 2;
            lblCardTongHint.Text = "Tất cả vai trò";
            // 
            // pnlCardAdmin
            // 
            pnlCardAdmin.BackColor = Color.FromArgb(241, 235, 252);
            pnlCardAdmin.Controls.Add(lblCardAdminTitle);
            pnlCardAdmin.Controls.Add(lblCardAdminValue);
            pnlCardAdmin.Controls.Add(lblCardAdminHint);
            pnlCardAdmin.Dock = DockStyle.Fill;
            pnlCardAdmin.Location = new Point(325, 4);
            pnlCardAdmin.Margin = new Padding(4);
            pnlCardAdmin.Name = "pnlCardAdmin";
            pnlCardAdmin.Size = new Size(313, 104);
            pnlCardAdmin.TabIndex = 1;
            // 
            // lblCardAdminTitle
            // 
            lblCardAdminTitle.AutoSize = true;
            lblCardAdminTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCardAdminTitle.ForeColor = Color.FromArgb(106, 75, 157);
            lblCardAdminTitle.Location = new Point(15, 10);
            lblCardAdminTitle.Name = "lblCardAdminTitle";
            lblCardAdminTitle.Size = new Size(62, 20);
            lblCardAdminTitle.TabIndex = 0;
            lblCardAdminTitle.Text = "ADMIN";
            // 
            // lblCardAdminValue
            // 
            lblCardAdminValue.AutoSize = true;
            lblCardAdminValue.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            lblCardAdminValue.ForeColor = Color.FromArgb(96, 66, 148);
            lblCardAdminValue.Location = new Point(14, 29);
            lblCardAdminValue.Name = "lblCardAdminValue";
            lblCardAdminValue.Size = new Size(43, 50);
            lblCardAdminValue.TabIndex = 1;
            lblCardAdminValue.Text = "0";
            // 
            // lblCardAdminHint
            // 
            lblCardAdminHint.AutoSize = true;
            lblCardAdminHint.Font = new Font("Segoe UI", 8.5F);
            lblCardAdminHint.ForeColor = Color.FromArgb(105, 121, 140);
            lblCardAdminHint.Location = new Point(17, 76);
            lblCardAdminHint.Name = "lblCardAdminHint";
            lblCardAdminHint.Size = new Size(126, 20);
            lblCardAdminHint.TabIndex = 2;
            lblCardAdminHint.Text = "Tài khoản quản trị";
            // 
            // pnlCardUser
            // 
            pnlCardUser.BackColor = Color.FromArgb(230, 245, 237);
            pnlCardUser.Controls.Add(lblCardUserTitle);
            pnlCardUser.Controls.Add(lblCardUserValue);
            pnlCardUser.Controls.Add(lblCardUserHint);
            pnlCardUser.Dock = DockStyle.Fill;
            pnlCardUser.Location = new Point(646, 4);
            pnlCardUser.Margin = new Padding(4);
            pnlCardUser.Name = "pnlCardUser";
            pnlCardUser.Size = new Size(313, 104);
            pnlCardUser.TabIndex = 2;
            // 
            // lblCardUserTitle
            // 
            lblCardUserTitle.AutoSize = true;
            lblCardUserTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCardUserTitle.ForeColor = Color.FromArgb(43, 117, 76);
            lblCardUserTitle.Location = new Point(15, 10);
            lblCardUserTitle.Name = "lblCardUserTitle";
            lblCardUserTitle.Size = new Size(46, 20);
            lblCardUserTitle.TabIndex = 0;
            lblCardUserTitle.Text = "USER";
            // 
            // lblCardUserValue
            // 
            lblCardUserValue.AutoSize = true;
            lblCardUserValue.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            lblCardUserValue.ForeColor = Color.FromArgb(35, 112, 70);
            lblCardUserValue.Location = new Point(14, 29);
            lblCardUserValue.Name = "lblCardUserValue";
            lblCardUserValue.Size = new Size(43, 50);
            lblCardUserValue.TabIndex = 1;
            lblCardUserValue.Text = "0";
            // 
            // lblCardUserHint
            // 
            lblCardUserHint.AutoSize = true;
            lblCardUserHint.Font = new Font("Segoe UI", 8.5F);
            lblCardUserHint.ForeColor = Color.FromArgb(105, 121, 140);
            lblCardUserHint.Location = new Point(17, 76);
            lblCardUserHint.Name = "lblCardUserHint";
            lblCardUserHint.Size = new Size(150, 20);
            lblCardUserHint.TabIndex = 2;
            lblCardUserHint.Text = "Tài khoản khách hàng";
            // 
            // pnlCardNhanVien
            // 
            pnlCardNhanVien.BackColor = Color.FromArgb(255, 243, 224);
            pnlCardNhanVien.Controls.Add(lblCardNhanVienTitle);
            pnlCardNhanVien.Controls.Add(lblCardNhanVienValue);
            pnlCardNhanVien.Controls.Add(lblCardNhanVienHint);
            pnlCardNhanVien.Dock = DockStyle.Fill;
            pnlCardNhanVien.Location = new Point(971, 4);
            pnlCardNhanVien.Margin = new Padding(8, 4, 0, 4);
            pnlCardNhanVien.Name = "pnlCardNhanVien";
            pnlCardNhanVien.Size = new Size(315, 104);
            pnlCardNhanVien.TabIndex = 3;
            // 
            // lblCardNhanVienTitle
            // 
            lblCardNhanVienTitle.AutoSize = true;
            lblCardNhanVienTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCardNhanVienTitle.ForeColor = Color.FromArgb(155, 93, 30);
            lblCardNhanVienTitle.Location = new Point(15, 10);
            lblCardNhanVienTitle.Name = "lblCardNhanVienTitle";
            lblCardNhanVienTitle.Size = new Size(94, 20);
            lblCardNhanVienTitle.TabIndex = 0;
            lblCardNhanVienTitle.Text = "NHÂN VIÊN";
            // 
            // lblCardNhanVienValue
            // 
            lblCardNhanVienValue.AutoSize = true;
            lblCardNhanVienValue.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            lblCardNhanVienValue.ForeColor = Color.FromArgb(153, 91, 28);
            lblCardNhanVienValue.Location = new Point(14, 29);
            lblCardNhanVienValue.Name = "lblCardNhanVienValue";
            lblCardNhanVienValue.Size = new Size(43, 50);
            lblCardNhanVienValue.TabIndex = 1;
            lblCardNhanVienValue.Text = "0";
            // 
            // lblCardNhanVienHint
            // 
            lblCardNhanVienHint.AutoSize = true;
            lblCardNhanVienHint.Font = new Font("Segoe UI", 8.5F);
            lblCardNhanVienHint.ForeColor = Color.FromArgb(105, 121, 140);
            lblCardNhanVienHint.Location = new Point(17, 76);
            lblCardNhanVienHint.Name = "lblCardNhanVienHint";
            lblCardNhanVienHint.Size = new Size(138, 20);
            lblCardNhanVienHint.TabIndex = 2;
            lblCardNhanVienHint.Text = "Tài khoản nhân viên";
            // 
            // tlpFilter
            // 
            tlpFilter.ColumnCount = 4;
            tlpFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tlpFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            tlpFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            tlpFilter.Controls.Add(cboVaiTro, 2, 0);
            tlpFilter.Controls.Add(btnLamMoi, 3, 0);
            tlpFilter.Controls.Add(txtTimKiem, 1, 0);
            tlpFilter.Controls.Add(lblTimKiem, 0, 0);
            tlpFilter.Dock = DockStyle.Fill;
            tlpFilter.Location = new Point(22, 204);
            tlpFilter.Margin = new Padding(0);
            tlpFilter.Name = "tlpFilter";
            tlpFilter.Padding = new Padding(0, 7, 0, 5);
            tlpFilter.RowCount = 1;
            tlpFilter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFilter.Size = new Size(1286, 62);
            tlpFilter.TabIndex = 2;
            // 
            // cboVaiTro
            // 
            cboVaiTro.Dock = DockStyle.Fill;
            cboVaiTro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVaiTro.Font = new Font("Segoe UI", 9.5F);
            cboVaiTro.Location = new Point(1006, 9);
            cboVaiTro.Margin = new Padding(0, 2, 12, 2);
            cboVaiTro.Name = "cboVaiTro";
            cboVaiTro.Size = new Size(163, 29);
            cboVaiTro.TabIndex = 2;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(230, 237, 246);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.FromArgb(25, 54, 87);
            btnLamMoi.Location = new Point(1181, 8);
            btnLamMoi.Margin = new Padding(0, 1, 0, 1);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(105, 31);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "↻  Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Dock = DockStyle.Fill;
            txtTimKiem.Font = new Font("Segoe UI", 10F);
            txtTimKiem.Location = new Point(80, 9);
            txtTimKiem.Margin = new Padding(0, 2, 12, 2);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm tên tài khoản, họ tên, cửa hàng, điện thoại, email...";
            txtTimKiem.Size = new Size(914, 30);
            txtTimKiem.TabIndex = 1;
            // 
            // lblTimKiem
            // 
            lblTimKiem.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimKiem.ForeColor = Color.FromArgb(35, 55, 78);
            lblTimKiem.Location = new Point(3, 7);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(74, 32);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Tìm kiếm:";
            lblTimKiem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpContent
            // 
            tlpContent.ColumnCount = 2;
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67F));
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tlpContent.Controls.Add(pnlDanhSach, 0, 0);
            tlpContent.Controls.Add(grpChiTiet, 1, 0);
            tlpContent.Dock = DockStyle.Fill;
            tlpContent.Location = new Point(22, 266);
            tlpContent.Margin = new Padding(0);
            tlpContent.Name = "tlpContent";
            tlpContent.RowCount = 1;
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpContent.Size = new Size(1286, 408);
            tlpContent.TabIndex = 3;
            // 
            // pnlDanhSach
            // 
            pnlDanhSach.BackColor = Color.White;
            pnlDanhSach.BorderStyle = BorderStyle.FixedSingle;
            pnlDanhSach.Controls.Add(tlpDanhSach);
            pnlDanhSach.Dock = DockStyle.Fill;
            pnlDanhSach.Location = new Point(0, 0);
            pnlDanhSach.Margin = new Padding(0, 0, 12, 0);
            pnlDanhSach.Name = "pnlDanhSach";
            pnlDanhSach.Padding = new Padding(10);
            pnlDanhSach.Size = new Size(849, 408);
            pnlDanhSach.TabIndex = 0;
            // 
            // tlpDanhSach
            // 
            tlpDanhSach.ColumnCount = 1;
            tlpDanhSach.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDanhSach.Controls.Add(lblDanhSachTitle, 0, 0);
            tlpDanhSach.Controls.Add(lblTongTaiKhoan, 0, 1);
            tlpDanhSach.Controls.Add(dgvTaiKhoan, 0, 2);
            tlpDanhSach.Dock = DockStyle.Fill;
            tlpDanhSach.Location = new Point(10, 10);
            tlpDanhSach.Margin = new Padding(0);
            tlpDanhSach.Name = "tlpDanhSach";
            tlpDanhSach.RowCount = 3;
            tlpDanhSach.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpDanhSach.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tlpDanhSach.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDanhSach.Size = new Size(827, 386);
            tlpDanhSach.TabIndex = 0;
            // 
            // lblDanhSachTitle
            // 
            lblDanhSachTitle.Dock = DockStyle.Fill;
            lblDanhSachTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDanhSachTitle.ForeColor = Color.FromArgb(25, 54, 87);
            lblDanhSachTitle.Location = new Point(3, 0);
            lblDanhSachTitle.Name = "lblDanhSachTitle";
            lblDanhSachTitle.Size = new Size(821, 34);
            lblDanhSachTitle.TabIndex = 0;
            lblDanhSachTitle.Text = "DANH SÁCH TÀI KHOẢN";
            lblDanhSachTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTongTaiKhoan
            // 
            lblTongTaiKhoan.Dock = DockStyle.Fill;
            lblTongTaiKhoan.Font = new Font("Segoe UI", 8.5F);
            lblTongTaiKhoan.ForeColor = Color.FromArgb(105, 121, 140);
            lblTongTaiKhoan.Location = new Point(3, 34);
            lblTongTaiKhoan.Name = "lblTongTaiKhoan";
            lblTongTaiKhoan.Size = new Size(821, 27);
            lblTongTaiKhoan.TabIndex = 1;
            lblTongTaiKhoan.Text = "Đang hiển thị: 0 / 0 tài khoản";
            lblTongTaiKhoan.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.AllowUserToAddRows = false;
            dgvTaiKhoan.AllowUserToDeleteRows = false;
            dgvTaiKhoan.AllowUserToResizeRows = false;
            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaiKhoan.BackgroundColor = Color.White;
            dgvTaiKhoan.BorderStyle = BorderStyle.None;
            dgvTaiKhoan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTaiKhoan.ColumnHeadersHeight = 42;
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTaiKhoan.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7 });
            dgvTaiKhoan.Dock = DockStyle.Fill;
            dgvTaiKhoan.Location = new Point(0, 64);
            dgvTaiKhoan.Margin = new Padding(0, 3, 0, 0);
            dgvTaiKhoan.MultiSelect = false;
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.ReadOnly = true;
            dgvTaiKhoan.RowHeadersVisible = false;
            dgvTaiKhoan.RowHeadersWidth = 51;
            dgvTaiKhoan.RowTemplate.Height = 40;
            dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaiKhoan.Size = new Size(827, 322);
            dgvTaiKhoan.TabIndex = 2;
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
            dataGridViewTextBoxColumn4.HeaderText = "Họ tên / CH";
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
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Trạng thái";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // grpChiTiet
            // 
            grpChiTiet.BackColor = Color.White;
            grpChiTiet.Controls.Add(tlpChiTiet);
            grpChiTiet.Dock = DockStyle.Fill;
            grpChiTiet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpChiTiet.ForeColor = Color.FromArgb(25, 54, 87);
            grpChiTiet.Location = new Point(861, 0);
            grpChiTiet.Margin = new Padding(0);
            grpChiTiet.Name = "grpChiTiet";
            grpChiTiet.Padding = new Padding(12);
            grpChiTiet.Size = new Size(425, 408);
            grpChiTiet.TabIndex = 1;
            grpChiTiet.TabStop = false;
            grpChiTiet.Text = "CHI TIẾT TÀI KHOẢN";
            // 
            // tlpChiTiet
            // 
            tlpChiTiet.ColumnCount = 2;
            tlpChiTiet.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tlpChiTiet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpChiTiet.Controls.Add(lblTenTaiKhoanTitle, 0, 0);
            tlpChiTiet.Controls.Add(lblChiTietTenTaiKhoan, 1, 0);
            tlpChiTiet.Controls.Add(lblVaiTroTitle, 0, 1);
            tlpChiTiet.Controls.Add(lblChiTietVaiTro, 1, 1);
            tlpChiTiet.Controls.Add(lblHoTenTitle, 0, 2);
            tlpChiTiet.Controls.Add(lblChiTietHoTen, 1, 2);
            tlpChiTiet.Controls.Add(lblSoDienThoaiTitle, 0, 3);
            tlpChiTiet.Controls.Add(lblChiTietSoDienThoai, 1, 3);
            tlpChiTiet.Controls.Add(lblEmailTitle, 0, 4);
            tlpChiTiet.Controls.Add(lblChiTietEmail, 1, 4);
            tlpChiTiet.Controls.Add(lblChiTietGhiChu, 0, 5);
            tlpChiTiet.Controls.Add(flpChiTietButtons, 0, 6);
            tlpChiTiet.Dock = DockStyle.Fill;
            tlpChiTiet.Location = new Point(12, 35);
            tlpChiTiet.Margin = new Padding(5, 10, 5, 5);
            tlpChiTiet.Name = "tlpChiTiet";
            tlpChiTiet.RowCount = 7;
            tlpChiTiet.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tlpChiTiet.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tlpChiTiet.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tlpChiTiet.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tlpChiTiet.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tlpChiTiet.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpChiTiet.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpChiTiet.Size = new Size(401, 361);
            tlpChiTiet.TabIndex = 0;
            // 
            // lblTenTaiKhoanTitle
            // 
            lblTenTaiKhoanTitle.Dock = DockStyle.Fill;
            lblTenTaiKhoanTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTenTaiKhoanTitle.Location = new Point(3, 0);
            lblTenTaiKhoanTitle.Name = "lblTenTaiKhoanTitle";
            lblTenTaiKhoanTitle.Size = new Size(104, 43);
            lblTenTaiKhoanTitle.TabIndex = 0;
            lblTenTaiKhoanTitle.Text = "Tài khoản:";
            lblTenTaiKhoanTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblChiTietTenTaiKhoan
            // 
            lblChiTietTenTaiKhoan.AutoEllipsis = true;
            lblChiTietTenTaiKhoan.Dock = DockStyle.Fill;
            lblChiTietTenTaiKhoan.Location = new Point(113, 0);
            lblChiTietTenTaiKhoan.Name = "lblChiTietTenTaiKhoan";
            lblChiTietTenTaiKhoan.Size = new Size(285, 43);
            lblChiTietTenTaiKhoan.TabIndex = 1;
            lblChiTietTenTaiKhoan.Text = "Chưa chọn";
            lblChiTietTenTaiKhoan.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblVaiTroTitle
            // 
            lblVaiTroTitle.Dock = DockStyle.Fill;
            lblVaiTroTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblVaiTroTitle.Location = new Point(3, 43);
            lblVaiTroTitle.Name = "lblVaiTroTitle";
            lblVaiTroTitle.Size = new Size(104, 43);
            lblVaiTroTitle.TabIndex = 2;
            lblVaiTroTitle.Text = "Vai trò:";
            lblVaiTroTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblChiTietVaiTro
            // 
            lblChiTietVaiTro.BackColor = Color.FromArgb(231, 240, 252);
            lblChiTietVaiTro.Dock = DockStyle.Fill;
            lblChiTietVaiTro.ForeColor = Color.FromArgb(25, 54, 87);
            lblChiTietVaiTro.Location = new Point(113, 43);
            lblChiTietVaiTro.Name = "lblChiTietVaiTro";
            lblChiTietVaiTro.Padding = new Padding(7, 0, 7, 0);
            lblChiTietVaiTro.Size = new Size(285, 43);
            lblChiTietVaiTro.TabIndex = 3;
            lblChiTietVaiTro.Text = "Chưa chọn";
            lblChiTietVaiTro.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHoTenTitle
            // 
            lblHoTenTitle.Dock = DockStyle.Fill;
            lblHoTenTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHoTenTitle.Location = new Point(3, 86);
            lblHoTenTitle.Name = "lblHoTenTitle";
            lblHoTenTitle.Size = new Size(104, 43);
            lblHoTenTitle.TabIndex = 4;
            lblHoTenTitle.Text = "Họ tên / CH:";
            lblHoTenTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblChiTietHoTen
            // 
            lblChiTietHoTen.AutoEllipsis = true;
            lblChiTietHoTen.Dock = DockStyle.Fill;
            lblChiTietHoTen.Location = new Point(113, 86);
            lblChiTietHoTen.Name = "lblChiTietHoTen";
            lblChiTietHoTen.Size = new Size(285, 43);
            lblChiTietHoTen.TabIndex = 5;
            lblChiTietHoTen.Text = "—";
            lblChiTietHoTen.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSoDienThoaiTitle
            // 
            lblSoDienThoaiTitle.Dock = DockStyle.Fill;
            lblSoDienThoaiTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSoDienThoaiTitle.Location = new Point(3, 129);
            lblSoDienThoaiTitle.Name = "lblSoDienThoaiTitle";
            lblSoDienThoaiTitle.Size = new Size(104, 43);
            lblSoDienThoaiTitle.TabIndex = 6;
            lblSoDienThoaiTitle.Text = "Điện thoại:";
            lblSoDienThoaiTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblChiTietSoDienThoai
            // 
            lblChiTietSoDienThoai.AutoEllipsis = true;
            lblChiTietSoDienThoai.Dock = DockStyle.Fill;
            lblChiTietSoDienThoai.Location = new Point(113, 129);
            lblChiTietSoDienThoai.Name = "lblChiTietSoDienThoai";
            lblChiTietSoDienThoai.Size = new Size(285, 43);
            lblChiTietSoDienThoai.TabIndex = 7;
            lblChiTietSoDienThoai.Text = "—";
            lblChiTietSoDienThoai.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEmailTitle
            // 
            lblEmailTitle.Dock = DockStyle.Fill;
            lblEmailTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmailTitle.Location = new Point(3, 172);
            lblEmailTitle.Name = "lblEmailTitle";
            lblEmailTitle.Size = new Size(104, 43);
            lblEmailTitle.TabIndex = 8;
            lblEmailTitle.Text = "Email:";
            lblEmailTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblChiTietEmail
            // 
            lblChiTietEmail.AutoEllipsis = true;
            lblChiTietEmail.Dock = DockStyle.Fill;
            lblChiTietEmail.Location = new Point(113, 172);
            lblChiTietEmail.Name = "lblChiTietEmail";
            lblChiTietEmail.Size = new Size(285, 43);
            lblChiTietEmail.TabIndex = 9;
            lblChiTietEmail.Text = "—";
            lblChiTietEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblChiTietGhiChu
            // 
            tlpChiTiet.SetColumnSpan(lblChiTietGhiChu, 2);
            lblChiTietGhiChu.Dock = DockStyle.Fill;
            lblChiTietGhiChu.Font = new Font("Segoe UI", 8.5F);
            lblChiTietGhiChu.ForeColor = Color.FromArgb(105, 121, 140);
            lblChiTietGhiChu.Location = new Point(3, 215);
            lblChiTietGhiChu.Name = "lblChiTietGhiChu";
            lblChiTietGhiChu.Size = new Size(395, 98);
            lblChiTietGhiChu.TabIndex = 10;
            lblChiTietGhiChu.Text = "Chọn tài khoản để xem thông tin.";
            lblChiTietGhiChu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flpChiTietButtons
            // 
            tlpChiTiet.SetColumnSpan(flpChiTietButtons, 2);
            flpChiTietButtons.Controls.Add(btnXoa);
            flpChiTietButtons.Controls.Add(btnSua);
            flpChiTietButtons.Dock = DockStyle.Fill;
            flpChiTietButtons.FlowDirection = FlowDirection.RightToLeft;
            flpChiTietButtons.Location = new Point(3, 316);
            flpChiTietButtons.Name = "flpChiTietButtons";
            flpChiTietButtons.Padding = new Padding(0, 5, 0, 0);
            flpChiTietButtons.Size = new Size(395, 42);
            flpChiTietButtons.TabIndex = 11;
            flpChiTietButtons.WrapContents = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(205, 76, 76);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.Enabled = false;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(290, 5);
            btnXoa.Margin = new Padding(6, 0, 0, 0);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(105, 35);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa User";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(52, 127, 193);
            btnSua.Cursor = Cursors.Hand;
            btnSua.Enabled = false;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(159, 5);
            btnSua.Margin = new Padding(6, 0, 0, 0);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(125, 35);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa thông tin";
            btnSua.UseVisualStyleBackColor = false;
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
            btnThemUser.Location = new Point(0, 0);
            btnThemUser.Name = "btnThemUser";
            btnThemUser.Size = new Size(75, 23);
            btnThemUser.TabIndex = 0;
            btnThemUser.Visible = false;
            // 
            // UcAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 252);
            Controls.Add(tlpRoot);
            Name = "UcAccount";
            Size = new Size(1330, 692);
            tlpRoot.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tlpCards.ResumeLayout(false);
            pnlCardTong.ResumeLayout(false);
            pnlCardTong.PerformLayout();
            pnlCardAdmin.ResumeLayout(false);
            pnlCardAdmin.PerformLayout();
            pnlCardUser.ResumeLayout(false);
            pnlCardUser.PerformLayout();
            pnlCardNhanVien.ResumeLayout(false);
            pnlCardNhanVien.PerformLayout();
            tlpFilter.ResumeLayout(false);
            tlpFilter.PerformLayout();
            tlpContent.ResumeLayout(false);
            pnlDanhSach.ResumeLayout(false);
            tlpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            grpChiTiet.ResumeLayout(false);
            tlpChiTiet.ResumeLayout(false);
            flpChiTietButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}

using System.Drawing;
using System.Windows.Forms;

namespace MotorbikeServices.GUI.AdminControls
{
    partial class UcHangXe
    {
        private System.ComponentModel.IContainer components = null;

        private SplitContainer splitMain;

        private Panel pnlHangXe;
        private Panel pnlDongXe;

        private Panel pnlHeaderHangXe;
        private Panel pnlHeaderDongXe;

        private Panel pnlToolbar;
        private Panel pnlToolbarDongXe;

        private FlowLayoutPanel flpNutHangXe;
        private FlowLayoutPanel flpNutDongXe;

        private Label lblTitle;
        private Label lblDescription;
        private Label lblTitleDongXe;
        private Label lblDescriptionDongXe;

        private TextBox txtTimKiem;
        private TextBox txtTimKiemDongXe;

        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;

        private Button btnThemDongXe;
        private Button btnSuaDongXe;
        private Button btnXoaDongXe;
        private Button btnLamMoiDongXe;

        private DataGridView dgvHangXe;
        private DataGridView dgvDongXe;

        private DataGridViewTextBoxColumn colMaHang;
        private DataGridViewTextBoxColumn colTenHang;
        private DataGridViewTextBoxColumn colQuocGia;

        private DataGridViewTextBoxColumn colMaDongXe;
        private DataGridViewTextBoxColumn colTenDongXe;
        private DataGridViewTextBoxColumn colTenHangCuaDongXe;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            splitMain = new SplitContainer();
            pnlHangXe = new Panel();
            dgvHangXe = new DataGridView();
            colMaHang = new DataGridViewTextBoxColumn();
            colTenHang = new DataGridViewTextBoxColumn();
            colQuocGia = new DataGridViewTextBoxColumn();
            pnlToolbar = new Panel();
            flpNutHangXe = new FlowLayoutPanel();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            txtTimKiem = new TextBox();
            pnlHeaderHangXe = new Panel();
            lblTitle = new Label();
            lblDescription = new Label();
            pnlDongXe = new Panel();
            dgvDongXe = new DataGridView();
            colMaDongXe = new DataGridViewTextBoxColumn();
            colTenDongXe = new DataGridViewTextBoxColumn();
            colTenHangCuaDongXe = new DataGridViewTextBoxColumn();
            pnlToolbarDongXe = new Panel();
            flpNutDongXe = new FlowLayoutPanel();
            btnThemDongXe = new Button();
            btnSuaDongXe = new Button();
            btnXoaDongXe = new Button();
            btnLamMoiDongXe = new Button();
            txtTimKiemDongXe = new TextBox();
            pnlHeaderDongXe = new Panel();
            lblTitleDongXe = new Label();
            lblDescriptionDongXe = new Label();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            pnlHangXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangXe).BeginInit();
            pnlToolbar.SuspendLayout();
            flpNutHangXe.SuspendLayout();
            pnlHeaderHangXe.SuspendLayout();
            pnlDongXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDongXe).BeginInit();
            pnlToolbarDongXe.SuspendLayout();
            flpNutDongXe.SuspendLayout();
            pnlHeaderDongXe.SuspendLayout();
            SuspendLayout();
            // 
            // splitMain
            // 
            splitMain.BackColor = Color.FromArgb(220, 225, 232);
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(0, 0);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(pnlHangXe);
            splitMain.Panel1MinSize = 300;
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(pnlDongXe);
            splitMain.Panel2MinSize = 300;
            splitMain.Size = new Size(1200, 650);
            splitMain.SplitterDistance = 580;
            splitMain.SplitterWidth = 6;
            splitMain.TabIndex = 0;
            // 
            // pnlHangXe
            // 
            pnlHangXe.BackColor = Color.FromArgb(245, 247, 250);
            pnlHangXe.Controls.Add(dgvHangXe);
            pnlHangXe.Controls.Add(pnlToolbar);
            pnlHangXe.Controls.Add(pnlHeaderHangXe);
            pnlHangXe.Dock = DockStyle.Fill;
            pnlHangXe.Location = new Point(0, 0);
            pnlHangXe.Name = "pnlHangXe";
            pnlHangXe.Padding = new Padding(8);
            pnlHangXe.Size = new Size(400, 650);
            pnlHangXe.TabIndex = 0;
            // 
            // dgvHangXe
            // 
            dgvHangXe.AllowUserToAddRows = false;
            dgvHangXe.AllowUserToDeleteRows = false;
            dgvHangXe.AllowUserToResizeRows = false;
            dgvHangXe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHangXe.BackgroundColor = Color.White;
            dgvHangXe.BorderStyle = BorderStyle.None;
            dgvHangXe.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHangXe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvHangXe.ColumnHeadersHeight = 40;
            dgvHangXe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHangXe.Columns.AddRange(new DataGridViewColumn[] { colMaHang, colTenHang, colQuocGia });
            dgvHangXe.Dock = DockStyle.Fill;
            dgvHangXe.EnableHeadersVisualStyles = false;
            dgvHangXe.GridColor = Color.FromArgb(235, 238, 243);
            dgvHangXe.MultiSelect = false;
            dgvHangXe.Name = "dgvHangXe";
            dgvHangXe.ReadOnly = true;
            dgvHangXe.RowHeadersVisible = false;
            dgvHangXe.RowTemplate.Height = 36;
            dgvHangXe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHangXe.TabIndex = 0;

            dgvHangXe.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(25, 45, 80);
            dgvHangXe.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHangXe.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvHangXe.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvHangXe.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);

            dgvHangXe.DefaultCellStyle.BackColor = Color.White;
            dgvHangXe.DefaultCellStyle.ForeColor = Color.FromArgb(45, 55, 70);
            dgvHangXe.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvHangXe.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 235, 248);
            dgvHangXe.DefaultCellStyle.SelectionForeColor = Color.FromArgb(25, 45, 80);
            dgvHangXe.DefaultCellStyle.Padding = new Padding(6, 0, 6, 0);
            dgvHangXe.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 253);
            // 
            // colMaHang
            // 
            colMaHang.FillWeight = 45F;
            colMaHang.HeaderText = "STT";
            colMaHang.MinimumWidth = 6;
            colMaHang.Name = "MaHang";
            colMaHang.Width = 125;
            // 
            // colTenHang
            // 
            colTenHang.FillWeight = 110F;
            colTenHang.HeaderText = "Tên hãng xe";
            colTenHang.MinimumWidth = 6;
            colTenHang.Name = "TenHang";
            colTenHang.Width = 125;
            // 
            // colQuocGia
            // 
            colQuocGia.FillWeight = 85F;
            colQuocGia.HeaderText = "Quốc gia";
            colQuocGia.MinimumWidth = 6;
            colQuocGia.Name = "QuocGia";
            colQuocGia.Width = 125;
            // 
            // pnlToolbar
            // 
            pnlToolbar.Controls.Add(flpNutHangXe);
            pnlToolbar.Controls.Add(txtTimKiem);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(8, 76);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(384, 82);
            pnlToolbar.TabIndex = 1;
            // 
            // flpNutHangXe
            // 
            flpNutHangXe.Controls.Add(btnThem);
            flpNutHangXe.Controls.Add(btnSua);
            flpNutHangXe.Controls.Add(btnXoa);
            flpNutHangXe.Controls.Add(btnLamMoi);
            flpNutHangXe.Dock = DockStyle.Fill;
            flpNutHangXe.Location = new Point(0, 27);
            flpNutHangXe.Name = "flpNutHangXe";
            flpNutHangXe.Padding = new Padding(3, 7, 0, 0);
            flpNutHangXe.Size = new Size(384, 51);
            flpNutHangXe.TabIndex = 0;
            flpNutHangXe.WrapContents = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(39, 174, 96);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(3, 8);
            btnThem.Margin = new Padding(0, 2, 5, 0);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(78, 32);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(52, 152, 219);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(84, 8);
            btnSua.Margin = new Padding(0, 2, 5, 0);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(78, 32);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(231, 76, 60);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(165, 8);
            btnXoa.Margin = new Padding(0, 2, 5, 0);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(78, 32);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(100, 116, 139);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(246, 8);
            btnLamMoi.Margin = new Padding(0, 2, 5, 0);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(78, 32);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Dock = DockStyle.Top;
            txtTimKiem.Font = new Font("Segoe UI", 9F);
            txtTimKiem.Location = new Point(0, 0);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm hãng xe...";
            txtTimKiem.Size = new Size(384, 27);
            txtTimKiem.TabIndex = 1;
            // 
            // pnlHeaderHangXe
            // 
            pnlHeaderHangXe.Controls.Add(lblTitle);
            pnlHeaderHangXe.Controls.Add(lblDescription);
            pnlHeaderHangXe.Dock = DockStyle.Top;
            pnlHeaderHangXe.Location = new Point(8, 8);
            pnlHeaderHangXe.Name = "pnlHeaderHangXe";
            pnlHeaderHangXe.Size = new Size(384, 68);
            pnlHeaderHangXe.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(25, 45, 80);
            lblTitle.Location = new Point(5, 3);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(277, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quản lý hãng xe";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F);
            lblDescription.ForeColor = Color.FromArgb(95, 112, 135);
            lblDescription.Location = new Point(7, 39);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(159, 20);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Danh sách các hãng xe";
            // 
            // pnlDongXe
            // 
            pnlDongXe.BackColor = Color.FromArgb(245, 247, 250);
            pnlDongXe.Controls.Add(dgvDongXe);
            pnlDongXe.Controls.Add(pnlToolbarDongXe);
            pnlDongXe.Controls.Add(pnlHeaderDongXe);
            pnlDongXe.Dock = DockStyle.Fill;
            pnlDongXe.Location = new Point(0, 0);
            pnlDongXe.Name = "pnlDongXe";
            pnlDongXe.Padding = new Padding(8);
            pnlDongXe.Size = new Size(794, 650);
            pnlDongXe.TabIndex = 0;
            // 
            // dgvDongXe
            // 
            dgvDongXe.AllowUserToAddRows = false;
            dgvDongXe.AllowUserToDeleteRows = false;
            dgvDongXe.AllowUserToResizeRows = false;
            dgvDongXe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDongXe.BackgroundColor = Color.White;
            dgvDongXe.BorderStyle = BorderStyle.None;
            dgvDongXe.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDongXe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDongXe.ColumnHeadersHeight = 40;
            dgvDongXe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDongXe.Columns.AddRange(new DataGridViewColumn[] { colMaDongXe, colTenDongXe, colTenHangCuaDongXe });
            dgvDongXe.Dock = DockStyle.Fill;
            dgvDongXe.EnableHeadersVisualStyles = false;
            dgvDongXe.GridColor = Color.FromArgb(235, 238, 243);
            dgvDongXe.MultiSelect = false;
            dgvDongXe.Name = "dgvDongXe";
            dgvDongXe.ReadOnly = true;
            dgvDongXe.RowHeadersVisible = false;
            dgvDongXe.RowTemplate.Height = 36;
            dgvDongXe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDongXe.TabIndex = 0;

            dgvDongXe.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(25, 45, 80);
            dgvDongXe.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDongXe.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvDongXe.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDongXe.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);

            dgvDongXe.DefaultCellStyle.BackColor = Color.White;
            dgvDongXe.DefaultCellStyle.ForeColor = Color.FromArgb(45, 55, 70);
            dgvDongXe.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvDongXe.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 235, 248);
            dgvDongXe.DefaultCellStyle.SelectionForeColor = Color.FromArgb(25, 45, 80);
            dgvDongXe.DefaultCellStyle.Padding = new Padding(6, 0, 6, 0);
            dgvDongXe.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 253);
            // 
            // colMaDongXe
            // 
            colMaDongXe.FillWeight = 40F;
            colMaDongXe.HeaderText = "STT";
            colMaDongXe.MinimumWidth = 6;
            colMaDongXe.Name = "MaDongXe";
            colMaDongXe.Width = 125;
            // 
            // colTenDongXe
            // 
            colTenDongXe.FillWeight = 110F;
            colTenDongXe.HeaderText = "Tên dòng xe";
            colTenDongXe.MinimumWidth = 6;
            colTenDongXe.Name = "TenDongXe";
            colTenDongXe.Width = 125;
            // 
            // colTenHangCuaDongXe
            // 
            colTenHangCuaDongXe.FillWeight = 85F;
            colTenHangCuaDongXe.HeaderText = "Hãng xe";
            colTenHangCuaDongXe.MinimumWidth = 6;
            colTenHangCuaDongXe.Name = "TenHangCuaDongXe";
            colTenHangCuaDongXe.Width = 125;
            // 
            // pnlToolbarDongXe
            // 
            pnlToolbarDongXe.Controls.Add(flpNutDongXe);
            pnlToolbarDongXe.Controls.Add(txtTimKiemDongXe);
            pnlToolbarDongXe.Dock = DockStyle.Top;
            pnlToolbarDongXe.Location = new Point(8, 76);
            pnlToolbarDongXe.Name = "pnlToolbarDongXe";
            pnlToolbarDongXe.Size = new Size(778, 82);
            pnlToolbarDongXe.TabIndex = 1;
            // 
            // flpNutDongXe
            // 
            flpNutDongXe.Controls.Add(btnThemDongXe);
            flpNutDongXe.Controls.Add(btnSuaDongXe);
            flpNutDongXe.Controls.Add(btnXoaDongXe);
            flpNutDongXe.Controls.Add(btnLamMoiDongXe);
            flpNutDongXe.Dock = DockStyle.Fill;
            flpNutDongXe.Location = new Point(0, 27);
            flpNutDongXe.Name = "flpNutDongXe";
            flpNutDongXe.Padding = new Padding(3, 7, 0, 0);
            flpNutDongXe.Size = new Size(778, 51);
            flpNutDongXe.TabIndex = 0;
            flpNutDongXe.WrapContents = false;
            // 
            // btnThemDongXe
            // 
            btnThemDongXe.BackColor = Color.FromArgb(39, 174, 96);
            btnThemDongXe.Cursor = Cursors.Hand;
            btnThemDongXe.FlatAppearance.BorderSize = 0;
            btnThemDongXe.FlatStyle = FlatStyle.Flat;
            btnThemDongXe.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnThemDongXe.ForeColor = Color.White;
            btnThemDongXe.Location = new Point(3, 8);
            btnThemDongXe.Margin = new Padding(0, 2, 5, 0);
            btnThemDongXe.Name = "btnThemDongXe";
            btnThemDongXe.Size = new Size(78, 32);
            btnThemDongXe.TabIndex = 0;
            btnThemDongXe.Text = "Thêm";
            btnThemDongXe.UseVisualStyleBackColor = false;
            // 
            // btnSuaDongXe
            // 
            btnSuaDongXe.BackColor = Color.FromArgb(52, 152, 219);
            btnSuaDongXe.Cursor = Cursors.Hand;
            btnSuaDongXe.FlatAppearance.BorderSize = 0;
            btnSuaDongXe.FlatStyle = FlatStyle.Flat;
            btnSuaDongXe.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnSuaDongXe.ForeColor = Color.White;
            btnSuaDongXe.Location = new Point(84, 8);
            btnSuaDongXe.Margin = new Padding(0, 2, 5, 0);
            btnSuaDongXe.Name = "btnSuaDongXe";
            btnSuaDongXe.Size = new Size(78, 32);
            btnSuaDongXe.TabIndex = 1;
            btnSuaDongXe.Text = "Sửa";
            btnSuaDongXe.UseVisualStyleBackColor = false;
            // 
            // btnXoaDongXe
            // 
            btnXoaDongXe.BackColor = Color.FromArgb(231, 76, 60);
            btnXoaDongXe.Cursor = Cursors.Hand;
            btnXoaDongXe.FlatAppearance.BorderSize = 0;
            btnXoaDongXe.FlatStyle = FlatStyle.Flat;
            btnXoaDongXe.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnXoaDongXe.ForeColor = Color.White;
            btnXoaDongXe.Location = new Point(165, 8);
            btnXoaDongXe.Margin = new Padding(0, 2, 5, 0);
            btnXoaDongXe.Name = "btnXoaDongXe";
            btnXoaDongXe.Size = new Size(78, 32);
            btnXoaDongXe.TabIndex = 2;
            btnXoaDongXe.Text = "Xóa";
            btnXoaDongXe.UseVisualStyleBackColor = false;
            // 
            // btnLamMoiDongXe
            // 
            btnLamMoiDongXe.BackColor = Color.FromArgb(100, 116, 139);
            btnLamMoiDongXe.Cursor = Cursors.Hand;
            btnLamMoiDongXe.FlatAppearance.BorderSize = 0;
            btnLamMoiDongXe.FlatStyle = FlatStyle.Flat;
            btnLamMoiDongXe.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnLamMoiDongXe.ForeColor = Color.White;
            btnLamMoiDongXe.Location = new Point(246, 8);
            btnLamMoiDongXe.Margin = new Padding(0, 2, 5, 0);
            btnLamMoiDongXe.Name = "btnLamMoiDongXe";
            btnLamMoiDongXe.Size = new Size(78, 32);
            btnLamMoiDongXe.TabIndex = 3;
            btnLamMoiDongXe.Text = "Làm mới";
            btnLamMoiDongXe.UseVisualStyleBackColor = false;
            // 
            // txtTimKiemDongXe
            // 
            txtTimKiemDongXe.Dock = DockStyle.Top;
            txtTimKiemDongXe.Font = new Font("Segoe UI", 9F);
            txtTimKiemDongXe.Location = new Point(0, 0);
            txtTimKiemDongXe.Name = "txtTimKiemDongXe";
            txtTimKiemDongXe.PlaceholderText = "Tìm dòng xe...";
            txtTimKiemDongXe.Size = new Size(778, 27);
            txtTimKiemDongXe.TabIndex = 1;
            // 
            // pnlHeaderDongXe
            // 
            pnlHeaderDongXe.Controls.Add(lblTitleDongXe);
            pnlHeaderDongXe.Controls.Add(lblDescriptionDongXe);
            pnlHeaderDongXe.Dock = DockStyle.Top;
            pnlHeaderDongXe.Location = new Point(8, 8);
            pnlHeaderDongXe.Name = "pnlHeaderDongXe";
            pnlHeaderDongXe.Size = new Size(778, 68);
            pnlHeaderDongXe.TabIndex = 2;
            // 
            // lblTitleDongXe
            // 
            lblTitleDongXe.AutoSize = true;
            lblTitleDongXe.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleDongXe.ForeColor = Color.FromArgb(25, 45, 80);
            lblTitleDongXe.Location = new Point(5, 3);
            lblTitleDongXe.Name = "lblTitleDongXe";
            lblTitleDongXe.Size = new Size(281, 46);
            lblTitleDongXe.TabIndex = 0;
            lblTitleDongXe.Text = "Quản lý dòng xe";
            // 
            // lblDescriptionDongXe
            // 
            lblDescriptionDongXe.AutoSize = true;
            lblDescriptionDongXe.Font = new Font("Segoe UI", 9F);
            lblDescriptionDongXe.ForeColor = Color.FromArgb(95, 112, 135);
            lblDescriptionDongXe.Location = new Point(7, 39);
            lblDescriptionDongXe.Name = "lblDescriptionDongXe";
            lblDescriptionDongXe.Size = new Size(210, 20);
            lblDescriptionDongXe.TabIndex = 1;
            lblDescriptionDongXe.Text = "Chọn hãng xe để xem dòng xe";
            // 
            // UcHangXe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(splitMain);
            Name = "UcHangXe";
            Size = new Size(1200, 650);
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            pnlHangXe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHangXe).EndInit();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            flpNutHangXe.ResumeLayout(false);
            pnlHeaderHangXe.ResumeLayout(false);
            pnlHeaderHangXe.PerformLayout();
            pnlDongXe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDongXe).EndInit();
            pnlToolbarDongXe.ResumeLayout(false);
            pnlToolbarDongXe.PerformLayout();
            flpNutDongXe.ResumeLayout(false);
            pnlHeaderDongXe.ResumeLayout(false);
            pnlHeaderDongXe.PerformLayout();
            ResumeLayout(false);
        }

    }
}

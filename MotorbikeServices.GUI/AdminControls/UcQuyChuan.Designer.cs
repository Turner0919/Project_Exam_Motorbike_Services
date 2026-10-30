namespace MotorbikeServices.GUI.AdminControls
{
    partial class UcQuyChuan
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            pnlMain = new Panel();
            tlpMain = new TableLayoutPanel();
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblDescription = new Label();
            tlpContent = new TableLayoutPanel();
            pnlLeft = new Panel();
            tlpLeft = new TableLayoutPanel();
            lblHangXe = new Label();
            dgvHangXe = new DataGridView();
            lblDongXe = new Label();
            dgvDongXe = new DataGridView();
            pnlRight = new Panel();
            tlpRight = new TableLayoutPanel();
            lblDongXeDangChon = new Label();
            pnlToolbar = new Panel();
            txtTimKiem = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            pnlGrid = new Panel();
            dgvQuyChuan = new DataGridView();

            pnlMain.SuspendLayout();
            tlpMain.SuspendLayout();
            pnlHeader.SuspendLayout();
            tlpContent.SuspendLayout();
            pnlLeft.SuspendLayout();
            tlpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangXe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDongXe).BeginInit();
            pnlRight.SuspendLayout();
            tlpRight.SuspendLayout();
            pnlToolbar.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuyChuan).BeginInit();
            SuspendLayout();

            // pnlMain: occupies the entire UserControl.
            pnlMain.BackColor = Color.FromArgb(245, 247, 251);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Padding = new Padding(22, 18, 22, 20);
            pnlMain.Name = "pnlMain";
            pnlMain.Controls.Add(tlpMain);

            // tlpMain: header + expandable content area.
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.RowCount = 2;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Margin = new Padding(0);
            tlpMain.Name = "tlpMain";
            tlpMain.Controls.Add(pnlHeader, 0, 0);
            tlpMain.Controls.Add(tlpContent, 0, 1);

            // Header
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Margin = new Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblDescription);

            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(25, 45, 80);
            lblTitle.Location = new Point(2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "Quy chuẩn bảo dưỡng";

            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9.5F);
            lblDescription.ForeColor = Color.FromArgb(102, 112, 133);
            lblDescription.Location = new Point(5, 43);
            lblDescription.Name = "lblDescription";
            lblDescription.Text = "Quản lý quy chuẩn bảo dưỡng theo từng dòng xe";

            // Main content: 26% left navigation, 74% data area.
            tlpContent.ColumnCount = 2;
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26F));
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74F));
            tlpContent.RowCount = 1;
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpContent.Dock = DockStyle.Fill;
            tlpContent.Margin = new Padding(0);
            tlpContent.Name = "tlpContent";
            tlpContent.Controls.Add(pnlLeft, 0, 0);
            tlpContent.Controls.Add(pnlRight, 1, 0);

            // Left panel
            pnlLeft.BackColor = Color.White;
            pnlLeft.Dock = DockStyle.Fill;
            pnlLeft.Margin = new Padding(0, 0, 12, 0);
            pnlLeft.Padding = new Padding(14, 10, 14, 12);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Controls.Add(tlpLeft);

            // Left panel: two equally-sized scrollable lists.
            tlpLeft.ColumnCount = 1;
            tlpLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpLeft.RowCount = 4;
            tlpLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tlpLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpLeft.Dock = DockStyle.Fill;
            tlpLeft.Margin = new Padding(0);
            tlpLeft.Name = "tlpLeft";
            tlpLeft.Controls.Add(lblHangXe, 0, 0);
            tlpLeft.Controls.Add(dgvHangXe, 0, 1);
            tlpLeft.Controls.Add(lblDongXe, 0, 2);
            tlpLeft.Controls.Add(dgvDongXe, 0, 3);

            lblHangXe.Dock = DockStyle.Fill;
            lblHangXe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHangXe.ForeColor = Color.FromArgb(25, 45, 80);
            lblHangXe.Text = "HÃNG XE";
            lblHangXe.TextAlign = ContentAlignment.MiddleLeft;
            lblHangXe.Name = "lblHangXe";

            dgvHangXe.Dock = DockStyle.Fill;
            dgvHangXe.Name = "dgvHangXe";
            dgvHangXe.Margin = new Padding(0);
            dgvHangXe.TabIndex = 1;
            dgvHangXe.CellClick += dgvHangXe_CellClick;

            lblDongXe.Dock = DockStyle.Fill;
            lblDongXe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDongXe.ForeColor = Color.FromArgb(25, 45, 80);
            lblDongXe.Text = "DÒNG XE";
            lblDongXe.TextAlign = ContentAlignment.MiddleLeft;
            lblDongXe.Name = "lblDongXe";

            dgvDongXe.Dock = DockStyle.Fill;
            dgvDongXe.Name = "dgvDongXe";
            dgvDongXe.Margin = new Padding(0);
            dgvDongXe.TabIndex = 3;
            dgvDongXe.CellClick += dgvDongXe_CellClick;

            // Right panel
            pnlRight.BackColor = Color.White;
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Margin = new Padding(0);
            pnlRight.Padding = new Padding(16, 12, 16, 14);
            pnlRight.Name = "pnlRight";
            pnlRight.Controls.Add(tlpRight);

            // Right panel: title, toolbar, full-size grid.
            tlpRight.ColumnCount = 1;
            tlpRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRight.RowCount = 3;
            tlpRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tlpRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 94F));
            tlpRight.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRight.Dock = DockStyle.Fill;
            tlpRight.Margin = new Padding(0);
            tlpRight.Name = "tlpRight";
            tlpRight.Controls.Add(lblDongXeDangChon, 0, 0);
            tlpRight.Controls.Add(pnlToolbar, 0, 1);
            tlpRight.Controls.Add(pnlGrid, 0, 2);

            lblDongXeDangChon.Dock = DockStyle.Fill;
            lblDongXeDangChon.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblDongXeDangChon.ForeColor = Color.FromArgb(25, 45, 80);
            lblDongXeDangChon.Text = "Vui lòng chọn dòng xe";
            lblDongXeDangChon.TextAlign = ContentAlignment.MiddleLeft;
            lblDongXeDangChon.Name = "lblDongXeDangChon";

            // Toolbar controls are kept on one line where possible.
            pnlToolbar.Dock = DockStyle.Fill;
            pnlToolbar.Margin = new Padding(0);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Controls.Add(txtTimKiem);
            pnlToolbar.Controls.Add(btnThem);
            pnlToolbar.Controls.Add(btnSua);
            pnlToolbar.Controls.Add(btnXoa);
            pnlToolbar.Controls.Add(btnLamMoi);

            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            txtTimKiem.Font = new Font("Segoe UI", 9.5F);
            txtTimKiem.Location = new Point(0, 3);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm theo tên quy chuẩn...";
            txtTimKiem.Size = new Size(320, 30);
            txtTimKiem.TabIndex = 0;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;

            btnThem.BackColor = Color.FromArgb(34, 160, 95);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 140, 82);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(0, 43);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 36);
            btnThem.Text = "+ Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;

            btnSua.BackColor = Color.FromArgb(35, 145, 210);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 125, 185);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(108, 43);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(82, 36);
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;

            btnXoa.BackColor = Color.FromArgb(205, 65, 65);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 50, 50);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(198, 43);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(82, 36);
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;

            btnLamMoi.BackColor = Color.FromArgb(230, 234, 240);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 222, 232);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.FromArgb(25, 45, 80);
            btnLamMoi.Location = new Point(288, 43);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(100, 36);
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;

            // Grid panel
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Margin = new Padding(0);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Controls.Add(dgvQuyChuan);

            dgvQuyChuan.Dock = DockStyle.Fill;
            dgvQuyChuan.Name = "dgvQuyChuan";
            dgvQuyChuan.Margin = new Padding(0);
            dgvQuyChuan.TabIndex = 0;
            dgvQuyChuan.CellClick += dgvQuyChuan_CellClick;

            // UcQuyChuan
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            Controls.Add(pnlMain);
            Name = "UcQuyChuan";
            Size = new Size(1200, 700);

            pnlGrid.ResumeLayout(false);
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            tlpRight.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQuyChuan).EndInit();
            tlpLeft.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDongXe).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHangXe).EndInit();
            tlpContent.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tlpMain.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private TableLayoutPanel tlpMain;
        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblDescription;
        private TableLayoutPanel tlpContent;
        private Panel pnlLeft;
        private TableLayoutPanel tlpLeft;
        private Label lblHangXe;
        private DataGridView dgvHangXe;
        private Label lblDongXe;
        private DataGridView dgvDongXe;
        private Panel pnlRight;
        private TableLayoutPanel tlpRight;
        private Label lblDongXeDangChon;
        private Panel pnlToolbar;
        private TextBox txtTimKiem;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Panel pnlGrid;
        private DataGridView dgvQuyChuan;
    }
}

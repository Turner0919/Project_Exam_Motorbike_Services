
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
            pnlDongXe = new Panel();

            pnlHeaderHangXe = new Panel();
            pnlHeaderDongXe = new Panel();

            pnlToolbar = new Panel();
            pnlToolbarDongXe = new Panel();

            flpNutHangXe = new FlowLayoutPanel();
            flpNutDongXe = new FlowLayoutPanel();

            lblTitle = new Label();
            lblDescription = new Label();
            lblTitleDongXe = new Label();
            lblDescriptionDongXe = new Label();

            txtTimKiem = new TextBox();
            txtTimKiemDongXe = new TextBox();

            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();

            btnThemDongXe = new Button();
            btnSuaDongXe = new Button();
            btnXoaDongXe = new Button();
            btnLamMoiDongXe = new Button();

            dgvHangXe = new DataGridView();
            dgvDongXe = new DataGridView();

            colMaHang = new DataGridViewTextBoxColumn();
            colTenHang = new DataGridViewTextBoxColumn();
            colQuocGia = new DataGridViewTextBoxColumn();

            colMaDongXe = new DataGridViewTextBoxColumn();
            colTenDongXe = new DataGridViewTextBoxColumn();
            colTenHangCuaDongXe = new DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();

            SuspendLayout();

            // UserControl
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Name = "UcHangXe";
            Size = new Size(1200, 650);

            // Chia màn hình trái - phải
            splitMain.Dock = DockStyle.Fill;
            splitMain.Orientation = Orientation.Vertical;
            splitMain.SplitterWidth = 6;
            splitMain.Panel1MinSize = 0;
            splitMain.Panel2MinSize = 0;
            splitMain.BackColor = Color.FromArgb(220, 225, 232);

            pnlHangXe.Dock = DockStyle.Fill;
            pnlHangXe.BackColor = Color.FromArgb(245, 247, 250);
            pnlHangXe.Padding = new Padding(8);

            pnlDongXe.Dock = DockStyle.Fill;
            pnlDongXe.BackColor = Color.FromArgb(245, 247, 250);
            pnlDongXe.Padding = new Padding(8);

            splitMain.Panel1.Controls.Add(pnlHangXe);
            splitMain.Panel2.Controls.Add(pnlDongXe);

            // Tiêu đề hãng xe
            pnlHeaderHangXe.Dock = DockStyle.Top;
            pnlHeaderHangXe.Height = 68;

            lblTitle.Text = "Quản lý hãng xe";
            lblTitle.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(25, 45, 80);
            lblTitle.Location = new Point(5, 3);
            lblTitle.AutoSize = true;

            lblDescription.Text = "Danh sách các hãng xe";
            lblDescription.Font = new Font("Segoe UI", 9F);
            lblDescription.ForeColor = Color.FromArgb(95, 112, 135);
            lblDescription.Location = new Point(7, 39);
            lblDescription.AutoSize = true;

            pnlHeaderHangXe.Controls.Add(lblTitle);
            pnlHeaderHangXe.Controls.Add(lblDescription);

            // Tiêu đề dòng xe
            pnlHeaderDongXe.Dock = DockStyle.Top;
            pnlHeaderDongXe.Height = 68;

            lblTitleDongXe.Text = "Quản lý dòng xe";
            lblTitleDongXe.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTitleDongXe.ForeColor = Color.FromArgb(25, 45, 80);
            lblTitleDongXe.Location = new Point(5, 3);
            lblTitleDongXe.AutoSize = true;

            lblDescriptionDongXe.Text = "Chọn hãng xe để xem dòng xe";
            lblDescriptionDongXe.Font = new Font("Segoe UI", 9F);
            lblDescriptionDongXe.ForeColor = Color.FromArgb(95, 112, 135);
            lblDescriptionDongXe.Location = new Point(7, 39);
            lblDescriptionDongXe.AutoSize = true;

            pnlHeaderDongXe.Controls.Add(lblTitleDongXe);
            pnlHeaderDongXe.Controls.Add(lblDescriptionDongXe);

            // Thanh công cụ hãng xe
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Height = 78;

            txtTimKiem.Dock = DockStyle.Top;
            txtTimKiem.Height = 30;
            txtTimKiem.Font = new Font("Segoe UI", 9F);
            txtTimKiem.PlaceholderText = "Tìm hãng xe...";

            flpNutHangXe.Dock = DockStyle.Fill;
            flpNutHangXe.FlowDirection = FlowDirection.LeftToRight;
            flpNutHangXe.WrapContents = false;
            flpNutHangXe.Padding = new Padding(0, 5, 0, 0);

            CauHinhNut(btnThem, "+ Thêm", Color.FromArgb(55, 126, 184));
            CauHinhNut(btnSua, "Sửa", Color.FromArgb(25, 45, 80));
            CauHinhNut(btnXoa, "Xóa", Color.FromArgb(180, 65, 65));
            CauHinhNut(btnLamMoi, "Làm mới", Color.FromArgb(25, 45, 80));

            flpNutHangXe.Controls.AddRange(new Control[]
            {
                btnThem, btnSua, btnXoa, btnLamMoi
            });

            pnlToolbar.Controls.Add(flpNutHangXe);
            pnlToolbar.Controls.Add(txtTimKiem);

            // Bảng hãng xe
            CauHinhBang(dgvHangXe);

            colMaHang.Name = "MaHang";
            colMaHang.HeaderText = "Mã";
            colMaHang.FillWeight = 45;

            colTenHang.Name = "TenHang";
            colTenHang.HeaderText = "Tên hãng xe";
            colTenHang.FillWeight = 110;

            colQuocGia.Name = "QuocGia";
            colQuocGia.HeaderText = "Quốc gia";
            colQuocGia.FillWeight = 85;

            dgvHangXe.Columns.AddRange(new DataGridViewColumn[]
            {
                colMaHang, colTenHang, colQuocGia
            });

            // Thanh công cụ dòng xe
            pnlToolbarDongXe.Dock = DockStyle.Top;
            pnlToolbarDongXe.Height = 78;

            txtTimKiemDongXe.Dock = DockStyle.Top;
            txtTimKiemDongXe.Height = 30;
            txtTimKiemDongXe.Font = new Font("Segoe UI", 9F);
            txtTimKiemDongXe.PlaceholderText = "Tìm dòng xe...";

            flpNutDongXe.Dock = DockStyle.Fill;
            flpNutDongXe.FlowDirection = FlowDirection.LeftToRight;
            flpNutDongXe.WrapContents = false;
            flpNutDongXe.Padding = new Padding(0, 5, 0, 0);

            CauHinhNut(
                btnThemDongXe, "+ Thêm",
                Color.FromArgb(55, 126, 184));

            CauHinhNut(
                btnSuaDongXe, "Sửa",
                Color.FromArgb(25, 45, 80));

            CauHinhNut(
                btnXoaDongXe, "Xóa",
                Color.FromArgb(180, 65, 65));

            CauHinhNut(
                btnLamMoiDongXe, "Làm mới",
                Color.FromArgb(25, 45, 80));

            flpNutDongXe.Controls.AddRange(new Control[]
            {
                btnThemDongXe,
                btnSuaDongXe,
                btnXoaDongXe,
                btnLamMoiDongXe
            });

            pnlToolbarDongXe.Controls.Add(flpNutDongXe);
            pnlToolbarDongXe.Controls.Add(txtTimKiemDongXe);

            // Bảng dòng xe
            CauHinhBang(dgvDongXe);

            colMaDongXe.Name = "MaDongXe";
            colMaDongXe.HeaderText = "Mã";
            colMaDongXe.FillWeight = 40;

            colTenDongXe.Name = "TenDongXe";
            colTenDongXe.HeaderText = "Tên dòng xe";
            colTenDongXe.FillWeight = 110;

            colTenHangCuaDongXe.Name = "TenHangCuaDongXe";
            colTenHangCuaDongXe.HeaderText = "Hãng xe";
            colTenHangCuaDongXe.FillWeight = 85;

            dgvDongXe.Columns.AddRange(new DataGridViewColumn[]
            {
                colMaDongXe,
                colTenDongXe,
                colTenHangCuaDongXe
            });

            // Bảng lấp đầy phần dưới
            pnlHangXe.Controls.Add(dgvHangXe);
            pnlHangXe.Controls.Add(pnlToolbar);
            pnlHangXe.Controls.Add(pnlHeaderHangXe);

            pnlDongXe.Controls.Add(dgvDongXe);
            pnlDongXe.Controls.Add(pnlToolbarDongXe);
            pnlDongXe.Controls.Add(pnlHeaderDongXe);

            Controls.Add(splitMain);

            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();

            splitMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void CauHinhNut(
            Button button, string text, Color color)
        {
            button.Text = text;
            button.Size = new Size(78, 32);
            button.Margin = new Padding(0, 2, 5, 0);
            button.BackColor = color;
            button.ForeColor = Color.White;
            button.Font = new Font(
                "Segoe UI", 8.5F, FontStyle.Bold);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.UseVisualStyleBackColor = false;
            button.Cursor = Cursors.Hand;
        }

        private void CauHinhBang(DataGridView grid)
        {
            grid.Dock = DockStyle.Fill;
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.FixedSingle;
            grid.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.ReadOnly = true;
            grid.MultiSelect = false;
            grid.RowHeadersVisible = false;
            grid.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            grid.RowTemplate.Height = 34;
            grid.ColumnHeadersHeight = 40;
            grid.EnableHeadersVisualStyles = false;

            grid.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(25, 45, 80);

            grid.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            grid.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            grid.DefaultCellStyle.Font =
                new Font("Segoe UI", 9F);

            grid.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(220, 235, 248);

            grid.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(25, 45, 80);
        }
    }
}

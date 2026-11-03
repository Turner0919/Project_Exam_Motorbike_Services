
using System.Drawing;
using System.Windows.Forms;

namespace MotorbikeServices.GUI.AdminControls
{
    partial class UcDashboard
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel tlpTongQuan;
        private Panel pnlTieuDe;
        private Label lblPageTitle;
        private Label lblPageDescription;

        private TableLayoutPanel tlpTheThongKe;

        private Panel pnlCardHangXe;
        private Label lblCardHangXeValue;
        private Label lblCardHangXeTitle;

        private Panel pnlCardDongXe;
        private Label lblCardDongXeValue;
        private Label lblCardDongXeTitle;

        private Panel pnlCardQuyChuan;
        private Label lblCardQuyChuanValue;
        private Label lblCardQuyChuanTitle;

        private Panel pnlCardTaiKhoan;
        private Label lblCardTaiKhoanValue;
        private Label lblCardTaiKhoanTitle;

        private TableLayoutPanel tlpBieuDo;

        private BieuDoThongKeControl bieuDoDongXeTheoHang;
        private BieuDoThongKeControl bieuDoTaiKhoan;
        private BieuDoThongKeControl bieuDoQuyChuan;
        private BieuDoThongKeControl bieuDoCuaHang;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tlpTongQuan = new TableLayoutPanel();
            pnlTieuDe = new Panel();
            lblPageTitle = new Label();
            lblPageDescription = new Label();
            tlpTheThongKe = new TableLayoutPanel();
            pnlCardHangXe = new Panel();
            lblCardHangXeValue = new Label();
            lblCardHangXeTitle = new Label();
            pnlCardDongXe = new Panel();
            lblCardDongXeValue = new Label();
            lblCardDongXeTitle = new Label();
            pnlCardQuyChuan = new Panel();
            lblCardQuyChuanValue = new Label();
            lblCardQuyChuanTitle = new Label();
            pnlCardTaiKhoan = new Panel();
            lblCardTaiKhoanValue = new Label();
            lblCardTaiKhoanTitle = new Label();
            tlpBieuDo = new TableLayoutPanel();
            bieuDoDongXeTheoHang = new BieuDoThongKeControl();
            bieuDoTaiKhoan = new BieuDoThongKeControl();
            bieuDoQuyChuan = new BieuDoThongKeControl();
            bieuDoCuaHang = new BieuDoThongKeControl();
            tlpTongQuan.SuspendLayout();
            pnlTieuDe.SuspendLayout();
            tlpTheThongKe.SuspendLayout();
            pnlCardHangXe.SuspendLayout();
            pnlCardDongXe.SuspendLayout();
            pnlCardQuyChuan.SuspendLayout();
            pnlCardTaiKhoan.SuspendLayout();
            tlpBieuDo.SuspendLayout();
            SuspendLayout();
            // 
            // tlpTongQuan
            // 
            tlpTongQuan.BackColor = Color.FromArgb(245, 247, 251);
            tlpTongQuan.ColumnCount = 1;
            tlpTongQuan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTongQuan.Controls.Add(pnlTieuDe, 0, 0);
            tlpTongQuan.Controls.Add(tlpTheThongKe, 0, 1);
            tlpTongQuan.Controls.Add(tlpBieuDo, 0, 2);
            tlpTongQuan.Dock = DockStyle.Fill;
            tlpTongQuan.Location = new Point(0, 0);
            tlpTongQuan.Name = "tlpTongQuan";
            tlpTongQuan.Padding = new Padding(18, 14, 18, 16);
            tlpTongQuan.RowCount = 3;
            tlpTongQuan.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tlpTongQuan.RowStyles.Add(new RowStyle(SizeType.Absolute, 132F));
            tlpTongQuan.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTongQuan.Size = new Size(1330, 481);
            tlpTongQuan.TabIndex = 0;
            // 
            // pnlTieuDe
            // 
            pnlTieuDe.BackColor = Color.Transparent;
            pnlTieuDe.Controls.Add(lblPageTitle);
            pnlTieuDe.Controls.Add(lblPageDescription);
            pnlTieuDe.Dock = DockStyle.Fill;
            pnlTieuDe.Location = new Point(18, 14);
            pnlTieuDe.Margin = new Padding(0);
            pnlTieuDe.Name = "pnlTieuDe";
            pnlTieuDe.Size = new Size(1294, 72);
            pnlTieuDe.TabIndex = 0;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(21, 54, 91);
            lblPageTitle.Location = new Point(2, 0);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(345, 46);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Tổng quan hệ thống";
            // 
            // lblPageDescription
            // 
            lblPageDescription.AutoSize = true;
            lblPageDescription.Font = new Font("Segoe UI", 9F);
            lblPageDescription.ForeColor = Color.FromArgb(100, 116, 139);
            lblPageDescription.Location = new Point(5, 45);
            lblPageDescription.Name = "lblPageDescription";
            lblPageDescription.Size = new Size(334, 20);
            lblPageDescription.TabIndex = 1;
            lblPageDescription.Text = "Thống kê tổng quan hệ thống bảo dưỡng xe máy";
            // 
            // tlpTheThongKe
            // 
            tlpTheThongKe.BackColor = Color.FromArgb(245, 247, 251);
            tlpTheThongKe.ColumnCount = 4;
            tlpTheThongKe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpTheThongKe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpTheThongKe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpTheThongKe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpTheThongKe.Controls.Add(pnlCardHangXe, 0, 0);
            tlpTheThongKe.Controls.Add(pnlCardDongXe, 1, 0);
            tlpTheThongKe.Controls.Add(pnlCardQuyChuan, 2, 0);
            tlpTheThongKe.Controls.Add(pnlCardTaiKhoan, 3, 0);
            tlpTheThongKe.Dock = DockStyle.Fill;
            tlpTheThongKe.Location = new Point(18, 88);
            tlpTheThongKe.Margin = new Padding(0, 2, 0, 8);
            tlpTheThongKe.Name = "tlpTheThongKe";
            tlpTheThongKe.RowCount = 1;
            tlpTheThongKe.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTheThongKe.Size = new Size(1294, 122);
            tlpTheThongKe.TabIndex = 1;
            // 
            // pnlCardHangXe
            // 
            pnlCardHangXe.BackColor = Color.FromArgb(232, 241, 252);
            pnlCardHangXe.Controls.Add(lblCardHangXeValue);
            pnlCardHangXe.Controls.Add(lblCardHangXeTitle);
            pnlCardHangXe.Dock = DockStyle.Fill;
            pnlCardHangXe.Location = new Point(6, 4);
            pnlCardHangXe.Margin = new Padding(6, 4, 6, 8);
            pnlCardHangXe.Name = "pnlCardHangXe";
            pnlCardHangXe.Padding = new Padding(16, 12, 12, 10);
            pnlCardHangXe.Size = new Size(311, 110);
            pnlCardHangXe.TabIndex = 0;
            // 
            // lblCardHangXeValue
            // 
            lblCardHangXeValue.Dock = DockStyle.Fill;
            lblCardHangXeValue.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblCardHangXeValue.ForeColor = Color.FromArgb(29, 61, 94);
            lblCardHangXeValue.Location = new Point(16, 42);
            lblCardHangXeValue.Name = "lblCardHangXeValue";
            lblCardHangXeValue.Size = new Size(283, 58);
            lblCardHangXeValue.TabIndex = 0;
            lblCardHangXeValue.Text = "--";
            lblCardHangXeValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCardHangXeTitle
            // 
            lblCardHangXeTitle.Dock = DockStyle.Top;
            lblCardHangXeTitle.Font = new Font("Segoe UI", 9F);
            lblCardHangXeTitle.ForeColor = Color.FromArgb(91, 108, 129);
            lblCardHangXeTitle.Location = new Point(16, 12);
            lblCardHangXeTitle.Name = "lblCardHangXeTitle";
            lblCardHangXeTitle.Size = new Size(283, 30);
            lblCardHangXeTitle.TabIndex = 1;
            lblCardHangXeTitle.Text = "Tổng số hãng xe";
            lblCardHangXeTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlCardDongXe
            // 
            pnlCardDongXe.BackColor = Color.FromArgb(229, 245, 247);
            pnlCardDongXe.Controls.Add(lblCardDongXeValue);
            pnlCardDongXe.Controls.Add(lblCardDongXeTitle);
            pnlCardDongXe.Dock = DockStyle.Fill;
            pnlCardDongXe.Location = new Point(329, 4);
            pnlCardDongXe.Margin = new Padding(6, 4, 6, 8);
            pnlCardDongXe.Name = "pnlCardDongXe";
            pnlCardDongXe.Padding = new Padding(16, 12, 12, 10);
            pnlCardDongXe.Size = new Size(311, 110);
            pnlCardDongXe.TabIndex = 1;
            // 
            // lblCardDongXeValue
            // 
            lblCardDongXeValue.Dock = DockStyle.Fill;
            lblCardDongXeValue.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblCardDongXeValue.ForeColor = Color.FromArgb(29, 61, 94);
            lblCardDongXeValue.Location = new Point(16, 42);
            lblCardDongXeValue.Name = "lblCardDongXeValue";
            lblCardDongXeValue.Size = new Size(283, 58);
            lblCardDongXeValue.TabIndex = 0;
            lblCardDongXeValue.Text = "--";
            lblCardDongXeValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCardDongXeTitle
            // 
            lblCardDongXeTitle.Dock = DockStyle.Top;
            lblCardDongXeTitle.Font = new Font("Segoe UI", 9F);
            lblCardDongXeTitle.ForeColor = Color.FromArgb(91, 108, 129);
            lblCardDongXeTitle.Location = new Point(16, 12);
            lblCardDongXeTitle.Name = "lblCardDongXeTitle";
            lblCardDongXeTitle.Size = new Size(283, 30);
            lblCardDongXeTitle.TabIndex = 1;
            lblCardDongXeTitle.Text = "Tổng số dòng xe";
            lblCardDongXeTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlCardQuyChuan
            // 
            pnlCardQuyChuan.BackColor = Color.FromArgb(240, 235, 250);
            pnlCardQuyChuan.Controls.Add(lblCardQuyChuanValue);
            pnlCardQuyChuan.Controls.Add(lblCardQuyChuanTitle);
            pnlCardQuyChuan.Dock = DockStyle.Fill;
            pnlCardQuyChuan.Location = new Point(652, 4);
            pnlCardQuyChuan.Margin = new Padding(6, 4, 6, 8);
            pnlCardQuyChuan.Name = "pnlCardQuyChuan";
            pnlCardQuyChuan.Padding = new Padding(16, 12, 12, 10);
            pnlCardQuyChuan.Size = new Size(311, 110);
            pnlCardQuyChuan.TabIndex = 2;
            // 
            // lblCardQuyChuanValue
            // 
            lblCardQuyChuanValue.Dock = DockStyle.Fill;
            lblCardQuyChuanValue.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblCardQuyChuanValue.ForeColor = Color.FromArgb(29, 61, 94);
            lblCardQuyChuanValue.Location = new Point(16, 42);
            lblCardQuyChuanValue.Name = "lblCardQuyChuanValue";
            lblCardQuyChuanValue.Size = new Size(283, 58);
            lblCardQuyChuanValue.TabIndex = 0;
            lblCardQuyChuanValue.Text = "--";
            lblCardQuyChuanValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCardQuyChuanTitle
            // 
            lblCardQuyChuanTitle.Dock = DockStyle.Top;
            lblCardQuyChuanTitle.Font = new Font("Segoe UI", 9F);
            lblCardQuyChuanTitle.ForeColor = Color.FromArgb(91, 108, 129);
            lblCardQuyChuanTitle.Location = new Point(16, 12);
            lblCardQuyChuanTitle.Name = "lblCardQuyChuanTitle";
            lblCardQuyChuanTitle.Size = new Size(283, 30);
            lblCardQuyChuanTitle.TabIndex = 1;
            lblCardQuyChuanTitle.Text = "Quy chuẩn bảo dưỡng";
            lblCardQuyChuanTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlCardTaiKhoan
            // 
            pnlCardTaiKhoan.BackColor = Color.FromArgb(231, 245, 236);
            pnlCardTaiKhoan.Controls.Add(lblCardTaiKhoanValue);
            pnlCardTaiKhoan.Controls.Add(lblCardTaiKhoanTitle);
            pnlCardTaiKhoan.Dock = DockStyle.Fill;
            pnlCardTaiKhoan.Location = new Point(975, 4);
            pnlCardTaiKhoan.Margin = new Padding(6, 4, 6, 8);
            pnlCardTaiKhoan.Name = "pnlCardTaiKhoan";
            pnlCardTaiKhoan.Padding = new Padding(16, 12, 12, 10);
            pnlCardTaiKhoan.Size = new Size(313, 110);
            pnlCardTaiKhoan.TabIndex = 3;
            // 
            // lblCardTaiKhoanValue
            // 
            lblCardTaiKhoanValue.Dock = DockStyle.Fill;
            lblCardTaiKhoanValue.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblCardTaiKhoanValue.ForeColor = Color.FromArgb(29, 61, 94);
            lblCardTaiKhoanValue.Location = new Point(16, 42);
            lblCardTaiKhoanValue.Name = "lblCardTaiKhoanValue";
            lblCardTaiKhoanValue.Size = new Size(285, 58);
            lblCardTaiKhoanValue.TabIndex = 0;
            lblCardTaiKhoanValue.Text = "--";
            lblCardTaiKhoanValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCardTaiKhoanTitle
            // 
            lblCardTaiKhoanTitle.Dock = DockStyle.Top;
            lblCardTaiKhoanTitle.Font = new Font("Segoe UI", 9F);
            lblCardTaiKhoanTitle.ForeColor = Color.FromArgb(91, 108, 129);
            lblCardTaiKhoanTitle.Location = new Point(16, 12);
            lblCardTaiKhoanTitle.Name = "lblCardTaiKhoanTitle";
            lblCardTaiKhoanTitle.Size = new Size(285, 30);
            lblCardTaiKhoanTitle.TabIndex = 1;
            lblCardTaiKhoanTitle.Text = "Tổng tài khoản";
            lblCardTaiKhoanTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpBieuDo
            // 
            tlpBieuDo.ColumnCount = 2;
            tlpBieuDo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBieuDo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBieuDo.Controls.Add(bieuDoDongXeTheoHang, 0, 0);
            tlpBieuDo.Controls.Add(bieuDoTaiKhoan, 1, 0);
            tlpBieuDo.Controls.Add(bieuDoQuyChuan, 0, 1);
            tlpBieuDo.Controls.Add(bieuDoCuaHang, 1, 1);
            tlpBieuDo.Dock = DockStyle.Fill;
            tlpBieuDo.Location = new Point(18, 218);
            tlpBieuDo.Margin = new Padding(0);
            tlpBieuDo.Name = "tlpBieuDo";
            tlpBieuDo.RowCount = 2;
            tlpBieuDo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBieuDo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBieuDo.Size = new Size(1294, 247);
            tlpBieuDo.TabIndex = 2;
            // 
            // bieuDoDongXeTheoHang
            // 
            bieuDoDongXeTheoHang.BackColor = Color.White;
            bieuDoDongXeTheoHang.Dock = DockStyle.Fill;
            bieuDoDongXeTheoHang.Font = new Font("Segoe UI", 9F);
            bieuDoDongXeTheoHang.ForeColor = Color.FromArgb(35, 55, 78);
            bieuDoDongXeTheoHang.Location = new Point(6, 6);
            bieuDoDongXeTheoHang.Margin = new Padding(6);
            bieuDoDongXeTheoHang.MinimumSize = new Size(240, 170);
            bieuDoDongXeTheoHang.MoTa = "Top 8 hãng có nhiều dòng xe nhất";
            bieuDoDongXeTheoHang.Name = "bieuDoDongXeTheoHang";
            bieuDoDongXeTheoHang.Size = new Size(635, 170);
            bieuDoDongXeTheoHang.TabIndex = 0;
            bieuDoDongXeTheoHang.TieuDe = "Số dòng xe theo hãng";
            // 
            // bieuDoTaiKhoan
            // 
            bieuDoTaiKhoan.BackColor = Color.White;
            bieuDoTaiKhoan.Dock = DockStyle.Fill;
            bieuDoTaiKhoan.Font = new Font("Segoe UI", 9F);
            bieuDoTaiKhoan.ForeColor = Color.FromArgb(35, 55, 78);
            bieuDoTaiKhoan.LoaiBieuDo = LoaiBieuDoThongKe.Tron;
            bieuDoTaiKhoan.Location = new Point(653, 6);
            bieuDoTaiKhoan.Margin = new Padding(6);
            bieuDoTaiKhoan.MinimumSize = new Size(240, 170);
            bieuDoTaiKhoan.MoTa = "Phân bố theo vai trò";
            bieuDoTaiKhoan.Name = "bieuDoTaiKhoan";
            bieuDoTaiKhoan.Size = new Size(635, 170);
            bieuDoTaiKhoan.TabIndex = 1;
            bieuDoTaiKhoan.TieuDe = "Cơ cấu tài khoản";
            // 
            // bieuDoQuyChuan
            // 
            bieuDoQuyChuan.BackColor = Color.White;
            bieuDoQuyChuan.Dock = DockStyle.Fill;
            bieuDoQuyChuan.Font = new Font("Segoe UI", 9F);
            bieuDoQuyChuan.ForeColor = Color.FromArgb(35, 55, 78);
            bieuDoQuyChuan.Location = new Point(6, 129);
            bieuDoQuyChuan.Margin = new Padding(6);
            bieuDoQuyChuan.MinimumSize = new Size(240, 170);
            bieuDoQuyChuan.MoTa = "Số lượng quy chuẩn theo số tháng";
            bieuDoQuyChuan.Name = "bieuDoQuyChuan";
            bieuDoQuyChuan.Size = new Size(635, 170);
            bieuDoQuyChuan.TabIndex = 2;
            bieuDoQuyChuan.TieuDe = "Quy chuẩn theo chu kỳ";
            // 
            // bieuDoCuaHang
            // 
            bieuDoCuaHang.BackColor = Color.White;
            bieuDoCuaHang.Dock = DockStyle.Fill;
            bieuDoCuaHang.Font = new Font("Segoe UI", 9F);
            bieuDoCuaHang.ForeColor = Color.FromArgb(35, 55, 78);
            bieuDoCuaHang.LoaiBieuDo = LoaiBieuDoThongKe.Tron;
            bieuDoCuaHang.Location = new Point(653, 129);
            bieuDoCuaHang.Margin = new Padding(6);
            bieuDoCuaHang.MinimumSize = new Size(240, 170);
            bieuDoCuaHang.MoTa = "Phân bố cửa hàng theo trạng thái";
            bieuDoCuaHang.Name = "bieuDoCuaHang";
            bieuDoCuaHang.Size = new Size(635, 170);
            bieuDoCuaHang.TabIndex = 3;
            bieuDoCuaHang.TieuDe = "Trạng thái cửa hàng";
            // 
            // UcDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            Controls.Add(tlpTongQuan);
            Name = "UcDashboard";
            Size = new Size(1330, 481);
            tlpTongQuan.ResumeLayout(false);
            pnlTieuDe.ResumeLayout(false);
            pnlTieuDe.PerformLayout();
            tlpTheThongKe.ResumeLayout(false);
            pnlCardHangXe.ResumeLayout(false);
            pnlCardDongXe.ResumeLayout(false);
            pnlCardQuyChuan.ResumeLayout(false);
            pnlCardTaiKhoan.ResumeLayout(false);
            tlpBieuDo.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}

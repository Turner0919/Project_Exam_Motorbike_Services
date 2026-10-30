
namespace MotorbikeServices.GUI.Setup
{
    partial class FormNhapTaiKhoan
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblVaiTro;
        private System.Windows.Forms.Label lblTenTaiKhoan;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblXacNhanMatKhau;
        private System.Windows.Forms.TextBox txtXacNhanMatKhau;
        private System.Windows.Forms.Label lblGhiChuMatKhau;
        private System.Windows.Forms.Label lblCauHoi;
        private System.Windows.Forms.TextBox txtCauHoi;
        private System.Windows.Forms.Label lblDapAn;
        private System.Windows.Forms.TextBox txtDapAn;
        private System.Windows.Forms.GroupBox grpThongTinUser;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.CheckBox chkNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTieuDe = new System.Windows.Forms.Label();
            lblVaiTro = new System.Windows.Forms.Label();
            lblTenTaiKhoan = new System.Windows.Forms.Label();
            txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            lblMatKhau = new System.Windows.Forms.Label();
            txtMatKhau = new System.Windows.Forms.TextBox();
            lblXacNhanMatKhau = new System.Windows.Forms.Label();
            txtXacNhanMatKhau = new System.Windows.Forms.TextBox();
            lblGhiChuMatKhau = new System.Windows.Forms.Label();
            lblCauHoi = new System.Windows.Forms.Label();
            txtCauHoi = new System.Windows.Forms.TextBox();
            lblDapAn = new System.Windows.Forms.Label();
            txtDapAn = new System.Windows.Forms.TextBox();
            grpThongTinUser = new System.Windows.Forms.GroupBox();
            lblHoTen = new System.Windows.Forms.Label();
            txtHoTen = new System.Windows.Forms.TextBox();
            lblNgaySinh = new System.Windows.Forms.Label();
            dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            chkNgaySinh = new System.Windows.Forms.CheckBox();
            lblGioiTinh = new System.Windows.Forms.Label();
            cboGioiTinh = new System.Windows.Forms.ComboBox();
            lblSoDienThoai = new System.Windows.Forms.Label();
            txtSoDienThoai = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            btnLuu = new System.Windows.Forms.Button();
            btnHuy = new System.Windows.Forms.Button();

            grpThongTinUser.SuspendLayout();
            SuspendLayout();

            // Form
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(560, 700);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Thông tin tài khoản";

            // Title
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(25, 45, 80);
            lblTieuDe.Location = new System.Drawing.Point(25, 20);
            lblTieuDe.Text = "THÊM TÀI KHOẢN";

            lblVaiTro.AutoSize = true;
            lblVaiTro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblVaiTro.Location = new System.Drawing.Point(30, 65);
            lblVaiTro.Text = "Vai trò: User";

            // Account
            lblTenTaiKhoan.AutoSize = true;
            lblTenTaiKhoan.Location = new System.Drawing.Point(30, 105);
            lblTenTaiKhoan.Text = "Tên tài khoản:";

            txtTenTaiKhoan.Location = new System.Drawing.Point(190, 100);
            txtTenTaiKhoan.Size = new System.Drawing.Size(330, 27);

            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new System.Drawing.Point(30, 145);
            lblMatKhau.Text = "Mật khẩu:";

            txtMatKhau.Location = new System.Drawing.Point(190, 140);
            txtMatKhau.Size = new System.Drawing.Size(330, 27);
            txtMatKhau.UseSystemPasswordChar = true;

            lblXacNhanMatKhau.AutoSize = true;
            lblXacNhanMatKhau.Location = new System.Drawing.Point(30, 185);
            lblXacNhanMatKhau.Text = "Xác nhận mật khẩu:";

            txtXacNhanMatKhau.Location = new System.Drawing.Point(190, 180);
            txtXacNhanMatKhau.Size = new System.Drawing.Size(330, 27);
            txtXacNhanMatKhau.UseSystemPasswordChar = true;

            lblGhiChuMatKhau.AutoSize = true;
            lblGhiChuMatKhau.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblGhiChuMatKhau.ForeColor = System.Drawing.Color.Gray;
            lblGhiChuMatKhau.Location = new System.Drawing.Point(190, 210);
            lblGhiChuMatKhau.Text = "";

            // Security question
            lblCauHoi.AutoSize = true;
            lblCauHoi.Location = new System.Drawing.Point(30, 245);
            lblCauHoi.Text = "Câu hỏi bảo mật:";

            txtCauHoi.Location = new System.Drawing.Point(190, 240);
            txtCauHoi.Size = new System.Drawing.Size(330, 27);

            lblDapAn.AutoSize = true;
            lblDapAn.Location = new System.Drawing.Point(30, 285);
            lblDapAn.Text = "Đáp án bảo mật:";

            txtDapAn.Location = new System.Drawing.Point(190, 280);
            txtDapAn.Size = new System.Drawing.Size(330, 27);

            // User profile
            grpThongTinUser.Location = new System.Drawing.Point(25, 325);
            grpThongTinUser.Size = new System.Drawing.Size(510, 265);
            grpThongTinUser.Text = "Thông tin cá nhân";

            lblHoTen.AutoSize = true;
            lblHoTen.Location = new System.Drawing.Point(15, 35);
            lblHoTen.Text = "Họ tên:";

            txtHoTen.Location = new System.Drawing.Point(145, 30);
            txtHoTen.Size = new System.Drawing.Size(340, 27);

            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new System.Drawing.Point(15, 75);
            lblNgaySinh.Text = "Ngày sinh:";

            chkNgaySinh.AutoSize = true;
            chkNgaySinh.Location = new System.Drawing.Point(145, 75);
            chkNgaySinh.Text = "Có ngày sinh";
            chkNgaySinh.Checked = false;

            dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new System.Drawing.Point(270, 70);
            dtpNgaySinh.Size = new System.Drawing.Size(215, 27);
            dtpNgaySinh.Enabled = false;
            chkNgaySinh.CheckedChanged += (s, e) =>
            {
                dtpNgaySinh.Enabled = chkNgaySinh.Checked;
            };

            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new System.Drawing.Point(15, 115);
            lblGioiTinh.Text = "Giới tính:";

            cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboGioiTinh.Location = new System.Drawing.Point(145, 110);
            cboGioiTinh.Size = new System.Drawing.Size(340, 27);

            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Location = new System.Drawing.Point(15, 155);
            lblSoDienThoai.Text = "Số điện thoại:";

            txtSoDienThoai.Location = new System.Drawing.Point(145, 150);
            txtSoDienThoai.Size = new System.Drawing.Size(340, 27);

            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(15, 195);
            lblEmail.Text = "Email:";

            txtEmail.Location = new System.Drawing.Point(145, 190);
            txtEmail.Size = new System.Drawing.Size(340, 27);

            grpThongTinUser.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                lblHoTen, txtHoTen,
                lblNgaySinh, chkNgaySinh, dtpNgaySinh,
                lblGioiTinh, cboGioiTinh,
                lblSoDienThoai, txtSoDienThoai,
                lblEmail, txtEmail
            });

            // Buttons
            btnLuu.BackColor = System.Drawing.Color.FromArgb(25, 45, 80);
            btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.ForeColor = System.Drawing.Color.White;
            btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnLuu.Location = new System.Drawing.Point(300, 620);
            btnLuu.Size = new System.Drawing.Size(105, 38);
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;

            btnHuy.BackColor = System.Drawing.Color.LightGray;
            btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnHuy.Location = new System.Drawing.Point(415, 620);
            btnHuy.Size = new System.Drawing.Size(105, 38);
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;

            Controls.AddRange(new System.Windows.Forms.Control[]
            {
                lblTieuDe, lblVaiTro,
                lblTenTaiKhoan, txtTenTaiKhoan,
                lblMatKhau, txtMatKhau,
                lblXacNhanMatKhau, txtXacNhanMatKhau,
                lblGhiChuMatKhau,
                lblCauHoi, txtCauHoi,
                lblDapAn, txtDapAn,
                grpThongTinUser,
                btnLuu, btnHuy
            });

            grpThongTinUser.ResumeLayout(false);
            grpThongTinUser.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

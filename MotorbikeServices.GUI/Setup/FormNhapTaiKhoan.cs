using System;
using System.Windows.Forms;

namespace MotorbikeServices.GUI.Setup
{
    public partial class FormNhapTaiKhoan : Form
    {
        private readonly bool laSua;

        public string VaiTro { get; private set; }
        public string TenTaiKhoan => txtTenTaiKhoan.Text.Trim();
        public string MatKhau => txtMatKhau.Text;
        public string XacNhanMatKhau => txtXacNhanMatKhau.Text;
        public string CauHoiBaoMat => txtCauHoi.Text.Trim();
        public string DapAnBaoMat => txtDapAn.Text.Trim();
        public string HoTen => txtHoTen.Text.Trim();
        public DateTime? NgaySinh =>
            chkNgaySinh.Checked ? dtpNgaySinh.Value.Date : null;
        public string GioiTinh =>
            cboGioiTinh.SelectedItem?.ToString() ?? "";
        public string SoDienThoai => txtSoDienThoai.Text.Trim();
        public string Email => txtEmail.Text.Trim();

        public FormNhapTaiKhoan(string vaiTro, bool laSua = false)
        {
            InitializeComponent();

            this.laSua = laSua;
            VaiTro = vaiTro;

            lblTieuDe.Text = laSua
                ? "CẬP NHẬT TÀI KHOẢN"
                : "THÊM TÀI KHOẢN";
            lblVaiTro.Text = "Vai trò: " + vaiTro;

            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cboGioiTinh.SelectedIndex = 0;
            chkNgaySinh.CheckedChanged += chkNgaySinh_CheckedChanged;
            bool laUser = vaiTro == "User";
            lblCauHoi.Visible = laUser;
            txtCauHoi.Visible = laUser;
            lblDapAn.Visible = laUser;
            txtDapAn.Visible = laUser;
            grpThongTinUser.Visible = laUser;

            // Cả Admin và User đều sửa được tên đăng nhập/mật khẩu.
            txtTenTaiKhoan.ReadOnly = false;
            txtMatKhau.ReadOnly = false;
            txtXacNhanMatKhau.ReadOnly = false;

            if (laSua)
            {
                lblMatKhau.Text = "Mật khẩu mới:";
                lblXacNhanMatKhau.Text = "Xác nhận mật khẩu:";
                lblGhiChuMatKhau.Text =
                    "Để trống cả hai ô nếu không muốn đổi mật khẩu.";
            }
            else
            {
                lblGhiChuMatKhau.Text =
                    "Mật khẩu phải có ít nhất 8 ký tự.";
            }

            btnLuu.Click += btnLuu_Click;
            btnHuy.Click += (s, e) =>
            {
                DialogResult = DialogResult.Cancel;
                Close();
            };
        }

        private void chkNgaySinh_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgaySinh.Enabled = chkNgaySinh.Checked;
        }

        public void GanThongTin(
            string tenTaiKhoan,
            string? hoTen = null,
            DateTime? ngaySinh = null,
            string? gioiTinh = null,
            string? soDienThoai = null,
            string? email = null,
            string? cauHoi = null,
            string? dapAn = null)
        {
            txtTenTaiKhoan.Text = tenTaiKhoan;
            txtMatKhau.Clear();
            txtXacNhanMatKhau.Clear();

            txtHoTen.Text = hoTen ?? "";
            txtSoDienThoai.Text = soDienThoai ?? "";
            txtEmail.Text = email ?? "";
            txtCauHoi.Text = cauHoi ?? "";
            txtDapAn.Text = dapAn ?? "";

            if (ngaySinh.HasValue)
            {
                chkNgaySinh.Checked = true;
                dtpNgaySinh.Value = ngaySinh.Value;
            }
            else
            {
                chkNgaySinh.Checked = false;
            }

            if (!string.IsNullOrWhiteSpace(gioiTinh))
            {
                int index = cboGioiTinh.Items.IndexOf(gioiTinh);
                if (index >= 0)
                    cboGioiTinh.SelectedIndex = index;
            }
        }

        private void btnLuu_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TenTaiKhoan))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản.");
                txtTenTaiKhoan.Focus();
                return;
            }

            if (TenTaiKhoan.Length > 50)
            {
                MessageBox.Show("Tên tài khoản không được vượt quá 50 ký tự.");
                txtTenTaiKhoan.Focus();
                return;
            }

            bool coNhapMatKhau =
                !string.IsNullOrWhiteSpace(MatKhau) ||
                !string.IsNullOrWhiteSpace(XacNhanMatKhau);

            if (!laSua || coNhapMatKhau)
            {
                if (string.IsNullOrWhiteSpace(MatKhau) || MatKhau.Length < 8)
                {
                    MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự.");
                    txtMatKhau.Focus();
                    return;
                }

                if (MatKhau != XacNhanMatKhau)
                {
                    MessageBox.Show("Mật khẩu xác nhận không khớp.");
                    txtXacNhanMatKhau.Focus();
                    return;
                }
            }

            if (VaiTro == "User")
            {
                if (string.IsNullOrWhiteSpace(CauHoiBaoMat) ||
                    string.IsNullOrWhiteSpace(DapAnBaoMat))
                {
                    MessageBox.Show(
                        "Vui lòng nhập câu hỏi và đáp án bảo mật.");
                    return;
                }

                if (HoTen.Length > 100 ||
                    SoDienThoai.Length > 15 ||
                    Email.Length > 100)
                {
                    MessageBox.Show(
                        "Thông tin cá nhân vượt quá độ dài cho phép.");
                    return;
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

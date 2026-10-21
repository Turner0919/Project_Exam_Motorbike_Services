using System;
using System.Windows.Forms;

namespace MotorbikeServices.GUI
{
    public partial class frmThemHangXe : Form
    {
        public string TenHangMoi { get; private set; } = string.Empty;
        public string? QuocGiaMoi { get; private set; }

        public frmThemHangXe()
        {
            InitializeComponent();
        }

        // Constructor nạp chồng (Overloaded Constructor) dùng cho chức năng Sửa
        public frmThemHangXe(string tenHangHienTai, string? quocGiaHienTai) : this()
        {
            Text = "Cập nhật thông tin hãng xe";
            btnLuu.Text = "Cập nhật";

            txtTenHang.Text = tenHangHienTai;
            txtQuocGia.Text = quocGiaHienTai ?? string.Empty;
        }

        private void BtnLuu_Click(object? sender, EventArgs e)
        {
            string tenHang = txtTenHang.Text.Trim();
            string quocGia = txtQuocGia.Text.Trim();

            if (string.IsNullOrEmpty(tenHang))
            {
                MessageBox.Show("Tên hãng xe không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHang.Focus();
                return;
            }

            if (tenHang.Length > 100)
            {
                MessageBox.Show("Tên hãng xe không được vượt quá 100 ký tự!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHang.Focus();
                return;
            }

            if (quocGia.Length > 100)
            {
                MessageBox.Show("Tên quốc gia không được vượt quá 100 ký tự!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuocGia.Focus();
                return;
            }

            TenHangMoi = tenHang;
            QuocGiaMoi = string.IsNullOrEmpty(quocGia) ? null : quocGia;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnHuy_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
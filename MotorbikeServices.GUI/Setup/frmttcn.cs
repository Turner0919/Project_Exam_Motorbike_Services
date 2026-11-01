using MotorbikeServices.BLL.Services;
using MotorbikeServices.DAL.Models.Account;
using MotorbikeServices.DAL.Models.Maintenance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.EntityFrameworkCore;

namespace MotorbikeServices.GUI.Setup
{
    public partial class frmttcn : Form
    {
        private readonly UserService _userService = new UserService();
        private readonly int _currentUserId;
        private bool _isBinding = false;
        public frmttcn(int userId)
        {
            InitializeComponent();
            _currentUserId = userId;
        }
        public frmttcn()
        {
            InitializeComponent();
        }
        private void frmttcn_Load(object sender, EventArgs e)
        {
            // 1. Cấu hình 2 ô TextBox chỉ xem, không sửa thủ công
            txtTinhTP.ReadOnly = true;
            txtPhuong.ReadOnly = true;

            // 2. Load thông tin người dùng từ SQL lên Form trước
            LoadUserProfile();

            // 3. Nạp danh sách Tỉnh/TP vào ComboBox để sẵn sàng cho việc chọn/sửa đổi
            LoadComboboxTinhTP();
        }
        private void LoadComboboxTinhTP()
        {
            _isBinding = true;
            var dsTinh = _userService.GetDanhSachTinhTP();
            cboTinhTP.DataSource = dsTinh;
            cboTinhTP.SelectedIndex = -1; // Đảm bảo ComboBox Tỉnh luôn trống khi mới nạp
            cboPhuong.DataSource = null;   // Đảm bảo ComboBox Phường cũng trống hoàn toàn
            _isBinding = false;
        }

        private void cboTinhTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isBinding || cboTinhTP.SelectedItem == null) return;

            string tinhChon = cboTinhTP.SelectedItem.ToString()!;

            // Cập nhật tên Tỉnh mới chọn vào TextBox
            txtTinhTP.Text = tinhChon;
            txtPhuong.Clear(); // Xóa tên Phường cũ

            var dsPhuong = _userService.GetDanhSachPhuongByTinh(tinhChon);

            _isBinding = true;
            cboPhuong.DataSource = dsPhuong;
            cboPhuong.DisplayMember = "PhuongXa";
            cboPhuong.ValueMember = "Id";
            cboPhuong.SelectedIndex = -1;
            _isBinding = false;
        }
        // Sự kiện khi chọn Phường/Xã trên ComboBox
        private void cboPhuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isBinding || cboPhuong.SelectedItem == null) return;

            if (cboPhuong.SelectedItem is DiaChi diaChi)
            {
                txtPhuong.Text = diaChi.PhuongXa; // Cập nhật tên Phường mới vào TextBox
            }
        }
        // 1. Tải dữ liệu lên Form khi mở
        private void LoadUserProfile()
        {
            if (_currentUserId <= 0) return;

            var profile = _userService.GetUserProfile(_currentUserId);
            if (profile == null) return;

            // Nạp thông tin cá nhân cơ bản
            txtHoTen.Text = profile.HoTen ?? "";
            if (profile.NgaySinh.HasValue) dtpNgaySinh.Value = profile.NgaySinh.Value;
            rdoNam.Checked = profile.GioiTinh == "Nam";
            rdoNu.Checked = profile.GioiTinh == "Nữ";
            txtSoDienThoai.Text = profile.SoDienThoai ?? "";
            txtEmail.Text = profile.Email ?? "";

            txtTenDuong.Text = profile.TenDuong ?? "";
            txtSoNha.Text = profile.SoNha ?? "";

            // NẠP ĐỊA CHỈ TỪ SQL VÀO 2 Ô TEXTBOX (Có dữ liệu thì hiện)
            if (profile.DiaChi != null)
            {
                txtTinhTP.Text = profile.DiaChi.TinhTP ?? "";
                txtPhuong.Text = profile.DiaChi.PhuongXa ?? "";
            }
            else
            {
                txtTinhTP.Text = "";
                txtPhuong.Text = "";
            }

            // ĐẢM BẢO 2 COMBOBOX VẪN TRẮNG RỖNG KHI MỚI VÀO FORM
            _isBinding = true;
            cboTinhTP.SelectedIndex = -1;
            cboPhuong.DataSource = null;
            _isBinding = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            if (_currentUserId <= 0)
            {
                MessageBox.Show("Phiên làm việc không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int? diaChiId = null;

            // 1. Ưu tiên lấy Id từ ComboBox Phường nếu người dùng vừa chọn mới
            if (cboPhuong.SelectedItem is DiaChi diaChiSelected)
            {
                diaChiId = diaChiSelected.Id;
            }
            else if (cboPhuong.SelectedValue != null && int.TryParse(cboPhuong.SelectedValue.ToString(), out int parsedId))
            {
                diaChiId = parsedId;
            }
            else
            {
                // 2. Nếu người dùng không mở ComboBox chọn lại -> Giữ nguyên DiaChiId cũ từ Database
                var profileHienTai = _userService.GetUserProfile(_currentUserId);
                diaChiId = profileHienTai?.DiaChiId;
            }

            string gioiTinh = rdoNam.Checked ? "Nam" : (rdoNu.Checked ? "Nữ" : "");

            bool isSuccess = _userService.SaveOrUpdateProfile(
                _currentUserId,
                txtHoTen.Text,
                dtpNgaySinh.Value,
                gioiTinh,
                txtSoDienThoai.Text,
                txtEmail.Text,
                diaChiId,
                txtTenDuong.Text,
                txtSoNha.Text
            );

            if (isSuccess)
            {
                MessageBox.Show("Cập nhật thông tin cá nhân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUserProfile(); // Tải lại dữ liệu từ CSDL để kiểm tra hiển thị đồng bộ
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

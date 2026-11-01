using MotorbikeServices.BLL.DTOs;
using MotorbikeServices.BLL.Services;
using MotorbikeServices.DAL.Models.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MotorbikeServices.GUI.Setup.CuaHang
{
    public partial class FormThongTinCuaHang : Form
    {
        private readonly NhanVienUseService _service = new NhanVienUseService();
        private readonly int _nhanVienId;
        private bool _isBinding = false;
        public FormThongTinCuaHang(int nhanVienId)
        {
            InitializeComponent();
            _nhanVienId = nhanVienId;
        }

        private void FormThongTinCuaHang_Load(object sender, EventArgs e)
        {
            LoadComboboxTinhTP();
            LoadComboboxTrangThai();
            LoadThongTinCuaHang();
        }
        private void LoadComboboxTrangThai()
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Đang hoạt động");
            cboTrangThai.Items.Add("Tạm ngừng hoạt động");
            cboTrangThai.SelectedIndex = 0;
        }
        private void LoadComboboxTinhTP()
        {
            _isBinding = true;
            var dsTinh = _service.GetDanhSachTinhTP();
            cboTinhTP.DataSource = dsTinh;
            cboTinhTP.SelectedIndex = -1;
            _isBinding = false;
        }
        private void cboTinhTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isBinding || cboTinhTP.SelectedItem == null) return;

            string tinhDuocChon = cboTinhTP.SelectedItem.ToString()!;
            var dsPhuong = _service.GetDanhSachPhuongByTinh(tinhDuocChon);

            cboPhuong.DataSource = dsPhuong;
            cboPhuong.DisplayMember = "PhuongXa";
            cboPhuong.ValueMember = "Id";
            cboPhuong.SelectedIndex = -1;
        }
        private void LoadThongTinCuaHang()
        {
            if (_nhanVienId <= 0) return;

            var info = _service.GetThongTinCuaHang(_nhanVienId);
            if (info == null) return;

            lblTaiKhoan.Text = info.TenTaiKhoan;
            txtTenCuaHang.Text = info.TenCuaHang;
            cboTrangThai.SelectedItem = string.IsNullOrEmpty(info.TrangThai) ? "Đang hoạt động" : info.TrangThai;
            txtTenDuong.Text = info.TenDuong;
            txtSoCuaHang.Text = info.SoCuaHang;

            if (!string.IsNullOrEmpty(info.TinhTP))
            {
                _isBinding = true;
                cboTinhTP.SelectedItem = info.TinhTP;

                var dsPhuong = _service.GetDanhSachPhuongByTinh(info.TinhTP);
                cboPhuong.DataSource = dsPhuong;
                cboPhuong.DisplayMember = "PhuongXa";
                cboPhuong.ValueMember = "Id";

                if (info.DiaChiId.HasValue)
                    cboPhuong.SelectedValue = info.DiaChiId.Value;
                else
                    cboPhuong.SelectedIndex = -1;

                _isBinding = false;
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_nhanVienId <= 0)
            {
                MessageBox.Show("Không tìm thấy thông tin tài khoản nhân viên đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboPhuong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Tỉnh/TP và Phường/Xã hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new NhanVienUseDTO
            {
                NhanVienId = _nhanVienId,
                TenCuaHang = txtTenCuaHang.Text,
                TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "Đang hoạt động",
                DiaChiId = (int)cboPhuong.SelectedValue,
                TenDuong = txtTenDuong.Text,
                SoCuaHang = txtSoCuaHang.Text
            };

            var res = _service.CapNhatThongTinCuaHang(dto);
            MessageBox.Show(res.Message, "Thông báo", MessageBoxButtons.OK, res.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        }
    }
}

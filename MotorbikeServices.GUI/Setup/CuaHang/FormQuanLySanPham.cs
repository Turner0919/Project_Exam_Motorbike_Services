using MotorbikeServices.BLL.DTOs;
using MotorbikeServices.BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MotorbikeServices.GUI.Setup.CuaHang
{
    public partial class FormQuanLySanPham : Form
    {
        private readonly SanPhamService _spService = new SanPhamService();
        private readonly int _currentNhanVienId;
        private int _selectedSpId = -1;
        public FormQuanLySanPham(int nhanVienId)
        {
            InitializeComponent();
            _currentNhanVienId = nhanVienId;
        }

        private void FormQuanLySanPham_Load(object sender, EventArgs e)
        {
            dgvDanhSachSanPham.AutoGenerateColumns = false;

            if (dgvDanhSachSanPham.Columns.Count >= 4)
            {
                dgvDanhSachSanPham.Columns[0].DataPropertyName = nameof(SanPhamDTO.MaSP);
                dgvDanhSachSanPham.Columns[1].DataPropertyName = nameof(SanPhamDTO.TenSanPham);
                dgvDanhSachSanPham.Columns[2].DataPropertyName = nameof(SanPhamDTO.DonGia);
                dgvDanhSachSanPham.Columns[3].DataPropertyName = nameof(SanPhamDTO.SoLuongTon);

                dgvDanhSachSanPham.Columns[2].DefaultCellStyle.Format = "#,##0 VNĐ";
            }

            dgvDanhSachSanPham.DefaultCellStyle.ForeColor = Color.Black;
            dgvDanhSachSanPham.DefaultCellStyle.BackColor = Color.White;
            dgvDanhSachSanPham.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvDanhSachSanPham.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);

            LoadDataGrid();
            ResetForm();
        }
        private void LoadDataGrid()
        {
            if (_currentNhanVienId <= 0) return;

            var list = _spService.GetSanPhamByNhanVien(_currentNhanVienId);

            dgvDanhSachSanPham.DataSource = null;
            dgvDanhSachSanPham.DataSource = list;

            lblTongSoSanPham.Text = $"Tổng số sản phẩm: {list.Count}";
            dgvDanhSachSanPham.ClearSelection();
        }
        private void dgvDanhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDanhSachSanPham.Rows[e.RowIndex].DataBoundItem is SanPhamDTO sp)
            {
                _selectedSpId = sp.Id;

                txtMaSP.Text = sp.MaSP;
                txtMaSP.Enabled = false; // KHÓA CỘT MÃ SẢN PHẨM KHÔNG CHO SỬA

                txtTenSanPham.Text = sp.TenSanPham;
                txtDonGia.Text = sp.DonGia.ToString("G0");
                txtSoLuongTon.Text = sp.SoLuongTon.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (_currentNhanVienId <= 0)
            {
                MessageBox.Show("Phiên làm việc nhân viên không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!txtMaSP.Enabled)
            {
                MessageBox.Show("Mã sản phẩm đã chọn không thể thêm đè! Vui lòng bấm 'Làm Mới' để nhập sản phẩm mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtDonGia.Text, out decimal donGia) || !int.TryParse(txtSoLuongTon.Text, out int slTon))
            {
                MessageBox.Show("Đơn giá và Số lượng tồn phải là số hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var res = _spService.ThemSanPham(_currentNhanVienId, txtMaSP.Text, txtTenSanPham.Text, donGia, slTon);
            MessageBox.Show(res.Message, "Thông báo", MessageBoxButtons.OK, res.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (res.IsSuccess)
            {
                LoadDataGrid();
                ResetForm();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_selectedSpId == -1)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa từ danh sách bên phải!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtDonGia.Text, out decimal donGia) || !int.TryParse(txtSoLuongTon.Text, out int slTon))
            {
                MessageBox.Show("Đơn giá và Số lượng tồn phải là số hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi hàm sửa (chỉ truyền Tên, Đơn giá và Số lượng)
            var res = _spService.SuaSanPham(_selectedSpId, txtTenSanPham.Text, donGia, slTon);
            MessageBox.Show(res.Message, "Thông báo", MessageBoxButtons.OK, res.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (res.IsSuccess)
            {
                LoadDataGrid();
                ResetForm();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedSpId == -1)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm [{txtMaSP.Text}] này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                var res = _spService.XoaSanPham(_selectedSpId);
                MessageBox.Show(res.Message, "Thông báo", MessageBoxButtons.OK, res.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                if (res.IsSuccess)
                {
                    LoadDataGrid();
                    ResetForm(); // Xóa thành công xong sẽ mở lại ô txtMaSP để người dùng có thể thêm lại mã đó nếu muốn
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
            ResetForm();
        }
        private void ResetForm()
        {
            _selectedSpId = -1;
            txtMaSP.Clear();
            txtMaSP.Enabled = true; // MỞ LẠI Ô NHẬP MÃ SẢN PHẨM

            txtTenSanPham.Clear();
            txtDonGia.Clear();
            txtSoLuongTon.Clear();
        }
        private void dgvSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                e.CellStyle.ForeColor = Color.Black;
            }
        }
    }
}

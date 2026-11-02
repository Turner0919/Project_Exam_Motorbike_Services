using MotorbikeServices.BLL.DTOs;
using MotorbikeServices.BLL.Services;
using MotorbikeServices.DAL.Models.Maintenance;
using MotorbikeServices.DAL.Models.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MotorbikeServices.GUI.Setup
{
    public partial class frmDangKyBaoDuongXe : Form
    {
        private readonly BaoDuongService _baoDuongService = new BaoDuongService();
        private readonly UserService _userService = new UserService();
        private readonly int _currentUserId;
        private List<UserXe> _dsXeUser = new List<UserXe>();
        private List<NhanVienUse> _dsCuaHang = new List<NhanVienUse>();
        private List<SanPham> _dsSanPham = new List<SanPham>();
        private List<BaoDuongItemDTO> _gioHang = new List<BaoDuongItemDTO>();
        private int _selectedCuaHangId = -1;
        private bool _isBinding = false;
        public frmDangKyBaoDuongXe(int userId)
        {
            InitializeComponent();
            _currentUserId = userId;
        }
        public frmDangKyBaoDuongXe()
        {
            InitializeComponent();
        }

        private void frmDangKyBaoDuongXe_Load(object sender, EventArgs e)
        {
            InitDataGrids();
            LoadDiaChiAndComboboxes();
            LoadXeUser();

        }
        private void frmDangKyBaoDuongXe_Shown(object sender, EventArgs e) // tránh trường hợp render khi load form
        {
            dgvCuaHang.ClearSelection();
            dgvGioHang.ClearSelection();
        }
        private void InitDataGrids()
        {
            // Grid Cửa Hàng
            dgvCuaHang.AutoGenerateColumns = false;
            if (dgvCuaHang.Columns.Count >= 3)
            {
                dgvCuaHang.Columns[0].DataPropertyName = nameof(NhanVienUse.TenCuaHang);
                dgvCuaHang.Columns[1].DataPropertyName = nameof(NhanVienUse.SoCuaHang);
                dgvCuaHang.Columns[2].DataPropertyName = nameof(NhanVienUse.TenDuong);
            }

            // Grid Hóa Đơn / Giỏ hàng
            dgvGioHang.AutoGenerateColumns = false;
            if (dgvGioHang.Columns.Count >= 6)
            {
                dgvGioHang.Columns[0].DataPropertyName = nameof(BaoDuongItemDTO.HangXe);
                dgvGioHang.Columns[1].DataPropertyName = nameof(BaoDuongItemDTO.LoaiXe);
                dgvGioHang.Columns[2].DataPropertyName = nameof(BaoDuongItemDTO.BienSo);
                dgvGioHang.Columns[3].DataPropertyName = nameof(BaoDuongItemDTO.TenSanPham);
                dgvGioHang.Columns[4].DataPropertyName = nameof(BaoDuongItemDTO.SoLuong);
                dgvGioHang.Columns[5].DataPropertyName = nameof(BaoDuongItemDTO.DonGia);
                dgvGioHang.Columns[5].DefaultCellStyle.Format = "#,##0 VNĐ";
            }
        }
        // 1. Tải Địa chỉ mặc định của User & Nạp ComboBox Tỉnh / Phường
        private void LoadDiaChiAndComboboxes()
        {
            _isBinding = true;
            var dsTinh = _userService.GetDanhSachTinhTP();
            cboTinhTP.DataSource = dsTinh;

            var (tinhUser, phuongUser) = _baoDuongService.GetDiaChiUser(_currentUserId);

            if (!string.IsNullOrEmpty(tinhUser))
            {
                cboTinhTP.SelectedItem = tinhUser;
                var dsPhuong = _userService.GetDanhSachPhuongByTinh(tinhUser);
                cboPhuong.DataSource = dsPhuong;
                cboPhuong.DisplayMember = "PhuongXa";
                cboPhuong.ValueMember = "Id";

                if (!string.IsNullOrEmpty(phuongUser))
                {
                    var itemPhuong = dsPhuong.FirstOrDefault(p => p.PhuongXa == phuongUser);
                    if (itemPhuong != null)
                        cboPhuong.SelectedValue = itemPhuong.Id;
                }
            }
            else
            {
                cboTinhTP.SelectedIndex = -1;
                cboPhuong.DataSource = null;
            }
            _isBinding = false;

            // Tìm danh sách cửa hàng trùng Tỉnh / Phường
            TimKiemCuaHang();
        }
        private void cboTinhTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isBinding || cboTinhTP.SelectedItem == null) return;

            string tinhChon = cboTinhTP.SelectedItem.ToString()!;
            var dsPhuong = _userService.GetDanhSachPhuongByTinh(tinhChon);

            _isBinding = true;
            cboPhuong.DataSource = dsPhuong;
            cboPhuong.DisplayMember = "PhuongXa";
            cboPhuong.ValueMember = "Id";
            cboPhuong.SelectedIndex = -1;
            _isBinding = false;

            TimKiemCuaHang();
        }

        private void cboPhuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isBinding) return;
            TimKiemCuaHang();
        }
        private void TimKiemCuaHang()
        {
            string tinhTP = cboTinhTP.SelectedItem?.ToString() ?? "";
            string phuongXa = "";

            if (cboPhuong.SelectedItem is DiaChi dc)
                phuongXa = dc.PhuongXa;

            if (string.IsNullOrEmpty(tinhTP) || string.IsNullOrEmpty(phuongXa))
            {
                _dsCuaHang.Clear();
            }
            else
            {
                _dsCuaHang = _baoDuongService.GetCuaHangHoatDongByDiaChi(tinhTP, phuongXa);
            }

            dgvCuaHang.DataSource = null;
            dgvCuaHang.DataSource = _dsCuaHang;
            lblSoLuongCuaHang.Text = $"Số Lượng Cửa Hàng Hoạt Động: {_dsCuaHang.Count}";

            _selectedCuaHangId = -1;
            cboSanPham.DataSource = null;
        }
        private void LoadSanPhamCuaHang(int nhanVienId)
        {
            _dsSanPham = _baoDuongService.GetSanPhamByCuaHang(nhanVienId);
            cboSanPham.DataSource = _dsSanPham;
            cboSanPham.DisplayMember = "TenSanPham";
            cboSanPham.ValueMember = "Id";
            if (_dsSanPham.Count > 0) cboSanPham.SelectedIndex = 0;
        }
        // 3. Khi click chọn 1 Cửa hàng trên DataGridView -> Load Sản phẩm của Cửa hàng đó
        private void dgvCuaHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCuaHang.Rows[e.RowIndex].DataBoundItem is NhanVienUse store)
            {
                _selectedCuaHangId = store.NhanVienId;

                // Nếu chọn cửa hàng khác thì hỏi reset giỏ hàng nếu đã lỡ thêm
                if (_gioHang.Count > 0)
                {
                    var confirm = MessageBox.Show("Đổi cửa hàng sẽ làm mới giỏ hàng hiện tại. Bạn có chắc chắn muốn chuyển?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.No) return;

                    ResetGioHang();
                }

                LoadSanPhamCuaHang(_selectedCuaHangId);
            }
        }
        // 4. Load thông tin Xe của User vào ComboBox
        private void LoadXeUser()
        {
            _dsXeUser = _baoDuongService.GetDanhSachXeUser(_currentUserId);

            // Lấy tên Hãng xe thông qua Navigation Property DongXe.HangXe
            var dsHang = _dsXeUser
                .Where(x => x.DongXe != null && x.DongXe.HangXe != null)
                .Select(x => x.DongXe.HangXe.TenHang)
                .Distinct()
                .ToList();

            cboHangXe.DataSource = dsHang;

            if (dsHang.Count > 0)
            {
                cboHangXe.SelectedIndex = 0;
                CapNhatDongXeVaBienSo();
            }
        }
        private void cboHangXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatDongXeVaBienSo();
        }

        private void cboLoaiXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHangXe.SelectedItem == null || cboLoaiXe.SelectedItem == null) return;

            string hang = cboHangXe.SelectedItem.ToString()!;
            string loai = cboLoaiXe.SelectedItem.ToString()!;

            var dsBienSo = _dsXeUser
                .Where(x => x.DongXe != null && x.DongXe.HangXe != null &&
                            x.DongXe.HangXe.TenHang == hang &&
                            x.DongXe.TenDongXe == loai)
                .Select(x => x.BienSoXe)
                .ToList();

            cboBienSo.DataSource = dsBienSo;
        }
        private void CapNhatDongXeVaBienSo()
        {
            if (cboHangXe.SelectedItem == null) return;

            string hangChon = cboHangXe.SelectedItem.ToString()!;

            var dsLoai = _dsXeUser
                .Where(x => x.DongXe != null && x.DongXe.HangXe != null &&
                            x.DongXe.HangXe.TenHang == hangChon)
                .Select(x => x.DongXe.TenDongXe)
                .Distinct()
                .ToList();

            cboLoaiXe.DataSource = dsLoai;

            if (dsLoai.Count > 0)
            {
                cboLoaiXe.SelectedIndex = 0;
                string loaiChon = dsLoai[0];

                var dsBienSo = _dsXeUser
                    .Where(x => x.DongXe != null && x.DongXe.HangXe != null &&
                                x.DongXe.HangXe.TenHang == hangChon &&
                                x.DongXe.TenDongXe == loaiChon)
                    .Select(x => x.BienSoXe)
                    .ToList();

                cboBienSo.DataSource = dsBienSo;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (_selectedCuaHangId <= 0)
            {
                MessageBox.Show("Vui lòng chọn 1 Cửa hàng hoạt động bên phải trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboSanPham.SelectedItem is not SanPham sp)
            {
                MessageBox.Show("Vui lòng chọn Sản phẩm cần dịch vụ/bảo dưỡng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboHangXe.SelectedItem == null || cboLoaiXe.SelectedItem == null || cboBienSo.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn thông tin xe đăng ký bảo dưỡng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hang = cboHangXe.SelectedItem.ToString()!;
            string loai = cboLoaiXe.SelectedItem.ToString()!;
            string bienSo = cboBienSo.SelectedItem.ToString()!;
            int soLuongChon = (int)nudSoLuong.Value;

            // TRỪ KHO TRỰC TIẾP TRONG DATABASE NGAY KHI BẤM THÊM
            var resTruKho = _baoDuongService.TruKhoTamThoi(sp.Id, soLuongChon);
            if (!resTruKho.IsSuccess)
            {
                MessageBox.Show(resTruKho.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nếu trừ kho thành công trong SQL mới cập nhật Giỏ hàng trên GUI
            var existingItem = _gioHang.FirstOrDefault(i =>
                i.SanPhamId == sp.Id &&
                i.BienSo == bienSo &&
                i.HangXe == hang &&
                i.LoaiXe == loai
            );

            if (existingItem != null)
            {
                existingItem.SoLuong += soLuongChon;
            }
            else
            {
                var newItem = new BaoDuongItemDTO
                {
                    HangXe = hang,
                    LoaiXe = loai,
                    BienSo = bienSo,
                    SanPhamId = sp.Id,
                    TenSanPham = sp.TenSanPham,
                    SoLuong = soLuongChon,
                    DonGia = sp.DonGia
                };

                _gioHang.Add(newItem);
            }

            CapNhatGridGioHang();
            LoadSanPhamCuaHang(_selectedCuaHangId);
        }

        private void btnXoaKhoiGio_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow == null || dgvGioHang.CurrentRow.Index < 0 || dgvGioHang.CurrentRow.DataBoundItem is not BaoDuongItemDTO itemXoa)
            {
                MessageBox.Show("Vui lòng chọn 1 sản phẩm/dịch vụ trong giỏ hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa dịch vụ '{itemXoa.TenSanPham}' của xe {itemXoa.BienSo} khỏi giỏ hàng?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // HOÀN TRẢ LẠI SỐ LƯỢNG TỒN VÀO DATABASE
                _baoDuongService.HoanTraKhoTamThoi(itemXoa.SanPhamId, itemXoa.SoLuong);

                _gioHang.Remove(itemXoa);
                CapNhatGridGioHang();
                LoadSanPhamCuaHang(_selectedCuaHangId); // Reload lại ComboBox để thấy SL Tồn được cộng trả lại
                MessageBox.Show("Đã xóa sản phẩm khỏi giỏ hàng và hoàn trả số lượng tồn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CapNhatGridGioHang()
        {
            dgvGioHang.DataSource = null;
            dgvGioHang.DataSource = _gioHang;

            lblSoLuongHoaDon.Text = $"Số Lượng Của Hóa Đơn: {_gioHang.Count}";
            decimal tongTien = _gioHang.Sum(i => i.ThanhTien);
            lblTongTien.Text = $"Tổng tiền: {tongTien:#,##0}đ";
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            if (_gioHang.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm sản phẩm/dịch vụ vào hóa đơn trước khi Đặt hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var res = _baoDuongService.DatHangBaoDuong(_currentUserId, _selectedCuaHangId, _gioHang);
            MessageBox.Show(res.Message, "Thông báo", MessageBoxButtons.OK, res.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (res.IsSuccess)
            {
                ResetGioHang();
                LoadSanPhamCuaHang(_selectedCuaHangId); // Load lại để thấy SL tồn đã giảm
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetGioHang();
            CapNhatGridGioHang();
            LoadSanPhamCuaHang(_selectedCuaHangId);
        }
        private void ResetGioHang()
        {
            _gioHang.Clear();
            CapNhatGridGioHang();
            nudSoLuong.Value = 1;
        }
        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                e.CellStyle.ForeColor = Color.Black;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dgvGioHang.ClearSelection();
        }
        // Hàm dọn dẹp và trả kho nếu người dùng chưa Đặt Hàng
        public void ClearAndRestoreStock()
        {
            if (_gioHang != null && _gioHang.Count > 0)
            {
                foreach (var item in _gioHang)
                {
                    _baoDuongService.HoanTraKhoTamThoi(item.SanPhamId, item.SoLuong);
                }
                _gioHang.Clear();
            }
        }
        private void frmDangKyBaoDuongXe_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClearAndRestoreStock();
        }
    }
}

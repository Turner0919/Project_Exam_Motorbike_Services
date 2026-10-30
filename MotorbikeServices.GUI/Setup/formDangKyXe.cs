using MotorbikeServices.BLL.DTOs;
using MotorbikeServices.BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MotorbikeServices.GUI.Setup
{
    public partial class formDangKyXe : Form
    {
        private readonly UserXeService _userXeService = new UserXeService();
        private readonly int _currentUserId;
        private int _selectedUserXeId = -1; // Lưu Id chiếc xe đang được chọn trên DataGridView
        private bool _isBindingData = false; // Cờ chặn sự kiện cboHangXe_SelectedIndexChanged chạy ngầm
        public formDangKyXe(int userId)
        {
            InitializeComponent();
            _currentUserId = userId;
        }
        public formDangKyXe()
        {
            InitializeComponent();
        }
        private void formDangKyXe_Load(object sender, EventArgs e)
        {
            // 1. Tắt tự động sinh cột
            dgvDanhSachXe.AutoGenerateColumns = false;

            // 2. ÉP BINDING DATA PROPERTY NAME BẰNG CODE (Sửa dứt điểm lỗi trắng ô)
            // Đảm bảo chỉ số cột [0..4] tương ứng đúng thứ tự các cột bạn đã tạo trên Designer
            if (dgvDanhSachXe.Columns.Count >= 5)
            {
                dgvDanhSachXe.Columns[0].DataPropertyName = nameof(UserXeDTO.STT);
                dgvDanhSachXe.Columns[1].DataPropertyName = nameof(UserXeDTO.TenHangXe);
                dgvDanhSachXe.Columns[2].DataPropertyName = nameof(UserXeDTO.TenDongXe);
                dgvDanhSachXe.Columns[3].DataPropertyName = nameof(UserXeDTO.BienSoXe);
                dgvDanhSachXe.Columns[4].DataPropertyName = nameof(UserXeDTO.NgayMuaXe);
            }

            // 3. Đặt màu chữ đen mặc định trên nền trắng
            dgvDanhSachXe.DefaultCellStyle.ForeColor = Color.Black;
            dgvDanhSachXe.DefaultCellStyle.BackColor = Color.White;
            dgvDanhSachXe.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvDanhSachXe.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);

            // 4. Tải dữ liệu
            LoadComboboxHangXe();
            LoadDataGrid();
            ResetForm();
        }
        private void LoadComboboxHangXe() // nap hang xe len combobox
        {
            _isBindingData = true;
            var dsHang = _userXeService.GetDanhSachHangXe();
            cboHangXe.DataSource = dsHang;
            cboHangXe.DisplayMember = "TenHang";
            cboHangXe.ValueMember = "Id";
            cboHangXe.SelectedIndex = -1;
            _isBindingData = false; // Bỏ chặn sự kiện cboHangXe_SelectedIndexChanged
        }
        private void cboHangXe_SelectedIndexChanged(object sender, EventArgs e) // nap dong xe len combobox khi chon hang xe
        {
            if (_isBindingData) return;
            if (cboHangXe.SelectedValue != null && int.TryParse(cboHangXe.SelectedValue.ToString(), out int hangXeId))
            {
                var dsDong = _userXeService.GetDanhSachDongXeByHang(hangXeId);
                cboDongXe.DataSource = dsDong;
                cboDongXe.DisplayMember = "TenDongXe";
                cboDongXe.ValueMember = "Id";
                cboDongXe.SelectedIndex = -1;
            }
            else
            {
                cboDongXe.DataSource = null;
            }
        }
        private void LoadDataGrid()
        {
            if (_currentUserId <= 0) return;

            var dsXe = _userXeService.GetDanhSachXeByUser(_currentUserId);

            dgvDanhSachXe.DataSource = null;
            dgvDanhSachXe.DataSource = dsXe;

            // Đảm bảo ép lại màu cho từng cột thủ công để tránh bị Override từ Designer
            foreach (DataGridViewColumn col in dgvDanhSachXe.Columns)
            {
                col.DefaultCellStyle.ForeColor = Color.Black;
                col.DefaultCellStyle.SelectionForeColor = Color.White;
                col.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            }

            lblTongSoXe.Text = $"Tổng số Chiếc Xe: {dsXe.Count}";

            // Bỏ chọn dòng đầu tiên để xem chữ có hiện trên nền trắng bình thường không
            dgvDanhSachXe.ClearSelection();
        }
        private void dgvDanhSachXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDanhSachXe.Rows[e.RowIndex].DataBoundItem is UserXeDTO xe)
            {
                _selectedUserXeId = xe.Id;

                _isBindingData = true; // Khóa event tạm thời khi đổ dữ liệu ngược về ComboBox
                cboHangXe.SelectedValue = xe.HangXeId;

                var dsDong = _userXeService.GetDanhSachDongXeByHang(xe.HangXeId);
                cboDongXe.DataSource = dsDong;
                cboDongXe.DisplayMember = "TenDongXe";
                cboDongXe.ValueMember = "Id";
                cboDongXe.SelectedValue = xe.DongXeId;
                _isBindingData = false;

                txtBienSoXe.Text = xe.BienSoXe;
                dtpNgayMuaXe.Value = xe.NgayMuaXe;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // 1. Bổ sung kiểm tra UserId
            if (_currentUserId <= 0)
            {
                MessageBox.Show("Phiên làm việc không hợp lệ (UserId không tồn tại)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Bổ sung kiểm tra Hãng/Dòng xe
            if (cboHangXe.SelectedIndex == -1 || cboDongXe.SelectedIndex == -1 || cboDongXe.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Hãng xe và Dòng xe hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Ép kiểu an toàn tránh Crash
            if (!int.TryParse(cboDongXe.SelectedValue.ToString(), out int dongXeId))
            {
                MessageBox.Show("Dòng xe chọn không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string bienSo = txtBienSoXe.Text.Trim();
            DateTime ngayMua = dtpNgayMuaXe.Value;

            var res = _userXeService.ThemXe(_currentUserId, dongXeId, bienSo, ngayMua);
            MessageBox.Show(res.Message, "Thông báo", MessageBoxButtons.OK, res.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (res.IsSuccess)
            {
                LoadDataGrid();
                ResetForm();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_selectedUserXeId == -1)
            {
                MessageBox.Show("Vui lòng chọn chiếc xe cần sửa từ danh sách bên phải!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboDongXe.SelectedValue == null || !int.TryParse(cboDongXe.SelectedValue.ToString(), out int dongXeId))
            {
                MessageBox.Show("Vui lòng chọn Dòng xe hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string bienSo = txtBienSoXe.Text.Trim();
            DateTime ngayMua = dtpNgayMuaXe.Value;

            var res = _userXeService.SuaXe(_selectedUserXeId, dongXeId, bienSo, ngayMua);
            MessageBox.Show(res.Message, "Thông báo", MessageBoxButtons.OK, res.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (res.IsSuccess)
            {
                LoadDataGrid();
                ResetForm();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedUserXeId == -1)
            {
                MessageBox.Show("Vui lòng chọn chiếc xe cần xóa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa chiếc xe này khỏi hệ thống?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                var res = _userXeService.XoaXe(_selectedUserXeId);
                MessageBox.Show(res.Message, "Thông báo", MessageBoxButtons.OK, res.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                if (res.IsSuccess)
                {
                    LoadDataGrid();
                    ResetForm();
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void ResetForm()
        {
            _selectedUserXeId = -1;
            txtBienSoXe.Clear();
            dtpNgayMuaXe.Value = DateTime.Now;
            LoadDataGrid();
            _isBindingData = true;
            cboHangXe.SelectedIndex = -1;
            cboDongXe.DataSource = null;
            _isBindingData = false;
        }
    }
}

using MotorbikeServices.BLL.DTOs;
using MotorbikeServices.BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MotorbikeServices.GUI.Setup.AllUser
{
    public partial class FormQuanLyBaoDuong : Form
    {
        private readonly QuanLyBaoDuongService _service = new QuanLyBaoDuongService();
        private readonly int _currentUserId;
        private List<UserXeDTO> _listXeUser = new List<UserXeDTO>();
        private int _selectedQuyChuanUserNgId = 0; // LƯU ID ĐANG CHỌN TRÊN GRID
        public FormQuanLyBaoDuong(int userId)
        {
            InitializeComponent();
            _currentUserId = userId;
        }
        public FormQuanLyBaoDuong()
        {
            InitializeComponent();
        }

        private void FormQuanLyBaoDuong_Load(object sender, EventArgs e)
        {
            txtHangXe.ReadOnly = true;
            txtLoaiXe.ReadOnly = true;
            txtBienSoXe.ReadOnly = true;
            txtTenQuyChuanDangChon.ReadOnly = true;
            dtpCapNhatNgayBaoDuong.Format = DateTimePickerFormat.Custom;
            dtpCapNhatNgayBaoDuong.CustomFormat = "dd/MM/yyyy";
            InitGridColumns();
            LoadDanhSachXeUser();
        }
        private void InitGridColumns()
        {
            dgvLichBaoDuong.AutoGenerateColumns = false;
            dgvLichBaoDuong.ReadOnly = true;
            dgvLichBaoDuong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLichBaoDuong.AllowUserToAddRows = false;

            if (dgvLichBaoDuong.Columns.Count >= 6)
            {
                dgvLichBaoDuong.Columns[0].DataPropertyName = nameof(LichBaoDuongDTO.STT);
                dgvLichBaoDuong.Columns[1].DataPropertyName = nameof(LichBaoDuongDTO.TenQuyChuan);
                dgvLichBaoDuong.Columns[2].DataPropertyName = nameof(LichBaoDuongDTO.DinhKyBaoDuong);
                dgvLichBaoDuong.Columns[3].DataPropertyName = nameof(LichBaoDuongDTO.NgayBaoDuongLanCuoi);
                dgvLichBaoDuong.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvLichBaoDuong.Columns[4].DataPropertyName = nameof(LichBaoDuongDTO.NgayBaoDuongTiepTheo);
                dgvLichBaoDuong.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvLichBaoDuong.Columns[5].DataPropertyName = nameof(LichBaoDuongDTO.TinhTrang);
            }
        }
        // 1. Load danh sách xe vào ComboBox STT Danh Sách Xe
        private void LoadDanhSachXeUser()
        {
            if (_currentUserId <= 0) return;

            _listXeUser = _service.GetDanhSachXeByUser(_currentUserId);

            // Gỡ tạm sự kiện để không bị trigger khi gán DataSource
            cboSttDanhSachXe.SelectedIndexChanged -= cboSttDanhSachXe_SelectedIndexChanged;

            cboSttDanhSachXe.DataSource = null;
            cboSttDanhSachXe.DataSource = _listXeUser;
            cboSttDanhSachXe.DisplayMember = "STT";
            cboSttDanhSachXe.ValueMember = "Id";

            // Đặt về -1 để trống không chọn xe nào khi vừa mở Form
            cboSttDanhSachXe.SelectedIndex = -1;

            // Gán lại sự kiện
            cboSttDanhSachXe.SelectedIndexChanged += cboSttDanhSachXe_SelectedIndexChanged;

            // Xóa trắng toàn bộ thông tin trên Form
            ClearToanBoForm();

            if (_listXeUser.Count == 0)
            {
                lblThongBaoTrangThai.Text = "Bạn chưa đăng ký chiếc xe nào trong hệ thống!";
                lblThongBaoTrangThai.ForeColor = Color.Red;
            }
        }
        // 2. EVENT: Đổi xe trong ComboBox -> Điền Hãng/Loại/Biển số & Nạp Lịch Bảo Dưỡng
        private void cboSttDanhSachXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSttDanhSachXe.SelectedIndex == -1 || cboSttDanhSachXe.SelectedItem is not UserXeDTO xeChon)
            {
                ClearToanBoForm();
                return;
            }

            txtHangXe.Text = xeChon.TenHangXe;
            txtLoaiXe.Text = xeChon.TenDongXe;
            txtBienSoXe.Text = xeChon.BienSoXe;

            LoadGridLichBaoDuong(xeChon.Id, xeChon.DongXeId);
        }
        private void LoadGridLichBaoDuong(int userXeId, int dongXeId)
        {
            var dsLich = _service.GetLichBaoDuongByXe(userXeId, dongXeId);
            dgvLichBaoDuong.DataSource = null;
            dgvLichBaoDuong.DataSource = dsLich;
            dgvLichBaoDuong.ClearSelection();

            ResetInputForm();

            // Hiển thị thông báo tổng quan
            int soQuaHan = dsLich.Count(l => l.MucDoCanhBao == 2);
            int soSapHan = dsLich.Count(l => l.MucDoCanhBao == 1);

            if (soQuaHan > 0)
            {
                lblThongBaoTrangThai.Text = $"Xe có {soQuaHan} hạng mục QUÁ HẠN bảo dưỡng!";
                lblThongBaoTrangThai.ForeColor = Color.Red;
            }
            else if (soSapHan > 0)
            {
                lblThongBaoTrangThai.Text = $"Xe có {soSapHan} hạng mục SẮP TỚI HẠN bảo dưỡng!";
                lblThongBaoTrangThai.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblThongBaoTrangThai.Text = "Tất cả hạng mục bảo dưỡng đều an toàn!";
                lblThongBaoTrangThai.ForeColor = Color.DarkGreen;
            }
        }
        // 3. EVENT: Bấm chọn 1 dòng quy chuẩn trên DataGridView -> Đổ dữ liệu lên phần Cập Nhật
        private void dgvLichBaoDuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvLichBaoDuong.Rows[e.RowIndex].DataBoundItem is LichBaoDuongDTO item)
            {
                _selectedQuyChuanUserNgId = item.QuyChuanXeNguoiDungId;
                txtTenQuyChuanDangChon.Text = item.TenQuyChuan;
                dtpCapNhatNgayBaoDuong.Value = item.NgayBaoDuongLanCuoi;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (_selectedQuyChuanUserNgId <= 0)
            {
                MessageBox.Show("Vui lòng chọn 1 quy chuẩn dưới bảng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime ngayMoi = dtpCapNhatNgayBaoDuong.Value;
            bool ok = _service.CapNhatNgayBaoDuong(_selectedQuyChuanUserNgId, ngayMoi);

            if (ok)
            {
                MessageBox.Show("Cập nhật ngày bảo dưỡng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (cboSttDanhSachXe.SelectedItem is UserXeDTO xeChon)
                {
                    LoadGridLichBaoDuong(xeChon.Id, xeChon.DongXeId);
                }
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboSttDanhSachXe.SelectedIndex = -1; // Đưa ComboBox về trống
            ClearToanBoForm();
        }
        private void ResetInputForm()
        {
            _selectedQuyChuanUserNgId = 0;
            txtTenQuyChuanDangChon.Clear();
            dtpCapNhatNgayBaoDuong.Value = DateTime.Now;
        }
        private void ClearToanBoForm()
        {
            txtHangXe.Clear();
            txtLoaiXe.Clear();
            txtBienSoXe.Clear();
            ResetInputForm();

            dgvLichBaoDuong.DataSource = null;
            lblThongBaoTrangThai.Text = "Vui lòng chọn STT chiếc xe để kiểm tra lịch bảo dưỡng!";
            lblThongBaoTrangThai.ForeColor = Color.Blue;
        }
        // 6. EVENT: Tô màu tự động từng dòng trên DataGridView
        private void dgvLichBaoDuong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvLichBaoDuong.Rows[e.RowIndex].DataBoundItem is LichBaoDuongDTO item)
            {
                if (item.MucDoCanhBao == 2)
                {
                    dgvLichBaoDuong.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.MistyRose;
                    dgvLichBaoDuong.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkRed;
                }
                else if (item.MucDoCanhBao == 1)
                {
                    dgvLichBaoDuong.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                    dgvLichBaoDuong.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkGoldenrod;
                }
                else
                {
                    dgvLichBaoDuong.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    dgvLichBaoDuong.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }
    }
}

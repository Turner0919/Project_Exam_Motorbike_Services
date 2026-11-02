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
    public partial class FormKiemTraDonDaDat : Form
    {
        private readonly KiemTraDonService _donService = new KiemTraDonService();
        private readonly int _currentUserId;
        private List<HoaDonKiemTraDTO> _dsHoaDon = new List<HoaDonKiemTraDTO>();
        public FormKiemTraDonDaDat(int userId)
        {
            InitializeComponent();
            _currentUserId = userId;
        }
        public FormKiemTraDonDaDat()
        {
            InitializeComponent();
        }

        private void FormKiemTraDonDaDat_Load(object sender, EventArgs e)
        {
            InitGridColumns();
            LoadDanhSachHoaDon();
        }
        // Cấu hình tên thuộc tính mapping cho 2 DataGridView
        private void InitGridColumns()
        {
            // Bảng Hóa Đơn (Bảng trên)
            dgvHoaDon.AutoGenerateColumns = false;
            if (dgvHoaDon.Columns.Count >= 6)
            {
                dgvHoaDon.Columns[0].DataPropertyName = nameof(HoaDonKiemTraDTO.MaHoaDon);
                dgvHoaDon.Columns[1].DataPropertyName = nameof(HoaDonKiemTraDTO.CuaHang);
                dgvHoaDon.Columns[2].DataPropertyName = nameof(HoaDonKiemTraDTO.DiaChiCuaHang);
                dgvHoaDon.Columns[3].DataPropertyName = nameof(HoaDonKiemTraDTO.NgayDat);
                dgvHoaDon.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                dgvHoaDon.Columns[4].DataPropertyName = nameof(HoaDonKiemTraDTO.TongTien);
                dgvHoaDon.Columns[4].DefaultCellStyle.Format = "#,##0 VNĐ";
                dgvHoaDon.Columns[5].DataPropertyName = nameof(HoaDonKiemTraDTO.TrangThai);
            }

            // Bảng Chi Tiết Hóa Đơn (Bảng dưới)
            dgvChiTiet.AutoGenerateColumns = false;
            if (dgvChiTiet.Columns.Count >= 6)
            {
                dgvChiTiet.Columns[0].DataPropertyName = nameof(ChiTietDichVuDTO.STT);
                dgvChiTiet.Columns[1].DataPropertyName = nameof(ChiTietDichVuDTO.TenXe);
                dgvChiTiet.Columns[2].DataPropertyName = nameof(ChiTietDichVuDTO.BienSo);
                dgvChiTiet.Columns[3].DataPropertyName = nameof(ChiTietDichVuDTO.DichVuSanPham);
                dgvChiTiet.Columns[4].DataPropertyName = nameof(ChiTietDichVuDTO.SoLuong);
                dgvChiTiet.Columns[5].DataPropertyName = nameof(ChiTietDichVuDTO.DonGia);
                dgvChiTiet.Columns[5].DefaultCellStyle.Format = "#,##0 VNĐ";
            }
        }
        // Nạp danh sách đơn hàng
        private void LoadDanhSachHoaDon()
        {
            if (_currentUserId <= 0) return;

            _dsHoaDon = _donService.GetDanhSachHoaDonUser(_currentUserId);

            dgvHoaDon.DataSource = null;
            dgvHoaDon.DataSource = _dsHoaDon;

            dgvChiTiet.DataSource = null; // Clear bảng chi tiết

            dgvHoaDon.ClearSelection();
            dgvChiTiet.ClearSelection();
        }
        // 1. EVENT: CHỌN 1 HÒA ĐƠN Ở BẢNG TRÊN -> HIỂN THỊ CHI TIẾT Ở BẢNG DƯỚI
        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvHoaDon.Rows[e.RowIndex].DataBoundItem is HoaDonKiemTraDTO hdChon)
            {
                dgvChiTiet.DataSource = null;
                dgvChiTiet.DataSource = hdChon.ChiTiets;
                dgvChiTiet.ClearSelection();
            }
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow == null || dgvHoaDon.CurrentRow.Index < 0 || dgvHoaDon.CurrentRow.DataBoundItem is not HoaDonKiemTraDTO hdChon)
            {
                MessageBox.Show("Vui lòng chọn 1 hóa đơn cần hủy trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trước trên GUI
            if (hdChon.TrangThai != "Chờ xác nhận")
            {
                MessageBox.Show($"Không thể hủy đơn hàng này! Đơn hàng đang ở trạng thái '{hdChon.TrangThai}'. Cửa hàng đã tiếp nhận hoặc đã hoàn thành.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hỏi xác nhận
            DialogResult dialog = MessageBox.Show(
                $"Bạn có chắc chắn muốn hủy Đơn hàng #{hdChon.MaHoaDon} tại cửa hàng '{hdChon.CuaHang}'?",
                "Xác nhận hủy đơn",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialog == DialogResult.Yes)
            {
                var result = _donService.HuyDonHang(hdChon.MaHoaDon, _currentUserId);

                MessageBox.Show(result.Message, "Thông báo", MessageBoxButtons.OK, result.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                if (result.IsSuccess)
                {
                    LoadDanhSachHoaDon(); // Tải lại danh sách sau khi hủy thành công
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDanhSachHoaDon();
        }
        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                e.CellStyle.ForeColor = Color.Black;
            }
        }
    }
}

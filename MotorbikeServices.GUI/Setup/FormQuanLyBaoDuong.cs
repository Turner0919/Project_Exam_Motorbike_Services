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
    public partial class FormQuanLyBaoDuong : Form
    {
        private readonly QuanLyBaoDuongService _service = new QuanLyBaoDuongService();
        private readonly int _currentUserId;
        private List<LichBaoDuongDTO> _dsLichBaoDuong = new List<LichBaoDuongDTO>();
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
            InitGridColumns();
            LoadDanhSachXeUser();
        }
        // 1. Cấu hình Mapping Cột cho DataGridView
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

        // 2. Load danh sách xe của User vào ComboBox
        private void LoadDanhSachXeUser()
        {
            if (_currentUserId <= 0) return;

            var listXe = _service.GetDanhSachXeByUser(_currentUserId);
            cboDanhSachXe.DataSource = listXe;
            cboDanhSachXe.DisplayMember = "TenXeFull";
            cboDanhSachXe.ValueMember = "Id"; // Dùng 'Id' từ UserXeDTO

            if (listXe.Count > 0)
            {
                cboDanhSachXe.SelectedIndex = 0;
            }
            else
            {
                lblThongBaoTrangThai.Text = "Bạn chưa đăng ký chiếc xe nào trong hệ thống!";
                lblThongBaoTrangThai.ForeColor = Color.Red;
            }
        }

        // 3. EVENT: Chọn xe khác trong ComboBox -> Nạp lại lịch bảo dưỡng
        private void cboDanhSachXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDanhSachXe.SelectedItem is UserXeDTO xeChon)
            {
                _dsLichBaoDuong = _service.GetLichBaoDuongByXe(xeChon.Id, xeChon.DongXeId);

                dgvLichBaoDuong.DataSource = null;
                dgvLichBaoDuong.DataSource = _dsLichBaoDuong;
                dgvLichBaoDuong.ClearSelection();

                // Đếm số lượng để hiển thị Label thông báo tổng quan
                int soQuaHan = _dsLichBaoDuong.Count(l => l.MucDoCanhBao == 2);
                int soSapHan = _dsLichBaoDuong.Count(l => l.MucDoCanhBao == 1);

                if (soQuaHan > 0)
                {
                    lblThongBaoTrangThai.Text = $"CẢNH BÁO: Xe có {soQuaHan} hạng mục QUÁ HẠN bảo dưỡng!";
                    lblThongBaoTrangThai.ForeColor = Color.Red;
                }
                else if (soSapHan > 0)
                {
                    lblThongBaoTrangThai.Text = $"LƯU Ý: Xe có {soSapHan} hạng mục SẮP TỚI HẠN bảo dưỡng!";
                    lblThongBaoTrangThai.ForeColor = Color.DarkOrange;
                }
                else
                {
                    lblThongBaoTrangThai.Text = "Tất cả các hạng mục bảo dưỡng đều an toàn!";
                    lblThongBaoTrangThai.ForeColor = Color.DarkGreen;
                }
            }
        }

        // 4. EVENT: Tô màu tự động từng dòng trên DataGridView theo mức độ cảnh báo
        private void dgvLichBaoDuong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvLichBaoDuong.Rows[e.RowIndex].DataBoundItem is LichBaoDuongDTO item)
            {
                if (item.MucDoCanhBao == 2) // Quá hạn -> Nền hồng nhạt, chữ đỏ
                {
                    dgvLichBaoDuong.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.MistyRose;
                    dgvLichBaoDuong.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkRed;
                }
                else if (item.MucDoCanhBao == 1) // Sắp tới hạn -> Nền vàng nhạt, chữ cam đậm
                {
                    dgvLichBaoDuong.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                    dgvLichBaoDuong.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkGoldenrod;
                }
                else // Còn hạn -> Màu mặc định
                {
                    dgvLichBaoDuong.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    dgvLichBaoDuong.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void btnDatLichBaoDuong_Click(object sender, EventArgs e)
        {
            if (cboDanhSachXe.SelectedItem is not UserXeDTO xeChon)
            {
                MessageBox.Show("Vui lòng chọn 1 chiếc xe để đặt lịch!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Bạn đang tiến hành Đặt lịch bảo dưỡng cho xe: {xeChon.TenHangXe} {xeChon.TenDongXe} ({xeChon.BienSoXe})",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

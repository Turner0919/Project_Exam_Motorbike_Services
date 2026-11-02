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
    public partial class FormDanhSachBaoDuong : Form
    {
        private readonly CuaHangBaoDuongService _service = new CuaHangBaoDuongService();
        private readonly int _currentNhanVienId; // Id của Cửa hàng đang đăng nhập
        private List<CuaHangBaoDuongDTO> _dsBaoDuong = new List<CuaHangBaoDuongDTO>();
        public FormDanhSachBaoDuong(int nhanVienId)
        {
            InitializeComponent();
            _currentNhanVienId = nhanVienId;
        }
        public FormDanhSachBaoDuong()
        {
            InitializeComponent();
            
        }
        private void FormDanhSachBaoDuong_Shown(object sender, EventArgs e) // tránh trường hợp render khi load form
        {
            dgvDanhSachDangKy.ClearSelection();
            dgvChiTietDangKy.ClearSelection();
        }
        private void FormDanhSachBaoDuong_Load(object sender, EventArgs e)
        {
            InitGridColumns();
            LoadDanhSachDangKy();

        }
        // Cấu hình Mapping Cột cho 2 DataGridView
        private void InitGridColumns()
        {
            // Bảng trên: Danh Sách Đăng Ký
            dgvDanhSachDangKy.AutoGenerateColumns = false;
            if (dgvDanhSachDangKy.Columns.Count >= 7)
            {
                dgvDanhSachDangKy.Columns[0].DataPropertyName = nameof(CuaHangBaoDuongDTO.MaHoaDon);
                dgvDanhSachDangKy.Columns[1].DataPropertyName = nameof(CuaHangBaoDuongDTO.TenKhach);
                dgvDanhSachDangKy.Columns[2].DataPropertyName = nameof(CuaHangBaoDuongDTO.SoDienThoai);
                dgvDanhSachDangKy.Columns[3].DataPropertyName = nameof(CuaHangBaoDuongDTO.EmailKH);
                dgvDanhSachDangKy.Columns[4].DataPropertyName = nameof(CuaHangBaoDuongDTO.NgayDat);
                dgvDanhSachDangKy.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                dgvDanhSachDangKy.Columns[5].DataPropertyName = nameof(CuaHangBaoDuongDTO.TongTien);
                dgvDanhSachDangKy.Columns[5].DefaultCellStyle.Format = "#,##0 VNĐ";
                dgvDanhSachDangKy.Columns[6].DataPropertyName = nameof(CuaHangBaoDuongDTO.TrangThai);
            }

            // Bảng dưới: Danh Sách Chi Tiết Đăng Ký
            dgvChiTietDangKy.AutoGenerateColumns = false;
            if (dgvChiTietDangKy.Columns.Count >= 6)
            {
                dgvChiTietDangKy.Columns[0].DataPropertyName = nameof(CuaHangChiTietDTO.STT);
                dgvChiTietDangKy.Columns[1].DataPropertyName = nameof(CuaHangChiTietDTO.ThongTinXe);
                dgvChiTietDangKy.Columns[2].DataPropertyName = nameof(CuaHangChiTietDTO.BienSoXe);
                dgvChiTietDangKy.Columns[3].DataPropertyName = nameof(CuaHangChiTietDTO.SanPhamDichVu);
                dgvChiTietDangKy.Columns[4].DataPropertyName = nameof(CuaHangChiTietDTO.SoLuong);
                dgvChiTietDangKy.Columns[5].DataPropertyName = nameof(CuaHangChiTietDTO.DonGia);
                dgvChiTietDangKy.Columns[5].DefaultCellStyle.Format = "#,##0 VNĐ";
            }
        }

        private void LoadDanhSachDangKy()
        {
            if (_currentNhanVienId <= 0) return;

            _dsBaoDuong = _service.GetDanhSachBaoDuongByCuaHang(_currentNhanVienId);

            dgvDanhSachDangKy.DataSource = null;
            dgvDanhSachDangKy.DataSource = _dsBaoDuong;

            dgvChiTietDangKy.DataSource = null; // Clear bảng chi tiết

            dgvDanhSachDangKy.ClearSelection();
            dgvChiTietDangKy.ClearSelection();
        }
        // 1. EVENT: CLICK CHỌN DÒNG TRÊN BẢNG ĐĂNG KÝ -> XEM CHI TIẾT BẢNG DƯỚI
        private void dgvDanhSachDangKy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDanhSachDangKy.Rows[e.RowIndex].DataBoundItem is CuaHangBaoDuongDTO hdChon)
            {
                // Nếu đơn đã bị hủy thì xóa trắng bảng chi tiết
                if (hdChon.TrangThai == "Đã hủy")
                {
                    dgvChiTietDangKy.DataSource = null;
                    return;
                }

                dgvChiTietDangKy.DataSource = null;
                dgvChiTietDangKy.DataSource = hdChon.ChiTiets;
                dgvChiTietDangKy.ClearSelection();
            }
        }
        // Đổi từ private void -> private async void để xử lý gửi mail bất đồng bộ
        private async void btnDuyetDon_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra người dùng đã chọn dòng nào trên DataGridView chưa
            if (dgvDanhSachDangKy.CurrentRow == null ||
                dgvDanhSachDangKy.CurrentRow.Index < 0 ||
                dgvDanhSachDangKy.CurrentRow.DataBoundItem is not CuaHangBaoDuongDTO hdChon)
            {
                MessageBox.Show("Vui lòng chọn 1 đơn đăng ký cần duyệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Hỏi xác nhận duyệt đơn
            DialogResult confirm = MessageBox.Show(
                $"Xác nhận DUYỆT đơn hàng #{hdChon.MaHoaDon} của khách hàng '{hdChon.TenKhach}'?",
                "Xác nhận duyệt",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                // 3. Thực hiện duyệt đơn trong Cơ sở dữ liệu trước
                var res = _service.DuyetDonHang(hdChon.MaHoaDon);

                if (res.IsSuccess)
                {
                    // Tải lại bảng để cập nhật trạng thái "Đã duyệt" lên giao diện
                    LoadDanhSachDangKy();

                    string emailKhach = hdChon.EmailKH?.Trim() ?? "";

                    // 4. KIỂM TRA EMAIL: Nếu khách hàng CÓ ghi email hợp lệ thì mới tiến hành gửi
                    if (!string.IsNullOrWhiteSpace(emailKhach) && emailKhach.Contains("@"))
                    {
                        var mailResult = await EmailService.SendEmailXacNhanDonAsync(
                            emailKhach,
                            hdChon.TenKhach,
                            hdChon.MaHoaDon,
                            hdChon.TongTien
                        );

                        if (mailResult.IsSuccess)
                        {
                            MessageBox.Show($"Đã duyệt đơn hàng #{hdChon.MaHoaDon} và gửi email xác nhận thành công tới khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Đã duyệt đơn hàng thành công! (Lưu ý: Không gửi được email thông báo - {mailResult.Message})", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        // Trường hợp khách không có email hoặc email không hợp lệ
                        MessageBox.Show($"Đã duyệt đơn hàng #{hdChon.MaHoaDon} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(res.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachDangKy.CurrentRow == null || dgvDanhSachDangKy.CurrentRow.Index < 0 || dgvDanhSachDangKy.CurrentRow.DataBoundItem is not CuaHangBaoDuongDTO hdChon)
            {
                MessageBox.Show("Vui lòng chọn 1 đơn đăng ký cần hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn HỦY đơn hàng #{hdChon.MaHoaDon} của khách hàng '{hdChon.TenKhach}'? (Số lượng tồn sản phẩm sẽ được cộng lại kho).",
                "Xác nhận hủy đơn",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                var res = _service.HuyDonHangPhiaCuaHang(hdChon.MaHoaDon);
                MessageBox.Show(res.Message, "Thông báo", MessageBoxButtons.OK, res.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                if (res.IsSuccess)
                {
                    LoadDanhSachDangKy();
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDanhSachDangKy();
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

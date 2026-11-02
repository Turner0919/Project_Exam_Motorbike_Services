
using MotorbikeServices.BLL.DTOs;
using MotorbikeServices.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MotorbikeServices.GUI.AdminControls
{
    public partial class UcQuanLyCuaHang : UserControl
    {
        private readonly NhanVienUseService _nhanVienUseService = new();

        private List<NhanVienUseDTO> danhSachCuaHang = new();

        public UcQuanLyCuaHang()
        {
            InitializeComponent();

            DangKySuKien();
            KhoiTaoGiaoDien();
            LoadDanhSachCuaHang();
        }

        // Đăng ký sự kiện
        private void DangKySuKien()
        {
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            cboTrangThai.SelectedIndexChanged += cboTrangThai_SelectedIndexChanged;
            dgvCuaHang.CellContentClick += dgvCuaHang_CellContentClick;
        }

        // Khởi tạo giao diện
        private void KhoiTaoGiaoDien()
        {
            lblTongSoValue.Text = "0";
            lblDangHoatDongValue.Text = "0";
            lblTamNgungValue.Text = "0";

            cboTrangThai.SelectedIndex = 0;
        }

        // Tải danh sách cửa hàng từ BLL
        private void LoadDanhSachCuaHang()
        {
            try
            {
                danhSachCuaHang =
                    _nhanVienUseService.GetDanhSachCuaHang();

                CapNhatThongKe();
                HienThiDanhSachCuaHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải danh sách cửa hàng:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Cập nhật ba thẻ thống kê
        private void CapNhatThongKe()
        {
            lblTongSoValue.Text = danhSachCuaHang.Count.ToString();

            lblDangHoatDongValue.Text =
                danhSachCuaHang.Count(c =>
                    c.TrangThai == "Đang hoạt động").ToString();

            lblTamNgungValue.Text =
                danhSachCuaHang.Count(c =>
                    c.TrangThai == "Tạm ngừng hoạt động").ToString();
        }

        // Hiển thị danh sách sau khi tìm kiếm và lọc
        private void HienThiDanhSachCuaHang()
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            string trangThai = cboTrangThai.Text;

            var ketQua = danhSachCuaHang.AsEnumerable();

            // Tìm theo tên cửa hàng hoặc tài khoản
            if (!string.IsNullOrWhiteSpace(tuKhoa))
            {
                ketQua = ketQua.Where(c =>
                    c.TenCuaHang.Contains(
                        tuKhoa,
                        StringComparison.OrdinalIgnoreCase)
                    ||
                    c.TenTaiKhoan.Contains(
                        tuKhoa,
                        StringComparison.OrdinalIgnoreCase));
            }

            // Lọc theo trạng thái
            if (trangThai != "Tất cả trạng thái"
                && !string.IsNullOrWhiteSpace(trangThai))
            {
                ketQua = ketQua.Where(c =>
                    c.TrangThai == trangThai);
            }

            dgvCuaHang.Rows.Clear();

            foreach (var cuaHang in ketQua)
            {
                // Ghép số nhà và tên đường
                string diaChi = string.Join(
                    " ",
                    new[] { cuaHang.SoCuaHang, cuaHang.TenDuong }
                        .Where(s => !string.IsNullOrWhiteSpace(s)));

                int viTri = dgvCuaHang.Rows.Add(
                    cuaHang.TenCuaHang,
                    cuaHang.TenTaiKhoan,
                    cuaHang.TinhTP,
                    cuaHang.PhuongXa,
                    diaChi,
                    cuaHang.TrangThai,
                    "Thay đổi");

                // Lưu NhanVienId vào Tag để sử dụng ở bước sau
                dgvCuaHang.Rows[viTri].Tag = cuaHang.NhanVienId;
            }
        }

        // Tìm kiếm cửa hàng
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            HienThiDanhSachCuaHang();
        }

        // Lọc theo trạng thái
        private void cboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiDanhSachCuaHang();
        }

        // Xử lý nút thay đổi trạng thái - triển khai ở bước tiếp theo

        private void dgvCuaHang_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            // Không xử lý tiêu đề hoặc chỉ số dòng không hợp lệ
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Chỉ xử lý khi nhấn cột Thao tác
            if (dgvCuaHang.Columns[e.ColumnIndex].Name != "colThaoTac")
                return;

            DataGridViewRow row = dgvCuaHang.Rows[e.RowIndex];

            // Lấy ID cửa hàng đã lưu trong Tag
            if (row.Tag == null)
                return;

            int nhanVienId = Convert.ToInt32(row.Tag);

            // Lấy trạng thái hiện tại
            string trangThaiHienTai =
                row.Cells["colTrangThai"].Value?.ToString() ?? "";

            // Xác định trạng thái mới
            string trangThaiMoi;

            if (trangThaiHienTai == "Đang hoạt động")
            {
                trangThaiMoi = "Tạm ngừng hoạt động";
            }
            else if (trangThaiHienTai == "Tạm ngừng hoạt động")
            {
                trangThaiMoi = "Đang hoạt động";
            }
            else
            {
                MessageBox.Show(
                    "Trạng thái cửa hàng không hợp lệ.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Xác nhận trước khi cập nhật
            DialogResult ketQua = MessageBox.Show(
                $"Bạn có chắc chắn muốn chuyển cửa hàng sang trạng thái:\n\n" +
                $"{trangThaiMoi}?",
                "Xác nhận thay đổi trạng thái",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
                return;

            try
            {
                // Gọi BLL cập nhật database
                var ketQuaCapNhat =
                    _nhanVienUseService.CapNhatTrangThaiCuaHang(
                        nhanVienId,
                        trangThaiMoi);

                if (ketQuaCapNhat.IsSuccess)
                {
                    MessageBox.Show(
                        ketQuaCapNhat.Message,
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Tải lại danh sách và thống kê
                    LoadDanhSachCuaHang();
                }
                else
                {
                    MessageBox.Show(
                        ketQuaCapNhat.Message,
                        "Không thể cập nhật",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Có lỗi khi cập nhật trạng thái cửa hàng:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

    }
}

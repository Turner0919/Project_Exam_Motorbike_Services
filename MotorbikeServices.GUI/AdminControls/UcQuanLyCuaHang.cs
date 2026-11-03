using MotorbikeServices.BLL.DTOs;
using MotorbikeServices.BLL.Services;

using System;
using System.Collections.Generic;
using System.Drawing;
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

            CauHinhCotBang();

            DangKySuKien();

            KhoiTaoGiaoDien();

            LoadDanhSachCuaHang();
        }

        private void CauHinhCotBang()
        {
            dgvCuaHang.SuspendLayout();

            // Xóa các cột được khai báo trong Designer.
            dgvCuaHang.Columns.Clear();

            // Tạo mới đầy đủ 7 cột.
            DataGridViewTextBoxColumn cotTenCuaHang =
                new DataGridViewTextBoxColumn
                {
                    Name = "colTenCuaHang",
                    HeaderText = "Tên cửa hàng",
                    FillWeight = 145F,
                    MinimumWidth = 130,
                    ReadOnly = true,
                    SortMode = DataGridViewColumnSortMode.NotSortable
                };

            DataGridViewTextBoxColumn cotTaiKhoan =
                new DataGridViewTextBoxColumn
                {
                    Name = "colTaiKhoan",
                    HeaderText = "Tài khoản",
                    FillWeight = 95F,
                    MinimumWidth = 100,
                    ReadOnly = true,
                    SortMode = DataGridViewColumnSortMode.NotSortable
                };

            DataGridViewTextBoxColumn cotTinhTP =
                new DataGridViewTextBoxColumn
                {
                    Name = "colTinhTP",
                    HeaderText = "Tỉnh / Thành phố",
                    FillWeight = 110F,
                    MinimumWidth = 120,
                    ReadOnly = true,
                    SortMode = DataGridViewColumnSortMode.NotSortable
                };

            DataGridViewTextBoxColumn cotPhuongXa =
                new DataGridViewTextBoxColumn
                {
                    Name = "colPhuongXa",
                    HeaderText = "Phường / Xã",
                    FillWeight = 110F,
                    MinimumWidth = 110,
                    ReadOnly = true,
                    SortMode = DataGridViewColumnSortMode.NotSortable
                };

            DataGridViewTextBoxColumn cotDiaChi =
                new DataGridViewTextBoxColumn
                {
                    Name = "colDiaChi",
                    HeaderText = "Địa chỉ",
                    FillWeight = 140F,
                    MinimumWidth = 150,
                    ReadOnly = true,
                    SortMode = DataGridViewColumnSortMode.NotSortable
                };

            DataGridViewTextBoxColumn cotTrangThai =
                new DataGridViewTextBoxColumn
                {
                    Name = "colTrangThai",
                    HeaderText = "Trạng thái",
                    FillWeight = 125F,
                    MinimumWidth = 145,
                    ReadOnly = true,
                    SortMode = DataGridViewColumnSortMode.NotSortable
                };

            DataGridViewButtonColumn cotThaoTac =
                new DataGridViewButtonColumn
                {
                    Name = "colThaoTac",
                    HeaderText = "Thao tác",
                    Text = "Thay đổi",
                    UseColumnTextForButtonValue = true,
                    FlatStyle = FlatStyle.Flat,
                    FillWeight = 85F,
                    MinimumWidth = 95,
                    ReadOnly = true,
                    SortMode = DataGridViewColumnSortMode.NotSortable
                };

            cotThaoTac.DefaultCellStyle.BackColor =
                Color.FromArgb(231, 240, 252);

            cotThaoTac.DefaultCellStyle.ForeColor =
                Color.FromArgb(52, 127, 193);

            // Thêm đủ 7 cột vào bảng.
            dgvCuaHang.Columns.AddRange(
                new DataGridViewColumn[]
                {
            cotTenCuaHang,
            cotTaiKhoan,
            cotTinhTP,
            cotPhuongXa,
            cotDiaChi,
            cotTrangThai,
            cotThaoTac
                });

            // Cấu hình hiển thị.
            dgvCuaHang.AutoGenerateColumns = false;

            dgvCuaHang.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvCuaHang.ColumnHeadersVisible = true;

            dgvCuaHang.RowHeadersVisible = false;

            dgvCuaHang.ReadOnly = true;

            dgvCuaHang.MultiSelect = false;

            dgvCuaHang.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvCuaHang.RowTemplate.Height = 42;

            dgvCuaHang.ResumeLayout();
        }

        // ==========================================
        // ĐĂNG KÝ SỰ KIỆN
        // ==========================================

        private void DangKySuKien()
        {
            txtTimKiem.TextChanged +=
                txtTimKiem_TextChanged;

            cboTrangThai.SelectedIndexChanged +=
                cboTrangThai_SelectedIndexChanged;

            btnLamMoi.Click +=
                btnLamMoi_Click;

            dgvCuaHang.CellContentClick +=
                dgvCuaHang_CellContentClick;

            dgvCuaHang.CellFormatting +=
                dgvCuaHang_CellFormatting;
        }

        // ==========================================
        // KHỞI TẠO GIAO DIỆN
        // ==========================================

        private void KhoiTaoGiaoDien()
        {
            lblTongSoValue.Text = "0";
            lblDangHoatDongValue.Text = "0";
            lblTamNgungValue.Text = "0";

            cboTrangThai.SelectedIndex = 0;

            dgvCuaHang.ClearSelection();
        }

        // ==========================================
        // TẢI DANH SÁCH CỬA HÀNG
        // ==========================================

        private void LoadDanhSachCuaHang()
        {
            try
            {
                danhSachCuaHang =
                    _nhanVienUseService.GetDanhSachCuaHang()
                    ?? new List<NhanVienUseDTO>();

                CapNhatThongKe();

                HienThiDanhSachCuaHang();
            }
            catch (Exception ex)
            {
                lblTongSoValue.Text = "--";
                lblDangHoatDongValue.Text = "--";
                lblTamNgungValue.Text = "--";

                dgvCuaHang.Rows.Clear();

                MessageBox.Show(
                    "Không thể tải danh sách cửa hàng:\n\n" +
                    ex.Message,
                    "Lỗi dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // CẬP NHẬT THỐNG KÊ
        // ==========================================

        private void CapNhatThongKe()
        {
            int tongSo = danhSachCuaHang.Count;

            int dangHoatDong = danhSachCuaHang.Count(c =>
                c.TrangThai == "Đang hoạt động");

            int tamNgung = danhSachCuaHang.Count(c =>
                c.TrangThai == "Tạm ngừng hoạt động");

            lblTongSoValue.Text =
                tongSo.ToString("N0");

            lblDangHoatDongValue.Text =
                dangHoatDong.ToString("N0");

            lblTamNgungValue.Text =
                tamNgung.ToString("N0");
        }

        // ==========================================
        // TÌM KIẾM VÀ LỌC
        // ==========================================

        private void HienThiDanhSachCuaHang()
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            string trangThai =
                cboTrangThai.SelectedItem?.ToString()
                ?? "Tất cả trạng thái";

            IEnumerable<NhanVienUseDTO> ketQua =
                danhSachCuaHang;

            // Tìm kiếm theo nhiều thông tin.
            if (!string.IsNullOrWhiteSpace(tuKhoa))
            {
                ketQua = ketQua.Where(c =>
                    CoChuaTuKhoa(c.TenCuaHang, tuKhoa) ||
                    CoChuaTuKhoa(c.TenTaiKhoan, tuKhoa) ||
                    CoChuaTuKhoa(c.TinhTP, tuKhoa) ||
                    CoChuaTuKhoa(c.PhuongXa, tuKhoa) ||
                    CoChuaTuKhoa(c.SoCuaHang, tuKhoa) ||
                    CoChuaTuKhoa(c.TenDuong, tuKhoa) ||
                    CoChuaTuKhoa(c.TrangThai, tuKhoa));
            }

            // Lọc theo trạng thái.
            if (trangThai != "Tất cả trạng thái")
            {
                ketQua = ketQua.Where(c =>
                    c.TrangThai == trangThai);
            }

            dgvCuaHang.Rows.Clear();

            foreach (var cuaHang in ketQua)
            {
                // Ghép số nhà và tên đường.
                string diaChi = string.Join(
                    " ",
                    new[]
                    {
                        cuaHang.SoCuaHang,
                        cuaHang.TenDuong
                    }
                    .Where(s => !string.IsNullOrWhiteSpace(s)));

                int viTri = dgvCuaHang.Rows.Add(
                    cuaHang.TenCuaHang,
                    cuaHang.TenTaiKhoan,
                    cuaHang.TinhTP,
                    cuaHang.PhuongXa,
                    diaChi,
                    cuaHang.TrangThai,
                    "Thay đổi");

                // Lưu NhanVienId để xử lý thao tác.
                dgvCuaHang.Rows[viTri].Tag =
                    cuaHang.NhanVienId;
            }

            dgvCuaHang.ClearSelection();
        }

        private bool CoChuaTuKhoa(
            string giaTri,
            string tuKhoa)
        {
            return !string.IsNullOrWhiteSpace(giaTri)
                && giaTri.Contains(
                    tuKhoa,
                    StringComparison.OrdinalIgnoreCase);
        }

        // ==========================================
        // SỰ KIỆN TÌM KIẾM
        // ==========================================

        private void txtTimKiem_TextChanged(
            object sender,
            EventArgs e)
        {
            HienThiDanhSachCuaHang();
        }

        // ==========================================
        // SỰ KIỆN LỌC TRẠNG THÁI
        // ==========================================

        private void cboTrangThai_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            HienThiDanhSachCuaHang();
        }

        // ==========================================
        // LÀM MỚI
        // ==========================================

        private void btnLamMoi_Click(
            object sender,
            EventArgs e)
        {
            txtTimKiem.Clear();

            cboTrangThai.SelectedIndex = 0;

            LoadDanhSachCuaHang();
        }

        // ==========================================
        // ĐỊNH DẠNG TRẠNG THÁI VÀ NÚT THAO TÁC
        // ==========================================

        private void dgvCuaHang_CellFormatting(
            object sender,
            DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string tenCot =
                dgvCuaHang.Columns[e.ColumnIndex].Name;

            // Màu trạng thái.
            if (tenCot == "colTrangThai")
            {
                string trangThai =
                    Convert.ToString(e.Value) ?? "";

                if (trangThai == "Đang hoạt động")
                {
                    e.CellStyle.BackColor =
                        Color.FromArgb(230, 245, 237);

                    e.CellStyle.ForeColor =
                        Color.FromArgb(35, 125, 75);
                }
                else if (trangThai == "Tạm ngừng hoạt động")
                {
                    e.CellStyle.BackColor =
                        Color.FromArgb(255, 243, 224);

                    e.CellStyle.ForeColor =
                        Color.FromArgb(175, 104, 28);
                }
            }

            // Căn giữa nút thao tác.
            if (tenCot == "colThaoTac")
            {
                e.CellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

                e.CellStyle.ForeColor =
                    Color.FromArgb(52, 127, 193);
            }
        }

        // ==========================================
        // THAY ĐỔI TRẠNG THÁI CỬA HÀNG
        // ==========================================

        private void dgvCuaHang_CellContentClick(
    object sender,
    DataGridViewCellEventArgs e)
        {
            // Không xử lý tiêu đề hoặc dòng không hợp lệ.
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Chỉ xử lý khi nhấn cột Thao tác.
            if (e.ColumnIndex != colThaoTac.Index)
                return;

            DataGridViewRow row = dgvCuaHang.Rows[e.RowIndex];

            if (row.Tag == null)
                return;

            int nhanVienId = Convert.ToInt32(row.Tag);

            // Cột trạng thái nằm ở vị trí thứ 6 (Index = 5).
            // Dùng chỉ số thay vì tìm kiếm theo tên cột.
            string trangThaiHienTai =
                Convert.ToString(row.Cells[5].Value) ?? "";

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

            DialogResult xacNhan = MessageBox.Show(
                "Bạn có chắc chắn muốn chuyển cửa hàng sang trạng thái:\n\n" +
                trangThaiMoi + "?",
                "Xác nhận thay đổi trạng thái",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (xacNhan != DialogResult.Yes)
                return;

            try
            {
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
                    "Có lỗi khi cập nhật trạng thái cửa hàng:\n\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
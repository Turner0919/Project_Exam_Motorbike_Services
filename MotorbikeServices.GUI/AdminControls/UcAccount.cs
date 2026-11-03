using Microsoft.EntityFrameworkCore;
using MotorbikeServices.DAL.Models;
using MotorbikeServices.DAL.Models.Account;
using MotorbikeServices.GUI.Setup;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MotorbikeServices.GUI.AdminControls
{
    public partial class UcAccount : UserControl
    {
        private int? userDangChonId;
        private string vaiTroDangChon = "";

        private List<TaiKhoanHienThi> danhSachTatCa = new();
        private List<TaiKhoanHienThi> danhSachHienThi = new();

        private string cotSapXep = "VaiTro";
        private bool sapXepTangDan = true;

        private class TaiKhoanHienThi
        {
            public int Id { get; set; }

            public string TenTaiKhoan { get; set; } = "";

            public string VaiTro { get; set; } = "";

            public string HoTen { get; set; } = "";

            public string SoDienThoai { get; set; } = "";

            public string Email { get; set; } = "";

            public string TrangThai { get; set; } = "";
        }

        // ==========================================
        // CONSTRUCTOR
        // ==========================================

        public UcAccount()
        {
            InitializeComponent();

            CauHinhBang();

            cboVaiTro.Items.Clear();

            cboVaiTro.Items.AddRange(new object[]
            {
                "Tất cả",
                "Admin",
                "User",
                "Nhân viên"
            });

            cboVaiTro.SelectedIndex = 0;

            // Admin và Nhân viên chỉ xem.
            btnThemAdmin.Visible = false;
            btnThemUser.Visible = false;

            lblMoTa.Text =
                "Quản lý tài khoản User; Admin và Nhân viên chỉ xem.";

            txtTimKiem.TextChanged += txtTimKiem_TextChanged;

            cboVaiTro.SelectedIndexChanged +=
                cboVaiTro_SelectedIndexChanged;

            dgvTaiKhoan.SelectionChanged +=
                dgvTaiKhoan_SelectionChanged;

            dgvTaiKhoan.ColumnHeaderMouseClick +=
                dgvTaiKhoan_ColumnHeaderMouseClick;

            btnLamMoi.Click += btnLamMoi_Click;

            btnSua.Click += (s, e) => SuaUser();

            btnXoa.Click += (s, e) => XoaUser();

            LoadTaiKhoan();
        }

        // ==========================================
        // CẤU HÌNH DATAGRIDVIEW
        // ==========================================

        private void CauHinhBang()
        {
            if (dgvTaiKhoan.Columns.Count < 7)
            {
                MessageBox.Show(
                    "DataGridView tài khoản cần có đủ 7 cột.",
                    "Lỗi giao diện",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            string[] tenCot =
            {
                "Id",
                "TenTaiKhoan",
                "VaiTro",
                "HoTen",
                "SoDienThoai",
                "Email",
                "TrangThai"
            };

            for (int i = 0; i < tenCot.Length; i++)
            {
                dgvTaiKhoan.Columns[i].Name = tenCot[i];
            }

            dgvTaiKhoan.Columns["Id"].Visible = false;

            // Cấu hình hành vi.
            dgvTaiKhoan.AllowUserToAddRows = false;
            dgvTaiKhoan.AllowUserToDeleteRows = false;
            dgvTaiKhoan.AllowUserToResizeColumns = false;
            dgvTaiKhoan.AllowUserToResizeRows = false;
            dgvTaiKhoan.AllowUserToOrderColumns = false;

            dgvTaiKhoan.ReadOnly = true;
            dgvTaiKhoan.MultiSelect = false;

            dgvTaiKhoan.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvTaiKhoan.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvTaiKhoan.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.None;

            dgvTaiKhoan.EnableHeadersVisualStyles = false;

            dgvTaiKhoan.BorderStyle = BorderStyle.None;

            dgvTaiKhoan.BackgroundColor = Color.White;

            dgvTaiKhoan.GridColor =
                Color.FromArgb(226, 233, 241);

            dgvTaiKhoan.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgvTaiKhoan.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            dgvTaiKhoan.RowHeadersVisible = false;

            dgvTaiKhoan.ColumnHeadersHeight = 42;

            dgvTaiKhoan.RowTemplate.Height = 40;

            // Header.
            dgvTaiKhoan.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(25, 54, 87);

            dgvTaiKhoan.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvTaiKhoan.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            dgvTaiKhoan.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            // Nội dung.
            dgvTaiKhoan.DefaultCellStyle.BackColor =
                Color.White;

            dgvTaiKhoan.DefaultCellStyle.ForeColor =
                Color.FromArgb(35, 55, 78);

            dgvTaiKhoan.DefaultCellStyle.Font =
                new Font("Segoe UI", 9F);

            dgvTaiKhoan.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(220, 235, 250);

            dgvTaiKhoan.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(25, 54, 87);

            dgvTaiKhoan.DefaultCellStyle.Padding =
                new Padding(8, 0, 5, 0);

            dgvTaiKhoan.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(247, 249, 252);

            dgvTaiKhoan.RowTemplate.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(220, 235, 250);

            dgvTaiKhoan.RowTemplate.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(25, 54, 87);

            // Phân bổ độ rộng.
            dgvTaiKhoan.Columns["TenTaiKhoan"].FillWeight = 20;
            dgvTaiKhoan.Columns["VaiTro"].FillWeight = 13;
            dgvTaiKhoan.Columns["HoTen"].FillWeight = 23;
            dgvTaiKhoan.Columns["SoDienThoai"].FillWeight = 15;
            dgvTaiKhoan.Columns["Email"].FillWeight = 19;
            dgvTaiKhoan.Columns["TrangThai"].FillWeight = 15;

            foreach (DataGridViewColumn column in dgvTaiKhoan.Columns)
            {
                column.Resizable = DataGridViewTriState.False;

                column.SortMode =
                    DataGridViewColumnSortMode.Programmatic;
            }
        }

        // ==========================================
        // TẢI DỮ LIỆU
        // ==========================================

        private void LoadTaiKhoan()
        {
            try
            {
                using var db = new AppDbContext();

                danhSachTatCa.Clear();

                // ----------------------------------
                // 1. Thống kê tổng số tài khoản
                // ----------------------------------

                int tongAdmin = db.Admins.Count();

                int tongUser = db.Users.Count();

                int tongNhanVien = db.NhanViens.Count();

                int tongTaiKhoan =
                    tongAdmin + tongUser + tongNhanVien;

                lblCardTongValue.Text =
                    tongTaiKhoan.ToString("N0");

                lblCardAdminValue.Text =
                    tongAdmin.ToString("N0");

                lblCardUserValue.Text =
                    tongUser.ToString("N0");

                lblCardNhanVienValue.Text =
                    tongNhanVien.ToString("N0");

                // ----------------------------------
                // 2. Lấy danh sách Admin
                // ----------------------------------

                var admins = db.Admins
                    .AsNoTracking()
                    .Select(a => new TaiKhoanHienThi
                    {
                        Id = a.Id,
                        TenTaiKhoan = a.TenTaiKhoan,
                        VaiTro = "Admin",
                        TrangThai = "—"
                    })
                    .ToList();

                danhSachTatCa.AddRange(admins);

                // ----------------------------------
                // 3. Lấy danh sách User
                // ----------------------------------

                var users = db.Users
                    .AsNoTracking()
                    .Select(u => new TaiKhoanHienThi
                    {
                        Id = u.Id,
                        TenTaiKhoan = u.TenTaiKhoan,
                        VaiTro = "User",
                        TrangThai = "—"
                    })
                    .ToList();

                var userIds = users
                    .Select(u => u.Id)
                    .ToList();

                var profilesUser = db.UserUses
                    .AsNoTracking()
                    .Where(p => userIds.Contains(p.UserId))
                    .Select(p => new
                    {
                        p.UserId,
                        HoTen = p.HoTen ?? "",
                        SoDienThoai = p.SoDienThoai ?? "",
                        Email = p.Email ?? ""
                    })
                    .ToList()
                    .GroupBy(p => p.UserId)
                    .ToDictionary(g => g.Key, g => g.First());

                foreach (var user in users)
                {
                    if (profilesUser.TryGetValue(
                        user.Id, out var profile))
                    {
                        user.HoTen = profile.HoTen;
                        user.SoDienThoai = profile.SoDienThoai;
                        user.Email = profile.Email;
                    }
                }

                danhSachTatCa.AddRange(users);

                // ----------------------------------
                // 4. Lấy danh sách Nhân viên
                // ----------------------------------

                var nhanViens = db.NhanViens
                    .AsNoTracking()
                    .Select(n => new
                    {
                        n.Id,
                        n.TenTaiKhoan
                    })
                    .ToList();

                var nhanVienIds = nhanViens
                    .Select(n => n.Id)
                    .ToList();

                // Lấy thông tin cửa hàng gắn với nhân viên.
                var profilesNhanVien = db.NhanVienUses
                    .AsNoTracking()
                    .Where(n => nhanVienIds.Contains(n.NhanVienId))
                    .Select(n => new
                    {
                        n.NhanVienId,
                        TenCuaHang = n.TenCuaHang ?? "",
                        TrangThai = n.TrangThai ?? ""
                    })
                    .ToList()
                    .GroupBy(n => n.NhanVienId)
                    .ToDictionary(g => g.Key, g => g.First());

                foreach (var nhanVien in nhanViens)
                {
                    var taiKhoan = new TaiKhoanHienThi
                    {
                        Id = nhanVien.Id,
                        TenTaiKhoan = nhanVien.TenTaiKhoan,
                        VaiTro = "Nhân viên",
                        TrangThai = "Chưa thiết lập"
                    };

                    if (profilesNhanVien.TryGetValue(
                        nhanVien.Id, out var profile))
                    {
                        // Cột hiển thị chung:
                        // User = Họ tên
                        // Nhân viên = Tên cửa hàng
                        taiKhoan.HoTen =
                            profile.TenCuaHang;

                        taiKhoan.TrangThai =
                            string.IsNullOrWhiteSpace(profile.TrangThai)
                                ? "Chưa thiết lập"
                                : profile.TrangThai;
                    }
                    else
                    {
                        taiKhoan.HoTen = "Chưa có cửa hàng";
                    }

                    danhSachTatCa.Add(taiKhoan);
                }

                // ----------------------------------
                // 5. Sắp xếp mặc định
                // ----------------------------------

                danhSachTatCa = danhSachTatCa
                    .OrderBy(x => ThuTuVaiTro(x.VaiTro))
                    .ThenBy(x => x.TenTaiKhoan)
                    .ToList();

                // Áp dụng từ khóa và bộ lọc hiện tại.
                ApDungBoLoc();
            }
            catch (Exception ex)
            {
                lblCardTongValue.Text = "--";
                lblCardAdminValue.Text = "--";
                lblCardUserValue.Text = "--";
                lblCardNhanVienValue.Text = "--";

                dgvTaiKhoan.Rows.Clear();

                lblTongTaiKhoan.Text =
                    "Không thể tải dữ liệu tài khoản.";

                XoaThongTinChiTiet();

                MessageBox.Show(
                    "Không thể tải danh sách tài khoản:\n\n" + ex.Message,
                    "Lỗi dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private int ThuTuVaiTro(string vaiTro)
        {
            return vaiTro switch
            {
                "Admin" => 0,
                "User" => 1,
                "Nhân viên" => 2,
                _ => 3
            };
        }

        // ==========================================
        // TÌM KIẾM VÀ LỌC
        // ==========================================

        private void txtTimKiem_TextChanged(
            object? sender,
            EventArgs e)
        {
            ApDungBoLoc();
        }

        private void cboVaiTro_SelectedIndexChanged(
            object? sender,
            EventArgs e)
        {
            ApDungBoLoc();
        }

        private void btnLamMoi_Click(
            object? sender,
            EventArgs e)
        {
            txtTimKiem.TextChanged -= txtTimKiem_TextChanged;

            cboVaiTro.SelectedIndexChanged -=
                cboVaiTro_SelectedIndexChanged;

            txtTimKiem.Clear();

            cboVaiTro.SelectedIndex = 0;

            txtTimKiem.TextChanged += txtTimKiem_TextChanged;

            cboVaiTro.SelectedIndexChanged +=
                cboVaiTro_SelectedIndexChanged;

            cotSapXep = "VaiTro";
            sapXepTangDan = true;

            LoadTaiKhoan();
        }

        private bool ChuaTuKhoa(
            string? giaTri,
            string tuKhoa)
        {
            if (string.IsNullOrWhiteSpace(giaTri))
                return false;

            return giaTri.Contains(
                tuKhoa,
                StringComparison.CurrentCultureIgnoreCase);
        }

        private void ApDungBoLoc()
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            string vaiTro =
                cboVaiTro.SelectedItem?.ToString() ?? "Tất cả";

            IEnumerable<TaiKhoanHienThi> query =
                danhSachTatCa;

            // Lọc vai trò.
            if (vaiTro != "Tất cả")
            {
                query = query.Where(x => x.VaiTro == vaiTro);
            }

            // Tìm kiếm trên nhiều trường.
            if (!string.IsNullOrWhiteSpace(tuKhoa))
            {
                query = query.Where(x =>
                    ChuaTuKhoa(x.TenTaiKhoan, tuKhoa) ||
                    ChuaTuKhoa(x.HoTen, tuKhoa) ||
                    ChuaTuKhoa(x.SoDienThoai, tuKhoa) ||
                    ChuaTuKhoa(x.Email, tuKhoa) ||
                    ChuaTuKhoa(x.TrangThai, tuKhoa));
            }

            danhSachHienThi = query.ToList();

            int soAdmin = danhSachTatCa.Count(
                x => x.VaiTro == "Admin");

            int soUser = danhSachTatCa.Count(
                x => x.VaiTro == "User");

            int soNhanVien = danhSachTatCa.Count(
                x => x.VaiTro == "Nhân viên");

            lblTongTaiKhoan.Text =
                $"Hiển thị {danhSachHienThi.Count:N0}/{danhSachTatCa.Count:N0}  |  " +
                $"Admin: {soAdmin}  |  User: {soUser}  |  Nhân viên: {soNhanVien}";

            HienThiBang();
        }

        // ==========================================
        // SẮP XẾP THEO CỘT
        // ==========================================

        private void dgvTaiKhoan_ColumnHeaderMouseClick(
            object? sender,
            DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0 ||
                e.ColumnIndex >= dgvTaiKhoan.Columns.Count)
                return;

            string tenCot =
                dgvTaiKhoan.Columns[e.ColumnIndex].Name;

            if (tenCot == "Id")
                return;

            if (cotSapXep == tenCot)
            {
                sapXepTangDan = !sapXepTangDan;
            }
            else
            {
                cotSapXep = tenCot;
                sapXepTangDan = true;
            }

            HienThiBang();
        }

        private void HienThiBang()
        {
            List<TaiKhoanHienThi> danhSachSapXep;

            // Sắp xếp theo vai trò.
            if (cotSapXep == "VaiTro")
            {
                danhSachSapXep = sapXepTangDan
                    ? danhSachHienThi
                        .OrderBy(x => ThuTuVaiTro(x.VaiTro))
                        .ThenBy(x => x.TenTaiKhoan)
                        .ToList()
                    : danhSachHienThi
                        .OrderByDescending(x => ThuTuVaiTro(x.VaiTro))
                        .ThenBy(x => x.TenTaiKhoan)
                        .ToList();
            }
            else
            {
                Func<TaiKhoanHienThi, string> layKhoa =
                    cotSapXep switch
                    {
                        "TenTaiKhoan" => x => x.TenTaiKhoan,
                        "HoTen" => x => x.HoTen,
                        "SoDienThoai" => x => x.SoDienThoai,
                        "Email" => x => x.Email,
                        "TrangThai" => x => x.TrangThai,
                        _ => x => x.TenTaiKhoan
                    };

                danhSachSapXep = sapXepTangDan
                    ? danhSachHienThi
                        .OrderBy(
                            layKhoa,
                            StringComparer.CurrentCultureIgnoreCase)
                        .ToList()
                    : danhSachHienThi
                        .OrderByDescending(
                            layKhoa,
                            StringComparer.CurrentCultureIgnoreCase)
                        .ToList();
            }

            dgvTaiKhoan.Rows.Clear();

            foreach (var item in danhSachSapXep)
            {
                int rowIndex = dgvTaiKhoan.Rows.Add(
                    item.Id,
                    item.TenTaiKhoan,
                    item.VaiTro,
                    item.HoTen,
                    item.SoDienThoai,
                    item.Email,
                    item.TrangThai);

                DataGridViewRow row =
                    dgvTaiKhoan.Rows[rowIndex];

                // Màu vai trò.
                if (item.VaiTro == "Admin")
                {
                    row.Cells["VaiTro"].Style.BackColor =
                        Color.FromArgb(241, 235, 252);

                    row.Cells["VaiTro"].Style.ForeColor =
                        Color.FromArgb(106, 75, 157);
                }
                else if (item.VaiTro == "User")
                {
                    row.Cells["VaiTro"].Style.BackColor =
                        Color.FromArgb(230, 245, 237);

                    row.Cells["VaiTro"].Style.ForeColor =
                        Color.FromArgb(43, 117, 76);
                }
                else
                {
                    row.Cells["VaiTro"].Style.BackColor =
                        Color.FromArgb(255, 243, 224);

                    row.Cells["VaiTro"].Style.ForeColor =
                        Color.FromArgb(155, 93, 30);
                }

                // Màu trạng thái cửa hàng.
                if (item.VaiTro == "Nhân viên")
                {
                    if (item.TrangThai == "Đang hoạt động")
                    {
                        row.Cells["TrangThai"].Style.ForeColor =
                            Color.FromArgb(35, 125, 75);
                    }
                    else if (item.TrangThai == "Tạm ngừng hoạt động")
                    {
                        row.Cells["TrangThai"].Style.ForeColor =
                            Color.FromArgb(190, 120, 35);
                    }
                }
            }

            // Mũi tên sắp xếp.
            foreach (DataGridViewColumn column in dgvTaiKhoan.Columns)
            {
                column.HeaderCell.SortGlyphDirection =
                    SortOrder.None;
            }

            if (dgvTaiKhoan.Columns.Contains(cotSapXep))
            {
                dgvTaiKhoan.Columns[cotSapXep]
                    .HeaderCell.SortGlyphDirection =
                    sapXepTangDan
                        ? SortOrder.Ascending
                        : SortOrder.Descending;
            }

            dgvTaiKhoan.ClearSelection();

            dgvTaiKhoan.CurrentCell = null;

            XoaThongTinChiTiet();
        }

        // ==========================================
        // CHỌN TÀI KHOẢN
        // ==========================================

        private void dgvTaiKhoan_SelectionChanged(
            object? sender,
            EventArgs e)
        {
            if (dgvTaiKhoan.CurrentRow == null ||
                dgvTaiKhoan.SelectedRows.Count == 0 ||
                dgvTaiKhoan.CurrentRow.IsNewRow)
            {
                XoaThongTinChiTiet();
                return;
            }

            DataGridViewRow row =
                dgvTaiKhoan.SelectedRows[0];

            if (row.Cells["Id"].Value == null)
            {
                XoaThongTinChiTiet();
                return;
            }

            int id = Convert.ToInt32(
                row.Cells["Id"].Value);

            vaiTroDangChon =
                Convert.ToString(row.Cells["VaiTro"].Value) ?? "";

            userDangChonId =
                vaiTroDangChon == "User" ? id : null;

            lblChiTietTenTaiKhoan.Text =
                GiaTriHienThi(row.Cells["TenTaiKhoan"].Value);

            lblChiTietVaiTro.Text = vaiTroDangChon;

            lblChiTietHoTen.Text =
                GiaTriHienThi(row.Cells["HoTen"].Value);

            lblChiTietSoDienThoai.Text =
                GiaTriHienThi(row.Cells["SoDienThoai"].Value);

            lblChiTietEmail.Text =
                GiaTriHienThi(row.Cells["Email"].Value);

            // Màu sắc và ghi chú theo vai trò.
            if (vaiTroDangChon == "Admin")
            {
                lblChiTietVaiTro.BackColor =
                    Color.FromArgb(241, 235, 252);

                lblChiTietVaiTro.ForeColor =
                    Color.FromArgb(106, 75, 157);

                lblChiTietGhiChu.Text =
                    "Tài khoản Admin chỉ được xem.";
            }
            else if (vaiTroDangChon == "User")
            {
                lblChiTietVaiTro.BackColor =
                    Color.FromArgb(230, 245, 237);

                lblChiTietVaiTro.ForeColor =
                    Color.FromArgb(43, 117, 76);

                lblChiTietGhiChu.Text =
                    "Tài khoản User có thể được chỉnh sửa hoặc xóa.";
            }
            else
            {
                lblChiTietVaiTro.BackColor =
                    Color.FromArgb(255, 243, 224);

                lblChiTietVaiTro.ForeColor =
                    Color.FromArgb(155, 93, 30);

                string tenCuaHang =
                    GiaTriHienThi(row.Cells["HoTen"].Value);

                string trangThai =
                    GiaTriHienThi(row.Cells["TrangThai"].Value);

                lblChiTietGhiChu.Text =
                    $"Cửa hàng: {tenCuaHang} | Trạng thái: {trangThai}";
            }

            // Chỉ User mới được phép chỉnh sửa/xóa.
            bool laUser = vaiTroDangChon == "User";

            btnSua.Enabled = laUser;

            btnXoa.Enabled = laUser;
        }

        private string GiaTriHienThi(object? giaTri)
        {
            string? ketQua =
                Convert.ToString(giaTri);

            return string.IsNullOrWhiteSpace(ketQua)
                ? "—"
                : ketQua;
        }

        private void XoaThongTinChiTiet()
        {
            userDangChonId = null;

            vaiTroDangChon = "";

            lblChiTietTenTaiKhoan.Text = "Chưa chọn";

            lblChiTietVaiTro.Text = "Chưa chọn";

            lblChiTietHoTen.Text = "—";

            lblChiTietSoDienThoai.Text = "—";

            lblChiTietEmail.Text = "—";

            lblChiTietGhiChu.Text =
                "Chọn một tài khoản trong danh sách để xem chi tiết.";

            lblChiTietVaiTro.BackColor =
                Color.FromArgb(231, 240, 252);

            lblChiTietVaiTro.ForeColor =
                Color.FromArgb(25, 54, 87);

            btnSua.Enabled = false;

            btnXoa.Enabled = false;
        }

        // ==========================================
        // KIỂM TRA TÊN TÀI KHOẢN TRÙNG
        // ==========================================

        private bool TenTaiKhoanDaTonTai(
            AppDbContext db,
            string tenTaiKhoan,
            int? userIdDangSua = null)
        {
            string ten =
                tenTaiKhoan.Trim().ToLowerInvariant();

            bool trungAdmin = db.Admins.Any(a =>
                a.TenTaiKhoan.ToLower() == ten);

            bool trungUser = db.Users.Any(u =>
                u.TenTaiKhoan.ToLower() == ten &&
                (!userIdDangSua.HasValue ||
                 u.Id != userIdDangSua.Value));

            bool trungNhanVien = db.NhanViens.Any(n =>
                n.TenTaiKhoan.ToLower() == ten);

            return trungAdmin || trungUser || trungNhanVien;
        }

        // ==========================================
        // THÊM USER
        // ==========================================

        private void ThemUser()
        {
            using var form = new FormNhapTaiKhoan("User");

            if (form.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                using var db = new AppDbContext();

                if (TenTaiKhoanDaTonTai(db, form.TenTaiKhoan))
                {
                    MessageBox.Show(
                        "Tên tài khoản đã tồn tại.",
                        "Trùng tài khoản",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                using var transaction =
                    db.Database.BeginTransaction();

                var user = new User
                {
                    TenTaiKhoan = form.TenTaiKhoan,
                    MatKhau = form.MatKhau,
                    CauHoiBaoMat = form.CauHoiBaoMat,
                    DapAnBaoMat = form.DapAnBaoMat
                };

                db.Users.Add(user);

                db.SaveChanges();

                var profile = new UserUse
                {
                    UserId = user.Id,
                    HoTen = form.HoTen,
                    NgaySinh = form.NgaySinh,
                    GioiTinh = form.GioiTinh,
                    SoDienThoai = form.SoDienThoai,
                    Email = form.Email
                };

                db.UserUses.Add(profile);

                db.SaveChanges();

                transaction.Commit();

                MessageBox.Show(
                    "Thêm tài khoản User thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadTaiKhoan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể thêm tài khoản User:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // SỬA USER
        // ==========================================

        private void SuaUser()
        {
            if (!userDangChonId.HasValue ||
                vaiTroDangChon != "User")
            {
                MessageBox.Show(
                    "Chỉ có thể sửa tài khoản User. Vui lòng chọn User.");

                return;
            }

            try
            {
                using var db = new AppDbContext();

                var user = db.Users.FirstOrDefault(
                    u => u.Id == userDangChonId.Value);

                if (user == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy tài khoản User.");

                    LoadTaiKhoan();

                    return;
                }

                var profile = db.UserUses.FirstOrDefault(
                    p => p.UserId == user.Id);

                using var form =
                    new FormNhapTaiKhoan("User", true);

                form.GanThongTin(
                    user.TenTaiKhoan,
                    profile?.HoTen,
                    profile?.NgaySinh,
                    profile?.GioiTinh,
                    profile?.SoDienThoai,
                    profile?.Email,
                    user.CauHoiBaoMat,
                    user.DapAnBaoMat);

                if (form.ShowDialog() != DialogResult.OK)
                    return;

                if (TenTaiKhoanDaTonTai(
                    db,
                    form.TenTaiKhoan,
                    user.Id))
                {
                    MessageBox.Show(
                        "Tên tài khoản đã được sử dụng.",
                        "Trùng tài khoản",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                user.TenTaiKhoan = form.TenTaiKhoan;

                user.CauHoiBaoMat = form.CauHoiBaoMat;

                user.DapAnBaoMat = form.DapAnBaoMat;

                if (!string.IsNullOrWhiteSpace(form.MatKhau))
                {
                    user.MatKhau = form.MatKhau;
                }

                if (profile == null)
                {
                    profile = new UserUse
                    {
                        UserId = user.Id
                    };

                    db.UserUses.Add(profile);
                }

                profile.HoTen = form.HoTen;

                profile.NgaySinh = form.NgaySinh;

                profile.GioiTinh = form.GioiTinh;

                profile.SoDienThoai = form.SoDienThoai;

                profile.Email = form.Email;

                db.SaveChanges();

                MessageBox.Show(
                    "Cập nhật tài khoản User thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadTaiKhoan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể cập nhật tài khoản User:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // XÓA USER
        // ==========================================

        private void XoaUser()
        {
            if (!userDangChonId.HasValue ||
                vaiTroDangChon != "User")
            {
                MessageBox.Show(
                    "Chỉ có thể xóa tài khoản User. Vui lòng chọn User.");

                return;
            }

            var xacNhan = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa tài khoản User này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (xacNhan != DialogResult.Yes)
                return;

            try
            {
                using var db = new AppDbContext();

                int id = userDangChonId.Value;

                // Không xóa User đang sở hữu xe.
                bool coXe = db.UserXes.Any(
                    x => x.UserId == id);

                if (coXe)
                {
                    MessageBox.Show(
                        "Không thể xóa User này vì tài khoản đang liên kết với xe máy.\n" +
                        "Vui lòng xử lý thông tin xe trước.",
                        "Không thể xóa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Bảo vệ lịch sử hóa đơn.
                bool coHoaDon = db.HoaDons.Any(
                    h => h.UserId == id);

                if (coHoaDon)
                {
                    MessageBox.Show(
                        "Không thể xóa User này vì tài khoản đã phát sinh hóa đơn.\n" +
                        "Cần giữ lại dữ liệu để bảo toàn lịch sử giao dịch.",
                        "Không thể xóa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                var user = db.Users.FirstOrDefault(
                    u => u.Id == id);

                if (user == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy tài khoản User.");

                    LoadTaiKhoan();

                    return;
                }

                var profile = db.UserUses.FirstOrDefault(
                    p => p.UserId == id);

                if (profile != null)
                {
                    db.UserUses.Remove(profile);
                }

                db.Users.Remove(user);

                db.SaveChanges();

                MessageBox.Show(
                    "Xóa tài khoản User thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadTaiKhoan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xóa tài khoản User:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
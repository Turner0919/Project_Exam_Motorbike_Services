using Microsoft.EntityFrameworkCore;
using MotorbikeServices.DAL.Models;
using MotorbikeServices.DAL.Models.Account;
using MotorbikeServices.DAL.Models.Maintenance;
using MotorbikeServices.GUI.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MotorbikeServices.GUI.AdminControls
{
    public partial class UcAccount : UserControl
    {
        private int? userDangChonId;
        private string vaiTroDangChon = "";

        private class TaiKhoanHienThi
        {
            public int Id { get; set; }
            public string TenTaiKhoan { get; set; } = "";
            public string VaiTro { get; set; } = "";
            public string HoTen { get; set; } = "";
            public string SoDienThoai { get; set; } = "";
            public string Email { get; set; } = "";
        }

        public UcAccount()
        {
            InitializeComponent();

            CauHinhBang();

            cboVaiTro.Items.Clear();
            cboVaiTro.Items.AddRange(new object[]
            {
                "Tất cả",
                "Admin",
                "User"
            });
            cboVaiTro.SelectedIndex = 0;

            // Admin chỉ được hiển thị, không có nút thêm/sửa/xóa.
            btnThemAdmin.Visible = false;
            btnThemUser.Text = "+ Thêm User";
            lblMoTa.Text = "Quản lý CRUD tài khoản User; tài khoản Admin chỉ xem.";

            txtTimKiem.TextChanged += (s, e) => LoadTaiKhoan();
            cboVaiTro.SelectedIndexChanged += (s, e) => LoadTaiKhoan();
            dgvTaiKhoan.SelectionChanged += dgvTaiKhoan_SelectionChanged;

            btnLamMoi.Click += (s, e) =>
            {
                txtTimKiem.Clear();
                cboVaiTro.SelectedIndex = 0;
                LoadTaiKhoan();
            };

            btnThemUser.Click += (s, e) => ThemUser();
            btnSua.Click += (s, e) => SuaUser();
            btnXoa.Click += (s, e) => XoaUser();

            LoadTaiKhoan();
        }

        private void CauHinhBang()
        {
            if (dgvTaiKhoan.Columns.Count < 6)
            {
                MessageBox.Show(
                    "DataGridView tài khoản cần có đủ 6 cột.",
                    "Lỗi giao diện",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            string[] tenCot =
            {
                "Id", "TenTaiKhoan", "VaiTro",
                "HoTen", "SoDienThoai", "Email"
            };

            for (int i = 0; i < tenCot.Length; i++)
                dgvTaiKhoan.Columns[i].Name = tenCot[i];

            dgvTaiKhoan.Columns["Id"].Visible = false;
            dgvTaiKhoan.AllowUserToAddRows = false;
            dgvTaiKhoan.AllowUserToDeleteRows = false;
            dgvTaiKhoan.AllowUserToResizeColumns = false;
            dgvTaiKhoan.AllowUserToResizeRows = false;
            dgvTaiKhoan.AllowUserToOrderColumns = false;
            dgvTaiKhoan.ReadOnly = true;
            dgvTaiKhoan.MultiSelect = false;
            dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaiKhoan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvTaiKhoan.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTaiKhoan.ColumnHeadersHeight = 38;
            dgvTaiKhoan.RowTemplate.Height = 34;
            dgvTaiKhoan.RowHeadersVisible = false;
            dgvTaiKhoan.ScrollBars = ScrollBars.Vertical;

            dgvTaiKhoan.Columns["TenTaiKhoan"].FillWeight = 22;
            dgvTaiKhoan.Columns["VaiTro"].FillWeight = 12;
            dgvTaiKhoan.Columns["HoTen"].FillWeight = 22;
            dgvTaiKhoan.Columns["SoDienThoai"].FillWeight = 17;
            dgvTaiKhoan.Columns["Email"].FillWeight = 27;

            foreach (DataGridViewColumn column in dgvTaiKhoan.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        // =====================================================
        // LOAD DANH SÁCH ADMIN VÀ USER
        // =====================================================
        private void LoadTaiKhoan()
        {
            try
            {
                using var db = new AppDbContext();

                string tuKhoa = txtTimKiem.Text.Trim().ToLowerInvariant();
                string boLoc = cboVaiTro.SelectedItem?.ToString() ?? "Tất cả";

                var ketQua = new List<TaiKhoanHienThi>();

                // Admin chỉ đọc và hiển thị.
                if (boLoc == "Tất cả" || boLoc == "Admin")
                {
                    var admins = db.Admins
                        .AsNoTracking()
                        .Where(a => a.TenTaiKhoan.ToLower().Contains(tuKhoa))
                        .Select(a => new TaiKhoanHienThi
                        {
                            Id = a.Id,
                            TenTaiKhoan = a.TenTaiKhoan,
                            VaiTro = "Admin"
                        })
                        .ToList();

                    ketQua.AddRange(admins);
                }

                // User có thêm thông tin hồ sơ từ bảng UserUse.
                if (boLoc == "Tất cả" || boLoc == "User")
                {
                    var users = db.Users
                        .AsNoTracking()
                        .Where(u => u.TenTaiKhoan.ToLower().Contains(tuKhoa))
                        .Select(u => new TaiKhoanHienThi
                        {
                            Id = u.Id,
                            TenTaiKhoan = u.TenTaiKhoan,
                            VaiTro = "User"
                        })
                        .ToList();

                    var userIds = users.Select(u => u.Id).ToList();

                    var profiles = db.UserUses
                        .AsNoTracking()
                        .Where(p => userIds.Contains(p.UserId))
                        .ToList();

                    foreach (var user in users)
                    {
                        var profile = profiles.FirstOrDefault(p => p.UserId == user.Id);
                        user.HoTen = profile?.HoTen ?? "";
                        user.SoDienThoai = profile?.SoDienThoai ?? "";
                        user.Email = profile?.Email ?? "";
                    }

                    ketQua.AddRange(users);
                }

                ketQua = ketQua
                    .OrderBy(x => x.VaiTro == "Admin" ? 0 : 1)
                    .ThenBy(x => x.TenTaiKhoan)
                    .ToList();

                dgvTaiKhoan.Rows.Clear();

                foreach (var item in ketQua)
                {
                    dgvTaiKhoan.Rows.Add(
                        item.Id,
                        item.TenTaiKhoan,
                        item.VaiTro,
                        item.HoTen,
                        item.SoDienThoai,
                        item.Email);
                }

                lblTongTaiKhoan.Text =
                    $"Tổng số tài khoản: {ketQua.Count} (Admin: {ketQua.Count(x => x.VaiTro == "Admin")}, User: {ketQua.Count(x => x.VaiTro == "User")})";

                XoaThongTinChiTiet();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải danh sách tài khoản:\n" + ex.Message,
                    "Lỗi dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // CHỌN TÀI KHOẢN
        // =====================================================
        private void dgvTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.CurrentRow == null ||
                dgvTaiKhoan.CurrentRow.IsNewRow ||
                dgvTaiKhoan.CurrentRow.Cells["Id"].Value == null)
            {
                XoaThongTinChiTiet();
                return;
            }

            var row = dgvTaiKhoan.CurrentRow;

            int id = Convert.ToInt32(row.Cells["Id"].Value);
            vaiTroDangChon = Convert.ToString(row.Cells["VaiTro"].Value) ?? "";

            lblChiTietTenTaiKhoan.Text =
                Convert.ToString(row.Cells["TenTaiKhoan"].Value) ?? "";
            lblChiTietVaiTro.Text = vaiTroDangChon;
            lblChiTietHoTen.Text =
                string.IsNullOrWhiteSpace(Convert.ToString(row.Cells["HoTen"].Value))
                    ? "—" : Convert.ToString(row.Cells["HoTen"].Value);
            lblChiTietSoDienThoai.Text =
                string.IsNullOrWhiteSpace(Convert.ToString(row.Cells["SoDienThoai"].Value))
                    ? "—" : Convert.ToString(row.Cells["SoDienThoai"].Value);
            lblChiTietEmail.Text =
                string.IsNullOrWhiteSpace(Convert.ToString(row.Cells["Email"].Value))
                    ? "—" : Convert.ToString(row.Cells["Email"].Value);

            // Chỉ chọn User mới được phép sửa hoặc xóa.
            if (vaiTroDangChon == "User")
            {
                userDangChonId = id;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                userDangChonId = null;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
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

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        // =====================================================
        // KIỂM TRA TÊN TÀI KHOẢN KHÔNG TRÙNG
        // =====================================================
        private bool TenTaiKhoanDaTonTai(
            AppDbContext db,
            string tenTaiKhoan,
            int? userIdDangSua = null)
        {
            string ten = tenTaiKhoan.Trim().ToLowerInvariant();

            bool trungAdmin = db.Admins.Any(a =>
                a.TenTaiKhoan.ToLower() == ten);

            bool trungUser = db.Users.Any(u =>
                u.TenTaiKhoan.ToLower() == ten &&
                (!userIdDangSua.HasValue || u.Id != userIdDangSua.Value));

            return trungAdmin || trungUser;
        }

        // =====================================================
        // THÊM USER
        // =====================================================
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
                        "Tên tài khoản đã tồn tại. Vui lòng chọn tên khác.",
                        "Trùng tài khoản",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                using var transaction = db.Database.BeginTransaction();

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

        // =====================================================
        // SỬA USER
        // =====================================================
        private void SuaUser()
        {
            if (!userDangChonId.HasValue || vaiTroDangChon != "User")
            {
                MessageBox.Show("Chỉ có thể sửa tài khoản User. Vui lòng chọn một User.");
                return;
            }

            try
            {
                using var db = new AppDbContext();

                var user = db.Users.FirstOrDefault(u => u.Id == userDangChonId.Value);
                if (user == null)
                {
                    MessageBox.Show("Không tìm thấy tài khoản User.");
                    LoadTaiKhoan();
                    return;
                }

                var profile = db.UserUses.FirstOrDefault(p => p.UserId == user.Id);

                using var form = new FormNhapTaiKhoan("User", true);
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

                if (TenTaiKhoanDaTonTai(db, form.TenTaiKhoan, user.Id))
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
                    user.MatKhau = form.MatKhau;

                if (profile == null)
                {
                    profile = new UserUse { UserId = user.Id };
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

        // =====================================================
        // XÓA USER
        // =====================================================
        private void XoaUser()
        {
            if (!userDangChonId.HasValue || vaiTroDangChon != "User")
            {
                MessageBox.Show("Chỉ có thể xóa tài khoản User. Vui lòng chọn một User.");
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

                // Không xóa User đang sở hữu xe để tránh lỗi khóa ngoại/mất liên kết.
                bool coXe = db.UserXes.Any(x => x.UserId == id);
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

                var user = db.Users.FirstOrDefault(u => u.Id == id);
                if (user == null)
                {
                    MessageBox.Show("Không tìm thấy tài khoản User.");
                    LoadTaiKhoan();
                    return;
                }

                var profile = db.UserUses.FirstOrDefault(p => p.UserId == id);
                if (profile != null)
                    db.UserUses.Remove(profile);

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

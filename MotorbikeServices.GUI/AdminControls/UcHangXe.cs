
using Microsoft.EntityFrameworkCore;
using MotorbikeServices.DAL.Models;
using MotorbikeServices.GUI.Setup;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MotorbikeServices.GUI.AdminControls
{
    public partial class UcHangXe : UserControl
    {
        private bool dangTaiHangXe = false;

        public UcHangXe()
        {
            InitializeComponent();

            // Thêm cột ẩn để giữ ID thật trong Database.
            ThemCotIDAn();

            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;

            dgvHangXe.SelectionChanged += dgvHangXe_SelectionChanged;

            txtTimKiemDongXe.TextChanged += txtTimKiemDongXe_TextChanged;
            btnThemDongXe.Click += btnThemDongXe_Click;
            btnSuaDongXe.Click += btnSuaDongXe_Click;
            btnXoaDongXe.Click += btnXoaDongXe_Click;
            btnLamMoiDongXe.Click += btnLamMoiDongXe_Click;

            splitMain.SizeChanged += splitMain_SizeChanged;

            LoadHangXe();
        }

        // ==================== CẤU HÌNH ID ====================

        private void ThemCotIDAn()
        {
            if (!dgvHangXe.Columns.Contains("IdHangAn"))
            {
                dgvHangXe.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "IdHangAn",
                    Visible = false
                });
            }

            if (!dgvDongXe.Columns.Contains("IdDongXeAn"))
            {
                dgvDongXe.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "IdDongXeAn",
                    Visible = false
                });
            }

            // Cột đầu tiên chỉ hiển thị số thứ tự.
            dgvHangXe.Columns["MaHang"].HeaderText = "STT";
            dgvDongXe.Columns["MaDongXe"].HeaderText = "STT";
        }

        private int? LayHangXeDangChon()
        {
            if (dgvHangXe.CurrentRow == null ||
                dgvHangXe.CurrentRow.Cells["IdHangAn"].Value == null)
            {
                return null;
            }

            return Convert.ToInt32(
                dgvHangXe.CurrentRow.Cells["IdHangAn"].Value);
        }

        private int? LayDongXeDangChon()
        {
            if (dgvDongXe.CurrentRow == null ||
                dgvDongXe.CurrentRow.Cells["IdDongXeAn"].Value == null)
            {
                return null;
            }

            return Convert.ToInt32(
                dgvDongXe.CurrentRow.Cells["IdDongXeAn"].Value);
        }

        // ==================== GIAO DIỆN ====================

        private void splitMain_SizeChanged(object? sender, EventArgs e)
        {
            int maxWidth = splitMain.Width - splitMain.SplitterWidth;

            if (maxWidth > 0)
                splitMain.SplitterDistance = maxWidth / 2;
        }

        // ==================== HÃNG XE ====================

        private void LoadHangXe(
            string tuKhoa = "", int? hangXeIdCanChon = null)
        {
            int? idCu = hangXeIdCanChon ?? LayHangXeDangChon();

            try
            {
                using (var db = new AppDbContext())
                {
                    var query = db.HangXes.AsQueryable();

                    if (!string.IsNullOrWhiteSpace(tuKhoa))
                    {
                        string keyword = tuKhoa.Trim().ToLower();

                        query = query.Where(h =>
                            h.TenHang.ToLower().Contains(keyword) ||
                            (h.QuocGia != null &&
                             h.QuocGia.ToLower().Contains(keyword)));
                    }

                    var danhSach = query
                        .OrderBy(h => h.TenHang)
                        .ToList();

                    dangTaiHangXe = true;

                    try
                    {
                        dgvHangXe.Rows.Clear();

                        int stt = 1;

                        foreach (var hangXe in danhSach)
                        {
                            dgvHangXe.Rows.Add(
                                stt++,
                                hangXe.TenHang,
                                hangXe.QuocGia ?? "",
                                hangXe.Id);
                        }

                        // Giữ hãng đang chọn sau khi tải lại.
                        int viTri = -1;

                        if (idCu.HasValue)
                        {
                            foreach (DataGridViewRow row in dgvHangXe.Rows)
                            {
                                if (Convert.ToInt32(
                                    row.Cells["IdHangAn"].Value) == idCu.Value)
                                {
                                    viTri = row.Index;
                                    break;
                                }
                            }
                        }

                        if (viTri < 0 && dgvHangXe.Rows.Count > 0)
                            viTri = 0;

                        if (viTri >= 0)
                        {
                            dgvHangXe.CurrentCell =
                                dgvHangXe.Rows[viTri].Cells["TenHang"];

                            dgvHangXe.Rows[viTri].Selected = true;
                        }
                    }
                    finally
                    {
                        dangTaiHangXe = false;
                    }
                }

                LoadDongXe(txtTimKiemDongXe.Text);
            }
            catch (Exception ex)
            {
                dangTaiHangXe = false;

                MessageBox.Show(
                    "Không thể tải danh sách hãng xe:\n" + ex.Message);
            }
        }

        private void txtTimKiem_TextChanged(object? sender, EventArgs e)
        {
            LoadHangXe(txtTimKiem.Text);
        }

        private void btnThem_Click(object? sender, EventArgs e)
        {
            using (var frm = new frmThemHangXe())
            {
                if (frm.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (var db = new AppDbContext())
                    {
                        string ten = frm.TenHangMoi.Trim();

                        if (db.HangXes.Any(h =>
                            h.TenHang.ToLower() == ten.ToLower()))
                        {
                            MessageBox.Show("Tên hãng xe đã tồn tại.");
                            return;
                        }

                        db.HangXes.Add(new HangXe
                        {
                            TenHang = ten,
                            QuocGia = frm.QuocGiaMoi
                        });

                        db.SaveChanges();
                    }

                    MessageBox.Show("Thêm hãng xe thành công.");
                    LoadHangXe(txtTimKiem.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm hãng xe:\n" + ex.Message);
                }
            }
        }

        private void btnSua_Click(object? sender, EventArgs e)
        {
            int? idChon = LayHangXeDangChon();

            if (!idChon.HasValue)
            {
                MessageBox.Show("Vui lòng chọn hãng xe cần sửa.");
                return;
            }

            int id = idChon.Value;

            string ten = dgvHangXe.CurrentRow!
                .Cells["TenHang"].Value?.ToString() ?? "";

            string quocGia = dgvHangXe.CurrentRow!
                .Cells["QuocGia"].Value?.ToString() ?? "";

            using (var frm = new frmThemHangXe(ten, quocGia))
            {
                if (frm.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (var db = new AppDbContext())
                    {
                        string tenMoi = frm.TenHangMoi.Trim();

                        if (db.HangXes.Any(h =>
                            h.Id != id &&
                            h.TenHang.ToLower() == tenMoi.ToLower()))
                        {
                            MessageBox.Show("Tên hãng xe đã tồn tại.");
                            return;
                        }

                        var hangXe = db.HangXes.Find(id);

                        if (hangXe == null)
                            return;

                        hangXe.TenHang = tenMoi;
                        hangXe.QuocGia = frm.QuocGiaMoi;

                        db.SaveChanges();
                    }

                    MessageBox.Show("Cập nhật hãng xe thành công.");
                    LoadHangXe(txtTimKiem.Text, id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sửa hãng xe:\n" + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object? sender, EventArgs e)
        {
            int? idChon = LayHangXeDangChon();

            if (!idChon.HasValue)
            {
                MessageBox.Show("Vui lòng chọn hãng xe cần xóa.");
                return;
            }

            int id = idChon.Value;

            string ten = dgvHangXe.CurrentRow!
                .Cells["TenHang"].Value?.ToString() ?? "";

            if (MessageBox.Show(
                $"Bạn có chắc muốn xóa hãng '{ten}' không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (var db = new AppDbContext())
                {
                    if (db.DongXes.Any(d => d.HangXeId == id))
                    {
                        MessageBox.Show(
                            "Không thể xóa hãng xe đang có dòng xe liên quan.");
                        return;
                    }

                    var hangXe = db.HangXes.Find(id);

                    if (hangXe != null)
                    {
                        db.HangXes.Remove(hangXe);
                        db.SaveChanges();
                    }
                }

                MessageBox.Show("Xóa hãng xe thành công.");
                LoadHangXe(txtTimKiem.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa hãng xe:\n" + ex.Message);
            }
        }

        private void btnLamMoi_Click(object? sender, EventArgs e)
        {
            txtTimKiem.Clear();
            LoadHangXe();
        }

        // ==================== DÒNG XE ====================

        private void dgvHangXe_SelectionChanged(object? sender, EventArgs e)
        {
            if (!dangTaiHangXe)
                LoadDongXe(txtTimKiemDongXe.Text);
        }

        private void LoadDongXe(string tuKhoa = "")
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var query = db.DongXes
                        .Include(d => d.HangXe)
                        .AsQueryable();

                    int? hangXeId = LayHangXeDangChon();

                    if (hangXeId.HasValue)
                        query = query.Where(d => d.HangXeId == hangXeId.Value);

                    if (!string.IsNullOrWhiteSpace(tuKhoa))
                    {
                        string keyword = tuKhoa.Trim().ToLower();

                        query = query.Where(d =>
                            d.TenDongXe.ToLower().Contains(keyword) ||
                            (d.HangXe != null &&
                             d.HangXe.TenHang.ToLower().Contains(keyword)));
                    }

                    var danhSach = query
                        .OrderBy(d => d.TenDongXe)
                        .ToList();

                    dgvDongXe.Rows.Clear();

                    int stt = 1;

                    foreach (var dongXe in danhSach)
                    {
                        dgvDongXe.Rows.Add(
                            stt++,
                            dongXe.TenDongXe,
                            dongXe.HangXe != null
                                ? dongXe.HangXe.TenHang
                                : "",
                            dongXe.Id);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải danh sách dòng xe:\n" + ex.Message);
            }
        }

        private void txtTimKiemDongXe_TextChanged(
            object? sender, EventArgs e)
        {
            LoadDongXe(txtTimKiemDongXe.Text);
        }

        private void btnThemDongXe_Click(object? sender, EventArgs e)
        {
            int? hangXeId = LayHangXeDangChon();

            if (!hangXeId.HasValue)
            {
                MessageBox.Show("Vui lòng chọn hãng xe trước.");
                return;
            }

            using (var frm = new frmThemDongXe(hangXeId))
            {
                if (frm.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (var db = new AppDbContext())
                    {
                        string tenMoi = frm.TenDongXeMoi.Trim();

                        bool trungTen = db.DongXes.Any(d =>
                            d.HangXeId == frm.HangXeIdMoi &&
                            d.TenDongXe.ToLower() == tenMoi.ToLower());

                        if (trungTen)
                        {
                            MessageBox.Show(
                                "Tên dòng xe đã tồn tại trong hãng này.");
                            return;
                        }

                        db.DongXes.Add(new DongXe
                        {
                            HangXeId = frm.HangXeIdMoi,
                            TenDongXe = tenMoi
                        });

                        db.SaveChanges();
                    }

                    LoadHangXe(txtTimKiem.Text, frm.HangXeIdMoi);

                    MessageBox.Show("Thêm dòng xe thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm dòng xe:\n" + ex.Message);
                }
            }
        }

        private void btnSuaDongXe_Click(object? sender, EventArgs e)
        {
            int? idChon = LayDongXeDangChon();

            if (!idChon.HasValue)
            {
                MessageBox.Show("Vui lòng chọn dòng xe cần sửa.");
                return;
            }

            int id = idChon.Value;

            int? hangXeId = LayHangXeDangChon();

            string tenDongXe = dgvDongXe.CurrentRow!
                .Cells["TenDongXe"].Value?.ToString() ?? "";

            using (var frm = new frmThemDongXe(hangXeId, tenDongXe))
            {
                if (frm.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (var db = new AppDbContext())
                    {
                        string tenMoi = frm.TenDongXeMoi.Trim();

                        bool trungTen = db.DongXes.Any(d =>
                            d.Id != id &&
                            d.HangXeId == frm.HangXeIdMoi &&
                            d.TenDongXe.ToLower() == tenMoi.ToLower());

                        if (trungTen)
                        {
                            MessageBox.Show(
                                "Tên dòng xe đã tồn tại trong hãng này.");
                            return;
                        }

                        var dongXe = db.DongXes.Find(id);

                        if (dongXe == null)
                            return;

                        dongXe.TenDongXe = tenMoi;
                        dongXe.HangXeId = frm.HangXeIdMoi;

                        db.SaveChanges();
                    }

                    LoadHangXe(txtTimKiem.Text, frm.HangXeIdMoi);

                    MessageBox.Show("Cập nhật dòng xe thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sửa dòng xe:\n" + ex.Message);
                }
            }
        }

        private void btnXoaDongXe_Click(object? sender, EventArgs e)
        {
            int? idChon = LayDongXeDangChon();

            if (!idChon.HasValue)
            {
                MessageBox.Show("Vui lòng chọn dòng xe cần xóa.");
                return;
            }

            int id = idChon.Value;

            string ten = dgvDongXe.CurrentRow!
                .Cells["TenDongXe"].Value?.ToString() ?? "";

            if (MessageBox.Show(
                $"Bạn có chắc muốn xóa dòng xe '{ten}' không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (var db = new AppDbContext())
                {
                    var dongXe = db.DongXes.Find(id);

                    if (dongXe == null)
                        return;

                    db.DongXes.Remove(dongXe);
                    db.SaveChanges();
                }

                LoadDongXe(txtTimKiemDongXe.Text);

                MessageBox.Show("Xóa dòng xe thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa dòng xe:\n" + ex.Message);
            }
        }

        private void btnLamMoiDongXe_Click(object? sender, EventArgs e)
        {
            txtTimKiemDongXe.Clear();
            LoadDongXe();
        }
    }
}

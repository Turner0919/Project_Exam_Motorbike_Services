using Microsoft.EntityFrameworkCore;
using MotorbikeServices.DAL.Models;
using MotorbikeServices.DAL.Models.Maintenance;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MotorbikeServices.GUI.AdminControls
{
    public partial class UcQuyChuan : UserControl
    {
        private int? hangXeIdDangChon;
        private int? dongXeIdDangChon;
        private int? idQuyChuanDangChon;
        private bool dangTaiDuLieu;

        public UcQuyChuan()
        {
            InitializeComponent();

            CauHinhBang();
            CauHinhNut();
            LoadHangXe();
        }

        // =====================================================
        // 1. CẤU HÌNH GIAO DIỆN DATAGRIDVIEW
        // =====================================================
        private void CauHinhBang()
        {
            CauHinhBangDanhMuc(dgvHangXe);
            CauHinhBangDanhMuc(dgvDongXe);

            dgvHangXe.Columns.Clear();
            dgvHangXe.Columns.Add("TenHang", "Hãng xe");
            dgvHangXe.Columns.Add("IdAn", "ID");
            dgvHangXe.Columns["IdAn"].Visible = false;

            dgvDongXe.Columns.Clear();
            dgvDongXe.Columns.Add("TenDongXe", "Dòng xe");
            dgvDongXe.Columns.Add("IdAn", "ID");
            dgvDongXe.Columns["IdAn"].Visible = false;

            dgvQuyChuan.Columns.Clear();
            dgvQuyChuan.Columns.Add("STT", "STT");
            dgvQuyChuan.Columns.Add("TenQuyChuan", "Tên quy chuẩn");
            dgvQuyChuan.Columns.Add("SoKm", "Số km");
            dgvQuyChuan.Columns.Add("ChiPhi", "Chi phí (VNĐ)");
            dgvQuyChuan.Columns.Add("MoTa", "Mô tả");
            dgvQuyChuan.Columns.Add("IdAn", "ID");
            dgvQuyChuan.Columns["IdAn"].Visible = false;

            dgvQuyChuan.Columns["STT"].FillWeight = 8;
            dgvQuyChuan.Columns["TenQuyChuan"].FillWeight = 27;
            dgvQuyChuan.Columns["SoKm"].FillWeight = 13;
            dgvQuyChuan.Columns["ChiPhi"].FillWeight = 19;
            dgvQuyChuan.Columns["MoTa"].FillWeight = 33;

            dgvQuyChuan.Columns["STT"].MinimumWidth = 45;
            dgvQuyChuan.Columns["TenQuyChuan"].MinimumWidth = 150;
            dgvQuyChuan.Columns["SoKm"].MinimumWidth = 85;
            dgvQuyChuan.Columns["ChiPhi"].MinimumWidth = 120;
            dgvQuyChuan.Columns["MoTa"].MinimumWidth = 160;

            dgvQuyChuan.Columns["STT"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvQuyChuan.Columns["SoKm"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvQuyChuan.Columns["ChiPhi"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;

            CauHinhBangDanhMuc(dgvHangXe);
            CauHinhBangDanhMuc(dgvDongXe);
            CauHinhBangDanhMuc(dgvQuyChuan);

            dgvQuyChuan.ColumnHeadersVisible = true;
            dgvQuyChuan.ColumnHeadersHeight = 42;
            dgvQuyChuan.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvQuyChuan.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvQuyChuan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvQuyChuan.RowTemplate.Height = 38;
        }

        private void CauHinhBangDanhMuc(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToResizeColumns = false;

            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersVisible = false;
            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.FromArgb(230, 234, 240);
            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(25, 45, 80);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 4, 0);

            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(40, 52, 70);
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(220, 235, 252);
            dgv.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(25, 45, 80);
            dgv.DefaultCellStyle.Padding = new Padding(7, 0, 4, 0);

            dgv.RowTemplate.Height = 36;
            dgv.ColumnHeadersVisible = true;
            dgv.ColumnHeadersHeight = 34;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }

        private void CauHinhNut()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnThem.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(27, 140, 82);
            btnSua.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(25, 125, 185);
            btnXoa.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(180, 50, 50);
            btnLamMoi.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(215, 222, 232);
        }

        // =====================================================
        // 2. TẢI HÃNG XE
        // =====================================================
        private void LoadHangXe()
        {
            try
            {
                dangTaiDuLieu = true;

                using (var db = new AppDbContext())
                {
                    var danhSach = db.HangXes
                        .AsNoTracking()
                        .OrderBy(h => h.TenHang)
                        .ToList();

                    dgvHangXe.Rows.Clear();

                    foreach (var hang in danhSach)
                        dgvHangXe.Rows.Add(hang.TenHang, hang.Id);
                }

                hangXeIdDangChon = null;
                dongXeIdDangChon = null;
                idQuyChuanDangChon = null;

                dgvHangXe.ClearSelection();
                dgvDongXe.Rows.Clear();
                dgvQuyChuan.Rows.Clear();

                if (dgvHangXe.Rows.Count > 0)
                {
                    dgvHangXe.Rows[0].Selected = true;
                    hangXeIdDangChon = Convert.ToInt32(
                        dgvHangXe.Rows[0].Cells["IdAn"].Value);

                    dangTaiDuLieu = false;
                    LoadDongXe();
                }
                else
                {
                    lblDongXeDangChon.Text = "Chưa có dữ liệu hãng xe";
                    CapNhatTrangThaiNut();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải danh sách hãng xe:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                dangTaiDuLieu = false;
            }
        }

        private void dgvHangXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dangTaiDuLieu)
                return;

            var row = dgvHangXe.Rows[e.RowIndex];
            if (row.Cells["IdAn"].Value == null)
                return;

            hangXeIdDangChon = Convert.ToInt32(row.Cells["IdAn"].Value);
            LoadDongXe();
        }

        // =====================================================
        // 3. TẢI / CHỌN DÒNG XE
        // =====================================================
        private void LoadDongXe()
        {
            if (!hangXeIdDangChon.HasValue)
                return;

            try
            {
                dangTaiDuLieu = true;

                using (var db = new AppDbContext())
                {
                    var danhSach = db.DongXes
                        .AsNoTracking()
                        .Where(d => d.HangXeId == hangXeIdDangChon.Value)
                        .OrderBy(d => d.TenDongXe)
                        .ToList();

                    dgvDongXe.Rows.Clear();

                    foreach (var dong in danhSach)
                        dgvDongXe.Rows.Add(dong.TenDongXe, dong.Id);
                }

                dongXeIdDangChon = null;
                idQuyChuanDangChon = null;
                dgvDongXe.ClearSelection();
                dgvQuyChuan.Rows.Clear();

                if (dgvDongXe.Rows.Count > 0)
                {
                    dgvDongXe.Rows[0].Selected = true;
                    dongXeIdDangChon = Convert.ToInt32(
                        dgvDongXe.Rows[0].Cells["IdAn"].Value);

                    lblDongXeDangChon.Text =
                        "Dòng xe: " +
                        Convert.ToString(dgvDongXe.Rows[0].Cells["TenDongXe"].Value);

                    dangTaiDuLieu = false;
                    LoadQuyChuan();
                }
                else
                {
                    lblDongXeDangChon.Text = "Hãng xe này chưa có dòng xe";
                    CapNhatTrangThaiNut();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải danh sách dòng xe:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                dangTaiDuLieu = false;
            }
        }

        private void dgvDongXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dangTaiDuLieu)
                return;

            var row = dgvDongXe.Rows[e.RowIndex];
            if (row.Cells["IdAn"].Value == null)
                return;

            dongXeIdDangChon = Convert.ToInt32(row.Cells["IdAn"].Value);
            lblDongXeDangChon.Text =
                "Dòng xe: " + Convert.ToString(row.Cells["TenDongXe"].Value);

            LoadQuyChuan();
        }

        // =====================================================
        // 4. TẢI QUY CHUẨN THEO DÒNG XE
        // =====================================================
        private void LoadQuyChuan()
        {
            if (!dongXeIdDangChon.HasValue)
            {
                dgvQuyChuan.Rows.Clear();
                idQuyChuanDangChon = null;
                CapNhatTrangThaiNut();
                return;
            }

            try
            {
                dangTaiDuLieu = true;

                using (var db = new AppDbContext())
                {
                    var query = db.QuyChuanBaoDuongs
                        .AsNoTracking()
                        .Where(q => q.DongXeId == dongXeIdDangChon.Value);

                    string tuKhoa = txtTimKiem.Text.Trim();
                    if (!string.IsNullOrWhiteSpace(tuKhoa))
                        query = query.Where(q => q.TenQuyChuan.Contains(tuKhoa));

                    var danhSach = query
                        .OrderBy(q => q.SoKm)
                        .ThenBy(q => q.TenQuyChuan)
                        .ToList();

                    dgvQuyChuan.Rows.Clear();

                    int stt = 1;
                    foreach (var q in danhSach)
                    {
                        dgvQuyChuan.Rows.Add(
                            stt++,
                            q.TenQuyChuan,
                            q.SoKm.ToString("N0"),
                            q.ChiPhi.ToString("N0"),
                            q.MoTa ?? string.Empty,
                            q.Id);
                    }
                }

                idQuyChuanDangChon = null;
                dgvQuyChuan.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải danh sách quy chuẩn:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                dangTaiDuLieu = false;
                CapNhatTrangThaiNut();
            }
        }

        private void dgvQuyChuan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dangTaiDuLieu)
                return;

            var row = dgvQuyChuan.Rows[e.RowIndex];
            if (row.Cells["IdAn"].Value == null)
                return;

            idQuyChuanDangChon = Convert.ToInt32(row.Cells["IdAn"].Value);
            CapNhatTrangThaiNut();
        }

        // =====================================================
        // 5. THÊM QUY CHUẨN
        // =====================================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!dongXeIdDangChon.HasValue)
            {
                MessageBox.Show("Vui lòng chọn dòng xe trước khi thêm quy chuẩn.");
                return;
            }

            using (var form = new FormNhapQuyChuan())
            {
                form.Text = "Thêm quy chuẩn bảo dưỡng";

                if (form.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (var db = new AppDbContext())
                    {
                        var q = new QuyChuanBaoDuong
                        {
                            DongXeId = dongXeIdDangChon.Value,
                            TenQuyChuan = form.TenQuyChuan,
                            SoKm = form.SoKm,
                            ChiPhi = form.ChiPhi,
                            MoTa = form.MoTa
                        };

                        db.QuyChuanBaoDuongs.Add(q);
                        db.SaveChanges();
                    }

                    MessageBox.Show(
                        "Thêm quy chuẩn thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadQuyChuan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm quy chuẩn:\n" + ex.Message,
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // =====================================================
        // 6. SỬA QUY CHUẨN
        // =====================================================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!idQuyChuanDangChon.HasValue)
            {
                MessageBox.Show("Vui lòng chọn quy chuẩn cần sửa.");
                return;
            }

            try
            {
                using (var db = new AppDbContext())
                {
                    var q = db.QuyChuanBaoDuongs
                        .FirstOrDefault(x => x.Id == idQuyChuanDangChon.Value);

                    if (q == null)
                    {
                        MessageBox.Show("Không tìm thấy quy chuẩn.");
                        LoadQuyChuan();
                        return;
                    }

                    using (var form = new FormNhapQuyChuan())
                    {
                        form.Text = "Cập nhật quy chuẩn bảo dưỡng";
                        form.TenQuyChuan = q.TenQuyChuan;
                        form.SoKm = q.SoKm;
                        form.ChiPhi = q.ChiPhi;
                        form.MoTa = q.MoTa ?? string.Empty;

                        if (form.ShowDialog() != DialogResult.OK)
                            return;

                        q.TenQuyChuan = form.TenQuyChuan;
                        q.SoKm = form.SoKm;
                        q.ChiPhi = form.ChiPhi;
                        q.MoTa = form.MoTa;

                        db.SaveChanges();
                    }
                }

                MessageBox.Show(
                    "Cập nhật quy chuẩn thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadQuyChuan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật quy chuẩn:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // 7. XÓA QUY CHUẨN
        // =====================================================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!idQuyChuanDangChon.HasValue)
            {
                MessageBox.Show("Vui lòng chọn quy chuẩn cần xóa.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa quy chuẩn này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using (var db = new AppDbContext())
                {
                    var q = db.QuyChuanBaoDuongs
                        .FirstOrDefault(x => x.Id == idQuyChuanDangChon.Value);

                    if (q != null)
                    {
                        db.QuyChuanBaoDuongs.Remove(q);
                        db.SaveChanges();
                    }
                }

                MessageBox.Show(
                    "Xóa quy chuẩn thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadQuyChuan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa quy chuẩn:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // 8. TÌM KIẾM / LÀM MỚI / TRẠNG THÁI
        // =====================================================
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (!dangTaiDuLieu)
                LoadQuyChuan();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            LoadHangXe();
        }

        private void CapNhatTrangThaiNut()
        {
            bool coDongXe = dongXeIdDangChon.HasValue;
            bool coQuyChuan = idQuyChuanDangChon.HasValue;

            btnThem.Enabled = coDongXe;
            btnSua.Enabled = coQuyChuan;
            btnXoa.Enabled = coQuyChuan;
        }
    }
}

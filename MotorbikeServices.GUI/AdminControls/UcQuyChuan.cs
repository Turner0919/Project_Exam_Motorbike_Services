
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
        private int? idDangChon = null;
        private bool dangTaiDuLieu = false;

        public UcQuyChuan()
        {
            InitializeComponent();

            // Không tạo thêm Label vì Designer đã có sẵn tiêu đề.
            CauHinhBang();

            LoadQuyChuan();
        }

        // =========================
        // 1. CẤU HÌNH DATAGRIDVIEW
        // =========================
        private void CauHinhBang()
        {
            dgvQuyChuan.Columns.Clear();

            dgvQuyChuan.Columns.Add("STT", "STT");
            dgvQuyChuan.Columns.Add("TenQuyChuan", "Tên quy chuẩn");
            dgvQuyChuan.Columns.Add("LoaiXe", "Loại xe");
            dgvQuyChuan.Columns.Add("SoKm", "Số km");
            dgvQuyChuan.Columns.Add("ChiPhi", "Chi phí (VNĐ)");
            dgvQuyChuan.Columns.Add("MoTa", "Mô tả");
            dgvQuyChuan.Columns.Add("IdAn", "ID");

            dgvQuyChuan.Columns["IdAn"].Visible = false;

            dgvQuyChuan.Columns["STT"].FillWeight = 35;
            dgvQuyChuan.Columns["TenQuyChuan"].FillWeight = 130;
            dgvQuyChuan.Columns["LoaiXe"].FillWeight = 70;
            dgvQuyChuan.Columns["SoKm"].FillWeight = 55;
            dgvQuyChuan.Columns["ChiPhi"].FillWeight = 85;
            dgvQuyChuan.Columns["MoTa"].FillWeight = 110;

            dgvQuyChuan.Columns["STT"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvQuyChuan.Columns["SoKm"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
        }

        // =========================
        // 2. TẢI DANH SÁCH
        // =========================
        private void LoadQuyChuan()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var query = db.QuyChuanBaoDuongs.AsQueryable();

                    string tuKhoa = txtTimKiem.Text.Trim();

                    if (!string.IsNullOrWhiteSpace(tuKhoa))
                    {
                        query = query.Where(q =>
                            q.TenQuyChuan.Contains(tuKhoa));
                    }

                    var danhSach = query
                        .OrderBy(q => q.LoaiXe)
                        .ThenBy(q => q.SoKm)
                        .ToList();

                    dangTaiDuLieu = true;

                    dgvQuyChuan.Rows.Clear();

                    int stt = 1;

                    foreach (var q in danhSach)
                    {
                        dgvQuyChuan.Rows.Add(
                            stt++,
                            q.TenQuyChuan,
                            q.LoaiXe,
                            q.SoKm.ToString("N0"),
                            q.ChiPhi.ToString("N0"),
                            q.MoTa ?? "",
                            q.Id
                        );
                    }

                    idDangChon = null;
                    dgvQuyChuan.ClearSelection();
                }
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
            }
        }

        // =========================
        // 3. CHỌN DÒNG
        // =========================
        private void dgvQuyChuan_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvQuyChuan.Rows[e.RowIndex];

            if (row.Cells["IdAn"].Value == null)
                return;

            idDangChon = Convert.ToInt32(
                row.Cells["IdAn"].Value);
        }

        // =========================
        // 4. THÊM
        // =========================
        private void btnThem_Click(object sender, EventArgs e)
        {
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
                            LoaiXe = form.LoaiXe,
                            TenQuyChuan = form.TenQuyChuan,
                            SoKm = form.SoKm,
                            ChiPhi = form.ChiPhi,
                            MoTa = form.MoTa
                        };

                        db.QuyChuanBaoDuongs.Add(q);
                        db.SaveChanges();
                    }

                    MessageBox.Show("Thêm quy chuẩn thành công!");

                    LoadQuyChuan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Lỗi thêm quy chuẩn:\n" + ex.Message);
                }
            }
        }

        // =========================
        // 5. SỬA
        // =========================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!idDangChon.HasValue)
            {
                MessageBox.Show("Vui lòng chọn quy chuẩn cần sửa.");
                return;
            }

            try
            {
                using (var db = new AppDbContext())
                {
                    var q = db.QuyChuanBaoDuongs
                        .FirstOrDefault(x => x.Id == idDangChon.Value);

                    if (q == null)
                    {
                        MessageBox.Show("Không tìm thấy quy chuẩn.");
                        LoadQuyChuan();
                        return;
                    }

                    using (var form = new FormNhapQuyChuan())
                    {
                        form.Text = "Cập nhật quy chuẩn bảo dưỡng";

                        form.LoaiXe = q.LoaiXe;
                        form.TenQuyChuan = q.TenQuyChuan;
                        form.SoKm = q.SoKm;
                        form.ChiPhi = q.ChiPhi;
                        form.MoTa = q.MoTa ?? "";

                        if (form.ShowDialog() != DialogResult.OK)
                            return;

                        q.LoaiXe = form.LoaiXe;
                        q.TenQuyChuan = form.TenQuyChuan;
                        q.SoKm = form.SoKm;
                        q.ChiPhi = form.ChiPhi;
                        q.MoTa = form.MoTa;

                        db.SaveChanges();
                    }
                }

                MessageBox.Show("Cập nhật quy chuẩn thành công!");

                LoadQuyChuan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi cập nhật quy chuẩn:\n" + ex.Message);
            }
        }

        // =========================
        // 6. XÓA
        // =========================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!idDangChon.HasValue)
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
                        .FirstOrDefault(x => x.Id == idDangChon.Value);

                    if (q != null)
                    {
                        db.QuyChuanBaoDuongs.Remove(q);
                        db.SaveChanges();
                    }
                }

                MessageBox.Show("Xóa quy chuẩn thành công!");

                LoadQuyChuan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi xóa quy chuẩn:\n" + ex.Message);
            }
        }

        // =========================
        // 7. LÀM MỚI
        // =========================
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            LoadQuyChuan();
        }

        // =========================
        // 8. TÌM KIẾM
        // =========================
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadQuyChuan();
        }
    }
}

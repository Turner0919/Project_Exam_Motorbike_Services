
using MotorbikeServices.DAL.Models;
using MotorbikeServices.GUI.Setup;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MotorbikeServices.GUI.AdminControls
{
    public partial class UcHangXe : UserControl
    {
        private readonly Color navy = Color.FromArgb(25, 45, 80);
        private readonly Color blue = Color.FromArgb(55, 126, 184);
        private readonly Color background = Color.FromArgb(245, 247, 250);

        public UcHangXe()
        {
            InitializeComponent();

            // Gắn sự kiện cho các control được tạo trong Designer.
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;

            // Đồng bộ màu nền với giao diện hiện tại.
            BackColor = background;
            pnlMain.BackColor = background;
            pnlToolbar.BackColor = background;

            // Co giãn giao diện theo kích thước UserControl.
            pnlMain.Resize += pnlMain_Resize;

            LoadHangXe();
        }

        private void LoadHangXe(string tuKhoa = "")
        {
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

                    dgvHangXe.Rows.Clear();

                    foreach (var hangXe in danhSach)
                    {
                        dgvHangXe.Rows.Add(
                            hangXe.Id,
                            hangXe.TenHang,
                            hangXe.QuocGia ?? ""
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải danh sách hãng xe.\n\n" + ex.Message,
                    "Lỗi kết nối dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadHangXe(txtTimKiem.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var frm = new frmThemHangXe())
            {
                if (frm.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (var db = new AppDbContext())
                    {
                        bool tonTai = db.HangXes.Any(h =>
                            h.TenHang.ToLower() ==
                            frm.TenHangMoi.ToLower());

                        if (tonTai)
                        {
                            MessageBox.Show(
                                "Hãng xe này đã tồn tại trong cơ sở dữ liệu!",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            return;
                        }

                        var hangXeMoi = new HangXe
                        {
                            TenHang = frm.TenHangMoi,
                            QuocGia = frm.QuocGiaMoi
                        };

                        db.HangXes.Add(hangXeMoi);
                        db.SaveChanges();

                        MessageBox.Show(
                            "Thêm hãng xe thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        LoadHangXe(txtTimKiem.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Lỗi khi lưu vào cơ sở dữ liệu:\n\n" + ex.Message,
                        "Lỗi hệ thống",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvHangXe.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn một hãng xe trong bảng để sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            int id = Convert.ToInt32(
                dgvHangXe.CurrentRow.Cells["MaHang"].Value);

            string tenHienTai =
                dgvHangXe.CurrentRow.Cells["TenHang"].Value?.ToString() ?? "";

            string quocGiaHienTai =
                dgvHangXe.CurrentRow.Cells["QuocGia"].Value?.ToString() ?? "";

            using (var frm = new frmThemHangXe(
                tenHienTai, quocGiaHienTai))
            {
                if (frm.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (var db = new AppDbContext())
                    {
                        bool trungTen = db.HangXes.Any(h =>
                            h.Id != id &&
                            h.TenHang.ToLower() ==
                            frm.TenHangMoi.ToLower());

                        if (trungTen)
                        {
                            MessageBox.Show(
                                "Tên hãng xe này đã trùng với một hãng khác trong hệ thống!",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            return;
                        }

                        var hangXe = db.HangXes.Find(id);

                        if (hangXe != null)
                        {
                            hangXe.TenHang = frm.TenHangMoi;
                            hangXe.QuocGia = frm.QuocGiaMoi;

                            db.SaveChanges();

                            MessageBox.Show(
                                "Cập nhật hãng xe thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            LoadHangXe(txtTimKiem.Text);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Lỗi khi cập nhật dữ liệu:\n\n" + ex.Message,
                        "Lỗi hệ thống",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHangXe.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn một hãng xe trong bảng để xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            int id = Convert.ToInt32(
                dgvHangXe.CurrentRow.Cells["MaHang"].Value);

            string tenHang =
                dgvHangXe.CurrentRow.Cells["TenHang"].Value?.ToString() ?? "";

            try
            {
                using (var db = new AppDbContext())
                {
                    bool coDongXeCon =
                        db.DongXes.Any(d => d.HangXeId == id);

                    if (coDongXeCon)
                    {
                        MessageBox.Show(
                            $"Không thể xóa hãng '{tenHang}' vì đang có các dòng xe thuộc hãng này trong cơ sở dữ liệu!\nVui lòng xóa hoặc chuyển các dòng xe liên quan trước.",
                            "Vi phạm toàn vẹn tham chiếu",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop
                        );
                        return;
                    }

                    var xacNhan = MessageBox.Show(
                        $"Bạn có chắc chắn muốn xóa hãng xe '{tenHang}' (Mã: {id}) không?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (xacNhan != DialogResult.Yes)
                        return;

                    var hangXe = db.HangXes.Find(id);

                    if (hangXe != null)
                    {
                        db.HangXes.Remove(hangXe);
                        db.SaveChanges();

                        MessageBox.Show(
                            "Đã xóa hãng xe thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        LoadHangXe(txtTimKiem.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi xóa hãng xe:\n\n" + ex.Message,
                    "Lỗi hệ thống",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            LoadHangXe();
        }

        private void pnlMain_Resize(object sender, EventArgs e)
        {
            int width = Math.Max(100, pnlMain.ClientSize.Width - 24);
            int height = Math.Max(100, pnlMain.ClientSize.Height - 162);

            pnlToolbar.Width = width;
            dgvHangXe.Width = width;
            dgvHangXe.Height = height;
        }
    }
}

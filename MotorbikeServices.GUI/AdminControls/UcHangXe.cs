using MotorbikeServices.DAL.Models;
using MotorbikeServices.GUI.Setup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace MotorbikeServices.GUI.AdminControls
{
    public partial class UcHangXe : UserControl
    {
        private readonly Color navy = Color.FromArgb(25, 45, 80);
        private readonly Color blue = Color.FromArgb(55, 126, 184);
        private readonly Color background = Color.FromArgb(245, 247, 250);

        private DataGridView dgvHangXe;
        private TextBox txtTimKiem;

        public UcHangXe()
        {
            InitializeComponent();
            TaoGiaoDien();
            LoadHangXe();
        }

        private void LoadHangXe(string tuKhoa = "")
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var query = db.HangXes.AsQueryable();

                    // Lọc theo từ khóa nếu người dùng có nhập tìm kiếm
                    if (!string.IsNullOrWhiteSpace(tuKhoa))
                    {
                        string keyword = tuKhoa.Trim().ToLower();
                        query = query.Where(h => h.TenHang.ToLower().Contains(keyword)
                                              || (h.QuocGia != null && h.QuocGia.ToLower().Contains(keyword)));
                    }

                    var danhSach = query.OrderBy(h => h.TenHang).ToList();

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


        private void TaoGiaoDien()
        {
            Controls.Clear();
            BackColor = background;

            Panel pnlMain = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(12),
                BackColor = background
            };

            Controls.Add(pnlMain);

            // Tiêu đề
            Label lblTitle = new Label
            {
                Text = "Quản lý hãng xe và dòng xe",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                ForeColor = navy,
                AutoSize = true,
                Location = new Point(12, 10)
            };

            Label lblDescription = new Label
            {
                Text = "Quản lý thông tin hãng xe và các dòng xe.",
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.FromArgb(95, 112, 135),
                AutoSize = true,
                Location = new Point(14, 52)
            };

            pnlMain.Controls.Add(lblTitle);
            pnlMain.Controls.Add(lblDescription);

            // Thanh công cụ
            Panel pnlToolbar = new Panel
            {
                Location = new Point(12, 95),
                Height = 42,
                Width = 850,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                BackColor = background
            };

            pnlMain.Controls.Add(pnlToolbar);

            txtTimKiem = new TextBox
            {
                Font = new Font("Segoe UI", 10),
                PlaceholderText = "Nhập tên hãng xe để tìm...",
                Location = new Point(0, 7),
                Width = 250
            };
            txtTimKiem.TextChanged += (s, e) => LoadHangXe(txtTimKiem.Text);

            Button btnThem = TaoNut(" + Thêm hãng xe", blue);
            btnThem.Location = new Point(265, 2);
            btnThem.Width = 145;
            btnThem.Click += (s, e) =>
            {
                using (var frm = new frmThemHangXe())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (var db = new AppDbContext())
                            {
                                // Kiểm tra xem tên hãng xe đã tồn tại trong DB chưa để tránh trùng lặp
                                bool tonTai = db.HangXes.Any(h => h.TenHang.ToLower() == frm.TenHangMoi.ToLower());
                                if (tonTai)
                                {
                                    MessageBox.Show("Hãng xe này đã tồn tại trong cơ sở dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                var hangXeMoi = new HangXe
                                {
                                    TenHang = frm.TenHangMoi,
                                    QuocGia = frm.QuocGiaMoi    
                                };

                                db.HangXes.Add(hangXeMoi);
                                db.SaveChanges();

                                MessageBox.Show("Thêm hãng xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Tải lại DataGridView để hiển thị dữ liệu mới
                                LoadHangXe();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi lưu vào cơ sở dữ liệu:\n\n" + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            };

            Button btnSua = TaoNut("Sửa", navy);
            btnSua.Location = new Point(420, 2);
            btnSua.Width = 75;
            btnSua.Click += (s, e) =>
            {
                if (dgvHangXe.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn một hãng xe trong bảng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy dữ liệu từ dòng đang chọn (Selected Row) trên DataGridView
                int id = Convert.ToInt32(dgvHangXe.CurrentRow.Cells["MaHang"].Value);
                string tenHienTai = dgvHangXe.CurrentRow.Cells["TenHang"].Value?.ToString() ?? "";
                string quocGiaHienTai = dgvHangXe.CurrentRow.Cells["QuocGia"].Value?.ToString() ?? "";

                using (var frm = new frmThemHangXe(tenHienTai, quocGiaHienTai))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (var db = new AppDbContext())
                            {
                                // Kiểm tra trùng tên với các hãng KHÁC (Id != id hiện tại)
                                bool trungTen = db.HangXes.Any(h => h.Id != id && h.TenHang.ToLower() == frm.TenHangMoi.ToLower());
                                if (trungTen)
                                {
                                    MessageBox.Show("Tên hãng xe này đã trùng với một hãng khác trong hệ thống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                var hangXe = db.HangXes.Find(id);
                                if (hangXe != null)
                                {
                                    hangXe.TenHang = frm.TenHangMoi;
                                    hangXe.QuocGia = frm.QuocGiaMoi;
                                    db.SaveChanges(); // EF Core Change Tracker tự động sinh câu lệnh UPDATE

                                    MessageBox.Show("Cập nhật hãng xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadHangXe(txtTimKiem.Text);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi cập nhật dữ liệu:\n\n" + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            };

            Button btnXoa = TaoNut("Xóa", Color.FromArgb(180, 65, 65));
            btnXoa.Location = new Point(505, 2);
            btnXoa.Width = 75;
            btnXoa.Click += (s, e) =>
            {
                if (dgvHangXe.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn một hãng xe trong bảng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dgvHangXe.CurrentRow.Cells["MaHang"].Value);
                string tenHang = dgvHangXe.CurrentRow.Cells["TenHang"].Value?.ToString() ?? "";

                try
                {
                    using (var db = new AppDbContext())
                    {
                        // Kiểm tra khóa ngoại (Foreign Key Constraint Check) trước khi xóa
                        bool coDongXeCon = db.DongXes.Any(d => d.HangXeId == id);
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

                        if (xacNhan == DialogResult.Yes)
                        {
                            var hangXe = db.HangXes.Find(id);
                            if (hangXe != null)
                            {
                                db.HangXes.Remove(hangXe);
                                db.SaveChanges(); // EF Core sinh câu lệnh DELETE

                                MessageBox.Show("Đã xóa hãng xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadHangXe(txtTimKiem.Text);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa hãng xe:\n\n" + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            Button btnLamMoi = TaoNut("Làm mới", navy);
            btnLamMoi.Location = new Point(590, 2);
            btnLamMoi.Width = 90;
            btnLamMoi.Click += (s, e) =>
            {
                txtTimKiem.Clear();
                LoadHangXe();
            };

            pnlToolbar.Controls.AddRange(new Control[]
            {
                txtTimKiem, btnThem, btnSua, btnXoa, btnLamMoi
            });

            // Bảng dữ liệu
            dgvHangXe = new DataGridView
            {
                Location = new Point(12, 150),
                Size = new Size(850, 400),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom
                         | AnchorStyles.Left | AnchorStyles.Right,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                MultiSelect = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowHeadersVisible = false,
                EnableHeadersVisualStyles = false
            };

            dgvHangXe.ColumnHeadersDefaultCellStyle.BackColor = navy;
            dgvHangXe.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHangXe.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);
            dgvHangXe.ColumnHeadersHeight = 42;

            dgvHangXe.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvHangXe.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(220, 235, 248);
            dgvHangXe.DefaultCellStyle.SelectionForeColor = navy;
            dgvHangXe.RowTemplate.Height = 36;

            dgvHangXe.Columns.Add("MaHang", "Mã hãng");
            dgvHangXe.Columns.Add("TenHang", "Tên hãng xe");
            dgvHangXe.Columns.Add("QuocGia", "Quốc gia");

            pnlMain.Controls.Add(dgvHangXe);

            // Co giãn bảng theo kích thước trang
            pnlMain.Resize += (s, e) =>
            {
                int width = Math.Max(100, pnlMain.ClientSize.Width - 24);
                int height = Math.Max(100, pnlMain.ClientSize.Height - 162);

                pnlToolbar.Width = width;
                dgvHangXe.Width = width;
                dgvHangXe.Height = height;
            };
        }

        private Button TaoNut(string text, Color mauNen)
        {
            return new Button
            {
                Text = text,
                BackColor = mauNen,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Cursor = Cursors.Hand,
                Height = 36,
                UseVisualStyleBackColor = false
            };
        }
    }
}
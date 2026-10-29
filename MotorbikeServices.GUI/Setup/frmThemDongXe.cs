
using MotorbikeServices.DAL.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MotorbikeServices.GUI.Setup
{
    public partial class frmThemDongXe : Form
    {
        public int HangXeIdMoi { get; private set; }
        public string TenDongXeMoi { get; private set; } = "";

        public frmThemDongXe()
        {
            InitializeComponent();

            btnLuu.Click += btnLuu_Click;
            btnHuy.Click += btnHuy_Click;

            LoadHangXe();
        }

        public frmThemDongXe(
            int? hangXeId, string? tenDongXe = null) : this()
        {
            if (hangXeId.HasValue)
                cboHangXe.SelectedValue = hangXeId.Value;

            txtTenDongXe.Text = tenDongXe ?? "";
        }

        private void LoadHangXe()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var danhSach = db.HangXes
                        .OrderBy(h => h.TenHang)
                        .ToList();

                    cboHangXe.DataSource = danhSach;
                    cboHangXe.DisplayMember = "TenHang";
                    cboHangXe.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải danh sách hãng xe:\n" + ex.Message,
                    "Lỗi dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenDongXe = txtTenDongXe.Text.Trim();

            if (cboHangXe.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn hãng xe.");
                cboHangXe.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tenDongXe))
            {
                MessageBox.Show("Tên dòng xe không được để trống.");
                txtTenDongXe.Focus();
                return;
            }

            if (tenDongXe.Length > 100)
            {
                MessageBox.Show("Tên dòng xe không được vượt quá 100 ký tự.");
                txtTenDongXe.Focus();
                return;
            }

            HangXeIdMoi = Convert.ToInt32(cboHangXe.SelectedValue);
            TenDongXeMoi = tenDongXe;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

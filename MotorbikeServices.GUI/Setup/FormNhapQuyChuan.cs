
using MotorbikeServices.DAL.Models;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace MotorbikeServices.GUI.AdminControls
{
    public partial class FormNhapQuyChuan : Form
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int DongXeId
        {
            get
            {
                if (cboLoaiXe.SelectedValue == null)
                    return 0;

                return Convert.ToInt32(cboLoaiXe.SelectedValue);
            }
            set
            {
                if (value > 0)
                    cboLoaiXe.SelectedValue = value;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string TenQuyChuan
        {
            get => txtTenQuyChuan.Text.Trim();
            set => txtTenQuyChuan.Text = value ?? "";
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SoKm
        {
            get => (int)numSoKm.Value;
            set
            {
                numSoKm.Value = Math.Max(
                    numSoKm.Minimum,
                    Math.Min(numSoKm.Maximum, value));
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public decimal ChiPhi
        {
            get => numChiPhi.Value;
            set
            {
                numChiPhi.Value = Math.Max(
                    numChiPhi.Minimum,
                    Math.Min(numChiPhi.Maximum, value));
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MoTa
        {
            get => txtMoTa.Text.Trim();
            set => txtMoTa.Text = value ?? "";
        }

        public FormNhapQuyChuan()
        {
            InitializeComponent();

            cboLoaiXe.DropDownStyle = ComboBoxStyle.DropDownList;

            NapDanhSachDongXe();

            numSoKm.Value = 1500;
            numChiPhi.Value = 0;
        }

        // =========================
        // 1. TẢI DANH SÁCH DÒNG XE
        // =========================
        private void NapDanhSachDongXe()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var danhSach = db.DongXes
                        .OrderBy(d => d.HangXe.TenHang)
                        .ThenBy(d => d.TenDongXe)
                        .Select(d => new
                        {
                            Id = d.Id,
                            TenHienThi = d.HangXe.TenHang
                                + " - " + d.TenDongXe
                        })
                        .ToList();

                    cboLoaiXe.DataSource = danhSach;
                    cboLoaiXe.DisplayMember = "TenHienThi";
                    cboLoaiXe.ValueMember = "Id";

                    if (danhSach.Count == 0)
                    {
                        cboLoaiXe.Enabled = false;
                        btnLuu.Enabled = false;

                        MessageBox.Show(
                            "Chưa có dòng xe nào. Vui lòng thêm dòng xe trước.",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        cboLoaiXe.SelectedIndex = 0;
                        btnLuu.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                cboLoaiXe.Enabled = false;
                btnLuu.Enabled = false;

                MessageBox.Show(
                    "Không thể tải danh sách dòng xe:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================
        // 2. LƯU
        // =========================
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboLoaiXe.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn dòng xe.");
                cboLoaiXe.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenQuyChuan.Text))
            {
                MessageBox.Show("Vui lòng nhập tên quy chuẩn.");
                txtTenQuyChuan.Focus();
                return;
            }

            if (numSoKm.Value <= 0)
            {
                MessageBox.Show("Số km phải lớn hơn 0.");
                numSoKm.Focus();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        // =========================
        // 3. HỦY
        // =========================
        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

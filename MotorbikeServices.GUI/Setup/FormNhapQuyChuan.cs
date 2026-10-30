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
                if (value > 0 && cboLoaiXe.DataSource != null)
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

        // Constructor mac dinh de Visual Studio Designer khoi tao form.
        public FormNhapQuyChuan()
        {
            InitializeComponent();

            cboLoaiXe.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiXe.DisplayMember = "TenHienThi";
            cboLoaiXe.ValueMember = "Id";

            numSoKm.Value = 1500;
            numChiPhi.Value = 0;
        }

        // Constructor dung khi mo form tu man hinh quan ly quy chuan.
        // Chi nap cac dong xe thuoc hang xe dang duoc chon.
        public FormNhapQuyChuan(int hangXeId, int? dongXeIdMacDinh = null)
            : this()
        {
            NapDanhSachDongXe(hangXeId, dongXeIdMacDinh);
        }

        // =========================
        // 1. TAI DONG XE THEO HANG XE
        // =========================
        private void NapDanhSachDongXe(int hangXeId, int? dongXeIdMacDinh)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var danhSach = db.DongXes
                        .Where(d => d.HangXeId == hangXeId)
                        .OrderBy(d => d.TenDongXe)
                        .Select(d => new
                        {
                            Id = d.Id,
                            TenHienThi = d.HangXe.TenHang + " - " + d.TenDongXe
                        })
                        .ToList();

                    cboLoaiXe.DataSource = danhSach;

                    if (danhSach.Count == 0)
                    {
                        cboLoaiXe.Enabled = false;
                        btnLuu.Enabled = false;

                        MessageBox.Show(
                            "Hãng xe này chưa có dòng xe nào. Vui lòng thêm dòng xe trước.",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        return;
                    }

                    cboLoaiXe.Enabled = true;
                    btnLuu.Enabled = true;

                    if (dongXeIdMacDinh.HasValue &&
                        danhSach.Any(d => d.Id == dongXeIdMacDinh.Value))
                    {
                        cboLoaiXe.SelectedValue = dongXeIdMacDinh.Value;
                    }
                    else
                    {
                        cboLoaiXe.SelectedIndex = 0;
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
        // 2. LUU
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
        // 3. HUY
        // =========================
        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

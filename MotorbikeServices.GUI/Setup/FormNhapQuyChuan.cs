
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MotorbikeServices.GUI.AdminControls
{
    public partial class FormNhapQuyChuan : Form
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string LoaiXe
        {
            get => cboLoaiXe.SelectedItem?.ToString() ?? "";
            set
            {
                int index = cboLoaiXe.Items.IndexOf(value);
                cboLoaiXe.SelectedIndex = index;
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

            cboLoaiXe.SelectedIndex = 0;
            numSoKm.Value = 1500;
            numChiPhi.Value = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboLoaiXe.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại xe.");
                cboLoaiXe.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenQuyChuan.Text))
            {
                MessageBox.Show("Vui lòng nhập tên quy chuẩn.");
                txtTenQuyChuan.Focus();
                return;
            }

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

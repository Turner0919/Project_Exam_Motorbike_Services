using MotorbikeServices.DAL.Models.Account;
using MotorbikeServices.GUI.Setup.CuaHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MotorbikeServices.BLL.DTOs;
using MotorbikeServices.BLL.Services;
using ClosedXML.Excel;
using System.IO;
using System.Threading.Tasks;
namespace MotorbikeServices.GUI.Setup.CuaHang
{
    public partial class frmaccountnhanvien : Form
    {
        private readonly int _currentNhanVienId;
        private readonly ThongKeNhanVienService _thongKeService = new ThongKeNhanVienService();
        public frmaccountnhanvien(int nhanVienId)
        {
            InitializeComponent();
            _currentNhanVienId = nhanVienId;
            OpenChildForm(new FormThongKeNhanVien(_currentNhanVienId));
        }
        private void OpenChildForm(Form childForm)
        {

            panelXam.Controls.Clear();

            childForm.TopLevel = false;                          // Bắt buộc: Tắt tính năng cửa sổ độc lập
            childForm.FormBorderStyle = FormBorderStyle.None;    // Bắt buộc: Bỏ thanh tiêu đề X / Minimize
            childForm.Dock = DockStyle.Fill;                     // Bắt buộc: Giãn hết kích thước ô xám

            panelXam.Controls.Add(childForm);
            panelXam.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void mnuThongTinCaNhan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongTinCuaHang(_currentNhanVienId));
        }

        private void mnuTrangChu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongKeNhanVien(_currentNhanVienId));
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuQuanLySanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLySanPham(_currentNhanVienId));
        }

        private void mnuDanhSachBaoDuong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDanhSachBaoDuong(_currentNhanVienId));
        }

        private async void mnuThongKe_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Title = "Xuất thống kê sản phẩm";
                saveDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                saveDialog.DefaultExt = "xlsx";
                saveDialog.AddExtension = true;
                saveDialog.FileName =
                    $"ThongKeSanPham_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";

                if (saveDialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    // Tránh người dùng nhấn xuất nhiều lần
                    mnuThongKe.Enabled = false;
                    Cursor = Cursors.WaitCursor;

                    string duongDan = saveDialog.FileName;

                    // 1. Truy vấn sản phẩm trên luồng nền
                    List<SanPhamDTO> danhSach = await Task.Run(() =>
                    {
                        SanPhamService sanPhamService = new SanPhamService();

                        return sanPhamService.GetSanPhamByNhanVien(
                            _currentNhanVienId);
                    });

                    if (danhSach == null)
                        throw new Exception("Không lấy được danh sách sản phẩm.");

                    // 2. Tạo và lưu Excel trên luồng nền
                    await Task.Run(() =>
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            var worksheet =
                                workbook.Worksheets.Add("ThongKeSanPham");

                            worksheet.Cell("A1").Value = "THỐNG KÊ SẢN PHẨM";
                            worksheet.Range("A1:D1").Merge();

                            worksheet.Cell("A2").Value = "Tổng số sản phẩm:";
                            worksheet.Cell("B2").Value = danhSach.Count;

                            worksheet.Cell("A4").Value = "Mã SP";
                            worksheet.Cell("B4").Value = "Tên Sản Phẩm";
                            worksheet.Cell("C4").Value = "Đơn Giá";
                            worksheet.Cell("D4").Value = "SL Tồn";

                            for (int i = 0; i < danhSach.Count; i++)
                            {
                                var sp = danhSach[i];
                                int dong = i + 5;

                                worksheet.Cell(dong, 1).Value = sp.MaSP;
                                worksheet.Cell(dong, 2).Value = sp.TenSanPham;
                                worksheet.Cell(dong, 3).Value = sp.DonGia;
                                worksheet.Cell(dong, 4).Value = sp.SoLuongTon;
                            }

                            // Định dạng tiêu đề
                            var tieuDe = worksheet.Range("A1:D1");
                            tieuDe.Style.Font.Bold = true;
                            tieuDe.Style.Font.FontSize = 16;
                            tieuDe.Style.Alignment.Horizontal =
                                XLAlignmentHorizontalValues.Center;

                            // Định dạng tiêu đề bảng
                            var tieuDeBang = worksheet.Range("A4:D4");
                            tieuDeBang.Style.Font.Bold = true;
                            tieuDeBang.Style.Fill.BackgroundColor = XLColor.LightBlue;
                            tieuDeBang.Style.Alignment.Horizontal =
                                XLAlignmentHorizontalValues.Center;

                            // Định dạng dữ liệu
                            if (danhSach.Count > 0)
                            {
                                int dongCuoi = danhSach.Count + 4;

                                worksheet.Range($"C5:C{dongCuoi}")
                                    .Style.NumberFormat.Format = "#,##0 \"VNĐ\"";

                                worksheet.Range($"D5:D{dongCuoi}")
                                    .Style.Alignment.Horizontal =
                                    XLAlignmentHorizontalValues.Center;
                            }

                            // Chỉ điều chỉnh 4 cột
                            worksheet.Columns(1, 4).AdjustToContents();

                            workbook.SaveAs(duongDan);
                        }
                    });

                    MessageBox.Show(
                        $"Xuất thống kê thành công!\nTổng số sản phẩm: {danhSach.Count}",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Lỗi khi xuất Excel:\n" + ex.ToString(),
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    mnuThongKe.Enabled = true;
                    Cursor = Cursors.Default;
                }
            }
        }
    }
}

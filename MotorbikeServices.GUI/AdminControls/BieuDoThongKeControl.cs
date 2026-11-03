using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;
using MotorbikeServices.BLL.DTOs;
using System.ComponentModel;
namespace MotorbikeServices.GUI.AdminControls
{
    public enum LoaiBieuDoThongKe
    {
        Cot,
        Tron
    }

    public class BieuDoThongKeControl : Control
    {
        private static readonly Color[] BangMau =
        {
            Color.FromArgb(54, 126, 184),
            Color.FromArgb(31, 157, 137),
            Color.FromArgb(132, 101, 190),
            Color.FromArgb(231, 159, 67),
            Color.FromArgb(67, 151, 190),
            Color.FromArgb(205, 103, 120),
            Color.FromArgb(112, 145, 91),
            Color.FromArgb(104, 119, 145)
        };

        private List<DuLieuBieuDoDTO> _duLieu = new List<DuLieuBieuDoDTO>();
        private string _tieuDe = string.Empty;
        private string _moTa = string.Empty;
        private LoaiBieuDoThongKe _loaiBieuDo = LoaiBieuDoThongKe.Cot;
        [DefaultValue("")]
        public string TieuDe
        {
            get => _tieuDe;
            set
            {
                _tieuDe = value ?? string.Empty;
                Invalidate();
            }
        }
        
        [DefaultValue("")]
        public string MoTa
        {
            get => _moTa;
            set
            {
                _moTa = value ?? string.Empty;
                Invalidate();
            }
        }
        [DefaultValue(LoaiBieuDoThongKe.Cot)]
        public LoaiBieuDoThongKe LoaiBieuDo
        {
            get => _loaiBieuDo;
            set
            {
                _loaiBieuDo = value;
                Invalidate();
            }
        }

        public BieuDoThongKeControl()
        {
            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.UserPaint |
                ControlStyles.ResizeRedraw,
                true);

            BackColor = Color.White;
            ForeColor = Color.FromArgb(35, 55, 78);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(240, 170);
        }

        public void CapNhatDuLieu(IEnumerable<DuLieuBieuDoDTO> duLieu)
        {
            _duLieu = duLieu == null
                ? new List<DuLieuBieuDoDTO>()
                : duLieu.Select(x => new DuLieuBieuDoDTO
                {
                    Nhan = x.Nhan ?? string.Empty,
                    GiaTri = Math.Max(0, x.GiaTri)
                }).ToList();

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (Width <= 0 || Height <= 0)
                return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            g.Clear(BackColor);

            using (var vien = new Pen(Color.FromArgb(226, 232, 240), 1F))
            {
                g.DrawRectangle(vien, 0, 0, Width - 1, Height - 1);
            }

            VeTieuDe(g);

            if (Width < 260 || Height < 175)
                return;

            if (!_duLieu.Any(x => x.GiaTri > 0))
            {
                VeKhongCoDuLieu(g);
                return;
            }

            if (LoaiBieuDo == LoaiBieuDoThongKe.Tron)
                VeBieuDoTron(g);
            else
                VeBieuDoCot(g);
        }

        private void VeTieuDe(Graphics g)
        {
            using (var fontTieuDe = new Font("Segoe UI", 10F, FontStyle.Bold))
            using (var fontMoTa = new Font("Segoe UI", 8F, FontStyle.Regular))
            using (var coTieuDe = new SolidBrush(Color.FromArgb(28, 55, 83)))
            using (var coMoTa = new SolidBrush(Color.FromArgb(117, 132, 151)))
            {
                g.DrawString(TieuDe, fontTieuDe, coTieuDe, new PointF(15, 11));
                g.DrawString(MoTa, fontMoTa, coMoTa, new PointF(15, 33));
            }
        }

        private void VeKhongCoDuLieu(Graphics g)
        {
            using (var font = new Font("Segoe UI", 9F, FontStyle.Italic))
            using (var co = new SolidBrush(Color.FromArgb(135, 147, 163)))
            using (var dinhDang = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            })
            {
                g.DrawString(
                    "Chưa có dữ liệu thống kê",
                    font,
                    co,
                    new RectangleF(12, 58, Width - 24, Height - 70),
                    dinhDang);
            }
        }

        private void VeBieuDoCot(Graphics g)
        {
            float leTrai = 48F;
            float lePhai = 18F;
            float dinh = 65F;
            float day = Height - 42F;
            float rongBieuDo = Width - leTrai - lePhai;
            float caoBieuDo = day - dinh;

            if (rongBieuDo <= 0 || caoBieuDo <= 0)
                return;

            int giaTriLonNhat = Math.Max(1, _duLieu.Max(x => x.GiaTri));
            int bacChia = 4;

            using (var fontTruc = new Font("Segoe UI", 7.5F))
            using (var coChu = new SolidBrush(Color.FromArgb(117, 132, 151)))
            using (var duongLuoi = new Pen(Color.FromArgb(232, 237, 243), 1F))
            using (var dinhDangTruc = new StringFormat { Alignment = StringAlignment.Far })
            {
                for (int i = 0; i <= bacChia; i++)
                {
                    float y = day - caoBieuDo * i / bacChia;
                    int nhan = giaTriLonNhat * i / bacChia;
                    g.DrawLine(duongLuoi, leTrai, y, Width - lePhai, y);
                    g.DrawString(nhan.ToString("N0"), fontTruc, coChu,
                        new RectangleF(4, y - 8, leTrai - 9, 16), dinhDangTruc);
                }
            }

            int soCot = _duLieu.Count;
            float moiCot = rongBieuDo / Math.Max(1, soCot);
            float rongCot = Math.Max(12F, Math.Min(48F, moiCot * 0.55F));

            using (var fontGiaTri = new Font("Segoe UI", 7.5F, FontStyle.Bold))
            using (var coGiaTri = new SolidBrush(Color.FromArgb(66, 83, 103)))
            using (var fontNhan = new Font("Segoe UI", 7F))
            using (var coNhan = new SolidBrush(Color.FromArgb(101, 117, 137)))
            using (var dinhDangNhan = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Near,
                Trimming = StringTrimming.EllipsisCharacter
            })
            {
                for (int i = 0; i < soCot; i++)
                {
                    DuLieuBieuDoDTO item = _duLieu[i];
                    float caoCot = caoBieuDo * item.GiaTri / giaTriLonNhat;
                    float x = leTrai + i * moiCot + (moiCot - rongCot) / 2F;
                    float y = day - caoCot;

                    using (var coCot = new SolidBrush(BangMau[i % BangMau.Length]))
                    {
                        g.FillRectangle(coCot, x, y, rongCot, Math.Max(2F, caoCot));
                    }

                    string chuGiaTri = item.GiaTri.ToString("N0");
                    g.DrawString(chuGiaTri, fontGiaTri, coGiaTri,
                        new RectangleF(x - 12, Math.Max(dinh, y - 18), rongCot + 24, 15),
                        new StringFormat { Alignment = StringAlignment.Center });

                    string nhan = item.Nhan.Length > 11
                        ? item.Nhan.Substring(0, 10) + "…"
                        : item.Nhan;

                    g.DrawString(nhan, fontNhan, coNhan,
                        new RectangleF(leTrai + i * moiCot, day + 5, moiCot, 25),
                        dinhDangNhan);
                }
            }
        }

        private void VeBieuDoTron(Graphics g)
        {
            List<DuLieuBieuDoDTO> duLieuHopLe = _duLieu
                .Where(x => x.GiaTri > 0)
                .ToList();

            int tong = duLieuHopLe.Sum(x => x.GiaTri);
            if (tong <= 0)
            {
                VeKhongCoDuLieu(g);
                return;
            }

            float duongKinh = Math.Min(Height - 88F, Math.Min(Width * 0.36F, 178F));
            duongKinh = Math.Max(72F, duongKinh);

            float xBieuDo = 22F;
            float yBieuDo = 61F + (Height - 75F - duongKinh) / 2F;
            RectangleF hinhTron = new RectangleF(xBieuDo, yBieuDo, duongKinh, duongKinh);

            float gocBatDau = -90F;
            for (int i = 0; i < duLieuHopLe.Count; i++)
            {
                float gocQuet = 360F * duLieuHopLe[i].GiaTri / tong;
                using (var co = new SolidBrush(LayMauTheoNhan(duLieuHopLe[i].Nhan, i)))
                {
                    g.FillPie(co, hinhTron, gocBatDau, gocQuet);
                }
                gocBatDau += gocQuet;
            }

            float duongKinhTrong = duongKinh * 0.59F;
            RectangleF loTrong = new RectangleF(
                hinhTron.X + (duongKinh - duongKinhTrong) / 2F,
                hinhTron.Y + (duongKinh - duongKinhTrong) / 2F,
                duongKinhTrong,
                duongKinhTrong);

            using (var coTrong = new SolidBrush(Color.White))
            {
                g.FillEllipse(coTrong, loTrong);
            }

            using (var fontTong = new Font("Segoe UI", 14F, FontStyle.Bold))
            using (var fontChuThich = new Font("Segoe UI", 7.5F))
            using (var coTong = new SolidBrush(Color.FromArgb(29, 57, 84)))
            using (var coChuThich = new SolidBrush(Color.FromArgb(117, 132, 151)))
            using (var dinhDang = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            })
            {
                g.DrawString(tong.ToString("N0"), fontTong, coTong,
                    new RectangleF(loTrong.X, loTrong.Y + loTrong.Height * 0.23F,
                        loTrong.Width, loTrong.Height * 0.32F), dinhDang);
                g.DrawString("Tổng cộng", fontChuThich, coChuThich,
                    new RectangleF(loTrong.X, loTrong.Y + loTrong.Height * 0.55F,
                        loTrong.Width, loTrong.Height * 0.22F), dinhDang);
            }

            float xChuThich = hinhTron.Right + 22F;
            float yChuThich = Math.Max(72F, (Height - duLieuHopLe.Count * 29F) / 2F);
            float rongChuThich = Width - xChuThich - 15F;

            using (var fontNhan = new Font("Segoe UI", 8.5F))
            using (var fontSo = new Font("Segoe UI", 8.5F, FontStyle.Bold))
            using (var coNhan = new SolidBrush(Color.FromArgb(74, 91, 111)))
            using (var coSo = new SolidBrush(Color.FromArgb(35, 55, 78)))
            using (var dinhDangNhan = new StringFormat { Trimming = StringTrimming.EllipsisCharacter })
            using (var dinhDangSo = new StringFormat { Alignment = StringAlignment.Far })
            {
                for (int i = 0; i < duLieuHopLe.Count; i++)
                {
                    DuLieuBieuDoDTO item = duLieuHopLe[i];
                    float y = yChuThich + i * 29F;
                    Color mau = LayMauTheoNhan(item.Nhan, i);

                    using (var coDiem = new SolidBrush(mau))
                    {
                        g.FillEllipse(coDiem, xChuThich, y + 3, 10, 10);
                    }

                    string nhan = item.Nhan;
                    g.DrawString(nhan, fontNhan, coNhan,
                        new RectangleF(xChuThich + 17, y, Math.Max(35, rongChuThich - 55), 20),
                        dinhDangNhan);

                    string giaTri = item.GiaTri.ToString("N0") +
                        " (" + (100.0 * item.GiaTri / tong).ToString("0.#") + "%)";
                    g.DrawString(giaTri, fontSo, coSo,
                        new RectangleF(xChuThich + 17, y + 13, Math.Max(35, rongChuThich - 20), 17),
                        dinhDangSo);
                }
            }
        }

        private Color LayMauTheoNhan(string nhan, int viTri)
        {
            if (string.Equals(nhan, "Đang hoạt động", StringComparison.OrdinalIgnoreCase))
                return Color.FromArgb(39, 157, 112);

            if (string.Equals(nhan, "Tạm ngừng hoạt động", StringComparison.OrdinalIgnoreCase))
                return Color.FromArgb(225, 155, 61);

            if (string.Equals(nhan, "Chưa thiết lập", StringComparison.OrdinalIgnoreCase))
                return Color.FromArgb(145, 157, 173);

            if (string.Equals(nhan, "Admin", StringComparison.OrdinalIgnoreCase))
                return Color.FromArgb(54, 126, 184);

            if (string.Equals(nhan, "User", StringComparison.OrdinalIgnoreCase))
                return Color.FromArgb(39, 157, 112);

            if (string.Equals(nhan, "Nhân viên", StringComparison.OrdinalIgnoreCase))
                return Color.FromArgb(132, 101, 190);

            return BangMau[viTri % BangMau.Length];
        }
    }
}

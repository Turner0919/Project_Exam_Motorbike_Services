using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MotorbikeServices.DAL.Models.Store
{
    public class ChiTietHoaDon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int HoaDonId { get; set; }

        [ForeignKey("HoaDonId")]
        public virtual HoaDon HoaDon { get; set; } = null!;

        public int SanPhamId { get; set; }

        [ForeignKey("SanPhamId")]
        public virtual SanPham SanPham { get; set; } = null!;

        [StringLength(100)]
        public string TenXe { get; set; } = string.Empty; // Lưu Tên Hãng + Dòng xe

        [StringLength(20)]
        public string BienSo { get; set; } = string.Empty; // Biển số xe bảo dưỡng

        public int SoLuong { get; set; }

        public decimal DonGia { get; set; }
    }
}

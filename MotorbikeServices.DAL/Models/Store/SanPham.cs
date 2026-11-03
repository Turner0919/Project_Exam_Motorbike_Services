using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MotorbikeServices.DAL.Models.Store
{
    public class SanPham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int NhanVienId { get; set; }

        [ForeignKey("NhanVienId")]
        public virtual NhanVienUse NhanVienUse { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string MaSP { get; set; } = null!;

        [Required]
        [StringLength(150)]
        public string TenSanPham { get; set; } = null!;

        public decimal DonGia { get; set; }

        public int SoLuongTon { get; set; }
    }
}

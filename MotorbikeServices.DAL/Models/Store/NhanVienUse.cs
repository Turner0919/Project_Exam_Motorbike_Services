using MotorbikeServices.DAL.Models.Account;
using MotorbikeServices.DAL.Models.Maintenance;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MotorbikeServices.DAL.Models.Store
{
    public class NhanVienUse
    {
        [Key]
        public int NhanVienId { get; set; } // Khóa chính trùng Khóa ngoại NhanVien.Id

        [ForeignKey("NhanVienId")]
        public virtual NhanVien NhanVien { get; set; } = null!;

        [StringLength(150)]
        public string? TenCuaHang { get; set; }

        [StringLength(50)]
        public string? TrangThai { get; set; }

        public int? DiaChiId { get; set; }

        [ForeignKey("DiaChiId")]
        public virtual DiaChi? DiaChi { get; set; }

        [StringLength(150)]
        public string? TenDuong { get; set; }

        [StringLength(50)]
        public string? SoCuaHang { get; set; }
    }
}

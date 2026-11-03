using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MotorbikeServices.DAL.Models.Account;

namespace MotorbikeServices.DAL.Models.Maintenance
{
    public class UserXe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Khóa ngoại liên kết tới bảng Users (Tài khoản người dùng)
        [Required]
        public int UserId { get; set; }

        // Khóa ngoại liên kết tới bảng DongXes (Dòng xe)
        [Required]
        public int DongXeId { get; set; }

        // Biển số xe
        [Required]
        [MaxLength(20)]
        public string BienSoXe { get; set; } = string.Empty;

        // Ngày mua xe
        [Required]
        public DateTime NgayMuaXe { get; set; } = DateTime.Now;

        // --- Navigation Properties ---

        [ForeignKey("UserId")]
        public virtual User User { get; set; } = null!;

        [ForeignKey("DongXeId")]
        public virtual DongXe DongXe { get; set; } = null!;
    }
}
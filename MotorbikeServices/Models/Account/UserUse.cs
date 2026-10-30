using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MotorbikeServices.DAL.Models.Account
{
    public class UserUse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; } // Khóa ngoại liên kết tới bảng User

        [StringLength(100)]
        public string? HoTen { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(10)]
        public string? GioiTinh { get; set; } // "Nam" hoặc "Nữ"

        [StringLength(15)]
        public string? SoDienThoai { get; set; }

        [StringLength(100)]
        public string? Email { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; } = null!; // Navigation property liên kết tới User
    }
}
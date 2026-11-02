using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MotorbikeServices.DAL.Models.Maintenance
{
    public class QuyChuanXeNguoiDung
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int UserXeId { get; set; }

        [Required]
        public int QuyChuanBaoDuongId { get; set; }

        // Ngày người dùng thực hiện bảo dưỡng lần gần nhất (Mặc định ban đầu = NgayMuaXe)
        public DateTime NgayBaoDuongLanCuoi { get; set; } = DateTime.Now;

        // Navigation properties
        [ForeignKey("UserXeId")]
        public virtual UserXe UserXe { get; set; } = null!;

        [ForeignKey("QuyChuanBaoDuongId")]
        public virtual QuyChuanBaoDuong QuyChuanBaoDuong { get; set; } = null!;
    }
}

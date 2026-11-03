using MotorbikeServices.DAL.Models.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MotorbikeServices.DAL.Models.Store
{
    public class HoaDon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; } = null!;

        public int NhanVienId { get; set; } // ID Cửa hàng nhận đơn bảo dưỡng

        [ForeignKey("NhanVienId")]
        public virtual NhanVienUse NhanVienUse { get; set; } = null!;

        public DateTime NgayTao { get; set; } = DateTime.Now;

        public decimal TongTien { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; } = "Chờ xác nhận"; // "Chờ xác nhận", "Đã hoàn thành", "Đã hủy"

        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();
    }
}


using System.ComponentModel.DataAnnotations;
using MotorbikeServices.DAL.Models.Maintenance;

namespace MotorbikeServices.DAL.Models
{
    public class DongXe
    {
        public int Id { get; set; }

        public int HangXeId { get; set; }

        [Required]
        [StringLength(100)]
        public string TenDongXe { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string LoaiXe { get; set; } = "Xe số";

        public HangXe HangXe { get; set; } = null!;

        public ICollection<QuyChuanBaoDuong> QuyChuanBaoDuongs { get; set; }
            = new List<QuyChuanBaoDuong>();
    }
}

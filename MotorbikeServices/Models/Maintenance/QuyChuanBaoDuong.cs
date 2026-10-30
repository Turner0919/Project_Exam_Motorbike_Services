
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MotorbikeServices.DAL.Models;

namespace MotorbikeServices.DAL.Models.Maintenance
{
    public class QuyChuanBaoDuong
    {
        public int Id { get; set; }

        [Required]
        public int DongXeId { get; set; }

        [Required]
        [StringLength(150)]
        public string TenQuyChuan { get; set; } = string.Empty;

        public int SoKm { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal ChiPhi { get; set; }

        [StringLength(500)]
        public string? MoTa { get; set; }

        // Navigation property
        public DongXe DongXe { get; set; } = null!;
    }
}

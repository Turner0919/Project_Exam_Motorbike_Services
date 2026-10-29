using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MotorbikeServices.DAL.Models
{
    public class DongXe
    {
        public int Id { get; set; }

        [Required]
        public int HangXeId { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenDongXe { get; set; } = string.Empty;
        [Required]
        [MaxLength(20)]
        public string LoaiXe { get; set; } = "Xe số";

        // Khóa ngoại và navigation property
        public HangXe HangXe { get; set; } = null!;
    }
}

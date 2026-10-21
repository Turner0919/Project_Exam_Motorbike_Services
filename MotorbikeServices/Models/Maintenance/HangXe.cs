using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MotorbikeServices.DAL.Models
{
    public class HangXe
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenHang { get; set; } = string.Empty;

        [MaxLength(100)]
        public string? QuocGia { get; set; }

        // Một hãng xe có thể có nhiều dòng xe
        public ICollection<DongXe> DongXes { get; set; }
            = new List<DongXe>();
    }
}

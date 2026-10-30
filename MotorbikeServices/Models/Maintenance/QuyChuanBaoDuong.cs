using System;
using System.Collections.Generic;
using System.Text;


using System.ComponentModel.DataAnnotations;

namespace MotorbikeServices.DAL.Models.Maintenance
{
    public class QuyChuanBaoDuong
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string LoaiXe { get; set; } = string.Empty;

        [Required]
        [MaxLength(150)]
        public string TenQuyChuan { get; set; } = string.Empty;

        public int SoKm { get; set; }

        public decimal ChiPhi { get; set; }

        [MaxLength(500)]
        public string? MoTa { get; set; }
    }
}


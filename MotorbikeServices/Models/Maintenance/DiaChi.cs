using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MotorbikeServices.DAL.Models.Maintenance
{
    public class DiaChi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string TinhTP { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string PhuongXa { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MotorbikeServices.DAL.Models.Account
{
    public class Admin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string TenTaiKhoan { get; set; } = null!;

        [Required]
        public string MatKhau { get; set; } = null!;
    }
}

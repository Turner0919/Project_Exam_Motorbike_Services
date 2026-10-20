using System;
using System.Collections.Generic;
using System.Text;

namespace MotorbikeServices.BLL.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string TenTaiKhoan { get; set; } = null!;
        public string Role { get; set; } = null!; // "Admin" hoặc "User"
    }
}

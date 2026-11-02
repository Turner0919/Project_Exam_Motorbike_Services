using System;

namespace MotorbikeServices.BLL.DTOs
{
    public class UserXeDTO
    {
        public int Id { get; set; }
        public int STT { get; set; }
        public string TenHangXe { get; set; } = string.Empty;
        public string TenDongXe { get; set; } = string.Empty;
        public string BienSoXe { get; set; } = string.Empty;
        public DateTime NgayMuaXe { get; set; }
        public int HangXeId { get; set; }
        public int DongXeId { get; set; }

        // Thêm dòng này để ComboBox tự hiển thị Tên Hãng + Tên Dòng + Biển Số
        public override string ToString() => $"{TenHangXe} {TenDongXe} ({BienSoXe})";
    }
}
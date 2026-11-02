using System;
using System.Collections.Generic;
using System.Text;

namespace MotorbikeServices.BLL.DTOs
{

    // DTO hiển thị danh sách nhắc lịch lên DataGridView
    public class LichBaoDuongDTO
    {
        public int STT { get; set; }
        public int QuyChuanId { get; set; }
        public string TenQuyChuan { get; set; } = string.Empty;
        public string DinhKyBaoDuong { get; set; } = string.Empty; // VD: "1 tháng"
        public int SoThangDinhKy { get; set; }
        public DateTime NgayBaoDuongLanCuoi { get; set; }
        public DateTime NgayBaoDuongTiepTheo { get; set; }
        public string TinhTrang { get; set; } = string.Empty;      // Còn hạn / Sắp tới hạn / Quá hạn X ngày
        public int MucDoCanhBao { get; set; }                      // 0: Bình thường (Xanh), 1: Sắp tới hạn (Vàng), 2: Quá hạn (Đỏ)
    }
}

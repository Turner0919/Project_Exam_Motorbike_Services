using System;
using System.Collections.Generic;
using System.Text;

namespace MotorbikeServices.BLL.DTOs
{

    // DTO hiển thị danh sách nhắc lịch lên DataGridView
    public class LichBaoDuongDTO
    {
        public int STT { get; set; }
        public int QuyChuanXeNguoiDungId { get; set; } // Id bảng QuyChuanXeNguoiDung để Cập nhật
        public string TenQuyChuan { get; set; } = string.Empty;
        public string DinhKyBaoDuong { get; set; } = string.Empty;
        public int SoThangDinhKy { get; set; }
        public DateTime NgayBaoDuongLanCuoi { get; set; }
        public DateTime NgayBaoDuongTiepTheo { get; set; }
        public string TinhTrang { get; set; } = string.Empty;
        public int MucDoCanhBao { get; set; } // 0: Thường, 1: Sắp tới hạn, 2: Quá hạn
    }
}

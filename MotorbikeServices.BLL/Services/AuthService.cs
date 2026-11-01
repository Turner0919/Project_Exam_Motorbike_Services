using System.Linq;
using MotorbikeServices.DAL;
using MotorbikeServices.DAL.Models;
using MotorbikeServices.DAL.Models.Account;
using MotorbikeServices.BLL.DTOs;

namespace MotorbikeServices.BLL.Services
{
    public class AuthService
    {
        // Key cố định dùng để xác minh đăng ký Admin
        public const string ADMIN_KEY = "41031102026";
        public const string NHANVIEN_KEY = "NV2026";

        /// <summary>
        /// 1. Xử lý Đăng nhập cho cả Admin và User (frmlogin)
        /// </summary>
        public (bool IsSuccess, string Message, UserDTO? UserInfo) DangNhap(string username, string password, string role)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return (false, "Vui lòng nhập đầy đủ Tài khoản và Mật khẩu!", null);
            }

            using (var db = new AppDbContext())
            {
                if (role == "Admin")
                {
                    var admin = db.Admins.FirstOrDefault(a => a.TenTaiKhoan == username && a.MatKhau == password);
                    if (admin != null)
                    {
                        var dto = new UserDTO { Id = admin.Id, TenTaiKhoan = admin.TenTaiKhoan, Role = "Admin" };
                        return (true, "Đăng nhập Admin thành công!", dto);
                    }
                }
                else if (role == "User")
                {
                    var user = db.Users.FirstOrDefault(u => u.TenTaiKhoan == username && u.MatKhau == password);
                    if (user != null)
                    {
                        var dto = new UserDTO { Id = user.Id, TenTaiKhoan = user.TenTaiKhoan, Role = "User" };
                        return (true, "Đăng nhập User thành công!", dto);
                    }
                }
                else if (role == "NhanVien") // Bổ sung đăng nhập cho Nhân viên
                {
                    var nv = db.NhanViens.FirstOrDefault(n => n.TenTaiKhoan == username && n.MatKhau == password);
                    if (nv != null)
                    {
                        var dto = new UserDTO { Id = nv.Id, TenTaiKhoan = nv.TenTaiKhoan, Role = "NhanVien" };
                        return (true, "Đăng nhập Nhân viên thành công!", dto);
                    }
                }
            }

            // Câu thông báo khi không tìm thấy tài khoản/mật khẩu khớp trong DB
            return (false, "Mat Khau hoac tai khoan chua dung", null);
        }

        /// <summary>
        /// 2. Kiểm tra xem tên tài khoản đã tồn tại trong CSDL chưa
        /// </summary>
        public bool KiemTraTonTaiTaiKhoan(string username)
        {
            using (var db = new AppDbContext())
            {
                return db.Admins.Any(a => a.TenTaiKhoan == username) ||
                       db.Users.Any(u => u.TenTaiKhoan == username) ||
                       db.NhanViens.Any(n => n.TenTaiKhoan == username);
            }
        }

        /// <summary>
        /// 3. Xử lý Đăng ký tài khoản Admin (frmsignup)
        /// </summary>
        public (bool IsSuccess, string Message) DangKyAdmin(string username, string password, string confirmPassword, string keyAdmin)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return (false, "Vui lòng nhập đầy đủ tên tài khoản và mật khẩu!");

            if (password.Length < 8)
                return (false, "Mật khẩu phải từ 8 ký tự trở lên!");

            if (password != confirmPassword)
                return (false, "Xác nhận mật khẩu không trùng khớp!");

            if (keyAdmin != ADMIN_KEY)
                return (false, "Key Admin không chính xác! Vui lòng kiểm tra lại.");

            if (KiemTraTonTaiTaiKhoan(username))
                return (false, "Tên tài khoản này đã tồn tại trong hệ thống!");

            using (var db = new AppDbContext())
            {
                var admin = new Admin
                {
                    TenTaiKhoan = username,
                    MatKhau = password
                };
                db.Admins.Add(admin);
                db.SaveChanges(); // EF Core tự sinh giá trị Id (Identity)
            }

            return (true, "Đăng ký tài khoản Admin thành công!");
        }

        /// <summary>
        /// 4. Xử lý Đăng ký tài khoản User (frmsignup)
        /// </summary>
        public (bool IsSuccess, string Message) DangKyUser(string username, string password, string confirmPassword, string cauHoi, string dapAn)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return (false, "Vui lòng nhập đầy đủ tên tài khoản và mật khẩu!");

            if (password.Length < 8)
                return (false, "Mật khẩu phải từ 8 ký tự trở lên!");

            if (password != confirmPassword)
                return (false, "Xác nhận mật khẩu không trùng khớp!");

            if (string.IsNullOrWhiteSpace(cauHoi) || string.IsNullOrWhiteSpace(dapAn))
                return (false, "Vui lòng nhập Câu hỏi và Đáp án bảo mật!");

            if (KiemTraTonTaiTaiKhoan(username))
                return (false, "Tên tài khoản này đã tồn tại trong hệ thống!");

            using (var db = new AppDbContext())
            {
                var user = new User
                {
                    TenTaiKhoan = username,
                    MatKhau = password,
                    CauHoiBaoMat = cauHoi.Trim(),
                    DapAnBaoMat = dapAn.Trim().ToLower() // Lưu chữ thường để so sánh chính xác khi khôi phục
                };
                db.Users.Add(user);
                db.SaveChanges(); // EF Core tự sinh giá trị Id (Identity)
            }

            return (true, "Đăng ký tài khoản User thành công!");
        }

        public (bool IsSuccess, string Message) DangKyNhanVien(string username, string password, string confirmPassword, string keyNhanVien, string cauHoi, string dapan)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return (false, "Vui lòng nhập đầy đủ tên tài khoản và mật khẩu!");

            if (password.Length < 8)
                return (false, "Mật khẩu phải từ 8 ký tự trở lên!");

            if (password != confirmPassword)
                return (false, "Xác nhận mật khẩu không trùng khớp!");

            if (keyNhanVien != NHANVIEN_KEY) // "NV2026"
                return (false, "Key Nhân viên không chính xác! Vui lòng kiểm tra lại.");

            if (string.IsNullOrWhiteSpace(cauHoi) || string.IsNullOrWhiteSpace(dapan))
                return (false, "Vui lòng nhập Câu hỏi và Đáp án bảo mật!");

            if (KiemTraTonTaiTaiKhoan(username))
                return (false, "Tên tài khoản này đã tồn tại trong hệ thống!");

            using (var db = new AppDbContext())
            {
                var nv = new NhanVien
                {
                    TenTaiKhoan = username,
                    MatKhau = password,
                    CauHoiBaoMat = cauHoi.Trim(),
                    DapAnBaoMat = dapan.Trim().ToLower()
                };

                db.NhanViens.Add(nv);
                db.SaveChanges();
            }

            return (true, "Đăng ký tài khoản Nhân viên thành công!");
        }
        /// <summary>
        /// 5. Lấy câu hỏi bảo mật của User theo Username (frmchangepassword)
        /// </summary>
        public string? LayCauHoiBaoMat(string username)
        {
            using (var db = new AppDbContext())
            {
                // Tìm trong bảng Users trước
                var user = db.Users.FirstOrDefault(u => u.TenTaiKhoan == username);
                if (user != null) return user.CauHoiBaoMat;

                // Nếu không có trong Users, tìm tiếp trong bảng NhanViens
                var nv = db.NhanViens.FirstOrDefault(n => n.TenTaiKhoan == username);
                if (nv != null) return nv.CauHoiBaoMat;
            }
            return null;
        }

        /// <summary>
        /// 6. Kiểm tra đáp án bảo mật của User (frmchangepassword)
        /// </summary>
        public bool KiemTraDapAnBaoMat(string username, string dapAn)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(dapAn))
                return false;

            using (var db = new AppDbContext())
            {
                var user = db.Users.FirstOrDefault(u => u.TenTaiKhoan == username);
                if (user != null)
                {
                    return user.DapAnBaoMat.Equals(dapAn.Trim().ToLower());
                }
                var nv = db.NhanViens.FirstOrDefault(n => n.TenTaiKhoan == username);
                if (nv != null)
                {
                    return nv.DapAnBaoMat.Equals(dapAn.Trim().ToLower());
                }
            }
            return false;
        }

        /// <summary>
        /// 7. Cập nhật mật khẩu mới cho User (frmchangepassword)
        /// </summary>
        public (bool IsSuccess, string Message) DatLaiMatKhau(string username, string newPassword, string confirmNewPassword)
        {
            if (string.IsNullOrWhiteSpace(newPassword))
                return (false, "Vui lòng nhập mật khẩu mới!");

            if (newPassword.Length < 8)
                return (false, "Mật khẩu mới phải từ 8 ký tự trở lên!");

            if (newPassword != confirmNewPassword)
                return (false, "Xác nhận mật khẩu mới không trùng khớp!");

            using (var db = new AppDbContext())
            {
                var user = db.Users.FirstOrDefault(u => u.TenTaiKhoan == username);
                if (user != null)
                {
                    user.MatKhau = newPassword;
                    db.SaveChanges();
                    return (true, "Đặt lại mật khẩu thành công! Vui lòng đăng nhập lại.");
                }
                var nv = db.NhanViens.FirstOrDefault(n => n.TenTaiKhoan == username);
                if (nv != null)
                {
                    nv.MatKhau = newPassword;
                    db.SaveChanges();
                    return (true, "Đặt lại mật khẩu thành công! Vui lòng đăng nhập lại.");
                }
            }
            return (false, "Không tìm thấy tài khoản để cập nhật!");
        }
    }
}

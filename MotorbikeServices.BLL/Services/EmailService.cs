using System;
using System.Net;// Cung cấp NetworkCredential (tài khoản/mật khẩu)
using System.Net.Mail;// Cung cấp SmtpClient và MailMessage (gửi mail)
using System.Threading.Tasks;
using System.Configuration;

namespace MotorbikeServices.BLL.Services
{
    public class EmailService
    {
        // Đọc cấu hình từ App.config
        private static string FROM_EMAIL => ConfigurationManager.AppSettings["SmtpEmail"] ?? "studyhome0806@gmail.com";
        private static string FROM_PASSWORD => ConfigurationManager.AppSettings["SmtpPassword"] ?? "";

        public static async Task<(bool IsSuccess, string Message)> SendEmailXacNhanDonAsync(
            string toEmail,
            string tenKhach,
            int maHoaDon,
            decimal tongTien,string tenCuaHang)
        {
            // Kiểm tra email nhận hợp lệ
            if (string.IsNullOrWhiteSpace(toEmail) || !toEmail.Contains("@"))
            {
                return (false, "Địa chỉ email khách hàng không hợp lệ!");
            }

            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(FROM_EMAIL, FROM_PASSWORD.Replace(" ", "")),
                    EnableSsl = true,
                };

                string bodyHtml = $@"
                <div style='font-family: Arial, sans-serif; line-height: 1.6; color: #333; max-width: 600px; margin: 0 auto; border: 1px solid #e0e0e0; border-radius: 8px; overflow: hidden;'>
                    <div style='background-color: #4CAF50; color: white; padding: 20px; text-align: center;'>
                        <h2 style='margin: 0;'>XÁC NHẬN ĐƠN BẢO DƯỠNG</h2>
                    </div>
                    <div style='padding: 20px;'>
                        <p>Kính gửi anh/chị <b>{tenKhach}</b>,</p>
                        <p>Đơn đăng ký dịch vụ bảo dưỡng xe mã số <b>#{maHoaDon}</b> của anh/chị tại hệ thống <b>DAIDAIMOTOR</b> đã được cửa hàng <b>{tenCuaHang}</b> tiếp nhận và <b>DUYỆT THÀNH CÔNG</b>.</p>
                        
                        <div style='background-color: #f9f9f9; padding: 15px; border-left: 4px solid #4CAF50; margin: 20px 0;'>
                            <p style='margin: 5px 0;'><b>Mã Hóa Đơn:</b> #{maHoaDon}</p>
                            <p style='margin: 5px 0;'><b>Tổng tiền dự kiến:</b> <span style='color: #d9534f; font-weight: bold;'>{tongTien:#,##0} VNĐ</span></p>
                            <p style='margin: 5px 0;'><b>Trạng thái:</b> <span style='color: #5cb85c; font-weight: bold;'>Đã duyệt</span></p>
                        </div>

                        <p>Rất hân hạnh được phục vụ anh/chị. Vui lòng mang xe đến cửa hàng theo lịch để trải nghiệm dịch vụ tốt nhất.</p>
                        <br/>
                        <p style='margin-bottom: 0;'>Trân trọng,</p>
                        <p style='margin-top: 5px;'><b>Hệ Thống DAIDAIMOTOR</b></p>
                    </div>
                </div>";

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(FROM_EMAIL, "DAIDAIMOTOR"),
                    Subject = $"[CUAHANG] Xác nhận đơn bảo dưỡng #{maHoaDon} thành công",
                    Body = bodyHtml,
                    IsBodyHtml = true,
                };

                mailMessage.To.Add(toEmail);

                // Gửi async để không bị treo giao diện WinForms
                await smtpClient.SendMailAsync(mailMessage);

                return (true, "Đã gửi email xác nhận thành công!");
            }
            catch (Exception ex)
            {
                return (false, "Lỗi gửi mail: " + ex.Message);
            }
        }
    }
}
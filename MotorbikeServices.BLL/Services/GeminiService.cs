using System;
using System.Configuration;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MotorbikeServices.BLL.Services
{
    public class GeminiService
    {
        private static string API_KEY => ConfigurationManager.AppSettings["GeminiApiKey"] ?? "";
        private static readonly HttpClient _httpClient = new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(30)
        };

        // Bổ sung tham số historyChat (mặc định là rỗng)
        public async Task<string> GetTuVanXeAsync(string userMessage, string contextDataUser = "", string historyChat = "")
        {
            if (string.IsNullOrWhiteSpace(API_KEY))
            {
                return "Chưa cấu hình GeminiApiKey trong App.config! Vui lòng bổ sung API Key.";
            }

            try
            {
                string endpoint = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-3.5-flash-lite:generateContent?key={API_KEY}";

                // Bơm dữ liệu CSDL + Lịch sử trò chuyện cũ vào Prompt
                string systemPrompt =   "Bạn là Trợ lý Kỹ thuật viên Bảo dưỡng Xe máy Chuyên nghiệp của hệ thống DAIDAIMOTOR.\n" +
                                        "DƯỚI ĐÂY LÀ DỮ LIỆU THỰC TẾ VỀ XE, LỊCH BẢO DƯỠNG VÀ CÁC ĐƠN HÀNG / HÓA ĐƠN ĐÃ ĐẶT CỦA KHÁCH HÀNG:\n" +
                                        $"--- DỮ LIỆU CSDL KHÁCH HÀNG ---\n{contextDataUser}\n-------------------------------\n" +
                                        (string.IsNullOrWhiteSpace(historyChat) ? "" : $"--- LỊCH SỬ HỘI THOẠI TRƯỚC ĐÓ ---\n{historyChat}\n-----------------------------------\n") +
                                        "HƯỚNG DẪN TRẢ LỜI:\n" +
                                        "1. Trả lời thân thiện, ngắn gọn, chính xác chuyên môn về xe máy và các dịch vụ của DAIDAIMOTOR.\n" +
                                        "2. Khi khách hỏi về ĐƠN ĐÃ ĐẶT (lịch sử đặt đơn, đơn đã duyệt, đơn đã hủy...), hãy tra cứu dữ liệu CSDL ở trên để trả lời rõ Mã đơn, Cửa hàng, Ngày đặt, Tổng tiền, Trạng thái và các sản phẩm/dịch vụ chi tiết.\n" +
                                        "3. Dựa vào dữ liệu CSDL để nhắc nhở các xe hoặc hạng mục bảo dưỡng đã Quá hạn hoặc Sắp tới hạn.\n" +
                                        "4. Kết hợp LỊCH SỬ HỘI THOẠI để hiểu ngữ cảnh những câu hỏi tiếp theo của khách hàng.\n\n" +
                                        $"Câu hỏi mới nhất của khách hàng: {userMessage}";

                var requestBody = new
                {
                    contents = new[]
                    {
                        new
                        {
                            parts = new[]
                            {
                                new { text = systemPrompt }
                            }
                        }
                    }
                };

                string jsonContent = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync(endpoint, content);
                string responseJson = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    dynamic result = JsonConvert.DeserializeObject(responseJson);
                    string aiReply = result.candidates[0].content.parts[0].text;
                    return aiReply.ToString().Trim();
                }
                else
                {
                    return $"Lỗi Google API ({response.StatusCode}): {responseJson}";
                }
            }
            catch (TaskCanceledException)
            {
                return "Lỗi: Kết nối API bị quá thời gian (Timeout). Vui lòng kiểm tra lại mạng internet!";
            }
            catch (Exception ex)
            {
                return $"Lỗi kết nối AI: {ex.Message}";
            }
        }
    }
}
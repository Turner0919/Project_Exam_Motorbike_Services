using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Configuration;

namespace MotorbikeServices.BLL.Services
{
    public class GeminiService
    {
        // Đọc Key từ App.config thông qua key "GeminiApiKey"
        private readonly string API_KEY = ConfigurationManager.AppSettings["GeminiApiKey"] ?? "";
        private readonly string API_URL;


        private readonly HttpClient _httpClient;

        public GeminiService()
        {
            _httpClient = new HttpClient();
            API_URL = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-3.8-flash:generateContent?key={API_KEY}";
        }

        public async Task<string> AskAIAsync(string userPrompt)
        {
            try
            {
                string systemInstruction = "Bạn là trợ lý AI thông minh trong phần mềm Quản lý & Bảo dưỡng xe máy. Hãy trả lời ngắn gọn, lịch sự bằng tiếng Việt.";
                string fullPrompt = $"{systemInstruction}\n\nNgười dùng hỏi: {userPrompt}";

                // Tạo đối tượng request chuẩn
                var requestObj = new GeminiRequest
                {
                    contents = new List<Content>
                    {
                        new Content
                        {
                            parts = new List<Part>
                            {
                                new Part { text = fullPrompt }
                            }
                        }
                    }
                };

                string jsonContent = JsonConvert.SerializeObject(requestObj);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _httpClient.PostAsync(API_URL, content);
                string responseJson = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return $"Lỗi API ({response.StatusCode}): {responseJson}";
                }

                // Parse JSON an toàn bằng Class DTO (không dùng dynamic)
                var result = JsonConvert.DeserializeObject<GeminiResponse>(responseJson);

                if (result?.candidates != null && result.candidates.Count > 0 &&
                    result.candidates[0].content?.parts != null && result.candidates[0].content.parts.Count > 0)
                {
                    return result.candidates[0].content.parts[0].text.Trim();
                }

                return "AI không trả lời được câu hỏi này.";
            }
            catch (Exception ex)
            {
                return $"Đã xảy ra lỗi: {ex.Message}";
            }
        }
    }

    // Các lớp DTO để đọc JSON an toàn
    public class GeminiRequest
    {
        public List<Content> contents { get; set; }
    }

    public class GeminiResponse
    {
        public List<Candidate> candidates { get; set; }
    }

    public class Candidate
    {
        public Content content { get; set; }
    }

    public class Content
    {
        public List<Part> parts { get; set; }
    }

    public class Part
    {
        public string text { get; set; }
    }
}

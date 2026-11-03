using MotorbikeServices.BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MotorbikeServices.GUI.Setup
{
    public partial class FormAIChatUser : Form
    {
        private readonly GeminiService _geminiService = new GeminiService();
        private readonly QuanLyBaoDuongService _baoDuongService = new QuanLyBaoDuongService();
        private readonly StringBuilder _chatHistory = new StringBuilder();
        private readonly int _currentUserId;
        public FormAIChatUser(int userId)
        {
            InitializeComponent();
            _currentUserId = userId;
        }
        public FormAIChatUser()
        {
            InitializeComponent();
        }

        private void FormAIChatUser_Load(object sender, EventArgs e)
        {
            AppendMessage("DAIDAIMOTOR Trợ Lý", "Xin chào! Tôi là Trợ lý DAIDAIMOTOR. Bạn cần tư vấn kỹ thuật hay kiểm tra lịch bảo dưỡng xe nào hôm nay?", Color.DarkGreen);
            txtInputMessage.Focus();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            await GuiTinNhanAsync();
        }
        private async void txtInputMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Chặn tiếng kêu bip của Windows
                await GuiTinNhanAsync();
            }
        }
        private async Task GuiTinNhanAsync()
        {
            string userMsg = txtInputMessage.Text.Trim();
            if (string.IsNullOrWhiteSpace(userMsg)) return;

            // 1. Hiển thị tin nhắn của User
            AppendMessage("Bạn", userMsg, Color.Blue);
            txtInputMessage.Clear();
            txtInputMessage.Enabled = false;
            btnSend.Enabled = false;
            lblStatus.Text = "DAIDAIMOTOR đang đọc hồ sơ xe và suy nghĩ câu trả lời...";
            lblStatus.ForeColor = Color.OrangeRed;

            // 2. Lấy dữ liệu xe cá nhân thực tế từ CSDL
            string contextData = _baoDuongService.GetThongTinBaoDuongUserForAI(_currentUserId);

            // 3. Gửi câu hỏi kèm Context sang Gemini API
            string aiResponse = await _geminiService.GetTuVanXeAsync(userMsg, contextData);

            // 4. Hiển thị phản hồi của AI
            AppendMessage("DAIDAIMOTOR Trợ Lý", aiResponse, Color.DarkGreen);

            // 5. Tích lũy đoạn hội thoại vừa xong vào biến _chatHistory để AI nhớ cho các câu sau
            _chatHistory.AppendLine($"Khách hàng: {userMsg}");
            _chatHistory.AppendLine($"AI Trợ Lý: {aiResponse}");

            txtInputMessage.Enabled = true;
            btnSend.Enabled = true;
            lblStatus.Text = "Sẵn sàng";
            lblStatus.ForeColor = Color.Gray;
            txtInputMessage.Focus();
        }
        private void AppendMessage(string senderName, string message, Color color)
        {
            rtbChatHistory.SelectionStart = rtbChatHistory.TextLength;
            rtbChatHistory.SelectionLength = 0;

            rtbChatHistory.SelectionFont = new Font(rtbChatHistory.Font, FontStyle.Bold);
            rtbChatHistory.SelectionColor = color;
            rtbChatHistory.AppendText($"{senderName} [{DateTime.Now:HH:mm}]:\n");

            rtbChatHistory.SelectionFont = new Font(rtbChatHistory.Font, FontStyle.Regular);
            rtbChatHistory.SelectionColor = Color.Black;
            rtbChatHistory.AppendText($"{message}\n\n");

            rtbChatHistory.ScrollToCaret();
        }
    }
}

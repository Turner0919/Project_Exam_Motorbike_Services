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
    public partial class frmAIChat : Form
    {
        private readonly GeminiService _geminiService = new GeminiService();
        public frmAIChat()
        {
            InitializeComponent();
            lblStatus.Text = "";
            AppendChat("Hệ thống AI", "Xin chào! Tôi có thể hỗ trợ gì cho bạn về kỹ thuật và lịch bảo dưỡng xe máy?", Color.DarkBlue);
        }
        // Hàm xử lý gửi tin nhắn bất đồng bộ
        private async Task SendMessageAsync()
        {
            string userQuery = txtUserInput.Text.Trim();
            if (string.IsNullOrEmpty(userQuery)) return;

            // 1. Hiển thị tin nhắn người dùng
            AppendChat("Bạn", userQuery, Color.DarkGreen);
            txtUserInput.Clear();

            // 2. Khóa nút bấm trong lúc chờ AI phản hồi
            btnSend.Enabled = false;
            txtUserInput.Enabled = false;
            lblStatus.Text = "Trợ lý AI đang suy nghĩ...";

            // 3. Gọi BLL xử lý (async không bị đơ giao diện WinForms)
            string aiResponse = await _geminiService.AskAIAsync(userQuery);

            // 4. Hiển thị câu trả lời của AI
            lblStatus.Text = "";
            AppendChat("Trợ lý AI", aiResponse, Color.DarkBlue);

            // 5. Mở lại nút bấm
            btnSend.Enabled = true;
            txtUserInput.Enabled = true;
            txtUserInput.Focus();
        }
        // Hàm định dạng màu sắc văn bản cuộc trò chuyện
        private void AppendChat(string sender, string message, Color color)
        {
            rtbChatHistory.SelectionStart = rtbChatHistory.TextLength;
            rtbChatHistory.SelectionLength = 0;

            rtbChatHistory.SelectionColor = color;
            rtbChatHistory.SelectionFont = new Font(rtbChatHistory.Font, FontStyle.Bold);
            rtbChatHistory.AppendText($"{sender}: ");

            rtbChatHistory.SelectionColor = Color.Black;
            rtbChatHistory.SelectionFont = new Font(rtbChatHistory.Font, FontStyle.Regular);
            rtbChatHistory.AppendText($"{message}\n\n");

            rtbChatHistory.ScrollToCaret();
        }
        // Sự kiện bấm Enter ở ô nhập
        private async void txtUserInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Tắt tiếng píp thông báo
                await SendMessageAsync();
            }
        }
        private void rtbChatHistory_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAIChat_Load(object sender, EventArgs e)
        {

        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            await SendMessageAsync();
        }
    }
}

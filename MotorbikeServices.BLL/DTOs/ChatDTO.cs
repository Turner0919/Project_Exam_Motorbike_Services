using System;
using System.Collections.Generic;
using System.Text;

namespace MotorbikeServices.BLL.DTOs
{
    public class ChatMessageDTO
    {
        public string Sender { get; set; } = string.Empty; // "User" hoặc "AI"
        public string Message { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; } = DateTime.Now;
    }
}

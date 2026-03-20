using System;
using System.Collections.Generic;
using System.Text;

namespace CybersecurityChatbot.Models
{
    public class ChatResponse
    {
        public string Message { get; set; }
        public ConsoleColor Color { get; set; }
        public bool UseTypingEffect { get; set; }

        public ChatResponse(string message, ConsoleColor color = ConsoleColor.White, bool useTypingEffect = true)
        {
            Message = message;
            Color = color;
            UseTypingEffect = useTypingEffect;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace CybersecurityChatbot.Models
{
    public class User
    {
        public string Name { get; set; }
        public DateTime ConversationStartTime { get; set; }

        public User()
        {
            ConversationStartTime = DateTime.Now;
        }
    }
}
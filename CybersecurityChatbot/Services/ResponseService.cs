using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace CybersecurityChatbot.Services
{
    public class ResponseService
    {
        private Dictionary<string, List<string>> _responses;

        public ResponseService()
        {
            InitializeResponses();
        }

        private void InitializeResponses()
        {
            _responses = new Dictionary<string, List<string>>
            {
                ["greeting"] = new List<string>
                {
                    "Hello there! How can I help you stay safe online today?",
                    "Hi! Ready to learn about cybersecurity?",
                    "Greetings! Ask me anything about online safety."
                },

                ["how are you"] = new List<string>
                {
                    "I'm functioning securely! Thanks for asking.",
                    "All systems operational and ready to help!",
                    "Doing great! Ready to share some cybersecurity tips."
                },

                ["purpose"] = new List<string>
                {
                    "I'm your Cybersecurity Awareness Assistant! I'm here to educate you about online safety, password security, phishing scams, and safe browsing habits.",
                    "My mission is to help you stay safe online by providing tips and information about cybersecurity threats and how to avoid them."
                },

                ["what can I ask"] = new List<string>
                {
                    "You can ask me about:\n" +
                    "  🔐 Password safety\n" +
                    "  🎣 Phishing scams\n" +
                    "  🌐 Safe browsing\n" +
                    "  📱 Social media privacy\n" +
                    "  🔄 Software updates\n" +
                    "  📧 Email security"
                },

                ["password"] = new List<string>
                {
                    "🔐 **Password Safety Tip**: Use strong, unique passwords for each account. A strong password should be at least 12 characters long and include uppercase, lowercase, numbers, and symbols.",
                    "🔐 **Password Tip**: Consider using a password manager! It can generate and store complex passwords for you, so you only need to remember one master password.",
                    "🔐 **Security Alert**: Never use personal information like your birthdate or pet's name in passwords. Hackers can easily find this info on social media."
                },

                ["phishing"] = new List<string>
                {
                    "🎣 **Phishing Alert**: Be cautious of emails or messages asking for personal information. Legitimate companies never ask for passwords via email.",
                    "🎣 **Phishing Tip**: Always check the sender's email address carefully. Scammers often use addresses that look similar to real ones (e.g., 'amaz0n.com' instead of 'amazon.com').",
                    "🎣 **Warning**: Don't click on links in unsolicited emails. Hover over them first to see the actual URL. If it looks suspicious, don't click!"
                },

                ["safe browsing"] = new List<string>
                {
                    "🌐 **Safe Browsing**: Always look for 'https://' in the website address and the padlock icon before entering any personal information.",
                    "🌐 **Wi-Fi Safety**: Avoid accessing sensitive accounts (banking, email) on public Wi-Fi. If you must, use a VPN to encrypt your connection.",
                    "🌐 **Browser Security**: Keep your browser updated and consider using privacy-focused browsers or extensions that block trackers and malicious sites."
                },

                ["default"] = new List<string>
                {
                    "I'm not sure I understand. Could you rephrase that?",
                    "I didn't quite catch that. Try asking about passwords, phishing, or safe browsing.",
                    "Hmm, I'm still learning! Can you ask your question differently?"
                }
            };
        }

        public string GetResponse(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return GetRandomResponse("default");

            input = input.ToLower().Trim();

            // Check for greetings
            if (input.Contains("hello") || input.Contains("hi") || input.Contains("hey"))
                return GetRandomResponse("greeting");

            // Check for "how are you"
            if (input.Contains("how are you"))
                return GetRandomResponse("how are you");

            // Check for purpose
            if (input.Contains("purpose") || input.Contains("what do you do") || input.Contains("who are you"))
                return GetRandomResponse("purpose");

            // Check for "what can I ask"
            if (input.Contains("what can i ask") || input.Contains("help") || input.Contains("what topics"))
                return GetRandomResponse("what can I ask");

            // Check cybersecurity keywords
            if (input.Contains("password") || input.Contains("passwords") || input.Contains("pass phrase"))
                return GetRandomResponse("password");

            if (input.Contains("phish") || input.Contains("scam") || input.Contains("fake email"))
                return GetRandomResponse("phishing");

            if (input.Contains("safe browse") || input.Contains("browsing") || input.Contains("website") ||
                input.Contains("internet") || input.Contains("online"))
                return GetRandomResponse("safe browsing");

            // Default response if no keywords match
            return GetRandomResponse("default");
        }

        private string GetRandomResponse(string key)
        {
            if (_responses.ContainsKey(key) && _responses[key].Count > 0)
            {
                var responses = _responses[key];
                var random = new System.Random();
                return responses[random.Next(responses.Count)];
            }
            return "I'm still learning about that topic. Try asking something else!";
        }
    }
}


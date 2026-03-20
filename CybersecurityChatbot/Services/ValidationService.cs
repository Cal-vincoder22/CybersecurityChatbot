using System;
using System.Collections.Generic;
using System.Text;

namespace CybersecurityChatbot.Services
{
    public class ValidationService
    {
        public bool IsValidInput(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }

        public string SanitizeInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            // Remove excessive whitespace
            return input.Trim();
        }

        public bool IsExitCommand(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            string lower = input.ToLower().Trim();
            return lower == "exit" || lower == "quit" || lower == "goodbye" || lower == "bye";
        }
    }
}
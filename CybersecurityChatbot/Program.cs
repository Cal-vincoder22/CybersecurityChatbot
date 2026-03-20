// See https://aka.ms/new-console-template for more information
using System;
using CybersecurityChatbot.Services;
using CybersecurityChatbot.Utilities;

namespace CybersecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set console title
            Console.Title = "Cybersecurity Awareness Bot";

            try
            {
                // Initialize services
                var audioService = new AudioService();
                var asciiService = new AsciiArtService();
                var chatService = new ChatService();

                // 1. Play voice greeting (Task 1)
                audioService.PlayGreeting();

                // 2. Display ASCII art (Task 2)
                asciiService.DisplayAsciiArt();

                // Small delay for dramatic effect
                System.Threading.Thread.Sleep(1000);

                // 3. Start the chat (Tasks 3-6)
                chatService.StartChat();
            }
            catch (Exception ex)
            {
                // Global error handler - prevents crashes
                ConsoleHelper.PrintError($"An unexpected error occurred: {ex.Message}");
                ConsoleHelper.PrintInfo("Please restart the application.");
                Console.ReadKey();
            }
        }
    }
}

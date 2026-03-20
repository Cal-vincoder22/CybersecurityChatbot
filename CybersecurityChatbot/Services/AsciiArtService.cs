using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CybersecurityChatbot.Services
{
    public class AsciiArtService
    {
        private readonly string _asciiFilePath = "Assets/ascii-art.txt";

        public void DisplayAsciiArt()
        {
            try
            {
                // Try to load from file first
                if (File.Exists(_asciiFilePath))
                {
                    string ascii = File.ReadAllText(_asciiFilePath);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(ascii);
                    Console.ResetColor();
                }
                else
                {
                    // Fallback to hardcoded ASCII art
                    DisplayDefaultAscii();
                }
            }
            catch
            {
                DisplayDefaultAscii();
            }
        }

        private void DisplayDefaultAscii()
        {
            string ascii = @"
    ╔══════════════════════════════════════════════════════════╗
    ║                                                          ║
    ║     🔒  CYBERSECURITY AWARENESS BOT  🔒                 ║
    ║                                                          ║
    ║     ╔═══╗ ╔═══╗ ╔═══╗ ╔═══╗ ╔═══╗ ╔═══╗ ╔═══╗ ╔═══╗    ║
    ║     ║ P ║ ║ A ║ ║ S ║ ║ S ║ ║ W ║ ║ O ║ ║ R ║ ║ D ║    ║
    ║     ╚═══╝ ╚═══╝ ╚═══╝ ╚═══╝ ╚═══╝ ╚═══╝ ╚═══╝ ╚═══╝    ║
    ║                                                          ║
    ║            Your Guide to Online Safety                  ║
    ║                                                          ║
    ╚══════════════════════════════════════════════════════════╝
            ";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(ascii);
            Console.ResetColor();
        }
    }
}

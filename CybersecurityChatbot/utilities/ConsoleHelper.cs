using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CybersecurityChatbot.Utilities
{
    public static class ConsoleHelper
    {
        public static void PrintColored(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void PrintWithTypingEffect(string message, ConsoleColor color, int delayMs = 30)
        {
            Console.ForegroundColor = color;
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(delayMs);
            }
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void PrintBorder()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("══════════════════════════════════════════════════");
            Console.ResetColor();
        }

        public static void PrintHeader(string title)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔══════════════════════════════════════════════════╗");
            Console.WriteLine($"║{title.PadLeft(25 + title.Length / 2).PadRight(50)}║");
            Console.WriteLine("╚══════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void PrintSuccess(string message)
        {
            PrintColored($"✓ {message}", ConsoleColor.Green);
        }

        public static void PrintError(string message)
        {
            PrintColored($"✗ {message}", ConsoleColor.Red);
        }

        public static void PrintInfo(string message)
        {
            PrintColored($"ℹ {message}", ConsoleColor.Yellow);
        }
    }
}


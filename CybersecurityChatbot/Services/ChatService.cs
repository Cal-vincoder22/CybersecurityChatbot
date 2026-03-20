using System;
using System.Collections.Generic;
using System.Text;
using CybersecurityChatbot.Models;
using CybersecurityChatbot.Utilities;

namespace CybersecurityChatbot.Services
{
    public class ChatService
    {
        private User _currentUser;
        private ResponseService _responseService;
        private ValidationService _validationService;

        public ChatService()
        {
            _responseService = new ResponseService();
            _validationService = new ValidationService();
            _currentUser = new User();
        }

        public void StartChat()
        {
            DisplayWelcome();
            GetUserName();
            RunChatLoop();
        }

        private void DisplayWelcome()
        {
            ConsoleHelper.PrintHeader("WELCOME TO CYBERSECURITY AWARENESS BOT");

            // Display a brief welcome
            ConsoleHelper.PrintColored("Your personal guide to staying safe online!", ConsoleColor.Green);
            ConsoleHelper.PrintBorder();
        }

        private void GetUserName()
        {
            ConsoleHelper.PrintColored("Before we begin, what's your name? ", ConsoleColor.Yellow);
            string input = Console.ReadLine();

            while (!_validationService.IsValidInput(input))
            {
                ConsoleHelper.PrintError("Name cannot be empty. Please enter your name: ");
                input = Console.ReadLine();
            }

            _currentUser.Name = _validationService.SanitizeInput(input);

            ConsoleHelper.PrintSuccess($"Welcome, {_currentUser.Name}! 👋");
            ConsoleHelper.PrintInfo("I'm here to help you learn about cybersecurity.");
            ConsoleHelper.PrintInfo("You can ask me about passwords, phishing, safe browsing, or type 'exit' to quit.");
            ConsoleHelper.PrintBorder();
        }

        private void RunChatLoop()
        {
            string userInput;

            do
            {
                // Get user input with prompt
                ConsoleHelper.PrintColored($"{_currentUser.Name}: ", ConsoleColor.Green);
                userInput = Console.ReadLine();

                // Check for exit
                if (_validationService.IsExitCommand(userInput))
                {
                    SayGoodbye();
                    break;
                }

                // Process the input
                ProcessUserInput(userInput);

            } while (true);
        }

        private void ProcessUserInput(string input)
        {
            // Validate input
            if (!_validationService.IsValidInput(input))
            {
                ConsoleHelper.PrintError("I didn't hear anything. Please type something!");
                return;
            }

            // Clean input
            string cleanInput = _validationService.SanitizeInput(input);

            // Get response
            string response = _responseService.GetResponse(cleanInput);

            // Display response with typing effect for more natural conversation
            ConsoleHelper.PrintWithTypingEffect($"Bot: {response}", ConsoleColor.White, 20);
            ConsoleHelper.PrintBorder();
        }

        private void SayGoodbye()
        {
            ConsoleHelper.PrintColored("\nBot: Thanks for chatting! Remember to stay safe online! 👋", ConsoleColor.Magenta);
            ConsoleHelper.PrintColored("Press any key to exit...", ConsoleColor.DarkGray);
            Console.ReadKey();
        }
    }
}

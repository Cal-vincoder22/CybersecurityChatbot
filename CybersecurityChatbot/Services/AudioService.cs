using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Text;
using CybersecurityChatbot.Utilities;

namespace CybersecurityChatbot.Services
{
    public class AudioService
    {
        private readonly string _audioFilePath = "Assets/greeting.wav";

        public void PlayGreeting()
        {
            try
            {
                // Check if file exists
                if (!File.Exists(_audioFilePath))
                {
                    ConsoleHelper.PrintError("Audio file not found. Continuing without sound...");
                    return;
                }

                using (SoundPlayer player = new SoundPlayer(_audioFilePath))
                {
                    player.Load(); // Load the sound
                    player.PlaySync(); // Play and wait for completion
                }
            }
            catch (Exception ex)
            {
                // Fallback if audio fails - don't crash the app
                ConsoleHelper.PrintError($"Audio playback failed: {ex.Message}");
                ConsoleHelper.PrintInfo("Continuing without sound...");
            }
        }
    }
}

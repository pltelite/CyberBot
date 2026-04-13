using System;

class Program
{
    static void Main()
    {
        Console.Title = "Cybersecurity Awareness Bot";

        // Play voice greeting
        AudioPlayer.PlayGreeting();

        // Display ASCII art
        Chatbot.DisplayLogo();

        // Start chatbot
        Chatbot.Start();
    }
}

using System;
using System.Threading;

class Chatbot
{
    static string userName = "";

    public static void DisplayLogo()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=====================================");
        Console.WriteLine("  CYBERSECURITY AWARENESS BOT  ");
        Console.WriteLine("=====================================");
        Console.WriteLine("   [🔒] Stay Safe Online [🔒]");
        Console.WriteLine("=====================================");
        Console.ResetColor();
    }

    public static void Start()
    {
        AskName();

        Console.WriteLine($"\nWelcome, {userName}! 👋");
        Console.WriteLine("Ask me anything about cybersecurity.");
        Console.WriteLine("Type 'exit' to quit.\n");

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("> ");
            Console.ResetColor();

            string input = Console.ReadLine()?.ToLower();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("⚠️ I didn’t quite understand that. Try again.");
                continue;
            }

            if (input == "exit")
            {
                Console.WriteLine("Goodbye! Stay safe online 🔐");
                break;
            }

            Respond(input);
        }
    }

    static void AskName()
    {
        Console.Write("Enter your name: ");
        userName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(userName))
        {
            userName = "User";
        }
    }

    static void Respond(string input)
    {
        if (input.Contains("how are you"))
        {
            Console.WriteLine("I'm just code, but I'm here to help you stay safe online!");
        }
        else if (input.Contains("purpose"))
        {
            Console.WriteLine("My purpose is to help you understand cybersecurity basics.");
        }
        else if (input.Contains("password"))
        {
            Console.WriteLine("Use strong passwords with letters, numbers, and symbols. Never reuse them!");
        }
        else if (input.Contains("phishing"))
        {
            Console.WriteLine("Phishing is when scammers trick you into giving personal info. Always check links carefully.");
        }
        else if (input.Contains("safe browsing"))
        {
            Console.WriteLine("Avoid suspicious websites and always look for HTTPS 🔒.");
        }
        else if (input.Contains("what can i ask"))
        {
            Console.WriteLine("You can ask about passwords, phishing, and safe browsing.");
        }
        else
        {
            Console.WriteLine("🤔 I didn’t quite understand that. Could you rephrase?");
        }

        TypingEffect();
    }

    static void TypingEffect()
    {
        Thread.Sleep(500);
    }
}

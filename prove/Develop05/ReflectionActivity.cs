using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done something similar?",
        "How did you feel when you completed it?",
        "What did you learn about yourself from this experience?"
    };

    public ReflectionActivity() : base("Reflection", "This activity helps you reflect on moments in your life when you've shown strength and resilience. It will help you recognize the power you have and how you can apply it to other areas of your life.")
    {
    }

    public override void ExecuteActivity()
    {
        DisplayStartMessage();

        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine(prompt);  // Only print the prompt without the "Prompt:" label
        Pause(2);

        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            string question = questions[rand.Next(questions.Count)];
            Console.WriteLine(question);  // Print the question without the "Reflection Question:" label
            Console.WriteLine("Press Enter to continue or press Enter again to pause and reflect more...");

            // Pause and wait for Enter key press
            while (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine("Paused. Press Enter again to continue.");
                while (Console.KeyAvailable && Console.ReadKey(true).Key != ConsoleKey.Enter) { }
                break;
            }

            Pause(5);  // Pause for 5 seconds to allow reflection
        }

        DisplayEndMessage();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example scriptures
            List<Scripture> scriptures = new List<Scripture>
            {
                new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
                new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.")
            };

            Random random = new Random();
            Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Scripture Memorizer\n");
                Console.WriteLine(selectedScripture.Display());
                Console.WriteLine("\nPress Enter to continue, type 'quit' to exit, or 'hint' for a hint.");

                string input = Console.ReadLine();
                if (input?.ToLower() == "quit") break;

                // "Hint" functionality: Allows the user to reveal a hidden word as a hint.
                if (input?.ToLower() == "hint")
                {
                    if (!selectedScripture.RevealHint())
                    {
                        Console.WriteLine("\nThere are no hidden words to reveal. Press Enter to continue.");
                        Console.ReadLine();
                    }
                    continue;
                }

                if (!selectedScripture.HideRandomWords())
                {
                    Console.WriteLine("\nYou have memorized the entire scripture! Program ending.");
                    break;
                }
            }
        }
    }
}

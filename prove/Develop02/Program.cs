using System;

class Program
{
    static void Main(string[] args)
    {
        Diary diary = new Diary();
        string[] questions = new string[]
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see God's hand in my life today?",
            "What was the strongest emotion I felt today?",
            "If I could do one thing today, what would it be?"
        };

        bool continueRunning = true;
        while (continueRunning)
        {
            // Menu options
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display diary entries");
            Console.WriteLine("3. Save diary to file");
            Console.WriteLine("4. Load diary from file");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");
            
            var option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    // Write a new entry
                    Random random = new Random();
                    string question = questions[random.Next(questions.Length)];
                    Console.WriteLine($"Question: {question}");
                    Console.Write("Answer: ");
                    string answer = Console.ReadLine();
                    string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    diary.AddEntry(date, question, answer);
                    break;

                case "2":
                    // Display diary entries
                    diary.DisplayEntries();
                    break;

                case "3":
                    // Save diary to a file
                    Console.Write("Enter the file name to save: ");
                    string fileNameToSave = Console.ReadLine();
                    diary.SaveDiary(fileNameToSave);
                    break;

                case "4":
                    // Load diary from a file
                    Console.Write("Enter the file name to load: ");
                    string fileNameToLoad = Console.ReadLine();
                    diary.LoadDiary(fileNameToLoad);
                    break;

                case "5":
                    // Exit the program
                    continueRunning = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}

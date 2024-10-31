using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name?");
        string question1 = Console.ReadLine();

        Console.Write("What is your last name?");
        string question2 = Console.ReadLine();

        Console.WriteLine($"Your name is {question2}, {question1} {question2}");
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();
        Console.Write("What is your last name? ");
        string last = Console.ReadLine();
        Console.WriteLine("");
        Console.Write($"Your name is {last}, {first}, {last}.");
        Console.WriteLine("");
    }
}
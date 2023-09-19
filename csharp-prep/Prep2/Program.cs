using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string letter;
        Console.WriteLine("");
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        if (number >= 90 && number <= 100)
        {
            letter = "A";
        }
        else if (number >= 80 && number <= 90)
        {
            letter = "B";
        }
        else if (number >= 70 && number <= 80)
        {
            letter = "C";
        }
        else if (number >= 60 && number <= 70)
        {
            letter = "D";
        }
        else if (number >= 0 && number <= 60)
        {
            letter = "F";
        }
        else
        {
            Console.WriteLine("Invalid input!");
            Console.WriteLine("");
            return;
        }
        Console.Write($"You got a(n) {letter}. ");
        Console.WriteLine("");
        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.Write("Great job! You acheived a passing grade!");
            Console.WriteLine("");
            Console.WriteLine("");
        }
        else
        {
            Console.Write("Nice try! Keep studying hard and maybe you'll get a passing grade next time.");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
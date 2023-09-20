using System;

class Program
{
    static void Main(string[] args)
    {
        string z = "continue";
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        Console.WriteLine("");
        Console.WriteLine("I'm thinking of a number between 1 & 100... What is it?");
        Console.WriteLine("");
        while (z == "continue")
        {
            string input = Console.ReadLine();
            int guess = int.Parse(input);
            Console.WriteLine("");
            if (guess < number && guess >= 1)
            {
                Console.WriteLine("Guess a little higher next time!");
                Console.WriteLine("");
            }
            else if (guess > number && guess <= 100)
            {
                Console.WriteLine("Guess a little lower next time!");
                Console.WriteLine("");
            }
            else if (guess == number)
            {
                Console.WriteLine("You guessed it!!!");
                Console.WriteLine("");
                z = "end";
            }
            else
            {
                Console.WriteLine("Enter a whole number between 1 & 100 please.");
                Console.WriteLine("");
            }
        }
    }
}
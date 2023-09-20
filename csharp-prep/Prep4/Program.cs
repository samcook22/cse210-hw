using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        while (true)
        {
            Console.WriteLine("");
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            numbers.Add(number);
            if (number == 0)
            {
                break;
            }
        
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine("");
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine("");
        float average = (float)sum / (numbers.Count - 1);
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine("");
        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine("");
    }
}
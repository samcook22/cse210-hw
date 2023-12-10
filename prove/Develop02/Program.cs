using System;
using System.IO;

public class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Entry entry = new Entry();

        string choice = "";

        Console.WriteLine("Ready to Journal!");

        while (choice != "5")
        {
            Console.WriteLine("\nSelect option to continue: \n1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
            Console.Write("Choose something ");
            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                string _writtenEntry = entry.NewEntry();
                journal._entriesList.Add(_writtenEntry);
            }
            else if (choice == "2")
            {
                journal.Display();
            }
            else if (choice == "3")
            {
                journal.Load();
            }
            else if (choice == "4")
            {
                journal.Save();
            }
        }
    }
}
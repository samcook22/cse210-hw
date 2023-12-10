using System.IO;

public class Journal
{
    public List<string> _entriesList = new List<string>();


    public void Display()
    {
        foreach (string entry in _entriesList)
        {
            Console.WriteLine($"{entry}");
        }
    }


    public void Load()
    {
        Console.WriteLine("Input file name? ");
        string _fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string _loadEntry = parts[0];
            _entriesList.Add(_loadEntry);
        }

    }


    public void Save()
    {
        Console.WriteLine("Name for the file? (add '.txt' to the end of the name)");
        string _fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
             foreach (string entry in _entriesList)
             {
                outputFile.WriteLine($"{entry}");
             }
        }
    }
}
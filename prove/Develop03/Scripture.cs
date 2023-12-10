using System.Collections.Generic;

public class Scripture
{
    private string _refernece = "";
    private string _text = "";
    private List<Verse> verses = new List<Verse>();

    public Scripture(string scripture)
    {
        string[] scriptureArray = scripture.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
        _refernece = scriptureArray[0];
        _text = scriptureArray[1];
        CreateVerses();
    }

    private void CreateVerses()
    {
        string[] splitVerses = _text.Split("\n", StringSplitOptions.RemoveEmptyEntries);

        foreach ( string verse in splitVerses)
        {
            Verse newVerse = new Verse(verse);
            verses.Add(newVerse);
        }
    }

    public void DisplayScripture()
    {
        Console.WriteLine($"\n{_refernece}");

        foreach (Verse verse in verses)
        {
            verse.DisplayVerse();
            
        }
        
    }

    public void HideWords()
    {
        foreach (Verse verse in verses)
        {
            verse.HideWords();
        }
    }
}
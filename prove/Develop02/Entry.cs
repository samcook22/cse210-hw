public class Entry
{
    public List<string> _promptsList = new List<string>()
    {"What was something you were grateful for today?", "What was the best thing you did today?", "After today, what will you change for tommorow?", "What was a miricale you saw today, big or small?"};
    
    public string NewEntry()
    {
    Random _promptNumber = new Random();
    DateTime _currentDate = DateTime.Now;
    string _entryDate = _currentDate.ToShortDateString();

    int _promptChoice = _promptNumber.Next(0,4);
    string _newPrompt = _promptsList.ElementAt(_promptChoice);
    Console.WriteLine($"{_newPrompt} ");
    string _userResponse = Console.ReadLine();
    string _finishedEntry = $"\nDate: {_entryDate} - Prompt: {_newPrompt} \n{_userResponse}\n\n";

    return _finishedEntry;
    }
}
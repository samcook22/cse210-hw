public class Entry
{
    public List<string> _promptsList = new List<string>()
    {"What was something you did productive?", "What was your favorite thing you did today?", "What something cool you saw today?", "After today, what can you do different tomorrow?"};
    
    public string NewEntry()
    {
    DateTime _currentDate = DateTime.Now;
    Random _promptNumber = new Random();
    string _entryDate = _currentDate.ToShortDateString();

    int _promptChoice = _promptNumber.Next(0,4);
    string _newPrompt = _promptsList.ElementAt(_promptChoice);
    Console.WriteLine($"{_newPrompt} ");
    string _userResponse = Console.ReadLine();
    string _finishedEntry = $"\nDate: {_entryDate} - Prompt: {_newPrompt} \n{_userResponse}\n\n";

    return _finishedEntry;
    }
}

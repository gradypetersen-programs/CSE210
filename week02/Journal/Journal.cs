class Journal
{
    public List<string> _entries = new List<string>();
    public string _entry;

    public void AddEntry()
    {
        _entries.Add(_entry);
    }

    public void Display()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Journal: ");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        foreach (string entry in _entries)
        {
            string updatedEntry = entry.Replace(" || ", "").Trim();
            Console.WriteLine(updatedEntry.Replace("||", "\n"));
            Console.WriteLine();
        }
    }
    
}
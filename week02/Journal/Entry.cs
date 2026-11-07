public class Entry
{
    public string _date;
    public string _userEntry;
    public string _promptText;
    public string CreateString()
    {
        string entry = $"{_date} Prompt: {_promptText}||{_userEntry} || ";
        return entry;
    }
        
    }
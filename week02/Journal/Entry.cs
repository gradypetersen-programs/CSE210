public class Entry
{
    public string _userEntry;
    public string _promptText;
    public string CreateString()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        string entry = $"{dateText} Prompt: {_promptText}||{_userEntry} || ";
        return entry;
    }
        
    }
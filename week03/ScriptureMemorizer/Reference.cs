public class Reference
{
    private string _bookName;
    private int _chapterNumber;
    private int _startVerse;
    private int _endVerse;

    public Reference(string bookName, int chapterNumber, int startVerse, int endVerse)
    {
            _bookName = bookName;
            _chapterNumber = chapterNumber;
            _startVerse = startVerse;
            _endVerse = endVerse;
    }
    
    public void Display()
    {
        if (_endVerse == 0)
        {
            Console.WriteLine($"{_bookName} {_chapterNumber}:{_startVerse}");
        }
        else
        {
            Console.WriteLine($"{_bookName} {_chapterNumber}:{_startVerse}-{_endVerse}");
        }
        Console.WriteLine();
    }
}
using System.Runtime.CompilerServices;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void StoreComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int CountComments()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Video Title: {_title}");
        Console.WriteLine($"Creator: {_author}");
        Console.WriteLine($"Video Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {CountComments()}");
        Console.WriteLine();
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            comment.Display();
            Console.WriteLine();
        }
    }
}
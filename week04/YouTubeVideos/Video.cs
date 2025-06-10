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

    public int NumberComments()
    {
        return _comments.Count;
    }

    public void StoreComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void GetDisplayText()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}");
        Console.WriteLine($"Number of Comments: {NumberComments()}");
        foreach (Comment comment in _comments) {
            Console.WriteLine(comment.DisplayComment());
        }
    }
}
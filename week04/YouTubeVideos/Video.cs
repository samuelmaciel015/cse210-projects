public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void GetVideoInfo()
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("VIDEO INFORMATION");
        Console.WriteLine($"Title: {_title} --- Length (in Seconds): {_lengthInSeconds}");
        Console.WriteLine($"Author: {_author}\n");
        Console.WriteLine("Comments:");
        foreach (Comment item in _comments)
        {
            item.GetComment();
        }
    }

}
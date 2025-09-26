public class Video
{
    //member variables
    private string _title;
    private string _author;
    private int _videoLength;
    List<Comment> _comments = new List<Comment>();

    //constructor
    public Video(string title, string author, int videoLength)
    {
        _title = title;
        _author = author;
        _videoLength = videoLength;
    }

    //get methods
    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public int GetVideoLength()
    {
        return _videoLength;
    }

    //other member methods
    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }
    public int NumberOfComments()
    {
        return _comments.Count();
    }
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Video Title: '{GetTitle()}'");
        Console.WriteLine($"Author: {GetAuthor()} --- Video Length: {GetVideoLength()} --- Number of comments: {NumberOfComments()}");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"- {comment.GetPersonName()}: '{comment.GetCommentText()}'");
        }
        Console.WriteLine("");
    }
}
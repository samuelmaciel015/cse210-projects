public class Comment
{
    private string _personName;
    private string _textComment;

    public Comment(string personName, string textComment)
    {
        _personName = personName;
        _textComment = textComment;
    }
    public void GetComment()
    {
        Console.WriteLine($"@{_personName}: '{_textComment}'");
    }
}
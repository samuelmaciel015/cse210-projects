public class Comment
{
    //member variables
    private string _personName;
    private string _commentText;

    //constructors
    public Comment(string personName, string commentText)
    {
        _personName = personName;
        _commentText = commentText;
    }

    //get methods
    public string GetPersonName()
    {
        return _personName;
    }
    public string GetCommentText()
    {
        return _commentText;
    }
}
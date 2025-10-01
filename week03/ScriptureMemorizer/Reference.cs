public class Reference
{
    //member variables
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    //constructors
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    //get methods
    private string GetBook()
    {
        return _book;
    }
    private int GetChapter()
    {
        return _chapter;
    }
    private int GetVerse()
    {
        return _verse;
    }
    private int GetEndVerse()
    {
        return _endVerse;
    }
    //member methods
    public string GetDisplayText()
    {
        if (GetEndVerse() != 0)
        {
            return $"{GetBook()} {GetChapter()}:{GetVerse()}-{GetEndVerse()}";
        }
        else
        {
            return $"{GetBook()} {GetChapter()}:{GetVerse()}";
        }
    }
}
using System.Security.Cryptography;

public class Word
{
    //member variables
    private string _text;
    private bool _isHidden;

    //constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    //get methods
    private string GetText()
    {
        return _text;
    }
    private bool GetIsHidden()
    {
        return _isHidden;
    }

    //member methods
    public void Hide()
    {
        foreach (char letter in GetText())
        {
            Console.Write("_");
        }
        _isHidden = true;
    }
    private void Show()
    {
        Console.Write(GetText());
        _isHidden = false;
    }
    private bool IsHidden()
    {
        return GetIsHidden();
    }
    public string GetDisplayText()
    {
        if (IsHidden() == true)
        {
            return _text;
        }
        else
        {
            return _text;
        }
    }
}
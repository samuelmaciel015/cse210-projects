using System.Security.Cryptography;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    //constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Word randomWord = _words[numberToHide];
    }
    public void GetDisplayText()
    {
        foreach (Word item in _words)
        {
            Console.Write($"{item.GetDisplayText} ");
        }
    }
}
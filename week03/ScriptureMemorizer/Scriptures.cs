public class Scripture
{
    //variables
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    //constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] textSplited = text.Split(' ');
        foreach (string item in textSplited)
        {
            Word word = new Word(item);

            _words.Add(word);
        }
    }

    //methods
    private Random _random = new Random();
    public void HideRandomWords(int numberToHide)
    {
        int hidden = 0;

        while (hidden < numberToHide && !IsCompletelyHidden())
        {
            int index = _random.Next(_words.Count);

            if (!_words[index].isHidden())
            {
                _words[index].Hide();
                hidden++;
            }
        }
    }
    public string GetDisplayText()
    {
        string text = "";
        foreach (Word word in _words)
        {
            text += $"{word.GetDisplayText()} ";
        }

        return text;
    }
    public bool IsCompletelyHidden()
    {
        int i = 0;
        foreach (Word word in _words)
        {
            if (word.isHidden() == true)
            {
                i++;
            }
        }

        if (i >= _words.Count())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
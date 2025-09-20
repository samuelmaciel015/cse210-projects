public class Fractions
{
    private int _top;
    private int _bottom;

    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fractions(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fractions(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public double GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        top = _top;
    }
    public double GetTBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        bottom = _bottom;
    }

    public string GetFractionString()
    {
        return GetTop() + "/" + GetTBottom().ToString();
    }
    public double GetDecimalValue()
    {
        return GetTop() / GetTBottom();
    }
}
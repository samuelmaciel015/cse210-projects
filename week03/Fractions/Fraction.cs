public class Fraction
{
    //variables
    private int _top;
    private int _bottom;

    //constructors
    public Fraction()
    {
        _bottom = 1;
        _top = 1;
    }
    public Fraction(int wholeNumber)
    {
        _bottom = 1;
        _top = wholeNumber;
    }
    public Fraction(int top, int bottom)
    {
        _bottom = bottom;
        _top = top;
    }

    //getters and setters
    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    //methods
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}
class Fraction
{
    private int _top;
    private int _botton;

    public Fraction()
    {
        _top = 1;
        _botton = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _botton = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _botton = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _botton;
    }

    public void SetBottom(int value)
    {
        _botton = value;
    }

    public void SetTop(int value)
    {
        _top = value;
    }

    public string GetFractionString()
    {
        string fractionText = $"{_top}/{_botton}";
        return fractionText;
    }

    public double GetDecimalValue()
    {
        return (double)_top/(double)_botton;
    } 
}
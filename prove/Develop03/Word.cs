class Word
{
    private string _text;
    private bool _IsHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _IsHidden = true;
    }

    public void Show()
    {
        _IsHidden = false;
    }

    public bool IsHidden()
    {
        return _IsHidden;
    }

    public string GetDisplayText()
    {   
        return _text;
    }
}
class Comments
{
    private string _name;
    private string _commentText;

    public void CreateComment(string name, string text)
    {
        _name = name;
        _commentText = text;
    }

    public string Text()
    {
        string text = ($"{_name}: {_commentText}");
        return text;
    }
}
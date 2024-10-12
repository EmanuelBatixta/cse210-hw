class Video
{
    private string _title;
    private string _autor;
    private int _duration;
    private List<Comments> _comment;

    public Video(string title, string autor, int duration)
    {
        _title = title;
        _autor = autor;
        _duration = duration;
        _comment = new List<Comments>();
    }

    public void AddComment(string name, string _text)
    {
        Comments text = new Comments();
        text.CreateComment(name, _text);
        _comment.Add(text);
    }

    public int CommentLength()
    {
        return _comment.Count;
    }

    public void PrintVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Autor: {_autor}");
        Console.WriteLine($"Duration: {_duration} seconds");
        Console.WriteLine($"This video has {CommentLength()} comments:");

        foreach(Comments comment in _comment)
        {
            Console.WriteLine(comment.Text());
        }
    }

}
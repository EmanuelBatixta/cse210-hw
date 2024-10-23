using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();
        Console.Clear();
        Video video1 = new Video("C# Introduction","Emanuel Jonatas", 8000);
        Video video2 = new Video("Introduction to Web design","Lincol Burrows", 9000);
        Video video3 = new Video("Introduction to Python","Getulio Vargas", 18000);

        video1.AddComment("Jorge Luis","This is a great way to do this.");
        video1.AddComment("Yuri Ramos","I loved this form to solve this problem.");
        video1.AddComment("Douglas Dutra","I don't like this, is the wrong way.");

        video2.AddComment("Aline Souza","Thanks, I started in the Web Design in the last week. This video helped me a lot.");
        video2.AddComment("David Barros","This make sense, I will try this in my project.");
        video2.AddComment("Teacher Young","Wow, this is amazing.");

        video3.AddComment("Lincol Scotfield","I love learn more Python.");
        video3.AddComment("Lucas Lemos","You helped me solve a problem this night. Thanks!");
        video3.AddComment("Felipe Silva","Hey bro, continue be the good professor.");

        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);

        foreach(Video v in _videos)
        {
            v.PrintVideo();
            Console.WriteLine("");
        }

    }
}
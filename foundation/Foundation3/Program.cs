using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("");
        List<Activity> _activity = new List<Activity>{
           new Cycling(180,50),
           new Running(120,30),
           new Swimming(60,80)
        };

        foreach(Activity a in _activity)
        {
            Console.WriteLine(a.GetSummary());
        }
        Console.WriteLine("\n");
    }
}
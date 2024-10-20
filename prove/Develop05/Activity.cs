class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome to the {_name} Activity.");
        Console.WriteLine($"\n{_description}");
        Console.Write($"\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        ShowSpinner(5);
        Console.WriteLine($"\nWell Done.");
        ShowSpinner(5);
        Console.WriteLine($"You have completed another {_duration} seconds of {_name} Activity.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> _spinner = new List<string>{"|","/","-","\\","|","/","-","\\"};
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while(DateTime.Now < endTime)
        {
            foreach(string i in _spinner)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for(int i = seconds; i > 0; i-- )
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}
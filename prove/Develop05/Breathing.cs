class Breathing : Activity
{
    public Breathing(string name, string description) : base(name, description)
    {
    }

    public void BreathingActivity()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while(DateTime.Now < endTime)
        {
            Console.Write($"\nBreathe in... ");
            ShowCountDown(3);
            Console.Write($"\nBreathe out... ");
            ShowCountDown(6);
            Console.Write($"\n");
        }
    }

    public void Run()
    {
        DisplayStartingMessage();
        BreathingActivity();
        DisplayEndingMessage();
    }

}
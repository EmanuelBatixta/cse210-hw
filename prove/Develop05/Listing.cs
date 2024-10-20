class Listing : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>{
        "What moment today made you feel most alive?",
        "How did you express kindness today?",
        "What did you learn about yourself today",
        "What inspired you today?",
        "Who do you wish to reconnect with and why?"};

    public Listing(string name, string description) : base(name, description)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();

        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.WriteLine($"You may begin in: ");
        GetListFromUser();

        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random _random = new Random();
        int index = _random.Next(_prompts.Count());
        Console.WriteLine($"--{_prompts[index]}--");
    }

    public List<string> GetListFromUser()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        List<string> _list = new List<string>();

        while(DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                _list.Add(input);
            }
        }
        _count = _list.Count();
        return _list;
    }
}
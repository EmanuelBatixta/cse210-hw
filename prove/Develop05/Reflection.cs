class Refletction : Activity
{
    private List<string> _prompts = new List<string>{
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Refletction(string name, string description) : base(name, description)
    {
    }

    public string GetRandomPrompt()
    {
        Random _random = new Random();
        int index = _random.Next(_prompts.Count());
        return _prompts[index];
    }
    public string GetRandomQuestion()
    {
        Random _random = new Random();
        int index = _random.Next(_questions.Count());
        return _questions[index];
    }
    
    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($"--{GetRandomPrompt()}--"); 
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    } 
    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    } 

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        DisplayPrompt();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(3);
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while(DateTime.Now < endTime)
        {
            DisplayQuestions();
            ShowSpinner(3);
        }

    }

}
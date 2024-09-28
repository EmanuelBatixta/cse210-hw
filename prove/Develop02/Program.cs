using System;
using System.IO; 


class Program
{
    static void Main(string[] args)
    {
        Journal _journal = new Journal();
        Exceptions _exception = new Exceptions();
        Entry _entry = new Entry();

        string _option;

        do 
        {   
            _option = MenuOptions();
        

            if(_option == "1") //write
            {   
                _journal.AddEntry(_entry);
            } 
            else if(_option == "2") // display
            {
                _journal.DisplayAll();
            }
            else if(_option == "3") // load
            {
                _exception.FileError(_journal);
            }
            else if(_option == "4") // save
            {
                _journal.SaveToFile();
            }

        }while(_option != "5"); // quit
    }

    static string MenuOptions()
    {
        Console.WriteLine("\nWelcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? "); 
        string _option = Console.ReadLine();

        return _option;
    }

    class Exceptions
    {
        public void FileError(Journal _path)
        {
            bool LoadedFile = false;
            while (!LoadedFile)
            {
                try
                {
                    _path.LoadFromFile();
                    LoadedFile = true;
                }
                catch(FileNotFoundException)
                {
                    Console.WriteLine("The file not found, please enter a valid filename.");
                }
                
            }
        }
    }

    class Journal
    {   
        List<Entry> _entries = new List<Entry>();

        public void AddEntry(Entry newEntry)
        {
            string _date = newEntry.DefDate();
            string _prompt = newEntry.GetPrompt();
            string _entryText = newEntry.Display();
            
            _entries.Add(new Entry{_date = _date, _prompt = _prompt, _entryText = _entryText});
        }

        public void LoadFromFile() // Read text of a document
        {   
            Console.Write("What's the filename? \n> ");
            string filename = Console.ReadLine();
            
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");

                string _date = parts[0];
                string _prompt = parts[1];
                string _entryText = parts[2];

                _entries.Add(new Entry{_date = _date, _prompt = _prompt, _entryText = _entryText});

            }
        }
    
        public void SaveToFile() //Put text in a document 
        {
            Console.Write("What's the filename? \n> ");
            string fileName = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach(Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date} | {entry._prompt} | {entry._entryText}");
                }
            }
        }

        public void DisplayAll()
        {
            foreach(Entry entry in _entries)
                {
                    Console.WriteLine($"\nDate: {entry._date} -- Prompt: {entry._prompt} \n{entry._entryText}");
                }
        }

    }

    class PromptGenerator
    {
        List<string> _prompts = new List<string>{
            "What the new thing that I learned today?",
            "What was the best part of my day?",
            "How did I help other person see the hand of the Lord today?",
            "What was the strongest emotion I felt today?",
            "What thing will do tomorrow to have a better day?"
        };
        public string GetRandomPrompt()
        {
            Random randomPrompt = new Random();
            int index = randomPrompt.Next(_prompts.Count);

            return _prompts[index];
        }
    }
    
    public class Entry
    {
        public string _prompt;
        public string _date;
        public string _entryText;
        PromptGenerator _promptText = new PromptGenerator();

        public string GetPrompt()
        {
            _prompt = _promptText.GetRandomPrompt();
            return _prompt;
        }
        public string DefDate()
        {      
            DateTime theCurrentTime = DateTime.Now;
            _date = theCurrentTime.ToShortDateString();
            return _date;
        }
        public string Display()
        {
            Console.WriteLine(_prompt);
            Console.Write("> ");
            _entryText = Console.ReadLine();
            return _entryText;
        }
    }
}
using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string op;
        Random rd = new Random();
        List<Scripture> scriptureList = LoadFromFile();
        int index = rd.Next(scriptureList.Count);      
        Scripture _scripture = scriptureList[index];
        Console.Clear();

        // Reference _reference = new Reference("João", 3, 16);
        // Scripture  _scripture = new Scripture(_reference, "Porque Deus amou o mundo de tal maneira, que deu o seu Filho Unigênito, para que todo aquele que nele crê não pereça, mas tenha a vida eterna.");

        Console.WriteLine(_scripture.GetDisplayText());

        Console.Write("\nPress enter to continue or 'quit' to finish\n > ");
        op = Console.ReadLine();
        
        do
        {
            Console.Clear();
            _scripture.HideRandomWords(3);
            Console.WriteLine(_scripture.GetDisplayText());

            Console.Write("\nPress enter to continue or 'quit' to finish\n > ");
            op = Console.ReadLine();

        }while(op != "quit" && _scripture.IsCompletelyHidden());

    }

    static List<Scripture> LoadFromFile() // Read text of a document
    {   
        List<Scripture> _scriptures = new List<Scripture>();
        string filename = "scriptures.txt";
        
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            if (parts.Length == 4)
            {
                string _book = parts[0].Trim();
                string _chapterS = parts[1];
                string _verseS = parts[2];
                string _scrip = parts[3];

                int _chapter = int.Parse(_chapterS);
                int _verse = int.Parse(_verseS);

                Reference _reference = new Reference(_book, _chapter, _verse);
                Scripture _scripture = new Scripture(_reference, _scrip);

                _scriptures.Add(_scripture);
            }   
            else if (parts.Length == 5)
            {
                string _book = parts[0].Trim();
                string _chapterS = parts[1];
                string _startVerseS = parts[2];
                string _endVerseS = parts[3];
                string _scrip = parts[4];

                int _chapter = int.Parse(_chapterS);
                int _startVerse = int.Parse(_startVerseS);
                int _endVerse = int.Parse(_endVerseS);

                Reference _reference = new Reference(_book, _chapter, _startVerse, _endVerse );
                Scripture _scripture = new Scripture(_reference, _scrip);

                _scriptures.Add(_scripture);
            }

        }
        return _scriptures;
    }
}
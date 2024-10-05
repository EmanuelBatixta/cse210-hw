using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string op;

        Console.Clear();
        Reference _reference = new Reference("João", 3, 16);
        Scripture  _scripture = new Scripture(_reference, "Porque Deus amou o mundo de tal maneira, que deu o seu Filho Unigênito, para que todo aquele que nele crê não pereça, mas tenha a vida eterna.");

        Console.WriteLine(_scripture.GetDisplayText());

        Console.Write("Press enter to continue or 'quit' to finish\n > ");
        op = Console.ReadLine();
        
        do
        {
            Console.Clear();
            _scripture.HideRandomWords(3);
            Console.WriteLine(_scripture.GetDisplayText());

            Console.Write("Press enter to continue or 'quit' to finish\n > ");
            op = Console.ReadLine();

        }while(op != "quit" && _scripture.IsCompletelyHidden());

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        
        DisplayWelcomeMessage();

        displayResult();

        
        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please, enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string num = Console.ReadLine();

            int iNum = int.Parse(num);
            return iNum;
        }

        static int SquareNumber(int iNum)
        {
            int square = iNum*iNum;
            return square;
        }

        static void DisplayResult()
        {
            string name = promptUserName();
            int num = promptUserNumber();
            int square = squareNumber(num);

            Console.WriteLine($"{name}, the square of your number is {square}");
        }

    }
}
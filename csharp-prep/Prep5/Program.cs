using System;

class Program
{
    static void Main(string[] args)
    {
        static string promptUserName()
        {
            Console.Write("Please, enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int promptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string num = Console.ReadLine();

            int iNum = int.Parse(num);
            return iNum;
        }

        static int squareNumber(int iNum)
        {
            int square = iNum*iNum;
            return square;
        }

        static void displayResult()
        {
            string name = promptUserName();
            int num = promptUserNumber();
            int square = squareNumber(num);

            Console.WriteLine($"{name}, the square of your number is {square}");
        }

        displayResult();
    }
}
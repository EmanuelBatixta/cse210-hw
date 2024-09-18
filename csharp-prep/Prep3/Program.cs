using System;

class Program
{
    static void Main(string[] args)
    {

        string play = "yes";
        do
        {
            int guess = 0;
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,101);
            int tryGuess = 0;

            // Console.Write("What is the magic number? ");
            // string magicNumberSting = Console.ReadLine();
            // magicNumber = int.Parse(magicNumberSting);
        
   
            do
            {
                tryGuess ++;

                Console.Write("What is your guess? ");
                string guessString = Console.ReadLine();
                guess = int.Parse(guessString);

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                
            } while (guess != magicNumber);

            Console.WriteLine($"Congratulations, you've guessed it in {tryGuess} times");

            Console.Write("Do you want play again? (yes/no) ");
            play = Console.ReadLine();

        } while (play == "yes");
    }
}
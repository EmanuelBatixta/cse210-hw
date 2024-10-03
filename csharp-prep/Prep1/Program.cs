using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? "); // this command will display in terminal the text in cases
        string Fname = Console.ReadLine(); // this command will recive a enter of user and save the data in a variable

        Console.Write("What is your last name? "); 
        string Lname = Console.ReadLine();
        
        Console.WriteLine($"Your name is {Lname}, {Fname} {Lname}"); // will display the text and the varible's content

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        string menu;
        Breathing _breathing = new Breathing("Breathing Activity","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");

        Listing _listing = new Listing("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Refletction _reflection = new Refletction("Reflection Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        
        do
        {
            Console.Clear();
            menu = MenuOptions();

            if(menu == "1")
            {
                _breathing.Run();
            }
            else if(menu == "2")
            {
                _reflection.Run();
            }

            else if(menu == "3")
            {
                _listing.Run();
            }

        }while(menu !="4");
    }

    public static string MenuOptions()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("\t1. Start Breathing Activity");
        Console.WriteLine("\t2. Start Refletcing Activity");
        Console.WriteLine("\t3. Start Listing Activity");
        Console.WriteLine("\t4. Quit");
        Console.Write("Choose one option: ");
        string choice = Console.ReadLine();
        return choice;
    }
}
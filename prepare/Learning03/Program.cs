using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction first = new Fraction();
        first.SetTop(1);
        first.SetBottom(1);
        // Console.WriteLine(first.GetTop());
        // Console.WriteLine(first.GetBottom());
        Console.WriteLine(first.GetFractionString());
        Console.WriteLine(first.GetDecimalValue());

        Fraction second = new Fraction(6);
        second.SetTop(5);
        second.SetBottom(1);
        // Console.WriteLine(second.GetTop());
        // Console.WriteLine(second.GetBottom());
        Console.WriteLine(second.GetFractionString());
        Console.WriteLine(second.GetDecimalValue());

        Fraction third = new Fraction(6, 7);
        third.SetTop(3);
        third.SetBottom(4);
        // Console.WriteLine(third.GetTop());
        // Console.WriteLine(third.GetBottom());
        Console.WriteLine(third.GetFractionString());
        Console.WriteLine(third.GetDecimalValue());

        Fraction forth = new Fraction(6, 7);
        forth.SetTop(1);
        forth.SetBottom(3);
        // Console.WriteLine(forth.GetTop());
        // Console.WriteLine(forth.GetBottom());
        Console.WriteLine(forth.GetFractionString());
        Console.WriteLine(forth.GetDecimalValue());

    }
}
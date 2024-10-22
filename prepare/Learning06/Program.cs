using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Clear();

        Circle circle = new Circle("yellow",7);
        Rectangle rectangle = new Rectangle("cyan",8,5);
        Square square = new Square("red",4);

        List<Shapes> _shapes = new List<Shapes>{
            circle,
            rectangle,
            square
        };

        foreach(Shapes s in _shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }

    }
}
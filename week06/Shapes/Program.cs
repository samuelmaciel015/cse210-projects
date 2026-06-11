using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 4);
        Circle circle = new Circle("blue", 4);
        Rectangle rectangle = new Rectangle("yellow", 5, 10);


        List<Shape> shapes = new List<Shape>()
        {
            square,
            circle,
            rectangle
        };
        
        foreach (Shape item in shapes)
        {
            Console.WriteLine(item.GetColor());
            Console.WriteLine(item.GetArea());
            Console.WriteLine();
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction number1 = new Fraction(1);
        Fraction number2 = new Fraction(5);
        Fraction number3 = new Fraction(3, 4);
        Fraction number4 = new Fraction(1, 3);

        Console.WriteLine($"{number1.GetFractionString()}\n{number1.GetDecimalValue()}");
        Console.WriteLine($"{number2.GetFractionString()}\n{number2.GetDecimalValue()}");
        Console.WriteLine($"{number3.GetFractionString()}\n{number3.GetDecimalValue()}");
        Console.WriteLine($"{number4.GetFractionString()}\n{number4.GetDecimalValue()}");

    }
}
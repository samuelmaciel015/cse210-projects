using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        MathAssignment irra = new MathAssignment("Samuel Maciel", "Eletricity", "7.3", "8-19");
        WritingAssignment urra = new WritingAssignment("Samuel Maciel", "Eletricity", "The Causes of World War II");

        Console.Write(irra.GetHomeworkList());
        Console.Write(urra.GetWritingInformation());
    }
}
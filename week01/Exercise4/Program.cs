using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number;
        List<int> numbers = new List<int>();

        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number); 
            }
        } while (number != 0);
        
        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }

        float sum = 0;
        int largest = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];

            if (largest < numbers[i])
            {
                largest = numbers[i];
            }
        }

        float average = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}
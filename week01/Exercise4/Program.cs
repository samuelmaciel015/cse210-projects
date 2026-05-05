using System;

class Program
{
    static void Main(string[] args)
    {
        int number;
        double sum = 0;
        int largest = 0;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        foreach (int i in numbers)
        {
            sum += i;

            if (i > largest)
            {
                largest = i;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum / numbers.Count()}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}
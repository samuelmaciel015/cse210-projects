using System.Collections.Generic; 

class Program
{
    static void Main(string[] args)
    {
        int number;
        float sum = 0;
        int largest = 0;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            string strNumber = Console.ReadLine();
            number = int.Parse(strNumber);

            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        foreach (int n in numbers)
        {

            sum += n;

            if (n > largest)
            {
                largest = n;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum / numbers.Count}");
        Console.WriteLine($"The largest number is: {largest}");

    }
}
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<int> numbers = new List<int>();
        int input = -1;

        do
        {
            Console.WriteLine("Enter a number (0 to stop):");

            try
            {
                input = int.Parse(Console.ReadLine());

                if (input != 0)
                    numbers.Add(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

        } while (input != 0);

        int sum = numbers.Sum();
        Console.WriteLine($"Sum of the elements: {sum}");
    }
}
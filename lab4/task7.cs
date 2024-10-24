using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 123, 456, 789, 121, 303, 444, 565, 678, 990, 12121 };

        var sortedNumbers = numbers.OrderByDescending(n => n.ToString().Last()).ToList();

        Console.WriteLine("Numbers sorted by the last digit in descending order:");
        foreach (var number in sortedNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
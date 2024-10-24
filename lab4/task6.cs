using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 123, 456, 789, 121, 303, 444, 565, 678, 990, 12121 };

        var matchingNumbers = numbers.Where(n => n.ToString().First() == n.ToString().Last()).ToList();

        Console.WriteLine("Numbers that start and end with the same digit:");
        foreach (var number in matchingNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
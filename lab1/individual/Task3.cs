using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            static void CalculateGCD(ref int a, ref int b)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
            }

            int a = 56, b = 98;
            Console.WriteLine($"Values: a = {a}, b = {b}");
            CalculateGCD(ref a, ref b);
            Console.WriteLine($"GCD: {a}");

            a = 270;
            b = 192;
            Console.WriteLine($"\nValues: a = {a}, b = {b}");
            CalculateGCD(ref a, ref b);
            Console.WriteLine($"GCD: {a}");

            a = 48;
            b = 18;
            Console.WriteLine($"\nValues: a = {a}, b = {b}");
            CalculateGCD(ref a, ref b);
            Console.WriteLine($"GCD: {a}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Program
    {
        static double? Sqrt(double x, out int errorCode)
        {
            if (x < 0)
            {
                errorCode = -1;
                return null;
            }

            errorCode = 0;
            double tolerance = 1e-10;
            double estimate = 1.0;
            double previousEstimate;

            do
            {
                previousEstimate = estimate;
                estimate = (previousEstimate + x / previousEstimate) / 2.0;
            } while (Math.Abs(estimate - previousEstimate) > tolerance);

            return estimate;
        }

        static void TestSqrt(double x)
        {
            int errorCode;
            double? result = Sqrt(x, out errorCode);

            if (errorCode == 0)
            {
                Console.WriteLine($"sqrt({x}) = {result}");
            }
            else
            {
                Console.WriteLine($"Unable to calculate the sqrt({x}): negative number.");
            }
        }

        static void Main(string[] args)
        {
            TestSqrt(25);
            TestSqrt(71.22);
            TestSqrt(-4);
            TestSqrt(0.001);
        }
    }
}
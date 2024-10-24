using System;
using System.Linq.Expressions;

class Program
{
    public delegate double FunctionDelegate(double x);

    static void Main()
    {
        FunctionDelegate function = x => 2 * x * x; // f(x) = 2x^2
        double a = 1.0;
        double b = 2.0;
        int n = 1000;

        double result = RiemannSum(function, a, b, n);

        Console.WriteLine($"The definite integral of f(x) = 2x^2 from {a} to {b} is: {result}");
    }

    static double RiemannSum(FunctionDelegate func, double a, double b, int n)
    {
        double width = (b - a) / n;
        double area = 0.0;

        for (int i = 0; i < n; i++)
        {
            double x = a + (i + 0.5) * width;
            area += func(x) * width;
        }

        return area;
    }
}
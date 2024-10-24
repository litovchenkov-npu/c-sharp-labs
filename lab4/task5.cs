using System;

class Program
{
    public delegate double FunctionDelegate(double x);

    static void Main()
    {
        FunctionDelegate function = x => 2 * x * x; // f(x) = 2x^2

        double a = 1.0;
        double b = 2.0;
        int n = 1000;

        double result = TrapezoidalRule(function, a, b, n);

        Console.WriteLine($"The definite integral of f(x) = 2x^2 from {a} to {b} is: {result}");
    }

    static double TrapezoidalRule(FunctionDelegate func, double a, double b, int n)
    {
        double h = (b - a) / n;
        double area = 0.0;

        area += 0.5 * func(a);
        area += 0.5 * func(b);

        for (int i = 1; i < n; i++)
        {
            double x = a + i * h;
            area += func(x);
        }

        area *= h;
        return area;
    }
}
using System;

namespace Task4
{
    class QuadraticEquation
    {
        private double a;
        private double b;
        private double c;

        public double? Root1 { get; private set; }
        public double? Root2 { get; private set; }

        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            Solve();
        }

        private void Solve()
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                Root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                Root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            }
            else if (discriminant == 0)
            {
                Root1 = Root2 = -b / (2 * a);
            }
            else
            {
                Root1 = Root2 = null;
            }
        }

        public double? this[int index]
        {
            get
            {
                return index switch
                {
                    0 => Root1,
                    1 => Root2,
                    _ => throw new IndexOutOfRangeException("Invalid index.")
                };
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            QuadraticEquation equation = new QuadraticEquation(1, -3, 2); // x^2 - 3x + 2 = 0
            Console.WriteLine("x^2 - 3x + 2 = 0");
            Console.WriteLine($"Root 1: {equation.Root1}");
            Console.WriteLine($"Root 2: {equation.Root2}");

            Console.WriteLine($"Root 1 using index: {equation[0]}");
            Console.WriteLine($"Root 2 using index: {equation[1]}");

            QuadraticEquation equation2 = new QuadraticEquation(1, 2, 5); // x^2 + 2x + 5 = 0
            Console.WriteLine("x^2 + 2x + 5 = 0");
            Console.WriteLine($"Root 1: {equation2.Root1?.ToString() ?? "no real root"}");
            Console.WriteLine($"Root 2: {equation2.Root2?.ToString() ?? "no real root"}");
        }
    }
}
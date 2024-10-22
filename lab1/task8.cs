using System;

public class Program
{
    static void PrintMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]:F1} ");
            }
            Console.WriteLine();
        }
    }

    public static void Main()
    {
        double[,] matrix = {
            { 1.2, -4.5, 0 },
            { 0, 3.7, -2.8 },
            { -1.0, 0, 5.3 }
        };

        Console.WriteLine("Original matrix:");
        PrintMatrix(matrix);

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                    matrix[i, j] = 1;
                else if (matrix[i, j] < 0)
                    matrix[i, j] = 0;
            }
        }

        Console.WriteLine("Modified matrix:");
        PrintMatrix(matrix);
    }
}
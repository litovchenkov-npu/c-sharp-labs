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
            { 1.2, 0, 2.4 },
            { 0, 3.7, 0 },
            { 2.1, 0, 5.3 }
        };

        Console.WriteLine("Original matrix:");
        PrintMatrix(matrix);

        double sum = 0;
        int count = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] != 0)
                {
                    sum += matrix[i, j];
                    count++;
                }
            }
        }

        double average = count > 0 ? sum / count : 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    matrix[i, j] = average;
                }
            }
        }

        Console.WriteLine("Modified matrix:");
        PrintMatrix(matrix);
    }
}
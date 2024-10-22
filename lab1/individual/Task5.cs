using System;

namespace Task5
{
    class Program
    {
        static void Main()
        {
            int[,] array = {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15 }
            };

            Console.WriteLine("2D array:");
            Print2DArray(array);

            int[][] jaggedArray = new int[array.GetLength(0)][];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int[] evenNumbers = GetEvenNumbers(array, i);
                jaggedArray[i] = evenNumbers;
            }

            Console.WriteLine("Jagged array:");
            PrintJaggedArray(jaggedArray);
        }

        static int[] GetEvenNumbers(int[,] array, int rowIndex)
        {
            int count = 0;

            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[rowIndex, j] % 2 == 0)
                    count++;
            }

            int[] evenNumbers = new int[count];
            int index = 0;

            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[rowIndex, j] % 2 == 0)
                {
                    evenNumbers[index] = array[rowIndex, j];
                    index++;
                }
            }

            return evenNumbers;
        }

        static void Print2DArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void PrintJaggedArray(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
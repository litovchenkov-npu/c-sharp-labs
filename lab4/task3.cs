using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter the folder name: ");
        string folderName = Console.ReadLine();

        DirectoryInfo directory = new DirectoryInfo(folderName);

        if (directory.Exists)
        {
            DirectoryInfo[] subdirectories = directory.GetDirectories();

            if (subdirectories.Length > 0)
            {
                Console.WriteLine("Subdirectories:");
                foreach (DirectoryInfo subdirectory in subdirectories)
                {
                    Console.WriteLine(subdirectory.Name);
                }
            }
            else
            {
                Console.WriteLine("No subdirectories found in the folder.");
            }
        }
        else
        {
            Console.WriteLine("The specified folder does not exist.");
        }
    }
}
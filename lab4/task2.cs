using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter the folder name: ");
        string folderName = Console.ReadLine();

        Console.Write("Enter the file extension (e.g., .txt): ");
        string fileExtension = Console.ReadLine();

        DirectoryInfo directory = new DirectoryInfo(folderName);

        if (directory.Exists)
        {
            FileInfo[] files = directory.GetFiles("*" + fileExtension);

            if (files.Length > 0)
            {
                Console.WriteLine($"Files with '{fileExtension}' extension:");
                foreach (FileInfo file in files)
                {
                    Console.WriteLine(file.Name);
                }
            }
            else
            {
                Console.WriteLine($"No files found with '{fileExtension}' extension.");
            }
        }
        else
        {
            Console.WriteLine("The specified folder does not exist.");
        }
    }
}
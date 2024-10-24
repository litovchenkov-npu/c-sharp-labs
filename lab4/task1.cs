using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter the folder name: ");
        string folderName = Console.ReadLine();

        Console.Write("Enter the file name: ");
        string fileName = Console.ReadLine();

        DirectoryInfo directory = new DirectoryInfo(folderName);

        if (!directory.Exists)
        {
            directory.Create();
            Console.WriteLine("Folder created.");
        }

        string filePath = Path.Combine(directory.FullName, fileName);
        using (FileStream fs = File.Create(filePath))
        {
            Console.WriteLine("File created.");
        }

        Console.WriteLine("Files in folder:");
        FileInfo[] files = directory.GetFiles();
        foreach (FileInfo file in files)
        {
            Console.WriteLine(file.Name);
        }

        File.Delete(filePath);
        Console.WriteLine("File removed.");

        directory.Delete();
        Console.WriteLine("Folder removed.");
    }
}
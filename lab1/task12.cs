public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(' ');
        string concatenated = string.Join("", words);

        Console.WriteLine(concatenated);
    }
}
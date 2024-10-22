using System;

public class Program
{
    public static void ModifyValues(ref int param1, ref int param2)
    {
        param1 += 1;
        param2 -= 2;
    }

    public static void Main()
    {
        int value1 = 10;
        int value2 = 20;

        Console.WriteLine($"Before modification: value1 = {value1}, value2 = {value2}");

        ModifyValues(ref value1, ref value2);

        Console.WriteLine($"After modification: value1 = {value1}, value2 = {value2}");
    }
}
using System;

public class Parallelepiped
{
    public double Length { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }

    public Parallelepiped(double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;
    }

    public double this[int index]
    {
        get
        {
            switch (index)
            {
                case 0: return Length;
                case 1: return Width;
                case 2: return Height;
                default: throw new IndexOutOfRangeException("Invalid index. Use 0 for Length, 1 for Width, and 2 for Height.");
            }
        }
        set
        {
            switch (index)
            {
                case 0: Length = value; break;
                case 1: Width = value; break;
                case 2: Height = value; break;
                default: throw new IndexOutOfRangeException("Invalid index. Use 0 for Length, 1 for Width, and 2 for Height.");
            }
        }
    }

    public double Volume()
    {
        return Length * Width * Height;
    }
}

public class Program
{
    public static void Main()
    {
        Parallelepiped p = new Parallelepiped(3.0, 4.0, 5.0);

        Console.WriteLine($"Length: {p[0]}");
        Console.WriteLine($"Width: {p[1]}");
        Console.WriteLine($"Height: {p[2]}");

        p[1] = 6.0;
        Console.WriteLine($"Updated Width: {p[1]}");
        p.Height = 8.0;
        Console.WriteLine($"Updated Height: {p.Height}");

        Console.WriteLine($"Volume: {p.Volume()}");
    }
}
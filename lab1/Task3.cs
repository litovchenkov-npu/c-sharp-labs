using System;

public class Point3D
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Point3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public double DistanceTo(Point3D other)
    {
        return Math.Sqrt(Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2) + Math.Pow(Z - other.Z, 2));
    }
}

public class Program
{
    public static void Main()
    {
        Point3D point1 = new Point3D(1.0, 2.0, 3.0);
        Point3D point2 = new Point3D(4.0, 6.0, 8.0);

        Console.WriteLine($"Point 1: ({point1.X}, {point1.Y}, {point1.Z})");
        Console.WriteLine($"Point 2: ({point2.X}, {point2.Y}, {point2.Z})");

        double distance = point1.DistanceTo(point2);
        Console.WriteLine($"Distance between Point 1 and Point 2: {distance:F2}");
    }
}
using System;

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }
}

public class Program
{
    public static void Main()
    {
        Product product1 = new Product("Laptop", 999.99);
        Product product2 = new Product("Smartphone", 499.99);

        Console.WriteLine($"Product 1: {product1.Name}, Price: ${product1.Price:F2}");
        Console.WriteLine($"Product 2: {product2.Name}, Price: ${product2.Price:F2}");
    }
}
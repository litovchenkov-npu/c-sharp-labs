using System;
using System.Collections.Generic;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Book(string title, string author, double price, int quantity)
    {
        Title = title;
        Author = author;
        Price = price;
        Quantity = quantity;
    }

    public void DisplayBookInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Price: {Price}, Quantity: {Quantity}");
    }
}

public class BookStore
{
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Book> Books { get; set; }

    public BookStore(string name, string address)
    {
        Name = name;
        Address = address;
        Books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void DisplayStoreInfo()
    {
        Console.WriteLine($"Store: {Name}, Address: {Address}");
        Console.WriteLine("Avaible books:");
        foreach (var book in Books)
        {
            book.DisplayBookInfo();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BookStore store = new BookStore("Book Shop", "123 Main St");

        store.AddBook(new Book("War and Peace", "Leo Tolstoy", 150.00, 10));
        store.AddBook(new Book("The Master and Margarita", "Mikhail Bulgakov", 120.00, 5));
        store.AddBook(new Book("Fahrenheit 451", "Ray Bradbury", 175.00, 3));

        store.DisplayStoreInfo();
    }
}
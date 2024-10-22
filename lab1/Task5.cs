using System;

public class User
{
    public string Username { get; set; }
    public string Password { get; set; }

    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }
}

public class Program
{
    public static void Main()
    {
        User user1 = new User("john_doe", "4%Rpk16~aL/bCWp:");
        User user2 = new User("jane_smith", "DtE-851]y0xc21Mj");

        Console.WriteLine($"User 1: Username = {user1.Username}, Password = {user1.Password}");
        Console.WriteLine($"User 2: Username = {user2.Username}, Password = {user2.Password}");
    }
}
using System;

class Program
{
    static void Main()
    {
        // strings are immutable
        string username = "admin";

        Console.WriteLine(username[0]);
        Console.WriteLine(username[username.Length - 1]);
    }
}
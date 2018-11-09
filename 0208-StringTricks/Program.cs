using System;

class Program
{
    static void Main(string[] args)
    {
        // String tricks
        string separator = new string('-', 40);

        string fruitJuice = "Strawberry Juice";

        // Check if string contains value (case-sensitive)
        Console.WriteLine( fruitJuice.Contains("f") );
        Console.WriteLine(separator);

        // returns index of first string occurrence (case-sensitive)
        Console.WriteLine(fruitJuice.IndexOf("r"));
        Console.WriteLine(separator);

        // returns index of last string occurrence (case-sensitive)
        Console.WriteLine(fruitJuice.LastIndexOf("r"));
        Console.WriteLine(separator);

        // converts entire string to lowercase
        fruitJuice = fruitJuice.ToLower();
        Console.WriteLine(fruitJuice);
        Console.WriteLine(separator);
    }
}
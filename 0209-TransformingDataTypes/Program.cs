using System;

class Program
{
    static void Main()
    {
        // Convert int to string
        int bigNumber = 3423432;

        Console.WriteLine(bigNumber.ToString().Contains("2"));

        // Combining strings
        string iLearn = "I am learning ";
        string course = "C# Mastercourse";

        string concatenated = iLearn + course;

        Console.WriteLine(concatenated);
    }
}
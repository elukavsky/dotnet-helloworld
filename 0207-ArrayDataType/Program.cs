using System;

class Program
{
    static void Main()
    {
        // Arrays
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        Console.WriteLine(numbers[3]);

        // All values in array are 0
        int[] numbers2 = new int[5];

        Console.WriteLine(numbers2[3]);

        string[] fruits = { "apple", "orange", "pear", "plum", "peach" };
        fruits[3] = "strawberry";

        Console.WriteLine(fruits[3][5]);
    }
}
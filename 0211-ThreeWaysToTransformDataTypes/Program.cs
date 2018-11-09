using System;

class Program
{
    static void Main()
    {
        int number = 5;
        string word = "five";
        char x = 'x';
        float pi = 3.14f;

        float integer = number; // You can save int as a decimal
        // int floatInt = pi;  // Can't save decimal value as int
        int floatInt = (int)pi; // Need to convert decimal to int (but decimal is rounded to a wholoe number)

        Console.WriteLine(floatInt);

        // int stringInt = word; // a string is not an int
        //int stringInt = Convert.ToInt32(word); // will not work because the string "five" is not the same as the string "5"
        word = "5"; // string has a numeric equivalent
        int stringInt = Convert.ToInt32(word);
        Console.WriteLine(stringInt); 
    }
}
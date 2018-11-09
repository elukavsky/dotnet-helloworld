using System;
using System.Text;

class Program
{
    static void Main()
    {
        // If special characters don't work
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        // Single character types (Must use single quotation marks)
        char theCharacterX = 'x';

        Console.WriteLine(theCharacterX);

        // ASCII
        char thePlusSign = '\u002B';

        Console.WriteLine(thePlusSign);

        // Unicode
        char unicodeSymbol = '\u00f6';

        Console.WriteLine(unicodeSymbol);
    }
}
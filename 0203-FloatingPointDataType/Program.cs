using System;

class Program
{
    static void Main()
    {
        // float (can hold precision to 7 decimals)
        // add an "f" to the end if error is shown (ex: 3.14f)
        float someFloatNumber = 3.143342424423432f;

        Console.WriteLine(someFloatNumber);
        Console.WriteLine(someFloatNumber.ToString("f"));

        // Area of circle
        float pi = 3.14f;
        float radius = 5f;
        float areaOfCircle = pi * radius * radius;
        Console.WriteLine("Circle Area: " + areaOfCircle );

        float floatMax = float.MaxValue;
        float floatMin = float.MinValue;

        Console.WriteLine("float: " + floatMin.ToString("f") + " - " + floatMax.ToString("f" ));

        // double
        double doubleMax = double.MaxValue;
        double doubleMin = double.MinValue;

        Console.WriteLine("double: " + doubleMin.ToString("f") + " - " + doubleMax.ToString("f"));

        // decimal
        decimal decimalMax = decimal.MaxValue;
        decimal decimalMin = decimal.MinValue;

        Console.WriteLine("decimal: " + decimalMin.ToString("f") + " - " + decimalMax.ToString("f"));
    }
}

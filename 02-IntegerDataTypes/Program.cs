using System;

class Program
{
    static void Main()
    {
        // Integer max/min = 2^32
        int someInteger = 265;
        int intMax = int.MaxValue;
        int intMin = int.MinValue;

        Console.WriteLine("int: " + intMin + " - " + intMax);

        // unsigned integer (can only ever be positive)
        uint someUInteger = 5;
        uint uIntMax = uint.MaxValue;
        uint uIntMin = uint.MinValue;

        Console.WriteLine("uint: " + uIntMin + " - " + uIntMax);

        Console.WriteLine(Math.Pow(2,32));

        // byte
        byte someByte = 255;
        byte byteMax = byte.MaxValue;
        byte byteMin = byte.MinValue;

        Console.WriteLine("byte: " + byteMin + " - " + byteMax);

        // sbyte (short byte)
        sbyte someSByte = 0;
        sbyte sByteMax = sbyte.MaxValue;
        sbyte sByteMin = sbyte.MinValue;

        Console.WriteLine("sbyte: " + sByteMin + " - " + sByteMax);

        // long
        long someLong = 255;
        long longMax = long.MaxValue;
        long longMin = long.MinValue;

        Console.WriteLine("long: " + longMin + " - " + longMax);

        // long
        ulong someULong = 255;
        ulong uLongMax = ulong.MaxValue;
        ulong uLongMin = ulong.MinValue;

        Console.WriteLine("ulong: " + uLongMin + " - " + uLongMax);
    }
}

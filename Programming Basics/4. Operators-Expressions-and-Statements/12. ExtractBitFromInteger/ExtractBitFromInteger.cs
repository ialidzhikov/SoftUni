using System;
class ExtractBitFromInteger
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());

        uint bitAtPosition = (number & (uint)(1 << position)) >> position;

        Console.WriteLine(bitAtPosition);
    }
}


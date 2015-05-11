using System;
class CheckBitAtGivenPosition
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());

        uint bitAtPosition = (number & (uint)(1 << position)) >> position;
        bool hasValueOne = bitAtPosition == 1;

        Console.WriteLine(hasValueOne ? "true" : "false");
    }
}


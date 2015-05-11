using System;
class ExtractBitThree
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());

        uint thirdBit = (number & (1 << 3)) >> 3;

        Console.WriteLine(thirdBit);
    }
}


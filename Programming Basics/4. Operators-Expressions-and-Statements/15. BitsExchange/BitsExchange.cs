using System;
class BitsExchange
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());

        int[] firstBits = new int[3];
        int[] secondBits = new int[3];

        for (int i = 0; i < 3; i++)
        {
            firstBits[i] = FindBitAtPosition(number, i + 3);
            secondBits[i] = FindBitAtPosition(number, i + 24);
        }

        for (int i = 0; i < 3; i++)
        {
            number = ExchangeBits(number, 24 + i, firstBits[i]);
            number = ExchangeBits(number, 3 + i, secondBits[i]);
        }

        Console.WriteLine(number);
    }

    private static uint ExchangeBits(uint number, int firstPos, int secondPosBit)
    {
        if (secondPosBit == 1)
        {
            uint mask = (uint)(1 << firstPos);
            number = number | mask;
        }
        else
        {
            uint mask = (uint)(~(1 << firstPos));
            number = number & mask;
        }

        return number;
    }

    private static int FindBitAtPosition(uint number, int position)
    {
        return ((int)number & (1 << position)) >> position;
    }
}


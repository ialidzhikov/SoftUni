using System;
class BitExcgangeAdvanced
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        int firstPos = int.Parse(Console.ReadLine());
        int secondPos = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());

        if (IsOverlapping(firstPos, secondPos, length))
        {
            Console.WriteLine("overlapping");
        }
        else if (firstPos < 0 || secondPos < 0)
        {
            Console.WriteLine("out of range");
        }
        else
        {
            int[] firstBits = new int[length];
            int[] secondBits = new int[length];

            for (int i = 0; i < length; i++)
            {
                firstBits[i] = (int)FindBitAtPosition(number, i + firstPos);
                secondBits[i] = (int)FindBitAtPosition(number, i + secondPos);
            }

            for (int i = 0; i < length; i++)
            {
                number = ExchangeBits(number, secondPos + i, firstBits[i]);
                number = ExchangeBits(number, firstPos + i, secondBits[i]);
            }

            Console.WriteLine(number);
        }
    }

    private static bool IsOverlapping(int firstPos, int secondPos, int length)
    {
        int smallerPos = FindSmallerPos(firstPos, secondPos);
        int biggerPos = FindBiggerPos(firstPos, secondPos);

        if (smallerPos + length >= biggerPos)
        {
            return true;    
        }

        return false;
    }

    private static int FindBiggerPos(int firstPos, int secondPos)
    {
        if (firstPos <= secondPos)
        {
            return secondPos;
        }
        else
        {
            return firstPos;
        }
    }

    private static int FindSmallerPos(int firstPos, int secondPos)
    {
        if (firstPos <= secondPos)
        {
            return firstPos;
        }
        else
        {
            return secondPos;
        }
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

    private static uint FindBitAtPosition(uint number, int position)
    {
        return (number & ((uint)1 << position)) >> position;
    }
}


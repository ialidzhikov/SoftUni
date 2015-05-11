using System;
class ModifyBitAtGivenPosition
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int value = int.Parse(Console.ReadLine());

        if (value == 1)
        {
            uint mask = (uint)(1 << position);
            number = number | mask;
        }
        else
        {
            uint mask = (uint)(~(1 << position));
            number = number & mask;
        }

        Console.WriteLine(number);
    }
}


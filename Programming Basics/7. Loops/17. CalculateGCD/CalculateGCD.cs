using System;
class CalculateGCD
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if (a < b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        int remainder = 0;
        while (b != 0)
        {
            remainder = a % b;
            a = b;
            b = remainder;
        }

        Console.WriteLine(a);
    }
}


using System;
using System.Numerics;
class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] elements = new int[n * 2];

        for (int i = 0; i < elements.Length; i++)
        {
            elements[i] = int.Parse(Console.ReadLine());
        }

        BigInteger sumEvens = 0;
        BigInteger sumOdds = 0;

        for (int i = 0; i < elements.Length; i++)
        {
            if ((i + 1) % 2 == 0)
            {
                sumEvens += elements[i];
            }
            else
            {
                sumOdds += elements[i];
            }
        }

        if (sumEvens == sumOdds)
        {
            Console.WriteLine("Yes, sum={0}", sumEvens);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs((decimal)(sumEvens - sumOdds)));
        }
    }
}


using System;

class CalculateFactorials
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int factorial = 1;
        for (int i = k + 1; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
}


using System;
class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double catalanNumber = 1;
        for (double k = 2; k <= n; k++)
        {
            catalanNumber *= (n + k) / k;           
        }
        Console.WriteLine(catalanNumber);
    }
}


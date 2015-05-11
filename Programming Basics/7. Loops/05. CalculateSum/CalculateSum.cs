using System;

class CalculateSum
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());

        double sum = 1;
        double currentFactorial = 1;
        for (int i = 1; i <= n; i++)
        {
            currentFactorial *= i;
            sum += currentFactorial / Math.Pow(x, i);
        }

        Console.WriteLine("{0:F5}", sum);
    }
}


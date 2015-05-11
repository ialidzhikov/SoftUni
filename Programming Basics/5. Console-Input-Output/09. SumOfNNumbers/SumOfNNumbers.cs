using System;
class SumOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double sum = 0;
        double[] numbers = new double[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
            sum += numbers[i];
        }

        Console.WriteLine(sum);
    }
}


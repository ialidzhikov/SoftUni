using System;
class SumOfTreeNumbers
{
    const int SIZE = 3;
    static void Main()
    {
        double[] numbers = new double[SIZE];
        double sum = 0;

        for (int i = 0; i < SIZE; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
            sum += numbers[i];
        }
        Console.WriteLine(sum);
    }
}


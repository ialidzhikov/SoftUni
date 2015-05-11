using System;
class SumOfFiveNumber
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] tokens = input.Split(' ');

        double sum = 0;
        double[] numbers = new double[tokens.Length];
        for (int i = 0; i < numbers.Length; i++)
		{
            numbers[i] = double.Parse(tokens[i]);
            sum += numbers[i];
		}

        Console.WriteLine(sum);
    }
}


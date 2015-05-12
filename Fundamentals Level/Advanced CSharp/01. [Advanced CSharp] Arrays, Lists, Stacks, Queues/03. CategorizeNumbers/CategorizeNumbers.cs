using System;
using System.Collections.Generic;
using System.Linq;

class CategorizeNumbers
{
    static void Main()
    {
        string inputLine = Console.ReadLine();

        string[] numbersAsStrings = inputLine.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        List<double> nonZeroFractionNumbers = new List<double>();
        List<double> zeroFractionNumbers = new List<double>();
        double currentNumber = 0;
        for (int i = 0; i < numbersAsStrings.Length; i++)
        {
            currentNumber = double.Parse(numbersAsStrings[i]);

            if ((currentNumber % 1) != 0)
            {
                nonZeroFractionNumbers.Add(currentNumber);
            }
            else
            {
                zeroFractionNumbers.Add(currentNumber);
            }
        }

        string nonZeroFractionElements = '[' + String.Join(", ", nonZeroFractionNumbers) + ']';
        string zeroFractionElements = '[' + String.Join(", ", zeroFractionNumbers) + ']';

        Console.WriteLine("{0} -> min: {1:F2}, max: {2:F2}, sum: {3:F2}, avg: {4:F2}",
                    nonZeroFractionElements, nonZeroFractionNumbers.Min(), 
                    nonZeroFractionNumbers.Max(), nonZeroFractionNumbers.Sum(), nonZeroFractionNumbers.Average());

        Console.WriteLine();

        Console.WriteLine("{0} -> min: {1:F2}, max: {2:F2}, sum: {3:F2}, avg: {4:F2}",
                    zeroFractionElements, zeroFractionNumbers.Min(),
                    zeroFractionNumbers.Max(), zeroFractionNumbers.Sum(), zeroFractionNumbers.Average());
    }
}


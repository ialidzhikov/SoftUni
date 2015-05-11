using System;
class OddEvenElements
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (!(String.IsNullOrEmpty(input)))
        {
            string[] tokens = input.Split(' ');

            decimal[] oddElements = new decimal[(int)(Math.Ceiling(tokens.Length / 2.0))];
            decimal[] evenElements = new decimal[tokens.Length / 2];

            int oddIndex = 0;
            int evenIndex = 0;
            for (int i = 0; i < tokens.Length; i++)
            {
                if ((i + 1) % 2 != 0)
                {
                    oddElements[oddIndex] = decimal.Parse(tokens[i]);
                    oddIndex++;
                }
                else
                {
                    evenElements[evenIndex] = decimal.Parse(tokens[i]);
                    evenIndex++;
                }
            }

            decimal oddSum = FindSum(oddElements);
            decimal evenSum = FindSum(evenElements);
            decimal oddMin = FindMin(oddElements);
            decimal evenMin = FindMin(evenElements);
            decimal oddMax = FindMax(oddElements);
            decimal evenMax = FindMax(evenElements);

            Console.WriteLine("OddSum={0}, OddMin={1:G29}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
                Decimal.MaxValue == oddSum ? "No" : oddSum.ToString("G29"), Decimal.MinValue == oddMin ? "No" : oddMin.ToString("G29"),
                Decimal.MaxValue == oddMax ? "No" : oddMax.ToString("G29"), Decimal.MaxValue == evenSum ? "No" : evenSum.ToString("G29"),
                Decimal.MinValue == evenMin ? "No" : evenMin.ToString("G29"), Decimal.MaxValue == evenMax ? "No" : evenMax.ToString("G29"));
        }
        else
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }
    }

    private static decimal FindMax(decimal[] elements)
    {
        if (elements.Length == 0)
        {
            return Decimal.MaxValue;
        }
        else
        {
            decimal max = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }
            return max;
        }
    }

    private static decimal FindMin(decimal[] elements)
    {
        if (elements.Length == 0)
        {
            return Decimal.MinValue;
        }
        else
        {
            decimal min = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] < min)
                {
                    min = elements[i];
                }
            }
            return min;
        }
    }

    private static decimal FindSum(decimal[] elements)
    {
        if (elements.Length == 0)
        {
            return Decimal.MaxValue;
        }
        else
        {
            decimal sum = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                sum += elements[i];
            }
            return sum;
        }
    }
}


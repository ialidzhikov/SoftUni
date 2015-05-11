using System;
class MagicDates
{
    static void Main()
    {
        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int magicWeight = int.Parse(Console.ReadLine());

        string format = "dd-MM-yyyy";
        DateTime startDate = new DateTime(startYear, 1, 1);
        DateTime endDate = new DateTime(endYear, 12, 31);

        int resultCount = 0;
        for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
        {
            if (CalculateWeight(i) == magicWeight)
            {
                Console.WriteLine(i.ToString(format));
                resultCount++;
            }
        }

        if (resultCount == 0)
        {
            Console.WriteLine("No");
        }
    }

    private static int CalculateWeight(DateTime date)
    {
        int weight = 0;
        string dateInString = date.ToString("ddMMyyyy");
        char[] dateInCharArray = dateInString.ToCharArray();

        int[] digits = new int[8];
        for (int i = 0; i < digits.Length; i++)
        {
            digits[i] = dateInCharArray[i] - '0';
        }

        for (int i = 0; i < digits.Length - 1; i++)
        {
            for (int j = i + 1; j < digits.Length; j++)
            {
                weight += digits[i] * digits[j];    
            }
        }

        return weight;
    }

}


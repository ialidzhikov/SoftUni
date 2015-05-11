using System;
using System.Collections.Generic;
using System.Linq;
class StudentCables
{
    const int STUDENT_CABLE_LENGTH = 504;
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<int> cablesLength = new List<int>(); 
        for (int i = 0; i < n; i++)
        {
            int value = int.Parse(Console.ReadLine());
            string metricSystem = Console.ReadLine();
            if (metricSystem == "meters")
            {
                cablesLength.Add(value * 100);
            }
            else if (value >= 20)
            {
                cablesLength.Add(value);
            }
        }

        int sum = CalculateSum(cablesLength);

        Console.WriteLine("{0}", sum / STUDENT_CABLE_LENGTH);
        Console.WriteLine("{0}", sum % STUDENT_CABLE_LENGTH);
    }

    private static int CalculateSum(List<int> cablesLength)
    {
        int sum = 0;
        foreach (var length in cablesLength)
        {
            sum += length;
        }
        return sum - ((cablesLength.Count - 1) * 3);
    }
}


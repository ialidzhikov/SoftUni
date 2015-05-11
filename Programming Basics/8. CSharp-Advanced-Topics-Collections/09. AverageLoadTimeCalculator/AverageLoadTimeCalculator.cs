using System;
using System.Collections.Generic;
using System.Globalization;
class AverageLoadTimeCalculator
{
    static void Main()
    {
        string input = System.IO.File.ReadAllText(@"C:\Users\Dell\Desktop\asd.txt");

        string[] lines = input.Split(new string[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, double> count = new Dictionary<string, double>();
        SortedDictionary<DateTime, Dictionary<string, double>> dictionary = new SortedDictionary<DateTime, Dictionary<string, double>>();
        for (int i = 0; i < lines.Length; i++)
		{
            string[] lineItems = lines[i].Split(' ');
            DateTime dateAndTime = DateTime.ParseExact(lineItems[0] + ' ' + lineItems[1], "yyyy-MMM-dd HH:mm", CultureInfo.InvariantCulture);
            double time = double.Parse(lineItems[3]);
            Dictionary<string, double> tempDictionary = new Dictionary<string,double>()
            { {lineItems[2], time} };

            if (!count.ContainsKey(lineItems[2]))
            {
                count.Add(lineItems[2], 0);
            }

            if (!dictionary.ContainsKey(dateAndTime))
            {
                dictionary.Add(dateAndTime, tempDictionary);
            }
            else
            {
                dictionary[dateAndTime][lineItems[2]] += time;
                count[lineItems[2]]++;
            }
		}

        Dictionary<string, double> sum = new Dictionary<string, double>();
        foreach (var datePair in dictionary)
        {
            foreach (var urlPair in dictionary[datePair.Key])
            {
                if (sum.ContainsKey(urlPair.Key))
                {
                    sum[urlPair.Key] += dictionary[datePair.Key][urlPair.Key];
                    count[urlPair.Key]++;
                }
                else
                {
                    sum.Add(urlPair.Key, urlPair.Value);
                    count[urlPair.Key]++;
                }
            }
        }

        foreach (var pair in sum)
        {
            Console.WriteLine("{0} -> {1}", pair.Key , pair.Value / count[pair.Key]);
        }
    }
}


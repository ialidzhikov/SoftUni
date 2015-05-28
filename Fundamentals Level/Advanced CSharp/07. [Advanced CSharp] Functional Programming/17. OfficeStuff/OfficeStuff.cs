using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class OfficeStuff
{
    private const string pattern = @"\|(?<companyName>\w+?) - (?<amount>\d+?) - (?<product>\w+?)\|";
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        Dictionary<string, Dictionary<string, int>> dataDictionary = new Dictionary<string, Dictionary<string, int>>();
        for (int i = 0; i < n; i++)
        {
            string inputLine = Console.ReadLine();

            Match match = Regex.Match(inputLine, pattern, RegexOptions.Singleline);
            string companyName = match.Groups["companyName"].Value;
            int amount = int.Parse(match.Groups["amount"].Value);
            string product = match.Groups["product"].Value;

            if (!dataDictionary.ContainsKey(companyName))
            {
                dataDictionary.Add(companyName, new Dictionary<string, int>());
            }
            if (!dataDictionary[companyName].ContainsKey(product))
            {
                dataDictionary[companyName].Add(product, amount);
            }
            else
            {
                dataDictionary[companyName][product] += amount;
            }
        }

        foreach (var pair in dataDictionary.OrderBy(pair => pair.Key))
        {
            Console.WriteLine("{0}: {1}", pair.Key, 
                String.Join(", ", dataDictionary[pair.Key].Select(keyValuePair => String.Format("{0}-{1}", keyValuePair.Key, keyValuePair.Value))));    
        }
    }
}


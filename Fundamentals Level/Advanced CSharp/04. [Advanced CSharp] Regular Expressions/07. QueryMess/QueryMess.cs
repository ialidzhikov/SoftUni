using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class QueryMess
{
    static void Main()
    {
        string inputLine = Console.ReadLine();
        
        Dictionary<string, List<string>> currentLineDictionary = new Dictionary<string, List<string>>();
        string[] pairs;
        string[] pairTokens;
        string field = String.Empty;
        string value = String.Empty;
        while (inputLine != "END")
        {
            //inputLine = Regex.Replace(inputLine, @"[\+%20]", "");
            pairs = Regex.Split(inputLine, @"&");
            foreach (string pair in pairs)
            {
                pairTokens = Regex.Split(pair, @"=");

                if (Regex.IsMatch(pairTokens[0], @"\?", RegexOptions.None))
                {
                    field = Regex.Split(pairTokens[0], @"\?", RegexOptions.None)[1];
                }
                else
                {
                    field = pairTokens[0];
                }
                field = Regex.Replace(field, @"\+|\%20", "");

                if (Regex.IsMatch(pairTokens[1], @"\+|\%20", RegexOptions.None))
                {
                    string[] valueTokens = Regex.Split(pairTokens[1], @"\+|\%20", RegexOptions.None);
                    List<string> valueList = new List<string>();
                    foreach (string valueToken in valueTokens)
                    {
                        if (valueToken != String.Empty)
                        {
                            valueList.Add(valueToken);
                        }
                    }
                    value = String.Join(", ", valueList);
                }
                else
                {
                    value = pairTokens[1];
                }
                if (!currentLineDictionary.ContainsKey(field))
                {
                    currentLineDictionary[field] = new List<string>();
                }
                currentLineDictionary[field].Add(value);
            }

            foreach (KeyValuePair<string, List<string>> keyValuePair in currentLineDictionary)
            {
                Console.Write("{0}=[{1}]", keyValuePair.Key, String.Join(", ", keyValuePair.Value));
            }
            Console.WriteLine();
            currentLineDictionary.Clear();

            inputLine = Console.ReadLine();
        }
    }
}


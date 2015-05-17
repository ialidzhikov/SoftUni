using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

class ValidUsernames
{
    static void Main()
    {
        string usernamesInputLine = Console.ReadLine();

        string patterntToSplitUsernames =
            @"
                [\s\/\\\(\)]
            ";
        string patternToValidateUsername =
            @"
                \b
                [a-zA-Z]
                \w{2,24}
                \b
            ";
        string[] allUsernames = Regex.Split(usernamesInputLine, patterntToSplitUsernames,
            RegexOptions.IgnorePatternWhitespace).Select(str => str.Trim()).ToArray();
        
        List<string> validUsernames = new List<string>(allUsernames.Length);
        foreach (string currentUsername in allUsernames)
        {
            if (Regex.IsMatch(currentUsername, patternToValidateUsername, RegexOptions.IgnorePatternWhitespace))
            {
                validUsernames.Add(currentUsername);
            }
        }

        int currentSum = 0;
        int bestSum = int.MinValue;
        int bestSumStartIndex = 0;
        for (int i = 0; i < validUsernames.Count- 1; i++)
        {
            currentSum = validUsernames[i].Length + validUsernames[i + 1].Length;
            if (currentSum > bestSum)
            {
                bestSum = currentSum;
                bestSumStartIndex = i;
            }
        }

        Console.WriteLine(validUsernames[bestSumStartIndex]);
        Console.WriteLine(validUsernames[bestSumStartIndex + 1]);
    }
}


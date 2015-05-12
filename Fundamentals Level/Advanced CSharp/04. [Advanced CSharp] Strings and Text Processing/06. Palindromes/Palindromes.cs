using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Palindromes
{
    static void Main()
    {
        string text = Console.ReadLine();

        string pattern = @"[^\W\d](\w|[-']{1,2}(?=[^\W\d]))*";
        MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnorePatternWhitespace);

        SortedSet<string> palindromesList = new SortedSet<string>();
        string currentWord = String.Empty;
        foreach (Match match in matches)
        {
            currentWord = match.Value;
            if (CheckForPalindrome(currentWord))
            {
                palindromesList.Add(currentWord);
            }
        }
        Console.WriteLine(String.Join(", ", palindromesList));
    }

    private static bool CheckForPalindrome(string stringToCheck)
    {
        for (int i = 0; i < stringToCheck.Length / 2; i++)
        {
            if (stringToCheck[i] != stringToCheck[stringToCheck.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}


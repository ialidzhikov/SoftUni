using System;
using System.Text.RegularExpressions;

class LettersChangeNumbers
{
    private const int ASCIICodeOfAUpper = 65;
    private const int ASCIICodeOfALower = 97;
    static void Main()
    {
        string inputLine = Console.ReadLine();

        string[] stringTokens = inputLine.Split(new char[] {' ', '\t', '\n', '\r', '\f'}, StringSplitOptions.RemoveEmptyEntries);
        string lettersPattern = @"[a-zA-Z]";
        string numberPattern = @"\d+";

        decimal totalSum = 0;
        foreach (string group in stringTokens)
        {
            if (group.Equals("END"))
            {
                break;
            }
            MatchCollection lettersMatchCollection = Regex.Matches(group, lettersPattern, RegexOptions.None);
            Match numberMatch = Regex.Match(group, numberPattern, RegexOptions.None);

            char firstLetter = Convert.ToChar(lettersMatchCollection[0].Value);
            char lastLetter = Convert.ToChar(lettersMatchCollection[1].Value);
            decimal number = decimal.Parse(numberMatch.Value);

            if (Char.IsUpper(firstLetter))
            {
                number /= (firstLetter - ASCIICodeOfAUpper + 1);
            }
            else
            {
                number *= (firstLetter - ASCIICodeOfALower + 1);
            }

            if (Char.IsUpper(lastLetter))
            {
                number -= lastLetter - ASCIICodeOfAUpper + 1;
            }
            else
            {
                number += lastLetter - ASCIICodeOfALower + 1;
            }

            totalSum += number;
        }
        Console.WriteLine("{0:F2}", totalSum);
    }
}


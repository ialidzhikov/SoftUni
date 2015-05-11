using System;
class LongestWordInAText
{
    static char[] seperators = { ' ', '.', ',', '\t', '\n', '\r'};
    static void Main()
    {
        string input = Console.ReadLine();

        string[] words = input.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

        string longestWord = "";
        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }            
        }

        Console.WriteLine(longestWord);
    }
}


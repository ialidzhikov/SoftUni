using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class WordCount
{
    static void Main()
    {

        SortedDictionary<string, int> wordOccurrencesSortedDictionary = new SortedDictionary<string, int>();
        StreamReader wordsReader = new StreamReader("words.txt", Encoding.GetEncoding("windows-1251"));
        using (wordsReader)
        {
            string currentWord = wordsReader.ReadLine();
            while (currentWord != null)
            {
                if (!wordOccurrencesSortedDictionary.ContainsKey(currentWord))
                {
                    wordOccurrencesSortedDictionary.Add(currentWord, 0);
                }

                currentWord = wordsReader.ReadLine();
            }    
        }

        string textContents = String.Empty;
        StreamReader textReader = new StreamReader("text.txt", Encoding.GetEncoding("windows-1251"));
        using (textReader)
        {
            textContents = textReader.ReadToEnd();
        }

        string[] words = wordOccurrencesSortedDictionary.Keys.Select(currentKey => currentKey.ToString()).ToArray();
        string pattern = String.Empty;
        foreach (var wordKey in words)
        {
            pattern = String.Format(@"\b{0}\b", wordKey);
            wordOccurrencesSortedDictionary[wordKey] = Regex.Matches(textContents, pattern,
                RegexOptions.IgnoreCase).Count;
        }

        var items = from pair in wordOccurrencesSortedDictionary
                    orderby pair.Value descending
                    select pair;
        StreamWriter writer = new StreamWriter("result.txt", false, Encoding.GetEncoding("windows-1251"));
        using (writer)
        {
            foreach (KeyValuePair<string, int> wordKeyValuePair in items)
            {
                writer.WriteLine("{0} - {1}", wordKeyValuePair.Key, wordKeyValuePair.Value);
            }
        }
    }
}


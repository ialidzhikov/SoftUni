using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _03.WordsOccurrencesInFile
{
    class WordsOccurrencesInFile
    {
        static void Main(string[] args)
        {
            //string[] words = ReadWords(@"..\..\Tests\test10.in.txt");
            string[] words = ReadWords(@"..\..\words.txt");
            
            Dictionary<string, int> wordOccerTimesCounter = OccurrencesCounter(words);

            Dictionary<string, int> sortedWords =
                wordOccerTimesCounter.OrderBy(p => p.Value).ThenBy(p => p.Key).
                ToDictionary(p => p.Key, p => p.Value);

            //Print(sortedWords, @"..\..\Tests\test10.out.txt");
            Print(sortedWords);
        }

        public static void Print(Dictionary<string, int> sortedWords)
        {
            foreach (var item in sortedWords)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }

        public static string[] ReadWords(string fileName)
        {
            List<string> allWords = new List<string>();
            StreamReader reader = new StreamReader(fileName);
            using (reader)
            {
                string lineText = reader.ReadLine();
                string[] lineWords;
                while (lineText != null)
                {
                    char[] separators = { '!', '.', '?', '"', '-', '–', ',', '(', ')', ':', ' ' };
                    lineWords = lineText.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < lineWords.Count(); i++)
                    {
                        allWords.Add(lineWords[i].ToLower());
                    }
                    lineText = reader.ReadLine();
                }
                return allWords.ToArray();
            }
        }

        public static Dictionary<T, int> OccurrencesCounter<T>(T[] sequence)
        {
            Dictionary<T, int> wordOccurTimeCounter = new Dictionary<T, int>();

            for (int i = 0; i < sequence.Length; i++)
            {
                if (wordOccurTimeCounter.ContainsKey(sequence[i]))
                {
                    wordOccurTimeCounter[sequence[i]]++;
                }
                else
                {
                    wordOccurTimeCounter.Add(sequence[i], 1);
                }
            }
            return wordOccurTimeCounter;
        }

        private static void Print(Dictionary<string, int> sortedWords, string fileName)
        {
            StreamWriter writer = new StreamWriter(fileName);

            using (writer)
            {
                foreach (var item in sortedWords)
                {
                    writer.WriteLine("{0} -> {1}", item.Key, item.Value);
                }
            }
        }
    }
}

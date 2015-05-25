using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _01.NumbersOccurrences
{
    public class NumbersOccurrences
    {
        static void Main(string[] args)
        {
            //TestGenerator.CreateTest("test11.in.txt", "test11.out.txt");return;

            //int[] array = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            int[] array = ReadConsoleInput();

            SortedDictionary<int, int> numberOccurTimesCounter = OccurrencesCounter(array);

            PrintConsole(numberOccurTimesCounter);
        }

        public static void PrintConsole(IDictionary<int, int> numberOccurTimesCounter)
        {
            StringBuilder output = new StringBuilder();
            foreach (var item in numberOccurTimesCounter)
            {
                output.AppendFormat("{0} -> {1}", item.Key, item.Value);
                output.AppendLine();
            }
            Console.Write(output);
        }

        private static int[] ReadConsoleInput()
        {
            string sequenceStr = Console.ReadLine();
            return ReadInput(sequenceStr);
        }

        public static int[] ReadInput(string sequenceStr)
        {
            string[] sequenceTokens = sequenceStr.Split(
                new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] sequence = new int[sequenceTokens.Length];
            for (int i = 0; i < sequenceTokens.Length; i++)
            {
                sequence[i] = int.Parse(sequenceTokens[i]);
            }
            return sequence;
        }

        public static SortedDictionary<T, int> OccurrencesCounter<T>(T[] sequence)
        {
            SortedDictionary<T, int> occurTimeCounter = new SortedDictionary<T, int>();

            for (int i = 0; i < sequence.Length; i++)
            {
                if (occurTimeCounter.ContainsKey(sequence[i]))
                {
                    occurTimeCounter[sequence[i]]++;
                }
                else
                {
                    occurTimeCounter.Add(sequence[i], 1);
                }
            }
            return occurTimeCounter;
        }

        private static int[] ReadFileInput(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);

            using (reader)
            {
                string sequenceStr = reader.ReadLine();
                return ReadInput(sequenceStr);
            }
        }
    }
}

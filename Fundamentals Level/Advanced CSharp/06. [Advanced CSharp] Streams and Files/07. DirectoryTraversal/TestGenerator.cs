using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _01.NumbersOccurrences
{
    public class TestGenerator
    {
        static Random random;
        const int minLength = 100000;
        const int maxLength = 110000;
        const int minMember = -1000;
        const int maxMember = 5000;

        public static void CreateTest(string inputFileName, string outputFileName)
        {
            string sequence = CreateSequence();
            int[] array = NumbersOccurrences.ReadInput(sequence);

            PrintInput(@"..\..\Tests\" + inputFileName,sequence);

            SortedDictionary<int, int> numberOccurTimesCounter = NumbersOccurrences.OccurrencesCounter(array);

            PrintOutput(@"..\..\Tests\" + outputFileName, numberOccurTimesCounter);
        }

        public static string CreateSequence()
        {
            random = new Random();
            StringBuilder sequence = new StringBuilder();
            int sequenceLength = random.Next(minLength,maxLength);

            int member = random.Next(minMember, maxMember);
            for (int i = 0; i < sequenceLength - 1; i++)
            {
                sequence.Append(member + " ");
                member = random.Next(minMember, maxMember);
            }
            sequence.Append(member);

            return sequence.ToString();
        }

        private static void PrintInput(string fileName, string sequence)
        {
            StreamWriter writer = new StreamWriter(fileName);

            using (writer)
            {
                writer.WriteLine(sequence);
            }
        }

        public static void PrintOutput(string fileName, SortedDictionary<int, int> numberOccurTimesCounter)
        {
            StreamWriter writer = new StreamWriter(fileName);

            using (writer)
            {
                foreach (var item in numberOccurTimesCounter)
                {
                    writer.WriteLine("{0} -> {1}", item.Key, item.Value);
                }
            }
        }
    }
}

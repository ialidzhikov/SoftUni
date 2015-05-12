using System;
using System.Collections.Generic;
using System.Globalization;

class SequencesOfEqualStrings
{
    static void Main()
    {
        string inputLine = Console.ReadLine();

        string[] tokens = inputLine.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < tokens.Length - 1; i++)
        {
            if (String.Compare(tokens[i], tokens[i + 1], StringComparison.InvariantCulture) != 0)
            {
                Console.WriteLine(tokens[i]);
            }
            else
            {
                Console.Write("{0} ", tokens[i]);
            }
        }
        Console.WriteLine(tokens[tokens.Length - 1]);
    }
}


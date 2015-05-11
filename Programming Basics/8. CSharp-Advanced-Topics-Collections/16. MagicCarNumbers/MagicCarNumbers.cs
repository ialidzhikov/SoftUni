using System;
using System.Collections.Generic;
class MagicCarNumbers
{
    static Dictionary<char, int> dictionary = new Dictionary<char, int>()
    {
        {'A', 10},
        {'B', 20},
        {'C', 30},
        {'E', 50},
        {'H', 80},
        {'K', 110},
        {'M', 130},
        {'P', 160},
        {'T', 200},
        {'X', 240},
    };
    static void Main()
    {
        int magicWeight = int.Parse(Console.ReadLine());

        int weight = 40;
        int resultCount = 0;
        for (int digits = 0; digits <= 9999; digits++)
        {
            
            foreach (var firstPair in dictionary)
            {
                foreach (var secondPair in dictionary)
                {
                    weight = 40;
                    weight += dictionary[firstPair.Key] + dictionary[secondPair.Key];
                    weight += CalculateSumOfDigits(digits);

                    if (weight == magicWeight && CheckFormat(digits))
                    {
                        resultCount++;
                    }
                }
            }
        }

        Console.WriteLine(resultCount);
    }

    private static bool CheckFormat(int number)
    {
        char[] numberCharArray = {'0', '0', '0', '0'};
        if (number < 10)
        {
            return true;
        }
        else if (number < 100)
        {
            if (number % 10 == (number / 10) % 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (number < 1000)
        {
            numberCharArray[1] = (char)((number / 100) + '0');
            numberCharArray[2] = (char)(((number / 10) % 10) + '0');
            numberCharArray[3] = (char)((number % 10) + '0');
        }
        else if (number < 10000)
        {
            numberCharArray[0] = (char)((number / 1000) + '0');
            numberCharArray[1] = (char)(((number / 100) % 10) + '0');
            numberCharArray[2] = (char)(((number / 10) % 10) + '0');
            numberCharArray[3] = (char)((number % 10) + '0');
        }

        if (numberCharArray[0] == numberCharArray[1] && numberCharArray[1] == numberCharArray[2]
            && numberCharArray[2] == numberCharArray[3])
        {
            return true;
        }
        else if (numberCharArray[1] == numberCharArray[2] && numberCharArray[2] == numberCharArray[3])
        {
            return true;
        }
        else if (numberCharArray[0] == numberCharArray[1] && numberCharArray[1] == numberCharArray[2])
        {
            return true;
        }
        else if (numberCharArray[0] == numberCharArray[1] && numberCharArray[2] == numberCharArray[3])
        {
            return true;
        }
        else if (numberCharArray[0] == numberCharArray[2] && numberCharArray[1] == numberCharArray[3])
        {
            return true;
        }
        else if (numberCharArray[0] == numberCharArray[3] && numberCharArray[1] == numberCharArray[2])
        {
            return true;
        }

        return false;
    }
    private static int CalculateSumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}


using System;
class LongestAreaInArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] elements = new string[n];
        for (int i = 0; i < n; i++)
        {
            elements[i] = Console.ReadLine();
        }

        int currentLength = 1;
        int maxLength = 0;
        string element = elements[0];
        for (int i = 1; i < n ; i++)
        {
            if (elements[i - 1] == elements[i])
            {
                currentLength++;
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    element = elements[i];
                }
            }
            else
            {
                currentLength = 1;
            }
        }

        Console.WriteLine();
        if (maxLength != 0)
        {
            for (int i = 0; i < maxLength; i++)
            {
                Console.WriteLine(element);
            }
        }
        else
        {
            Console.WriteLine(element);
        }
    }
}


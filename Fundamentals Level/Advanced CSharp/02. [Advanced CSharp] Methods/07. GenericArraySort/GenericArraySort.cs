//using System;
//using System.Data;

//class GenericArraySort
//{
//    static void Main()
//    {
//        int[] numbers = {1, 3, 4, 5, 1, 0, 5};
//        string[] strings = { "zaz", "cba", "baa", "azis" };
//        DateTime[] dates =
//        {
//            new DateTime(2002, 3, 1), new DateTime(2015, 5, 6), new DateTime(2014, 1, 1), 
//        };

//        SortArray(numbers);
//        SortArray(strings);
//        SortArray(dates);

//        Console.WriteLine(String.Join(", ", numbers));
//        Console.WriteLine(String.Join(", ", strings));
//        Console.WriteLine(String.Join(", ", dates));
//    }

//    private static void SortArray<T>(T[] arrayToSort) where T : IComparable
//    {
//        bool swapped = false;
//        T temp = default(T);
//        do
//        {
//            swapped = false;
//            for (int i = 0; i < arrayToSort.Length - 1; i++)
//            {
//                if (arrayToSort[i].CompareTo(arrayToSort[i + 1]) > 0)
//                {
//                    temp = arrayToSort[i];
//                    arrayToSort[i] = arrayToSort[i + 1];
//                    arrayToSort[i + 1] = temp;

//                    swapped = true;
//                }
//            }
//        } while (swapped);
//    }
//}

using System;
using System.Globalization;

public class SequenceInMatrix
{
    public static void Main()
    {
        Console.Write("Enter the number of the rows in your matrix: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of the coloms in your matrix: ");
        int m = int.Parse(Console.ReadLine());

        string[,] matrix = new string[n, m];

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.WriteLine("Enter the string on position row[{0}], col[{1}]: ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }

        int lenght = 1;
        int bestLength = 1;
        string equalString = String.Empty;
        string bestEqualString = String.Empty;

        for (int row = 0; row < n - 1; row++)
        {
            for (int col = 0; col < m - 1; col++)
            {
                if ((matrix[row, col].Equals(matrix[row, col + 1])) || (matrix[row, col].Equals(matrix[row + 1, col]))
                    || matrix[row, col].Equals(matrix[row + 1, col + 1]))
                {
                    equalString = matrix[row, col];
                    lenght++;

                    if (lenght > bestLength)
                    {
                        bestLength = lenght;
                        bestEqualString = equalString;
                    }
                }
            }
        }

        lenght = 1;
        equalString = String.Empty;

        for (int row = 0; row < n - 1; row++)
        {
            if (matrix[row, m - 1].Equals(matrix[row + 1, m - 1]))
            {
                equalString = matrix[row, m - 1];
                lenght++;

                if (lenght > bestLength)
                {
                    bestLength = lenght;
                    bestEqualString = equalString;
                }
            }
        }


        Console.WriteLine();
        Console.WriteLine("The best equal string in your matrix looks like that: ");
        Console.WriteLine();

        for (int i = 0; i < bestLength - 1; i++)
        {
            Console.Write("{0}, ", bestEqualString);
        }

        Console.WriteLine(bestEqualString);
    }
}


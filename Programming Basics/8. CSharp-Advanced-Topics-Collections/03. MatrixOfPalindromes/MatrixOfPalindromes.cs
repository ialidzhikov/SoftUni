using System;
class MatrixOfPalindromes
{
    const int ASCII_CODE = 97;
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("{0}{1}{0} ", (char)(ASCII_CODE + i), (char)(ASCII_CODE + i + j));
            }
            Console.WriteLine();
        }
    }
}


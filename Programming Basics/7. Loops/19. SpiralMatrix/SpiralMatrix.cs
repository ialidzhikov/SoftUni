using System;
class SpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        int hor = 0;
        int vert = 0;
        int currentNumber = 1;

        while (currentNumber <= n * n)
        {
            for (int col = hor; col < n - hor; col++)
            {
                matrix[hor, col] = currentNumber;
                currentNumber++;
            }
            vert++;
            for (int row = vert; row < n - hor; row++)
            {
                matrix[row, n - vert] = currentNumber;
                currentNumber++;
            }
            //hor++;
            for (int col = n - vert - 1; col >= hor; col--)
            {
                matrix[n - vert, col] = currentNumber;
                currentNumber++;
            }
            //vert++;
            for (int row = n - vert - 1; row > hor ; row--)
            {
                matrix[row, hor] = currentNumber;
                currentNumber++;
            }
            hor++;
        }

        //Print Spiral Matrix
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,2} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}


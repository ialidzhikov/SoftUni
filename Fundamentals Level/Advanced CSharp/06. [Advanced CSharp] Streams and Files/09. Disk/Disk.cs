using System;
class Disk
{
    static void Main()
    {
        int fieldSize = int.Parse(Console.ReadLine());
        int radius = int.Parse(Console.ReadLine());

        int diskCenterRow = fieldSize / 2;
        int diskCenterCol = fieldSize / 2;

        int deltaX = 0;
        int deltaY = 0;
        double distanceToCenter = 0;
        char[,] disk = new char[fieldSize ,fieldSize];
        for (int row = 0; row < fieldSize; row++)
        {
            deltaX = row - diskCenterCol;
            for (int col = 0; col < fieldSize; col++)
            {
                deltaY = col - diskCenterCol;
                distanceToCenter = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

                if (distanceToCenter <= radius)
                {
                    disk[row, col] = '*';
                }
                else
                {
                    disk[row, col] = '.';
                }
            }
        }

        for (int row = 0; row < fieldSize; row++)
        {
            for (int col = 0; col < fieldSize; col++)
            {
                Console.Write(disk[row, col]);
            }
            Console.WriteLine();
        }
    }
}


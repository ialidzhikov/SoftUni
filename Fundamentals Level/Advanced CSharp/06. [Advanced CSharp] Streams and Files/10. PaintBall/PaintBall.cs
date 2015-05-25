using System;
using System.Text;

class PaintBall
{
    private const int CanvasSize = 10;
    static void Main()
    {
        int[,] canvas = new int[CanvasSize, CanvasSize];
        for (int row = 0; row < CanvasSize; row++)
        {
            for (int col = 0; col < CanvasSize; col++)
            {
                canvas[row, col] = 1;
            }
        }

        int shotRow = 0;
        int shotCol = 0;
        int shotRadius = 0;
        bool isBlackPaint = true;
        int shotColor = 0;
        string command = Console.ReadLine();
        string[] commandTokens;
        while (command != "End")
        {
            commandTokens = command.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            shotRow = int.Parse(commandTokens[0]);
            shotCol = CanvasSize - 1 - int.Parse(commandTokens[1]);
            shotRadius = int.Parse(commandTokens[2]);

            if (isBlackPaint == true)
            {
                shotColor = 0;
            }
            else
            {
                shotColor = 1;
            }

            for (int row = shotRow - shotRadius; row <= shotRow + shotRadius; row++)
            {
                for (int col = shotCol - shotRadius; col <= shotCol + shotRadius; col++)
                {
                    if ((row >= 0 && row < CanvasSize) && (col >= 0 && col < CanvasSize))
                    {
                        canvas[row, col] = shotColor;
                    }
                }
            }

            command = Console.ReadLine();
            isBlackPaint = !isBlackPaint;
        }

        StringBuilder currentRowBinary = new StringBuilder(CanvasSize);
        int totalSum = 0;
        for (int row = 0; row < CanvasSize; row++)
        {
            for (int col = 0; col < CanvasSize; col++)
            {
                currentRowBinary.Append(canvas[row, col]);
            }
            totalSum += Convert.ToInt32(currentRowBinary.ToString(), 2);
            currentRowBinary.Clear();
        }
        Console.WriteLine(totalSum);
    }
}


using System;
class InsideTheBuilding
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());

        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        int x3 = int.Parse(Console.ReadLine());
        int y3 = int.Parse(Console.ReadLine());
        int x4 = int.Parse(Console.ReadLine());
        int y4 = int.Parse(Console.ReadLine());
        int x5 = int.Parse(Console.ReadLine());
        int y5 = int.Parse(Console.ReadLine());

        CheckPoint(x1, y1, h);
        CheckPoint(x2, y2, h);
        CheckPoint(x3, y3, h);
        CheckPoint(x4, y4, h);
        CheckPoint(x5, y5, h);
    }

    private static void CheckPoint(int x, int y, int h)
    {
        bool inBase = (x >= 0 && x <= (h * 3)) && (y >= 0 && y <= h);
        bool inToward = (x >= h && x <= h * 2) && (y >= h && y <= h * 4);

        if (inBase || inToward)
        {
            Console.WriteLine("inside");
        }
        else
        {
            Console.WriteLine("outside");
        }
    }
}


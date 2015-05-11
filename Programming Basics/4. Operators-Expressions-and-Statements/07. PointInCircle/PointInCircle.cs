using System;
class PointInCircle
{
    const int radius = 2;
    const int xCenter = 0;
    const int yCenter = 0;
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        bool isInside = Math.Pow((x - xCenter), 2) + Math.Pow((y - yCenter), 2) <= Math.Pow(radius, 2);

        Console.WriteLine(isInside ? "true" : "false");
    }
}


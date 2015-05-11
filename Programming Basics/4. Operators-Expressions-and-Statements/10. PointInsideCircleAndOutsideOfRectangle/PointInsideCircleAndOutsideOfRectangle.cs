using System;
class PointInsideCircleAndOutsideOfRectangle
{
    const double radius = 1.5;
    const double xCenter = 1;
    const double yCenter = 1;

    const double rectTop = 1;
    const double rectLeft = -1;
    const double rectWidth = 6;
    const double rectHeight = 2;
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        bool insideCircle = Math.Pow((x - xCenter), 2) + Math.Pow((y - yCenter), 2) <= Math.Pow(radius, 2);
        bool outsideRect = y > rectTop || y < (rectTop - rectHeight);
        bool insideCircleOutsideRect = insideCircle && outsideRect;

        Console.WriteLine(insideCircleOutsideRect ? "yes" : "no");
    }
}


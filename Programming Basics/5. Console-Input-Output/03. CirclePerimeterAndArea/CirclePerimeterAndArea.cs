using System;
class CirclePerimeterAndArea
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());

        double perimeter = radius * Math.PI * 2;
        double area = radius * radius * Math.PI;

        Console.WriteLine("{0:F2}\n{1:F2}", perimeter, area);
    }
}


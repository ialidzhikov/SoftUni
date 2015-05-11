using System;
class Trapezoids
{
    static void Main()
    {
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double area = ((sideA + sideB) / 2.0) * height;

        Console.WriteLine(area);
    }
}


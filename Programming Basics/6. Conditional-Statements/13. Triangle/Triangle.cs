using System;
class Triangle
{
    static void Main()
    {
        double aX = double.Parse(Console.ReadLine());
        double aY = double.Parse(Console.ReadLine());
        double bX = double.Parse(Console.ReadLine());
        double bY = double.Parse(Console.ReadLine());
        double cX = double.Parse(Console.ReadLine());
        double cY = double.Parse(Console.ReadLine());

        double sideA = Math.Sqrt(Math.Pow(bX - aX, 2) + Math.Pow(bY - aY, 2));
        double sideB = Math.Sqrt(Math.Pow(cX - bX, 2) + Math.Pow(cY - bY, 2));
        double sideC = Math.Sqrt(Math.Pow(aX - cX, 2) + Math.Pow(aY - cY, 2));

        if (sideA + sideB > sideC && sideB + sideC > sideA && sideA + sideC > sideB)
        {
            double halfPerimeter = (sideA + sideB + sideC) / 2.0;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
            Console.WriteLine("Yes");
            Console.WriteLine("{0:F2}", area);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:F2}", sideA);
        }
    }
}


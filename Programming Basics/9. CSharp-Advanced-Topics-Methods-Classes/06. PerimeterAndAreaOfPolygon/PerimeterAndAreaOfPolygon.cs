using System;
class PerimeterAndAreaOfPolygon
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double pointX = 0;
        double pointY = 0;
        string input;
        Polygon polygon = new Polygon();
        for (int i = 0; i < n; i++)
        {
            input = Console.ReadLine();
            string[] tokens = input.Split(' ');
            pointX = int.Parse(tokens[0]);
            pointY = int.Parse(tokens[1]);

            polygon.Points.Add(new Point(pointX, pointY));
            
        }

        double perimeter = polygon.GetPerimeter();
        double area = polygon.GetArea();
        Console.WriteLine(perimeter);
        Console.WriteLine(area);
    }
}


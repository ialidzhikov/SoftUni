using System;
using System.Collections.Generic;
class Polygon
{
    public List<Point> Points
    {
        get;
        set;
    }

    public Polygon()
    {
        this.Points = new List<Point>();
    }

    public double GetPerimeter()
    {
        double perimeter = 0;
        for (int i = 1; i < this.Points.Count; i++)
        {
            perimeter += this.Points[i - 1].FindDistance(this.Points[i]);
        }
        perimeter += this.Points[this.Points.Count - 1].FindDistance(this.Points[0]);
        return Math.Round(perimeter, 2);
    }
    public double GetArea()
    {
        double doubledArea = 0;
        for (int i = 1; i < this.Points.Count; i++)
        {
            doubledArea += (this.Points[i - 1].X * this.Points[i].Y) - (this.Points[i - 1].Y * this.Points[i].X);
        }
        doubledArea += (this.Points[this.Points.Count - 1].X * this.Points[0].Y) -
                        (this.Points[this.Points.Count - 1].Y * this.Points[0].X);
        double area = doubledArea / 2;
        return Math.Abs(Math.Round(area, 2));
    }

}


using System;
class Point
{
    private double pointX;
    private double pointY;

    public double X
    {
        get { return this.pointX; }
        set { this.pointX = value; }
    }
    public double Y
    {
        get { return this.pointY; }
        set { this.pointY = value; }
    }

    public Point(double pointX, double pointY)
    {
        this.pointX = pointX;
        this.pointY = pointY;
    }

    public double FindDistance(Point somePoint)
    {
        double distance = Math.Sqrt(Math.Pow(this.pointX - somePoint.X, 2) + Math.Pow(this.pointY - somePoint.Y, 2));
        return distance;
    }
}


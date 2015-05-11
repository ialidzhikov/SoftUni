using System;
class PointClass
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

    public PointClass() : this(0, 0)
    {

    }
    public PointClass(double pointX, double pointY)
    {
        this.pointX = pointX;
        this.pointY = pointY;
    }
    static void Main()
    {
        PointClass firstPoint = new PointClass(10, -10);
        PointClass secondPoint = new PointClass(1, 0);

        Console.WriteLine("First point coordinates ({0}, {1})", firstPoint.X, firstPoint.Y);
        Console.WriteLine("Second point coordinates ({0}, {1})", secondPoint.X, secondPoint.Y);
    }
}


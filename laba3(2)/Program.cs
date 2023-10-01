using System;

class Point
{
    public double X { get; }
    public double Y { get; }
    public string Name { get; }

    public Point(double x, double y, string name)
    {
        X = x;
        Y = y;
        Name = name;
    }
}

class Figure
{
    private Point[] points;

    public Figure(Point a, Point b, Point c)
    {
        points = new Point[] { a, b, c };
    }

    public Figure(Point a, Point b, Point c, Point d)
    {
        points = new Point[] { a, b, c, d };
    }

    public Figure(Point a, Point b, Point c, Point d, Point e)
    {
        points = new Point[] { a, b, c, d, e };
    }

    public double GetSideLength(Point A, Point B)
    {
        double sideLength = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        return sideLength;
    }

    public void CalculatePerimeter()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length; i++)
        {
            int nextIndex = (i + 1) % points.Length;
            perimeter += GetSideLength(points[i], points[nextIndex]);
        }
        Console.WriteLine($"Периметр багатокутника: {perimeter}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point pointA = new Point(0, 0, "A");
        Point pointB = new Point(3, 0, "B");
        Point pointC = new Point(3, 4, "C");

        Figure triangle = new Figure(pointA, pointB, pointC);

        triangle.CalculatePerimeter();
    }
}
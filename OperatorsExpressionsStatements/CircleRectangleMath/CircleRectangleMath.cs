using System;

class CircleRectangleMath
{
    public static double _coordinateTop = 1;
    public static double _coordinateLeft = -1;

    public static double _width = 6;
    public static double _height = 2;


    static void Main(string[] args)
    {
        double y = Convert.ToDouble(Console.ReadLine());
        double x = Convert.ToDouble(Console.ReadLine());

        PointInCircle circle = new PointInCircle(1, 1, 1.5);

        Boolean inCircle = circle.isInCircle(x, y);
        Boolean inRectangle = isPointInRectangle(x, y);
        Boolean conditionSatisfied = false;
        if (inCircle)
        {
            if (!inRectangle)
            {
                conditionSatisfied = true;
            }
        }
        Console.WriteLine("In circle " + inCircle + " in Rec " + inRectangle);
        Console.WriteLine("Overall: " + conditionSatisfied);
    }

    private static double GetCoordinateBottom()
    {
        return _coordinateTop - _height;
    }

    private static double GetCoordinateRight()
    {
        return _coordinateLeft + _width;
    }

    private static Boolean isPointInRectangle(double x, double y)
    {
        Boolean inX = false;
        Boolean inY = false;
        if (x <= _coordinateTop && x >= GetCoordinateBottom())
        {
            inX = true;
        }
        if (y >= _coordinateLeft && y <= GetCoordinateRight())
        {
            inY = true;
        }
        return inX && inY;
    }
}


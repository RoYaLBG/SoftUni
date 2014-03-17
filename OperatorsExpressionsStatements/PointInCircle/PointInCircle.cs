using System;

public class PointInCircle
{
    private double _centerX = 0;
    private double _centerY = 0;
    private double _radius = 2;

    public PointInCircle(double centerX, double centerY, double radius)
    {
        this._centerX = centerX;
        this._centerY = centerY;
        this._radius = radius;
    }

    public static void Main(string[] args)
    {
        PointInCircle self = new PointInCircle(0, 0, 2);
        self.check();
    }

    private void check()
    {
        Console.WriteLine("Write x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Write y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Are points inside? " + this.isInCircle(x, y));
    }

    public Boolean isInCircle(double x, double y)
    {
        return (Math.Pow((x - this._centerX), 2) + Math.Pow((y - this._centerY), 2)) <= Math.Pow(this._radius, 2);
    }
}

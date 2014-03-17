using System;

class RectangleMath
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter rectangle's width: ");
        double width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter rectangle's height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("The perimeter of the rectangle is: " + CalculatePerimeter(width, height));
        Console.WriteLine("The area of the rectangle is: " + CalculateArea(width, height));
    }

    private static double CalculatePerimeter(double width, double height)
    {
        return (width * 2) + (height * 2);
    }

    private static double CalculateArea(double width, double height)
    {
        return width * height;
    }
}


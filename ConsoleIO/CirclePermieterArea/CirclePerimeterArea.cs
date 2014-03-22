using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CirclePerimeterArea
{


    static void Main(string[] args)
    {
        Console.WriteLine("Enter circle's radius: ");
        double r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("The area of circle is: " + CalculateArea(r) + " and the perimeter is: " + CalculatePerimeter(r));
    }

    private static double CalculateArea(double r)
    {
        return Math.Round(Math.PI * Math.Pow(r, 2), 2);
    }

    private static double CalculatePerimeter(double r)
    {
        return Math.Round(2 * Math.PI * r, 2);
    }
}

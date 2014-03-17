using System;

class TrapezoidArea
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter side A: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter side B: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter side H: ");
        double h = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("The area is: " + CalculateArea(a, b, h));
    }

    private static double CalculateArea(double a, double b, double h)
    {
        return (0.5 * (a + b)) * h;
    }
}


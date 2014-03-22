using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class QuadraticEquation
{
    private static double _a, _b, _c;

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a: ");
        _a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter b: ");
        _b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter c: ");
        _c = Convert.ToDouble(Console.ReadLine());
        try
        {
            Console.WriteLine("Result: " + Calculate());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }
        
    }

    private static double GetDiscriminant()
    {
        return Math.Pow(_b, 2) - 4 * _a * _c;
    }

    private static bool HasRealRoots()
    {
        return GetDiscriminant() >= 0;
    }

    private static bool HasOneRoot()
    {
        return GetDiscriminant() == 0;
    }

    private static string CalculateAllRoots()
    {
        double x1 = ((_b * -1) - Math.Sqrt(GetDiscriminant()))/(2*_a);
        double x2 = ((_b * -1) + Math.Sqrt(GetDiscriminant()))/(2*_a);
        return "x1 = " + x1 + "; x2 = " + x2; 
    }

    private static string CalculateRoot()
    {
        double x1 = ((_b * -1) + Math.Sqrt(GetDiscriminant())) / (2 * _a);
        return "x1 = x2 = " + x1;
    }

    private static string Calculate()
    {
        if (HasOneRoot())
        {
            return CalculateRoot();
        }
        if (HasRealRoots())
        {
            return CalculateAllRoots();
        }
        throw new Exception("The equation has no real roots");
    }
}

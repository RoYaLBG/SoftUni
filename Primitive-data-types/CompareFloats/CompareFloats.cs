using System;

class CompareFloats
{
    static void Main(string[] args)
    {
        Console.WriteLine("Number A:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Number B:");
        double b = Convert.ToDouble(Console.ReadLine());
        double eps = 0.000001;
        Console.WriteLine((b - a) <= eps);
    }
}


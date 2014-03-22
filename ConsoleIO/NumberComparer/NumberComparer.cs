using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class NumberComparer
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Write b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("The greater number is: " + Math.Max(a, b));
    }
}


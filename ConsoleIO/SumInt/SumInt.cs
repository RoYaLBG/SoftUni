using System;

class SumInt
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write a:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Write b:");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Write c:");
        double c = Convert.ToDouble(Console.ReadLine());

        double sum = a + b + c;

        Console.WriteLine("The sum of a, b and c is: " + sum);
    }
}


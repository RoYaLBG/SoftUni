using System;

class WeightOnMoon
{
    static void Main(string[] args)
    {
        double moonGravityDelta = 0.17;

        Console.WriteLine("Enter your weight:");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Your weight on moon will be: " + weight * moonGravityDelta);
    }
}

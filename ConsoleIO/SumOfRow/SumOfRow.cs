using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SumOfRow
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter row of 5 numbers separated by space");
        string input = Console.ReadLine();
        string[] arrToSum = input.Split();
        if (arrToSum.Length != 5)
        {
            Console.WriteLine("The numbers have to be 5");
            return;
        }
        double sum = 0;
        foreach (var value in arrToSum)
        {
            sum += Convert.ToDouble(value);
        }
        Console.WriteLine(sum);
    }
}

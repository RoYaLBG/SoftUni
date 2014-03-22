using System;
using System.Linq;

class FibonacciNumbers
{
    static void Main(string[] args)
    {
        int input = Convert.ToInt32(Console.ReadLine());
        int[] j = new int[input];
        for (int i = 0; i < input; i++)
        {
            j[i] = (i > 1) ? (j[i-2] + j[i-1]) : i;
        }
        string[] fibonacciNumbersArray = j.Select(t => t.ToString()).ToArray();
        string fibonacciNumbersRow = String.Join(" ", fibonacciNumbersArray);
        Console.WriteLine(fibonacciNumbersRow);
    }
}


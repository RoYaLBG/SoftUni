using System;

class NumbersToN
{
    static void Main(string[] args)
    {
        int input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        for (int i = 1; i <= input; i++)
        {
            Console.WriteLine(i);
        }
    }
}


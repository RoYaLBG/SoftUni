using System;

class OddEven
{
    static void Main(string[] args)
    {
        int inputNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(inputNum % 2 == 0 && inputNum != 0);
    }
}


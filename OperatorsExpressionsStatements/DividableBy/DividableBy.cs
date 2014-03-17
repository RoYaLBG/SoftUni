using System;

class DividableBy
{
    static void Main(string[] args)
    {
        const int FIRST_DIVIDER = 5;
        const int SECOND_DIVIDER = 7;
        Console.WriteLine("Enter num to check if it's dividable by: " + FIRST_DIVIDER + " and " + SECOND_DIVIDER);
        int inputNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(inputNum % FIRST_DIVIDER == 0 && inputNum % SECOND_DIVIDER == 0 && inputNum != 0);
    }
}

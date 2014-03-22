using System;

class SumNumberToN
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter how many numbers do you want to sum");
        int input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Now enter " + input + " numbers, each on separated row, in order to sum them");
        double[] toSum = new double[input];
        double sum = 0;
        for (int i = 0; i < toSum.Length; i++)
        {
            toSum[i] = Convert.ToDouble(Console.ReadLine());
            sum += toSum[i];
        }
        Console.WriteLine("The sum is: " + sum);
    }
}


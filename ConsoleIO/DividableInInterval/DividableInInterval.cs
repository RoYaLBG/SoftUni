using System;
using System.Collections;
using System.Collections.Generic;


class DividableInInterval
{
    static void Main(string[] args)
    {
        int division = 5;

        Console.WriteLine("Enter start: ");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter end: ");
        int end = Convert.ToInt32(Console.ReadLine());
        List<string> counter = new List<string>();
        for (int i = start; i <= end; i++)
        {
            if (i % division == 0)
            {
                counter.Add(i.ToString());
            }
        }

        string numbers = counter.Count > 0 ? String.Join(" ", counter) : " - ";
        Console.WriteLine("p: " + counter.Count + " numbers: " + numbers);
    }
}

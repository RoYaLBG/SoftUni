using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());
        int i;
        Console.WriteLine(String.Format("|{0,-10}|{1,1}|{2,10}|{3,-10}|",
            a.ToString("X"),
            Convert.ToString(a, 2).PadLeft(10, '0'),
            b == (int)b ? b.ToString() : String.Format("{0:0.00}", b),
            c == (int)c ? c.ToString() : String.Format("{0:0.000}", c)
        ));
    }
}

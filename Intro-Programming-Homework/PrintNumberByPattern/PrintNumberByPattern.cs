using System;

class PrintNumbers
{
    private const int START_NUM = 1;
    private const int END_NUM = 1;

    private int MiddleIncrementor = 0;
    private int PrintingTimes = 3;

    private static PrintNumbers self = new PrintNumbers();

    static void Main(string[] args)
    {
        //simplified(); /* simplified version of the program */
        self.PrintByPattern();
    }

    private String PrintMiddleIncrementor(int incrementor)
    {
        String[] joined = new String[PrintingTimes];
        for (int i = 1; i <= incrementor; i++)
        {
            joined[i] = MiddleIncrementor.ToString();
        }
        return String.Join("", joined);
    }


    private void PrintByPattern()
    {
        Console.WriteLine(START_NUM);
        for (int i = 1; i < PrintingTimes; i++)
        {
            Console.WriteLine(START_NUM.ToString() + PrintMiddleIncrementor(i) + END_NUM);
        }
    }


    private static void simplified()
    {
        Console.WriteLine(1);
        Console.WriteLine(101);
        Console.WriteLine(1001);
    }
}


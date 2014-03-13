using System;

public class PrintNumberSequence
{
    private const int INC_START = 1;
    private const int START = 2;
    public static int _memberCount = 10;
    private const int SEQUENCE = 2;

    static void Main(string[] args)
    {
        PrintRow();
    }

    public static void PrintRow()
    {
        int delta = START - INC_START;
        String[] row = new String[_memberCount];
        for (int i = INC_START; i <= _memberCount; i++)
        {
            //int numToPrint = (i % SEQUENCE != 0) ? i + delta : (i + delta) * -1; /* Shortened but much more unreadable */
            int numToPrint = i + delta;
            if (i % SEQUENCE == 0)
            {
                numToPrint *= -1;
            }

            row[i - delta] = numToPrint.ToString();
        }
        Console.WriteLine(String.Join(", ", row));
    }
}
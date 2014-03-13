using System;

class PrintLongSequence
{
    private static int _memberCount = 1000;
    static void Main(string[] args)
    {
        PrintNumberSequence._memberCount = _memberCount;
        PrintNumberSequence.PrintRow();
    }
}
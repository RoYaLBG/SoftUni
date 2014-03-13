using System;

class StringQuotation
{
    static void Main(string[] args)
    {
        String UnquotedString = "The \"use\" of quotations causes difficulties.";
        String QuotedString = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(QuotedString);
        Console.WriteLine(UnquotedString);
    }
}


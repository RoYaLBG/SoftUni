using System;

class StringQuotation
{
    static void Main(string[] args)
    {
        String unquotedString = "The \"use\" of quotations causes difficulties.";
        String quotedString = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(quotedString);
        Console.WriteLine(unquotedString);
    }
}


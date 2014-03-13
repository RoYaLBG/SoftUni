using System;

class NullArithmetic
{
    static void Main(string[] args)
    {
       int intNull = null;
       double dblNull = null;
       Console.WriteLine(intNull);
       Console.WriteLine(dblNull);
        /*
         * Error	1	Cannot convert null to 'int' because it is a non-nullable value type	...NullArithmetic.cs	7	23	NullArithmetic
         * Error	2	Cannot convert null to 'double' because it is a non-nullable value type	...NullArithmetic.cs	8	26	NullArithmetic
        */
        intNull = null + 20;
        dblNull = null + null;
        Console.WriteLine(intNull);
        Console.WriteLine(dblNull);
        /*
         * Error	1	Cannot implicitly convert type 'int?' to 'int'. An explicit conversion exists (are you missing a cast?)	...NullArithmetic.cs	15	23	NullArithmetic
         * Error	2	Operator '+' is ambiguous on operands of type '<null>' and '<null>'	...NullArithmetic.cs	16	26	NullArithmetic
        */
    }
}


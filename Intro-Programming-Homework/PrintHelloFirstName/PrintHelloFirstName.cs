using System;

class PrintHelloFirstName
{

    static void Main(string[] args)
    {
        try
        {
            PrintName firstName = new PrintName("Ivan", "first", false);
            firstName.print();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}


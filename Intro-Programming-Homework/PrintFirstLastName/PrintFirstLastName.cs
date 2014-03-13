using System;

class PrintFirstLastName
{

    static void Main(string[] args)
    {
        try
        {
            PrintName firstName = new PrintName("Ivan", "first", false);
            PrintName lastName = new PrintName("Yonkov", "last", false);
            //PrintName lastName = new PrintName("", "last", false); /* Throws exception */
            //PrintName lastName = new PrintName("Yonkov", "blabla", false); /* Throws exception */
            firstName.print();
            lastName.print();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}


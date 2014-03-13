using System;

class CheckFemale
{
    static void Main(string[] args)
    {
        Console.WriteLine("Are you Female?");
        String Female = Console.ReadLine();
        Boolean isFemale = (Female == "yes");
        Console.WriteLine(isFemale);
    }
}


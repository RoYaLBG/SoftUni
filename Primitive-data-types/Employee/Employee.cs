using System;

class Employee
{

    static void Main(string[] args)
    {
        String FirstName = "Ivan";
        String LastName = "Yonkov";
        int Age = 21;
        long PID = 8306112507;
        int Employee_ID = 27563333;
        String Gender = "m";
        try
        {
            checkEmployeeNumber(Employee_ID);
            checkGender(Gender);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        Console.WriteLine(FirstName);
        Console.WriteLine(LastName);
        Console.WriteLine(Age);
        Console.WriteLine(PID);
        Console.WriteLine(Employee_ID);
    }

    private static void checkEmployeeNumber(int num)
    {
        if (num < 27560000 || num > 27569999)
        {
            throw new Exception("Number out of range");
        }
    }

    private static void checkGender(String Gender)
    {
        if (Gender != "m" && Gender != "f")
        {
            throw new Exception("Invalid Gender");
        }
    }
}
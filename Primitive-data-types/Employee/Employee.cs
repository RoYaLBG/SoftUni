using System;

class Employee
{

    static void Main(string[] args)
    {
        String firstName = "Ivan";
        String lastName = "Yonkov";
        int age = 21;
        long PID = 8306112507;
        int employee_ID = 27563333;
        String gender = "m";
        try
        {
            checkEmployeeNumber(employee_ID);
            checkGender(gender);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        Console.WriteLine(firstName);
        Console.WriteLine(lastName);
        Console.WriteLine(age);
        Console.WriteLine(PID);
        Console.WriteLine(employee_ID);
    }

    private static void checkEmployeeNumber(int num)
    {
        if (num < 27560000 || num > 27569999)
        {
            throw new Exception("Number out of range");
        }
    }

    private static void checkGender(String gender)
    {
        if (gender != "m" && gender != "f")
        {
            throw new Exception("Invalid Gender");
        }
    }
}
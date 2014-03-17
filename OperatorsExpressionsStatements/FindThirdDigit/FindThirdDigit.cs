using System;

class FindThirdDigit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter valid integer to see if its third digit from right-to-left is 7:");
        int myInt = Convert.ToInt32(Console.ReadLine());
        char[] charArr = myInt.ToString().ToCharArray();
        Array.Reverse(charArr);
        String converted = new String(charArr);
        Console.WriteLine(converted.IndexOf("7") == 2);
    }
}

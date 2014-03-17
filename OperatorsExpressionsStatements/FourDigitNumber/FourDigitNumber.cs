using System;

class FourDigitNumber
{
    static void Main(string[] args)
    {
        int input = Convert.ToInt32(Console.ReadLine());
        try
        {
            inputIntConstraints(input);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }
        Console.WriteLine("The sum is: " + CalculateSum(input));
        Console.WriteLine("The reversed num is: " + ReversedInt(input));
        Console.WriteLine("Last position in front: " + LastDigitInfront(input));
        Console.WriteLine("Exchanged second and third: " + ExchangeSecondThird(input));
    }

    private static Boolean inputIntConstraints(int input)
    {
        if (input.ToString().Length != 4)
        {
            throw new Exception("The input int must be 4 chars long");
        }
        return true;
    }

    private static int CalculateSum(int input)
    {
        int sum = 0;
        while (input != 0)
        {
            sum += input % 10;
            input /= 10;
        }
        return sum;
    }

    private static char[] CharDivided(int input)
    {
        return input.ToString().ToCharArray();
    }

    private static string ReversedInt(int input)
    {
        char[] charArr = CharDivided(input);
        Array.Reverse(charArr);
        return new String(charArr);
    }

    private static string LastDigitInfront(int input)
    {
        String last = CharDivided(input)[(input.ToString().Length - 1)].ToString();
        return last + CharDivided(input)[0].ToString() + CharDivided(input)[1].ToString() + CharDivided(input)[2].ToString();
    }

    private static string ExchangeSecondThird(int input)
    {
        String last = CharDivided(input)[(input.ToString().Length - 1)].ToString();
        String first = CharDivided(input)[0].ToString();
        String second = CharDivided(input)[2].ToString();
        String third = CharDivided(input)[1].ToString();
        return first + second + third + last;
    }
}


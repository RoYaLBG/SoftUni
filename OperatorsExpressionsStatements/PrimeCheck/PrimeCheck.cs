using System;

class PrimeCheck
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number to check if prime:");
        int input = Convert.ToInt32(Console.ReadLine());
        int i = 2;
        String checkPrime = (isPrime(input)) ? "prime" : "not prime";
        Console.WriteLine("The number " + input + " is " + checkPrime);
    }

    private static Boolean isPrime(int input)
    {
        int i = 2;
        while (i < input)
        {
            if (input % i == 0)
            {
                return false;
            }
        i++;
        }
        return true;
    }
}
using System;
using System.Collections;
using System.Collections.Specialized;

class BankAccount
{
    static void Main(string[] args)
    {
        OrderedDictionary holder = new OrderedDictionary();
        Console.WriteLine("Please enter your name:");
        holder.Add("First_Name", Console.ReadLine());
        Console.WriteLine("Please enter your middle name:");
        holder.Add("Middle_Name", Console.ReadLine());
        Console.WriteLine("Please enter your last name:");
        holder.Add("Last_Name", Console.ReadLine());
        Console.WriteLine("Balance:");
        decimal balance = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("IBAN:");
        ulong IBAN = Convert.ToUInt64(Console.ReadLine());
        Console.WriteLine("Bank name:");
        String bankName = Console.ReadLine(); ;
        OrderedDictionary creditCard = new OrderedDictionary();
        Console.WriteLine("First Bank Account:");
        creditCard.Add("Account1", Console.ReadLine());
        Console.WriteLine("Second Bank Account:");
        creditCard.Add("Account2", Console.ReadLine());
        Console.WriteLine("Third Bank Account:");
        creditCard.Add("Account3", Console.ReadLine());
    }
}


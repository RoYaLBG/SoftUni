using System;
using System.Collections;
using System.Collections.Specialized;

class BankAccount
{
    static void Main(string[] args)
    {
        OrderedDictionary Holder = new OrderedDictionary();
        Console.WriteLine("Please enter your name:");
        Holder.Add("First_Name", Console.ReadLine());
        Console.WriteLine("Please enter your middle name:");
        Holder.Add("Middle_Name", Console.ReadLine());
        Console.WriteLine("Please enter your last name:");
        Holder.Add("Last_Name", Console.ReadLine());
        Console.WriteLine("Balance:");
        long Balance = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("IBAN:");
        ulong IBAN = Convert.ToUInt64(Console.ReadLine());
        Console.WriteLine("Bank name:");
        String BankName = Console.ReadLine(); ;
        OrderedDictionary CreditCard = new OrderedDictionary();
        Console.WriteLine("First Bank Account:");
        CreditCard.Add("Account1", Console.ReadLine());
        Console.WriteLine("Second Bank Account:");
        CreditCard.Add("Account2", Console.ReadLine());
        Console.WriteLine("Third Bank Account:");
        CreditCard.Add("Account3", Console.ReadLine());
    }
}


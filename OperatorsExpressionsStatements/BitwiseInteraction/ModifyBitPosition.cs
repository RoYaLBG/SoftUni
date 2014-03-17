using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitwiseInteraction
{
    class ModifyBitPosition
    {
        public static void Start()
        {
            //var p = 7;
            //var n = 5343;
            //var v = 0;
            Console.WriteLine("Enter integer:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter position:");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter bit value:");
            int v = Convert.ToInt32(Console.ReadLine());

            var switchVal = (int)Math.Pow(2, p);

            int shifted = n / switchVal;

            var bitAtP = shifted % 2;
            //(n / p ^ 2) % 2;
            var result = n;
            if ((bitAtP & v) == 0)
            {
                result = n + (v - bitAtP) * switchVal;
            }

            Console.WriteLine("The binary expression of " + n + " is: " + ExtractThirdBit.GetBits(n));
            Console.WriteLine("The result after switching is: " + result);
            Console.WriteLine("The binary expression of the result (" + result + ") is: " + ExtractThirdBit.GetBits(result));
        }

    }
}

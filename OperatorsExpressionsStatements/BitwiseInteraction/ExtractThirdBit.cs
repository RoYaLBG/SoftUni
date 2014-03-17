using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitwiseInteraction
{
    class ExtractThirdBit
    {
        public static void Start()
        {
            Console.WriteLine("Enter number: ");
            try
            {
                uint unsignedInput = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine(FindPositionedBit(GetBits((int)unsignedInput)));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static String GetBits(int input)
        {
            char[] bits = new char[32];
            int pos = 31;
            int i = 0;

            while (i < 32)
            {
                if ((input & (1 << i)) != 0)
                {
                    bits[pos] = '1';
                }
                else
                {
                    bits[pos] = '0';
                }
                pos--;
                i++;
            }
            return new String(bits);
        }

        public static char FindPositionedBit(String bit, int position = 3)
        {
            char[] bits = bit.ToCharArray();
            Array.Reverse(bits);
            String reversedBits = new String(bits);
            if (position >= reversedBits.Length)
            {
                position = reversedBits.Length - 1;
            }
            return reversedBits[position];
        }
    }
}

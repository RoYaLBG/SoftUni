using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitwiseInteraction
{
    class ExtractBitFromInt
    {
        public static void Start()
        {
            Console.WriteLine("Enter number:");
            int intInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter position to check:");
            int position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The position " + position + " in number " + intInput + " is " +
            ExtractThirdBit.FindPositionedBit(ExtractThirdBit.GetBits(intInput), position));
            
            Boolean isTrueBit = ExtractThirdBit.FindPositionedBit(ExtractThirdBit.GetBits(intInput), position) == '1';

            Console.WriteLine("So the equation to 1 is: " + isTrueBit);
        }

    }
}

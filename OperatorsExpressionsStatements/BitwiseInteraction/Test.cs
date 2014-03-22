using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitwiseInteraction
{

    class BitExchangeAdvanced
    {

        static void Main()
        {

            while (true)
            {

                Console.Write("Enter a number: Range number : Min value = 0, Max value = ");

                Console.WriteLine(uint.MaxValue + " : \n");

                string line = Console.ReadLine();

                uint number; bool result = uint.TryParse(line, out number);

                if (result == false)   //not a valid uint number 
                {

                    Console.WriteLine("\nThis is not a valid input for uint number!\n\n");

                }

                else  // the input for number is valid 
                {

                    Console.WriteLine("\nEnter a value for position [p]: Range p : Min value p = 0, Max value p = 31 !\n");

                    line = Console.ReadLine();

                    int p;      // mask can take values from 1 to 1000 0000 0000 0000 0000 0000 0000 0000 for uint 

                    // type uint has 32 bits word, 

                    // position p takes values from 0 to 31 

                    // bits are numbered from 0 to 31 , from right to left 

                    result = int.TryParse(line, out p);

                    if (result == false || p < 0 || p > 31)
                    {

                        Console.WriteLine(result == false ? "\nThis is not a valid input for p!\n\n" : "\nOut of range!\n\n");

                    }

                    else //the input for p is valid 
                    {

                        Console.WriteLine("\nEnter a value for position [q]: Range q : Min value q = 0, Max value q = 31 ! \n");

                        line = Console.ReadLine(); int q; result = int.TryParse(line, out q);

                        if (result == false || q < 0 || q > 31)
                        {

                            Console.WriteLine(result == false ? "\nThis is not a valid input for q!\n\n" : "\nTOut of range!\n\n");

                        }

                        else // the input for q is valid 
                        {

                            int MaxValueOfK; if (p > q)
                            {

                                MaxValueOfK = 31 - p;

                            }

                            else // q > p 
                            {

                                MaxValueOfK = 31 - q;

                            }

                            Console.WriteLine("\nEnter a value for [k]! Range k : Min value k = 0, Max value k = "

                                                                                                                                     + MaxValueOfK + " !\n");

                            line = Console.ReadLine();

                            int k;

                            result = int.TryParse(line, out k);

                            if (result == false || p + k > 31 || q + k > 31) //not a valid integer number or k is out of it's range 
                            {

                                Console.WriteLine(result == false ? "\nThis is not a valid input for k!\n\n" : "\nOut of range!\n\n");

                            }

                            else //the input for k is valid 
                            {

                                // condition for bits overlapping 

                                bool overlap = (p < q && p + k >= q) || (q < p && q + k >= p);

                                //checking for bits overlapping  

                                if (overlap)
                                {

                                    Console.WriteLine("\nOverlapping !\n\n");

                                }

                                else // there are not bits overlaps 
                                {

                                    // swaping p with q, p+1 with q+1, p+2 with q+2, ................, p+k-1 with q+k-1 

                                    int bitPValue;

                                    int bitQValue;

                                    uint maskP;

                                    uint maskQ;

                                    for (int i = 0; i <= k - 1; i++)
                                    {

                                        //geting the value from the bit in position [p] 

                                        maskP = 1u << p;

                                        bitPValue = (int)(number & maskP) >> p; // 0  or  1 

                                        //geting the value from the bit in position [q] 

                                        maskQ = 1u << q;

                                        bitQValue = (int)(number & maskQ) >> q;  // 0  or 1 



                                        //replacing the value in the q-bit with the value in the p-bit

                                        if (bitPValue == 1)  //so we are inserting value [1] in q 
                                        {

                                            // changing the q-Bit Value to 1

                                            number = number | maskQ;

                                        }

                                        else //bitPValue = 0, so we are insertin value [0] in q 
                                        {

                                            // changing the q-Bit Value to 0 maskQ = ~ maskQ;

                                            number = number & maskQ;

                                        }

                                        //replacing the value in the p-bit with the value in the q-bit 

                                        if (bitQValue == 1) //so, we are inserting value [1] in p 
                                        {

                                            // changing the p-Bit Value to 1 

                                            number = number | maskP;

                                        }

                                        else  // bitQValue == 0, so we are inserting value [0] in p 
                                        {

                                            // changing the p-Bit Value to 0 

                                            maskP = ~maskP;

                                            number = number & maskP;

                                        }

                                        p++;

                                        q++;

                                    }

                                    Console.WriteLine("\nResult : \n\n" + number + " \n\n\n");

                                }

                            }

                        }

                    }

                }

            }

        }

    }
}

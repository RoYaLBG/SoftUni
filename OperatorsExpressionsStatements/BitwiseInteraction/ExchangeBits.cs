using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitwiseInteraction
{
    class ExchangeBits
    {

        private static Dictionary<int, Dictionary<string, Dictionary<int, int>>> exchangeHashTable = new Dictionary<int, Dictionary<string, Dictionary<int, int>>>();
        private static uint input;


        public static void Start()
        {

            uint n = 2369124121;
            input = n;
            initHashTable();

            for (int i = 0; i < exchangeHashTable.Count; i++)
            {
                if (exchangeHashTable[i]["from"][0] != exchangeHashTable[i]["to"][0])
                {
                    if (exchangeHashTable[i]["from"][0] != 0)
                    {
                        n = SwitchBitToTrue(n, exchangeHashTable[i]["to"][1]);
                        n = SwitchBitToFalse(n, exchangeHashTable[i]["from"][1]);
                    }
                    else
                    {
                        n = SwitchBitToFalse(n, exchangeHashTable[i]["to"][1]);
                        n = SwitchBitToTrue(n, exchangeHashTable[i]["from"][1]);
                    }
                }
            }
            Console.WriteLine(n);
        }

        public static uint SwitchBitToFalse(uint n, int p)
        {
            int mask = ~(1 << p);
            uint result = n & (uint)mask;
            return result;
        }

        public static uint SwitchBitToTrue(uint n, int p)
        {
            int mask = 1 << p;
            uint result = n | (uint)mask;
            return result;
        }

        public static int GetBitAtPosition(uint n, int p)
        {
            uint nRightP = n >> p;
            int bit = (int)nRightP & 1;
            return bit;
        }
    

        /**
         * Dafuq :)
         * Strongly typed languages are killing me
         * Long Live PHP
         */
        private static void initHashTable()
        {
            int[] localFrom = new int[3] { 3, 4, 5 };
            int[] localTo = new int[3] { 24, 25, 26 };

            for (int i = 0; i < localFrom.Length; i++)
            {
                exchangeHashTable.Add(i, new Dictionary<string, Dictionary<int, int>>());
                exchangeHashTable[i].Add("from", new Dictionary<int, int>());
                exchangeHashTable[i].Add("to", new Dictionary<int, int>());
                exchangeHashTable[i]["from"].Add(0, GetBitAtPosition(input, localFrom[i]));
                exchangeHashTable[i]["to"].Add(0, GetBitAtPosition(input, localTo[i]));
                exchangeHashTable[i]["from"].Add(1, localFrom[i]);
                exchangeHashTable[i]["to"].Add(1, localTo[i]);
            }
        }


    }
}

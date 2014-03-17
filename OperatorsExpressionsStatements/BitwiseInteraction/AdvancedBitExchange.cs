using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitwiseInteraction
{
    class AdvancedBitExchange
    {
        private static Dictionary<int, Dictionary<string, Dictionary<int, int>>> exchangeHashTable = new Dictionary<int, Dictionary<string, Dictionary<int, int>>>();
        private static uint input;
        private static int _p, _q, _k;

        public static void Start()
        {
            Console.WriteLine("Enter uint: ");
            uint n;
            try
            {
                n = Convert.ToUInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            Console.WriteLine("Enter p: ");
            int p = _p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter q: ");
            int q = _q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter k: ");
            int k = _k = Convert.ToInt32(Console.ReadLine());
            input = n;
            initHashTable();
            try
            {
                constraints(p, q, k);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

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

        private static Boolean constraints(int p, int q, int k)
        {
            if (p + k > 32 || q + k > 32 || p > 32 || q > 32 || p < 0 || q < 0)
            {
                throw new Exception("out of range");
            }

            if ((p + k >= q && p < q) || (q + k >= p && q < p))
            {
                throw new Exception("overlapping");
            }
            return true;
        }

        private static void initHashTable()
        {

            int[] localFrom = new int[_q - (_q - _k)];
            int j = 0;
            for (int i = _q; i <= _q + _k - 1; i++)
            {
                localFrom[j] = i;
                j++;
            }

            int[] localTo = new int[_p - (_p - _k)];
            int k = 0;
            for (int i = _p; i <= _p + _k - 1; i++)
            {
                localTo[k] = i;
                k++;
            }

            int length = (localFrom.Length > localTo.Length) ? localFrom.Length : localTo.Length;

            for (int i = 0; i < length; i++)
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
    

    }
}

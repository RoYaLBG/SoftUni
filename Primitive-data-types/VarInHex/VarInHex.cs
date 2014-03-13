using System;
class VarInHex
{
    static void Main(string[] args)
    {
        /*
        int PureInt = 254;
        String IntToHex = "0x" + PureInt.ToString("X"); // 0xFE

        String myHex = "0xFE";
        Console.WriteLine(Convert.ToInt32(myHex, 16)); // 254
        */

        int myIntInHex = 0xFE;
        Console.WriteLine(myIntInHex); // 254
    }
}

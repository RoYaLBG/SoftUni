using System;

class ObjectCasting
{
    static void Main(string[] args)
    {
        String Hello = "Hello";
        String World = "World";

        Object HelloWorld_Obj = Hello + " " + World;

        String HelloWorld = HelloWorld_Obj.ToString();
    }
}


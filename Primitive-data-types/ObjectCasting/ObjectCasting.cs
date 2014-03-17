using System;

class ObjectCasting
{
    static void Main(string[] args)
    {
        String hello = "Hello";
        String world = "World";

        Object HelloWorld_Obj = hello + " " + world;

        String helloWorld = HelloWorld_Obj.ToString();
    }
}


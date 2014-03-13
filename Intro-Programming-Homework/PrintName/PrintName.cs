using System;

public class PrintName
{
    private String _name { get; set; }
    private String _nameType { get; set; }

    private const String NO_NAME_ERROR = "Error! You have to set your name before using print().";

    public static void Main()
    {
        try
        {
            PrintName self = new PrintName("Ivan", "first", true);
            self.print();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public PrintName(String Name, String NameType, bool isHello)
    {
        this._name = Name;
        this._nameType = NameType;
        if (!checkConstraints())
        {
            throw new Exception("Cannot instantiate the name object, because of constraint violation.");
        }
        if (isHello)
        {
            printHello();
        }
    }

    private Boolean checkConstraints()
    {
        if (this._nameType != "first" && this._nameType != "last") // it could be enums
        {
            return false;
        }

        if (this._name.Length <= 0)
        {
            printNoNameError();
            return false;
        }

        return true;
    }

    private void printHello()
    {
        Console.Write("Hello ");
    }

    public void print()
    {
        Console.WriteLine(this._name);
    }

    private void printNoNameError()
    {
        Console.WriteLine(NO_NAME_ERROR);
    }

}



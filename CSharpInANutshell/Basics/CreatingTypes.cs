namespace CSharpInANutshell.Basics;

public class CreatingTypes
{
    private int _myLocalInt;
    private bool _myLocalBool;
    private string _myLocalString;
    
    public static void PrintBasics()
    {
        Console.WriteLine("The most common kind of reference type is the class.");
        Console.WriteLine("Complex class can optionally have the following in their declaration:");
        Console.WriteLine("Preceding class keyword:");
        Console.WriteLine("Attributes and class modifiers - public, internal, abstract, sealed, static, unsafe, partial.");
        Console.WriteLine("Following the ClassName:");
        Console.WriteLine("Generic type parameters and constraints, a base class and interfaces.");

        int InternalMethod(int value)
        {
            return value * 2;
        }
    }

    // when one constructor calls another, the called one is executed first
    public CreatingTypes(int someInt)
    {
        _myLocalInt = someInt;
        Console.WriteLine("int constructor called!");
    }
    public CreatingTypes(int someInt, bool someBool) : this(someInt)
    {
        _myLocalBool = someBool;  
        Console.WriteLine("bool constructor called!");
    } 
    // constructors can be expression-bodied
    public CreatingTypes(int someInt, bool someBool, string someString) : this(someInt, someBool) 
        => Console.WriteLine($"string constructor called with {_myLocalString = someString}.");

    public void Deconstruct(out int myInt, out bool myBool, out string myString)
    {
       myInt = _myLocalInt;
       myBool = _myLocalBool;
       myString = _myLocalString;
    }

    public void Deconstruct(out int myInt, out bool myBool)
    {
        myInt = _myLocalInt;
        myBool = _myLocalBool;
    }
    public void Deconstruct(out int myInt)
    {
        myInt = _myLocalInt;
    }
}
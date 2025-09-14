namespace CSharpInANutshell.Basics;

public class CreatingTypes(string primaryConstructorParameter)
{
    // can use primary constructor arguments to populate fields or properties
    // if we use exactly the same name, field masks/hides the argument elsewhere in the code
    // unless if on the right of an assignment operator
    private readonly string _primaryConstructorParameter = (primaryConstructorParameter == null) ?
        throw new ArgumentNullException(nameof(primaryConstructorParameter)) : 
        primaryConstructorParameter.ToUpper();

    public string PrimaryConstructorParameterProp { get; set; } 
        = primaryConstructorParameter;
    
    private int _myLocalInt;
    private bool _myLocalBool;
    private string _myLocalString = "Wasn't set in constructor.";

    // we can implement an Indexer by defining a property called 'this'
    public char this[int index] => _myLocalString[index];
    
    // we can also support Index and Range type
    public char this[Index index] => _myLocalString[index];
    public string this[Range range] => _myLocalString[range];

    public string Name = "JohnOfUs";
    public CreatingTypes? BestFriendOfSameType;
    
    [System.Runtime.CompilerServices.ModuleInitializer]
    internal static void InitAssembly()
    {
        Console.WriteLine("-----------");
        Console.WriteLine("InitAssembly called!");
        Console.WriteLine("Since C#9 we can add static void methods with the [ModuleInitializer] attribute (System.Runtime.CompilerServices)");
        Console.WriteLine("These methods are called when the assembly is first loaded.");
        Console.WriteLine("-----------");
    }
    static CreatingTypes()
    {
        Console.WriteLine("-----------");
        Console.WriteLine("Static constructor of CreatingTypes called.");
        Console.WriteLine("There can only be one static constructor per type, it has to be parameterless.");
        Console.WriteLine("It is called either when the first static method of the type is called, or the type is initialized.");
        Console.WriteLine("-----------");
    }
    
    ~CreatingTypes() => Console.WriteLine("Destructor called! - Compiler overrides Finalize(), calls base.Finalize() after this call.");
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

    // When one constructor calls another, the called one is executed first.
    // Because we have a primary constructor, each additional custom constructor has to first call the primary constructor.
    // Due to chaining, we only need to do it from the deepest constructor as it's called by all other constructors
    public CreatingTypes(int someInt) : this("Hello World!")
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

    public void MeetNewBestFriend(CreatingTypes newBestFriend)
    {
        BestFriendOfSameType = newBestFriend;
        newBestFriend.BestFriendOfSameType = this; // "this" refers to the instance the method was called on
    }
}
namespace CSharpInANutshell.Basics;

public class VariablesAndParameters
{
    public static void PrintBasicsVariables()
    {
        Console.WriteLine("A variable represents a storage location with a modifiable value.");
        Console.WriteLine("Can be: local variable, parameter (value, ref, out, in), field (instance, static), array element.");
        Console.WriteLine("Memory is stored on stack or heap.");
        Console.WriteLine("Stack: Block memory for local variables and parameters, gets deleted of the stack once block execution finishes.");
        Console.WriteLine("Heap: For all reference types, memory management via the GC.");
        Console.WriteLine("Once a referenced object isn't used any longer by any referencing pointers, it is eligible for garbage collection.");
        Console.WriteLine("Value types that are instance members of reference types (e.g. an int in a class) are stored on the heap, within the reference type.");
        Console.WriteLine("Static fields are stored on the heap and persist during the entire apps runtime.\n");

        Console.WriteLine("C# enforces a definite assignment policy, meaning outside of unsafe/interop context you can't accidentally access uninitialized memory.");
        Console.WriteLine("This means:");
        Console.WriteLine("1) Local variables must be assigned a value before they can be read.");
        Console.WriteLine("2) Function arguments must be supplied to a method call (unless marked as optional).");
        Console.WriteLine("3) All other variables (fields, array elements) are automatically initialized by the runtime to default value.\n");

        Console.WriteLine("Default values of different types:");
        Console.WriteLine("Reference / nullable value types: null");
        Console.WriteLine("Numeric and enum types: 0");
        Console.WriteLine(@"Char type: '\0'");
        Console.WriteLine("Boolean type: false");
        Console.WriteLine("Default value for any type can be obtained with the default keyword.");
        Console.WriteLine($"Default value of decimal is {default(decimal)} - default(type)");

        Console.WriteLine("\n------------------\n");
    }
    
    public static void PrintBasicsParameters()
    {
        Console.WriteLine("Parameters define the set of arguments that must be provided to a method.");
        Console.WriteLine("Parameters = blueprint, arguments = actual values when calling method.");
        Console.WriteLine("Parameters can have modifiers: ref, in, out\n");

        Console.WriteLine("Value types are passed by copy.");
        Console.WriteLine("Reference types pass a copy of the reference pointer, not a copy of the object.");
        Console.WriteLine("The ref keyword allows explicitly passing by reference, the original value is affected.");
        Console.WriteLine("This means value types can be changed from within the method, and the reference pointer of a ref type can be assigned a different object or null.");
        var x = 69;
        SimpleRefIncrement(ref x); // this modifies the original value of x instead of passing by copy.
        Console.WriteLine("\nThe out modifier behaves the same as ref, except the argument can be empty on entrance, but has to be assigned when leaving the method.");
        SimpleOutCreation(out int i, out _);
        Console.WriteLine("""By using the special "_" special character, we can discard an output parameter we do not care for.""");
        
        Console.WriteLine("\nThe in modifier allows to pass a value type by reference, but prevents modification.");
        Console.WriteLine("This is useful when passing large value types to prevent extra storage allocation for the copy.");
        Console.WriteLine("Do not use for small 1-8 byte value types as it can prevent certain optimizations, CPU might prefer working with registers than with memory.");
        Console.WriteLine("If performance is not a big concern, may be used to clearly show non-modification within method.");
        SimpleInPrint(in x);
        SimpleInPrint(42);   // if there is no method overload, in may be omitted on call
        Console.WriteLine("A method may be overloaded by just adding the in modifier to some parameters.");
        
        Console.WriteLine("\nThe params modifier allows to add any number of arguments at the end of a method call.");
        Console.WriteLine("These have to be of the same type and can be passed individually, or as a one-dimensional array.");
        Console.WriteLine("The method does receive it as a 'params type[] name' array either way - if none are specified a zero-length array is created.");
        SimpleParamsPrint(1, 2, 3, 4, 5);
        SimpleParamsPrint(0);

        Console.WriteLine("\nWe can add optional parameters by specifying a default value.");
        Console.WriteLine("void Foo(int i, int j = 42) {...}");
        Console.WriteLine("All mandatory parameters have to appear before the optional ones.");
        Console.WriteLine("Omitted optional parameters still are available within the method with their specified fallback values.");
        Console.WriteLine("\nNamed arguments allow us to specify only certain arguments, but they do have to appear after mandatory ones.");
        Console.WriteLine("\n------------------\n");
    }

    private static void SimpleParamsPrint(int i, params int[] numbers)
    {
        Console.WriteLine($"\nParams array length is {numbers.Length}.");
        Console.WriteLine($"Individually provided variable i is: {i}\n");
        Console.WriteLine("Printing params!");
        foreach (var number in numbers)
            Console.Write(number);
        Console.WriteLine();
        Console.WriteLine("Done printing params!\n");
    }

    private static void SimpleInPrint(in int i)
    {
        Console.WriteLine(i);
        // i = 20; is not allowed due to the in keyword.
    }

    private static void SimpleRefIncrement(ref int i)
    {
        i++;
    }

    private static void SimpleOutCreation(out int i, out int j)
    {
        i = 69; // i and j have to be assigned within the method scope
        j = 420;
    }

    private static string _myString = "Old Value";
    private static ref string GetX() => ref _myString;
    private static ref string Prop => ref _myString; // property, implicitly writeable
    private static ref readonly string ReadOnlyProp => ref _myString; // readonly
    public static void PrintRefVariables()
    {
        Console.WriteLine("Rev locals were introduce with C#7 and allow us to define a local variable that references an element in an array or a field in an object.");
        Console.WriteLine("This allows us to modify the value of the referenced element without having to copy it first.");
        int[] numbers = [1, 2, 3, 4, 5];
        ref var first = ref numbers[0]; // "first" is now pointing at the first element in the numbers array
        Console.WriteLine("The target for ref local must be: array element, field or local variable - cannot be a property!");
        Console.WriteLine("Intended for specialized micro-optimization, especially used with ref returns.");
        Console.WriteLine("int[] numbers = [1,2,3]; ref var first = ref numbers[0];");

        Console.WriteLine("\nref return allows us to return a ref local from a method - similar to an out modifier, but as the main return type.");
        Console.WriteLine($"x: {_myString}");
        ref var xRef = ref GetX();
        xRef = "New Value";
        Console.WriteLine(xRef);
        Console.WriteLine("If we call the ref method without the ref modifier we get an ordinary copied value.");
        var xRef2 = GetX();
        xRef2 = "Another new value.";
        Console.WriteLine($"x: {_myString}, xRef with ref modifier: {xRef}, xRef without ref modifier: {xRef2}");
        Console.WriteLine("Can also use ref returns when defining a property or indexer.");
        Console.WriteLine("This property then is implicitly writeable, despite missing a set accessor.");
        Console.WriteLine("To make it non-writeable use, static ref readonly string MyProperty => ref _localField");
        Console.WriteLine("This is useful for large structs - but only if they are marked as readonly as well.");
        Console.WriteLine("Otherwise the compiler will perform a defensive copy.");
        Console.WriteLine("\n------------------\n");
    }
}
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
        
    }
}
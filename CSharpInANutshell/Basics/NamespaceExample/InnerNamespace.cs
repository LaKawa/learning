// ReSharper disable once CheckNamespace
namespace CSharpInANutshell.Basics.NamespaceExample.InnerNamespace;

// extern alias AssemblyName; - allows explicitly referencing other assemblies
// alias also has to be added in the csproj file

// using static declaration imports type instead of namespace
using static System.Console;

public class InnerNamespace
{
    private OuterNamespace _outer; // outer namespace is accessible from inner namespace
    public static int MyInt { get; set; } = 42;

    // Name hiding: if an inner namespace defines a variable with the same name
    // as a variable in the outer namespace, the inner variable is used.
    // The outer variable has to be accessed with full qualification.
    static void PrintMyInt()
    {
        System.Console.WriteLine($"MyInt: {MyInt}");
    }

    static void PrintOuterMyInt()
    { 
        WriteLine($"MyOuterInt: {OuterNamespace.MyInt}");
        WriteLine(typeof(Console));
        
    }
}
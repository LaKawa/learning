// ReSharper disable once CheckNamespace
namespace CSharpInANutshell.Basics.NamespaceExample.InnerNamespace;

public class InnerNamespace
{
    private OuterNamespace _outer; // outer namespace is accessible from inner namespace
    public static int MyInt { get; set; } = 42;

    // Name hiding: if an inner namespace defines a variable with the same name
    // as a variable in the outer namespace, the inner variable is used.
    // The outer variable has to be accessed with full qualification.
    static void PrintMyInt()
    {
        Console.WriteLine($"MyInt: {MyInt}");
    }

    static void PrintOuterMyInt()
    {
        Console.WriteLine($"MyOuterInt: {OuterNamespace.MyInt}");
    }
}
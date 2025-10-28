namespace CSharpInANutshell.Experiments.InitializationOrder;

public class DerivedClass : BaseClass
{
    public int field = InitDerivedField();

    public DerivedClass(int x) : base(x)
    {
        Console.WriteLine($"Derived ctor: {x}");
        Console.WriteLine($"Accessing Derived field: {field}");
    }
    private static int InitDerivedField()
    {
        Console.WriteLine("Derived field init.");
        return 44;
    }
}
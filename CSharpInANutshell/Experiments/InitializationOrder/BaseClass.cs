namespace CSharpInANutshell.Experiments.InitializationOrder;

public class BaseClass
{
    public int field = InitBaseField();

    public BaseClass(int x)
    {
        Console.WriteLine($"Base class ctor: {x}");
    }

    private static int InitBaseField()
    {
        Console.WriteLine("Base field init.");
        return 42;
    }
}
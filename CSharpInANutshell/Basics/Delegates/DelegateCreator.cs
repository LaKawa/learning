namespace CSharpInANutshell.Basics.Delegates;

public class DelegateCreator
{
    public delegate int MyDelegate(int x);

    public readonly MyDelegate DelegateInstance = Square;
    public readonly MyDelegate AlternativeDelegateInstance = new MyDelegate(Square);
    
    // if the assigned method is overloaded, the correct overload is picked based on the delegate signature

    private static int Square(int x) => x * x;

    private static int Square(int x, string msg)
    {
        Console.WriteLine("Printing random user message:");
        Console.WriteLine(msg);
        return x * x;
    }

    public int Cube(int x) => x * x * x;
    
    public delegate int Transformer(int x);

    
    public void Transform(int[] values, Transformer t)
    {
        for (var i = 0; i < values.Length; i++)
        {
            values[i] = t(values[i]);
        }
    }

    public static void CreateAndPrintExamples()
    {
        DelegateCreator myDelegateContainer = new();
        Console.WriteLine(myDelegateContainer.DelegateInstance(4));
        Console.WriteLine(myDelegateContainer.DelegateInstance.Invoke(4));


        int[] someNumbers = [1, 3, 4, 5];

        Console.WriteLine("Original numbers:");
        foreach (var i in someNumbers)
            Console.Write(i + " ");

        Transformer t = myDelegateContainer.Cube;
        Console.WriteLine($"Delegate instance t has single target? {t.HasSingleTarget}.\n" +
                          $"Current target: {t.Target}.\n" +
                          $"Method Info: {t.Method}.\n");
        // we may accept a delegate-fulfilling method as an argument (int Foo(int x))
        myDelegateContainer.Transform(someNumbers, myDelegateContainer.Cube);
        myDelegateContainer.Transform(someNumbers, t);
        
        Console.WriteLine("\nTransformed Numbers:");
        foreach(var i in someNumbers)
            Console.Write(i + " ");

        Console.WriteLine(); 
    }
}
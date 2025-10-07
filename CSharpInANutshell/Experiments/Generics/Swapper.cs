namespace CSharpInANutshell.Experiments.Generics;

public static class Swapper
{
    static void SwapValues<T>(ref T a, ref T b)
    {
        var temp = a;
        a = b;
        b = temp;
    }
    
    // IDE suggests using deconstruction tuples, need to learn more about this:

    static void SwapValuesWithDeconstructSyntax<T>(ref T a, ref T b)
    {
        (a, b) = (b, a);
    }
}
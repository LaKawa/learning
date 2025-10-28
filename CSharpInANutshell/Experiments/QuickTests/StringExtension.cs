using CSharpInANutshell.Experiments.InitializationOrder;

namespace CSharpInANutshell.Experiments.QuickTests;

public static class StringExtension
{
    public static void PrintNTimes(this string s, int n)
    {
        for (var i = 0; i < n; i++)
        {
            Console.WriteLine($"{s}");
        }
    }

    public static void PrintBaseClass(this BaseClass bc, int n)
    {
        for (var i = 0; i < n; i++)
        {
            Console.WriteLine(bc.field);
        }
    }
    
}
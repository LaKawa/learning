namespace CSharpInANutshell.Experiments.UsingDeclarations;

// can use using + name to alias a type
// useful if two identical type names exist
using ExplicitPropInfo = System.Reflection.PropertyInfo;
using C = Console;

using DoubleArray = double[];
using RenamedInt = int;

// can also alias an entire namespace!
using S = System;

public class UsingExperiment
{
    private System.Reflection.PropertyInfo myInfo;
    private ExplicitPropInfo someOtherInfo;

    RenamedInt myInt = 24;
    private DoubleArray someDoubles = [2.5, 3.2, 6.4];
    
    private void TestPrint()
    {
        C.WriteLine("Aliased Console type!");
        S.Console.WriteLine("Aliased a whole namespace!");
    }
}
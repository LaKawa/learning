namespace CSharpInANutshell.Experiments.InitSetters;

public class InitTesting
{
    private readonly int _x = 42;

    public int X
    {
        get => _x; init => _x = value;
    }
    
    // init-setter property generates readonly backing field
    public int Number { get; init; }
    
    
    // readonly is only settable
    // - on declaration
    // - in constructor
    
    // init-only property is only settable
    // - in constructor
    // - in object initializer
}
namespace CSharpInANutshell.Experiments.EnumUsage;

// we can use enums in other enums, but this introduces hidden dependencies
// => if we change BorderSide.Left value, it will change Alignment.Left value as well
public enum Alignment
{
    Left = BorderSide.Left,
    Right = BorderSide.Right,
    Center
}

// better to use a mapper helper so we don't silently break things
public static class AlignmentMapper
{
    public static Alignment FromBorderSide(BorderSide side) => side switch
    {
        BorderSide.Left => Alignment.Left,
        BorderSide.Right => Alignment.Right,
        _ => Alignment.Center
    };
}
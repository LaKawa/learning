namespace CSharpInANutshell.Experiments.EnumUsage;

// having overlapping values is permitted but only useful for aliasing (so almost never)
public enum BorderSide : byte
{
    Left = 5,
    Right = 9,
    Top = 8,
    RightAlias, // is set to 9 by default
    Bottom = 1
}

/*
 BorderSide side = BorderSide.Right;
 side == BorderSide.RightAlias = true
 
 evaluates to true because both enum values are just names for the byte value 9
*/
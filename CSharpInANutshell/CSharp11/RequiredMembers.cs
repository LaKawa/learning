namespace CSharpInANutshell.CSharp11;

/// <summary>
/// Adding the required modifier to a field or property forces to initialize it during object creation.
/// <para/>
/// This prevents writing long constructors.<br/>
/// If you also need a constructor, use <c>[SetsRequiredMembers]</c> attribute to bypass restrictions for this constructor.
/// </summary>
public class RequiredMembers
{
    public required string Name;
}
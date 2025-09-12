namespace CSharpInANutshell.CSharp12;

/// <summary>
/// Can now automatically build a primary constructor for simple classes.
/// <para/>
/// Also works for structs.<br/>
/// Records were introduced in C#9 and behave slightly differently.
/// </summary>
/// <param name="name">Some name.</param>
/// <param name="age">Some age.</param>
public class PrimaryConstructors(string name, int age)
{
    public void Print() => Console.WriteLine($"{name} is {age} years old.");
}
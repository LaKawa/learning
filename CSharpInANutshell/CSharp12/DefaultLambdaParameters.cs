namespace CSharpInANutshell.CSharp12;
/// <summary>
/// Can now add default parameters to lambda expressions.
/// <para/>
/// Has certain usecases, for example in the ASP.NET Minimal API.
/// <code>app.MapGet("/hello", (string name = "world") => $"Hello {name}!");</code>
/// </summary>
public class DefaultLambdaParameters
{
    public void Print(string msg = "Hello World.") => Console.WriteLine(msg);

    public void Print2(string msg)
    {
        var print = (string msg2 = "Hello World.") => Console.WriteLine(msg2);
    }
    
}
namespace CSharpInANutshell.CSharp11;

/// <summary>
/// <c>""" - """</c> creates raw string literals which can contain almost any character
/// without escaping or doubling up.<br/>
/// Allows usage of $ for interpolation. Using multiple $ characters changes interpolation
/// sequence to include braces in the string itself.
/// <code>Console.WriteLine($$"""{ "TimeStamp": "{{DateTime.Now}}" }""");</code>
/// </summary>
public class RawStringLiterals
{
    string _raw = """<file path=""C:\temp\test.txt"" />""";

    string _rawMultiLine = $"""
                            Line 1
                            Line 2
                            The date and time is {DateTime.Now}.
                            """;

    private string _rawMultiInterpolation = $$"""{ "TimeStamp": "{{DateTime.Now}}" }""";


    public void Print()
    {
        Console.WriteLine(_raw);
        Console.WriteLine(_rawMultiLine);
        Console.WriteLine(_rawMultiInterpolation);
    }
}
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
    private const string Raw = """<file path=""C:\temp\test.txt"" />""";

    private readonly string _rawMultiLine = $"""
                                             Line 1
                                             Line 2
                                             The date and time is {DateTime.Now}.
                                             """;

    private readonly string _rawMultiInterpolation = $$"""{ "TimeStamp": "{{DateTime.Now}}" }""";


    public void Print()
    {
        Console.WriteLine(Raw);
        Console.WriteLine(_rawMultiLine);
        Console.WriteLine(_rawMultiInterpolation);
    }
}
using System.Text;

namespace CSharpInANutshell.Basics;

public static class CharactersAndStrings
{
    public static void PrintChar()
    {
        Console.WriteLine("char type represents Unicode character with 2 bytes -> UTF16");
        Console.WriteLine("Char literal is specified with single quote \'c\'.");
        Console.WriteLine("There are multiple escape characters which work both in chars and string.");
        Console.WriteLine("\\' - Single Quote");
        Console.WriteLine("\\\" - Double Quote");
        Console.WriteLine("\\n - New Line");
        Console.WriteLine("\\t - Horizontal tab");
        Console.WriteLine("\\v - Vertical Tab - mostly redundant today, was used to add specified length space");
        Console.WriteLine("\\b - Backslash - deletes previous character");
        Console.WriteLine("\\r - Carriage Return - move to beginning of line");
        Console.WriteLine("\\0 - Null - used in interops for C \\0 terminated strings");
        Console.WriteLine("\\x - Hexadecimal - for UTF16 surrogate pairs, displays characters outside of BMP (Basic Multilingual Plane)");
        Console.WriteLine("\\u - Unicode - for UTF16 single 2 byte characters");
        
        Console.WriteLine("\n------------------\n");
    }

    public static void PrintEncoding()
    {
        Console.WriteLine("C# uses UTF16 encoding, so 2 bytes per character.");
        Console.WriteLine("Encoding to UTF8 (used for backwards compatibility in web), needs encoding into a byte[].");
        Console.WriteLine("Can be set globally with Console.OutputEncoding = System.Text.Encoding.UTF8");
        Console.WriteLine("This isn't good for performance critical apps as now every single console call will first encode to UTF8, even if its redundant.");

        Console.WriteLine("\nUTF8 uses a flexible 1-4 byte encoding, while UTF16 uses 2 surrogate 2 byte values for characters outside the BMP.");
        Console.WriteLine("Example for a smiling emote: \xD83D\xDE00" + " - this doesn't display in UTF16 -> ??");
        string emote = "\xD83D\xDE00";
        var previousEncoding = Console.OutputEncoding;
        Console.OutputEncoding = Encoding.UTF8;
        //byte[] utf8Bytes = Encoding.UTF8.GetBytes(emote);
        Console.WriteLine(emote);
        Console.OutputEncoding = previousEncoding;
        // careful if app uses multiple threads!
        Console.WriteLine("\n------------------\n");

        Console.WriteLine("""
                             This is 
                              a raw
                                multiline
                               string!
                             """);
    }
}
namespace CSharpInANutshell.CSharp11;

/// <summary>
/// <c>u8</c>-suffix allows creating UTF-8 string literals rather UTF-16.<br/>
/// This is useful for performance-critical operations.
/// <para/>
/// // TODO: could use this for JSON-parsing in discogs app?
/// <para/>
/// // TODO: learn more about Spans - pointers to chunk of memory
/// </summary>
internal ref struct Utf8Strings()
{
    private ReadOnlySpan<byte> _utf8 = "ab->cd"u8;
}
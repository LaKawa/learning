using Point = (int X, int Y);
using NumberList = double[];

namespace CSharpInANutshell.CSharp12;

/// <summary>
/// C# was always able to alias simple or generic types via using directive.
/// <code>using ListOfInt = System.Collections.Generic.List&lt;int&gt;
/// var list = new ListOfInt();
/// </code>
/// Now works with other types like arrays and tuples.
/// <code>using NumberList = double[];
/// using Point = (int X, int Y);
/// NumberList numbers = [1.1, 2.2, 3.3];
/// Point p = (42, 69);</code>
/// </summary>
public class AliasAnyType
{
    private NumberList _numbers = [1.1, 2.2, 3.3];
    
    private Point _p = (42, 69);
    private Point _p2 = (43, 70);
}
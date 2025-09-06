namespace CSharpInANutshell.CSharp12;

/// <summary>
/// Collection expressions <c>(= ['a', 'b', 'c'])</c> allow easier collection creation.
/// <para/>
/// The same syntax works for different collection types, e.g., lists, sets, spans.
/// <para/>
/// They are target-typed, meaning you can omit the type where the compiler can infer it.
/// <code>
/// char[] charArray = ['a', 'b', 'c'];
/// Foo(['a', 'b', 'c']);</code>
/// </summary>
public class CollectionExpressions
{
   private char[] _oldArray = { 'a', 'b', 'c' };
   private char[] _newArray = ['a', 'b', 'c'];   // collection expression
   
   List<char> _oldList = new List<char> { 'a', 'b', 'c' };
   private List<char> _somewhatOldList = new() { 'a', 'b', 'c' };
   private List<char> _newList = ['a', 'b', 'c']; // collection expression
}
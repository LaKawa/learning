namespace CSharpInANutshell.CSharp11;

/// <summary>
/// Use Print for examples.
/// <para/>
/// List patterns match a series of elements in square brackets and work with any collection type that is countable
/// and indexable.
/// <code>Console.WriteLine(number is [0, 1, 2, 3]);</code>
/// </summary>
public class ListPatterns
{
    private readonly int[] _numbers = [1, 2, 3, 4, 5];

    public void Print()
    {
        Console.WriteLine("Numbers: 1, 2, 3, 4, 5");
        Console.Write("Numbers is [1, 2, 3, 4, 5] - ");
        Console.WriteLine(_numbers is [1, 2, 3, 4, 5]);
        
        Console.Write("Numbers is [1, 2, 3, 4, 6] - ");
        Console.WriteLine(_numbers is [1, 2, 3, 4, 6]);

        Console.Write("Numbers is [_, 1, .., 4] - ");
        Console.WriteLine(_numbers is [_, 1, .., 4]); // false - _ matches one element of any value, .. 0 ore more elements
        Console.WriteLine("_ checks for any value in this position, .. for 0 or more elements with any value.\n");
        
        Console.Write("Numbers is [1, .., 5] - ");
        Console.WriteLine(_numbers is [1, .., 5]); // true - starts with 1, ends with 5
        
        Console.Write("Numbers is [1, _, 3, _, 5] - ");
        Console.WriteLine(_numbers is [1, _, 3, _, 5]); // true - 1 - any value - 3 - any value - 5
    }
    
}
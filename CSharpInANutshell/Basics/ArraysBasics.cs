using System.Runtime.InteropServices;

namespace CSharpInANutshell.Basics;

public static class ArraysBasics
{
    public static void PrintBasics()
    {
        Console.WriteLine("Arrays are reference types.");
        Console.WriteLine("On creation, they are preinitialized with default values.");
        var myInts = new int[5];
        Console.WriteLine($"myInts[0] = {myInts[0]} - just created this, all ints are set to 0.");
        Console.WriteLine("In case of reference types, or references within structs - these are null initialized.\n");

        Console.WriteLine("We can access elements relative to the end of the array with the ^ operator.");
        Console.WriteLine("^1 = last element, ^2 = second-to-last element...");
        Console.WriteLine("^0 equals the length of the array, so throws an arrow due to 0 indexing.\n");

        Console.WriteLine("We can extract ranges from an array using the .. operator.");
        Console.WriteLine(
            "[0..1] gets only the first element - first number = starting index, second number = exclusive");
        Console.WriteLine("[1..] gets all elements from index 1 to end, [..^1] gets all indexes except the last one.");
        Console.WriteLine("As with the Index type, there is a Range type to store a range.\n");
        Index first = 0;
        Index last = ^1;
        Range range = first..last; // gets everything except the last element

        Console.WriteLine("One can shorten array expression, either by leaving out the new operator and type qualification.");
        Console.WriteLine("char[] vowels = {'a', 'e', 'i', 'o', 'u'}; - since C#12 ['a'...] is also valid");
        Console.WriteLine("Or by using var and then only new without the type qualifier.");
        Console.WriteLine("var vowels = new[] {'a', 'e', 'i', 'o', 'u'};");
    }

    public static void PrintMultiDimensional()
    {
        Console.WriteLine(
            "There are two types of multidimensional arrays, rectangular and jagged, which are arrays of arrays.");
        var twoDimensionalMatrix = new int[3, 12]; // 3 rows, 3 columns
        Console.WriteLine("int[,] matrix = new int[3, 4];");
        Console.WriteLine(
            $"Matrix is: {twoDimensionalMatrix.GetLength(0)} rows, {twoDimensionalMatrix.GetLength(1)} columns.");
        for (var i = 0; i < twoDimensionalMatrix.GetLength(0); i++)
        for (var j = 0; j < twoDimensionalMatrix.GetLength(1); j++)
            twoDimensionalMatrix[i, j] = i * twoDimensionalMatrix.GetLength(1) + j;
        for (var i = 0; i < twoDimensionalMatrix.GetLength(0); i++)
        {
            Console.WriteLine();
            for(var j = 0; j < twoDimensionalMatrix.GetLength(1); j++)
                Console.Write($"{twoDimensionalMatrix[i, j]} ");
        }
        Console.WriteLine("\n------------------\n");
    }

    public static void PrintJagged()
    {
        Console.WriteLine("Jagged arrays are arrays of arrays.");
        var jaggedArray = new int[3][];
        Console.WriteLine("new int[3][] - left = outermost dimension - fits three arrays");
        Console.WriteLine("Inner array length is unspecified, as it can differ between arrays.");
        Console.WriteLine("Each inner array is implicitly initialized to null and must be manually created.");
        for (var i = 0; i < jaggedArray.Length; i++)
        {
            jaggedArray[i] = new int[i + 1];
            for (var j = 0; j < jaggedArray[i].Length; j++)
                jaggedArray[i][j] = i * jaggedArray[i].Length + j;
        }
        foreach (var innerArr in jaggedArray)
        {
            Console.WriteLine();
            foreach (var number in innerArr)
                Console.Write($"{number} ");
        }

        Console.WriteLine("Jagged arrays can be initialized with explicit values.");
        Console.WriteLine("new int [][] { new int[] {1, 2, 3}, new int[] {4, 5, 6}};");
        Console.WriteLine("\n------------------\n");
    }
}
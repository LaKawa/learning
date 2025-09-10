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
            
        Console.WriteLine("\n");
    }

}
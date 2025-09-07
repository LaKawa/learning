namespace CSharpInANutshell.Basics;

public static class NumericTypes
{
    // int and long are first-class citizens
    // integral
    private static byte _byte; // 8 bits   Byte
    private static sbyte _sbyte; //          SByte

    private static short _short; // 16 bits  Int16
    private static ushort _ushort; //          UInt16

    private static int _int; // 32 bits  Int32
    private static uint _uint; //          UInt32  U suffix

    private static long _long; // 64 bits  Int64   L suffix
    private static ulong _ulong; //          UInt64  UL suffix

    private static nint _nint; // 32/64 bits IntPtr     
    private static nuint _nuint; // 32/64 bits UIntPtr      

    // real numbers
    private static float _float; // 32 bits          F suffix
    private static double _double; // 64 bits          D suffix
    private static decimal _decimal; // 128 bits     M suffix

    public static void Print()
    {
        PrintSizes();
        PrintSuffixes();
        PrintHexadecimal();
        PrintBinary();
    }


    public static void PrintSizes()
    {
        Console.WriteLine("-----------------------------");
        Console.WriteLine($"Bits in {_byte.GetType()}: {sizeof(byte) * 8}");
        Console.WriteLine($"{_byte.GetType()} - Min: {byte.MinValue:N0} | Max: {byte.MaxValue:N0}");
        Console.WriteLine("-----------------------------");

        Console.WriteLine($"Bits in {_sbyte.GetType()}: {sizeof(sbyte) * 8}");
        Console.WriteLine($"{_sbyte.GetType()} - Min: {sbyte.MinValue} | Max: {sbyte.MaxValue}");
        Console.WriteLine("-----------------------------");

        Console.WriteLine($"Bits in {_short.GetType()}: {sizeof(short) * 8}");
        Console.WriteLine($"{_short.GetType()} - Min: {short.MinValue:N0} | Max: {short.MaxValue:N0}");
        Console.WriteLine("-----------------------------");

        Console.WriteLine($"Bits in {_ushort.GetType()}: {sizeof(ushort) * 8}");
        Console.WriteLine($"{_ushort.GetType()} - Min: {ushort.MinValue:N0} | Max: {ushort.MaxValue:N0}");
        Console.WriteLine("-----------------------------");

        Console.WriteLine($"Bits in {_int.GetType()}: {sizeof(int) * 8}");
        Console.WriteLine($"{_int.GetType()} - Min: {int.MinValue:N0} | Max: {int.MaxValue:N0}");
        Console.WriteLine("-----------------------------");

        Console.WriteLine($"Bits in {_uint.GetType()}: {sizeof(uint) * 8}");
        Console.WriteLine($"{_uint.GetType()} - Min: {uint.MinValue:N0} | Max: {uint.MaxValue:N0}");
        Console.WriteLine("-----------------------------");

        Console.WriteLine($"Bits in {_long.GetType()}: {sizeof(long) * 8}");
        Console.WriteLine($"{_long.GetType()} - Min: {long.MinValue:N0} | Max: {long.MaxValue:N0}");
        Console.WriteLine("-----------------------------");

        Console.WriteLine($"Bits in {_ulong.GetType()}: {sizeof(ulong) * 8}");
        Console.WriteLine($"{_ulong.GetType()} - Min: {ulong.MinValue:N0} | Max: {ulong.MaxValue:N0}");
        Console.WriteLine("-----------------------------");

        Console.WriteLine($"Bits in {_float.GetType()}: {sizeof(float) * 8}");
        Console.WriteLine($"{_float.GetType()} - Min: {float.MinValue:N0} | Max: {float.MaxValue:N0}");
        Console.WriteLine("-----------------------------");

        Console.WriteLine($"Bits in {_double.GetType()}: {sizeof(double) * 8}");
        Console.WriteLine($"{_double.GetType()} - Min: {double.MinValue:N0} \n\nMax: {double.MaxValue:N0}");
        Console.WriteLine("-----------------------------");

        Console.WriteLine($"Bits in {_decimal.GetType()}: {sizeof(decimal) * 8}");
        Console.WriteLine($"{_decimal.GetType()} - Min: {decimal.MinValue:N0} | Max: {decimal.MaxValue:N0}");
        Console.WriteLine("-----------------------------\n\n");
    }

    public static void PrintSuffixes()
    {
        Console.WriteLine($"long: {123L}L");
        Console.WriteLine($"uint: {123U}U");
        Console.WriteLine($"ulong: {123UL}UL");
        Console.WriteLine($"float: {123.456F}F");
        Console.WriteLine($"double: {123.456D}D");
        Console.WriteLine($"decimal: {123.456M}M\n\n");
    }

    public static void PrintHexadecimal()
    {
        Console.WriteLine($"0x7F: {0x7F}\n\n");
    }

    public static void PrintBinary()
    {
        Console.WriteLine($"1100_0010: 0b{0b1100_0010:b8}\n\n");
    }

}
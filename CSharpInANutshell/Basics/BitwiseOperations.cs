namespace CSharpInANutshell.Basics;

public class BitwiseOperations
{
    [Flags]
    enum BitwiseFlagExample{
        None = 0,
        Bold = 1 << 0,
        Italic = 1 << 1,
        Underline = 1 << 2,
        Strikethrough = 1 << 3,
    }
    
    /* ~ complement - ~0xfU = 0xfffffff0U - 32 bit -> 8 hexa-digits
     *                ~0b1110 = 0b0001
     */
    // TODO continue here


    public static void PrintComplement()
    {
        Console.WriteLine("\n~, the complement operator is used to invert all bits of an integral type.");
        Console.WriteLine("~0xfU = 0xfffffff0U - 32 bit -> 8 hexa-digits");
        Console.WriteLine("~0b1110 = 0b0001\n");

        Console.WriteLine("This is useful for inverting masks and some low level tasks.");
        var mask = 0b1111_0000;
        var value = 0b1010_1111;
        var result = value & mask;
        var resultComplement = value & ~mask;
        Console.WriteLine("Mask = 1111_0000");
        Console.WriteLine("Value = 1010_1111");
        Console.WriteLine($"Result Value & Mask = 1010_0000  {result:b8}");
        Console.WriteLine($"Result Value & ~Mask = 0101_1111  {resultComplement:b8}\n");
        Console.WriteLine("---------------------------\n");
    }


    public static void PrintAnd()
    {
        Console.WriteLine("\n&, the bitwise AND operator is used to compare each bit of two numbers.");
        Console.WriteLine("Only keeps the bits that are set in both numbers.");
        Console.WriteLine("0b1010 & 0b0111 = 0b0010\n");

        Console.WriteLine("Useful for \n1) Masking bits:");
        var value = 0b1010_1011;
        var mask = 0b0000_1111;
        var result = value & mask;
        Console.WriteLine($"Value = 1010_1011");
        Console.WriteLine($"Mask = 0000_1111 - this isolates the lowest 4 bits");
        Console.WriteLine($"Result = 0000_1011  {result:b8}");

        Console.WriteLine("\n2) Checking flags:");
        Console.WriteLine("Flag & FlagOption != 0   => FlagOption is set.\n");
        var flags = BitwiseFlagExample.Bold | BitwiseFlagExample.Italic;
        if ((flags & BitwiseFlagExample.Italic) != 0)
        {
            Console.WriteLine("flags = FlagExample.Bold | FlagExample.Italic");
            Console.WriteLine("if(flags & FlagExample.Italic != 0) Italic is set.");
        }
            

        Console.WriteLine("\n3) Clear a specific bit with complement operator:");
        Console.WriteLine("Value = 1111");
        Console.WriteLine("Mask  = 0100");
        Console.WriteLine("Value &= ~Mask = 1011");

        Console.WriteLine("\n4) Optimization of % if dividing by power of 2");
        Console.WriteLine("int y = x % 8    ==>  int y = x & 7;");
        Console.WriteLine("Modern JIT compilers already optimize this under the hood.");
        Console.WriteLine("Can be useful for circular buffers where wrap around happens often.");

        Console.WriteLine("\n5) Logical AND, Comparing booleans without short-circuiting.");
        Console.WriteLine("bool a = false, b = true;");
        Console.WriteLine("(a & b) { // This checks b even if a is false. }");
        Console.WriteLine("Haven't seen a use-case for this yet.\n");
        Console.WriteLine("---------------------------\n\n");

    }

    public static void PrintOr()
    {
        Console.WriteLine("\n|, the bitwise OR operator is used to compare each bit of two numbers.");
        Console.WriteLine("Keeps the bits that are set in either number.");
        Console.WriteLine("0b1010 | 0b0110 = 0b1110\n");
        
        Console.WriteLine("Useful for \n1) Setting flags with combined options:");
        BitwiseFlagExample flags = BitwiseFlagExample.Bold | BitwiseFlagExample.Italic;
        Console.WriteLine("Permissions p = Permission.Read | Permission.Write");

        Console.WriteLine("\n2) Combining masks:");
        Console.WriteLine("mask1 = 0b0000_1111");
        Console.WriteLine("mask2 = 0b1111_0000");
        Console.WriteLine("mask1 | mask2 = 0b1111_1111");

        Console.WriteLine("\n3) Applying masks:");
        Console.WriteLine("int value = 0b1010_0000");
        Console.WriteLine("int mask  = 0b0000_1111");
        Console.WriteLine("value |= mask; // value = 0b1010_1111");

        Console.WriteLine("\n4) Bit level arithmetic tricks:");
        Console.WriteLine("Setting sign bit manually.");
        Console.WriteLine("Packing multiple values into a single integer:");
        Console.WriteLine("byte color = (red << 4 | green; // 2 4-bit values into one byte");

        Console.WriteLine("\n5) Logical OR without short-circuiting, both sides are always evaluated.");
        Console.WriteLine("\n---------------------------\n\n");
    }

    public static void PrintXor()
    {
        Console.WriteLine("\n^, the bitwise XOR operator is used to compare each bit of two numbers.");
        Console.WriteLine("Keeps the bits that are set in one number but not the other.");
        Console.WriteLine("0b1010 ^ 0b0110 = 0b1100\n");

        Console.WriteLine("Use cases:\n1) Toggling bits / flag values:");
        Console.WriteLine("When using a mask all 0 mask bits stay the same, 1 mask bits get toggled.");
        Console.WriteLine("value = 0b1010_0011;");
        Console.WriteLine("mask  = 0b0000_1111");
        Console.WriteLine("value ^ mask = 0b1010_1100");
        Console.WriteLine("This toggles the smallest 4 bits.");

        Console.WriteLine("\n2) Swap two values without temp variable:");
        Console.WriteLine("int a = 5, b = 9; // a = 0101, b = 1001");
        Console.WriteLine("a ^= b; a = 1100 = 12");
        Console.WriteLine("b ^= a; b = 0101 = 5");
        Console.WriteLine("a ^= b; a = 1001 = 9");

        Console.WriteLine("\n3) Check the differing bits in two numbers:");
        Console.WriteLine("int a = 0b1010;");
        Console.WriteLine("int b = 0b1100;");
        Console.WriteLine("diff  = a ^ b; // 0110");

        Console.WriteLine("\n4) Bit-level arithmetic / algorithms:");
        Console.WriteLine("Parity checks, checksums, cryptography, low-level array algorithms.");
        
        Console.WriteLine("\n---------------------------\n\n"); 
    }

    public static void PrintShiftLeftOrRight()
    {
        Console.WriteLine("\n<<, the bitwise shift left operator shifts all bits to the left.");
        Console.WriteLine("0's are inserted on the right side.");
        Console.WriteLine("This effectively multiplies by 2^n where n is the number of shifts.");
        Console.WriteLine("0b0001 << 1 = 0b0010");
        Console.WriteLine("  1   * 2^1 =    2");
        Console.WriteLine("0b0001 << 2 = 0b00100");
        Console.WriteLine("  1   * 2^2 =    4");
        Console.WriteLine("0b1010 << 3 = 0101_0000");
        Console.WriteLine("  10  * 2^3 =    80");
        Console.WriteLine("If overflow happens, leftmost digits are discarded.");
        
        Console.WriteLine("\n>>, the bitwise shift right operator shifts all bits to the right.");
        Console.WriteLine("Unsigned: 0's are inserted on the left side.");
        Console.WriteLine("Signed: fills leftmost bits with sign bit - preserves negative sign");
        Console.WriteLine("This effectively divides by 2^n for positive integers, where n is the number of shifts.");
        Console.WriteLine("int x = 0b0010_1100 // 44");
        Console.WriteLine("int y = x >> 2; // 0b0000_1011 - 11");
        Console.WriteLine("int z = x >> 3; // 0b0000_0101 - 5");
        Console.WriteLine("When shifting unsigned it's like floored division.");
        Console.WriteLine("When shifting signed we eventually reach -1 and stay there forever.");

        Console.WriteLine("\nUse cases:\nAccess, pack or unpack specific bits:");
        Console.WriteLine("byte color = 0b1011_0010");
        Console.WriteLine("int red = (color >> 4) & 0x0F; // extracts high 4 bits");
        Console.WriteLine("int green = color & 0x0F; // extracts low 4 bits");

        Console.WriteLine("\nSince C#11 the >>> operator allows shifting a signed integer without preserving the signed bit.");
        Console.WriteLine("\n---------------------------\n\n"); 
    }
}
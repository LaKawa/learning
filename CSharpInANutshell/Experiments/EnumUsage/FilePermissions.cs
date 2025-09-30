namespace CSharpInANutshell.Experiments.EnumUsage;


// Flags attribute is useful for setting multiple enum values at once
[Flags]
public enum FilePermissions
{
    None = 0,
    Read = 1,
    Write = 1 << 1, // 2
    Execute = 1 << 2, // 4
    Delete = 1 << 3, // 8
    ReadWrite = Read | Write, // 1 | 2 = 3
    ReadExecute = Read | Execute, // 1 | 4 = 5
    ReadWriteExecute = Read | Write | Execute, // 1 | 2 | 4 = 7
    All = Read | Write | Execute | Delete // 1 | 2 | 4 | 8 = 15
}

// flag enums usually use a plural name to avoid confusion with single value enums
namespace CSharpInANutshell.Experiments.StructInterfaceBoxing;

public struct SomeStruct : ITalker
{
    // implicit ITalker implementation
    public void Speak() => Console.Write("Struct speaks!");
}
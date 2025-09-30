namespace CSharpInANutshell.Experiments.StructInterfaceBoxing;

public class Caller
{
    private SomeStruct _someStruct; // new() is redundant, automatically initialized to default values on declaration

    public void BoxingExample()
    {
        _someStruct.Speak(); // no boxing, calling ITalker implementation statically on SomeStruct
        ITalker talker = _someStruct; // this leads to boxing, dynamic calling of ITalker implementation
        talker.Speak();
    }
}
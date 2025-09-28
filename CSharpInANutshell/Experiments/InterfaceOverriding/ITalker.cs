namespace CSharpInANutshell.Experiments.InterfaceOverriding;

public interface ITalker
{
    void Speak()
    {
        PrintType();
        SpeakWithName();
        Console.Write("\"\n");
    }

    void SpeakWithName();

    private void PrintType()
    {
        Console.Write($"{GetType().Name}: \"");
    }
}
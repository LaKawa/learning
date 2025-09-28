using CSharpInANutshell.Experiments.InterfaceOverriding.Animals;

namespace CSharpInANutshell.Experiments.InterfaceOverriding.Robots;

public class Robot : ITalker
{
    public virtual void SpeakWithName()
    {
        Console.Write("Generic robot!");
    }
}
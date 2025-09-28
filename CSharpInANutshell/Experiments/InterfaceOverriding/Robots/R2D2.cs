using CSharpInANutshell.Experiments.InterfaceOverriding.Animals;

namespace CSharpInANutshell.Experiments.InterfaceOverriding.Robots;

public class R2D2 : Robot, ITalker
{
    public new void SpeakWithName()
    {
        Console.Write("Beep boop!");
    }
}
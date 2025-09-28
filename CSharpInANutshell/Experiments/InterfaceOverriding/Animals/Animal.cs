namespace CSharpInANutshell.Experiments.InterfaceOverriding.Animals;

public class Animal : ITalker
{
    public virtual void SpeakWithName()
    {
        Console.Write("I'm an animal, not sure what to say!");
    }
}
namespace CSharpInANutshell.Experiments.InterfaceOverriding.Animals;

public class Chihuahua : Dog
{
    public override void SpeakWithName()
    {
        Console.Write("Annoying chihuahua woof!");
    }
}
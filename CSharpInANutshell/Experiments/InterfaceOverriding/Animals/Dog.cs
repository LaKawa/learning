namespace CSharpInANutshell.Experiments.InterfaceOverriding.Animals;

public class Dog : Animal
{
    public override void SpeakWithName()
    {
        Console.Write("Woof!");
    }
}
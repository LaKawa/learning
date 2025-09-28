using CSharpInANutshell.Experiments.InterfaceOverriding.Animals;
using CSharpInANutshell.Experiments.InterfaceOverriding.Robots;

namespace CSharpInANutshell.Experiments.InterfaceOverriding;

public class Caller
{
    public required Animal Animal { get; init; } = new();
    public required Dog Dog { get; init; } = new();
    public required Chihuahua Chihuahua { get; init; } = new();
    public required ITalker DogTalker { get; set; } = new Dog();
    
    public required Robot RobotBase { get; init; } = new();
    
    // can use a more specific type than base class, calls R2D2 override
    public required Robot RobotDerived { get; init; } = new R2D2();
    public required R2D2 R2D2 { get; init; } = new();

    [System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
    public Caller()
    {
        Console.WriteLine(
            "Used parameterless constructor," +
            " required members were set to default before running the constructor.");
        Console.WriteLine("Parameterless constructor runs both with object initializer and new() syntax.");
    }

    private static void Speak(ITalker talker) => talker.Speak();

    public void PrintExample()
    {
        Speak(Animal);
        Speak(Dog);
        Speak(Chihuahua);
        
        Speak(RobotBase);
        
        // because we use a default implementation in the interface, this still calls the subclass method despite it hiding the base class method
        // usually would call base class method because Derived robot is a Robot here
        Speak(RobotDerived);
        
        Speak(R2D2);
        Speak(DogTalker);
    }
}
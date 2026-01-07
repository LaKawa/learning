namespace CSharpInANutshell.Experiments.Generics;

public class NakedTypeConstraint<T>
{
    private int myInt = 42;

    NakedTypeConstraint<U> SpecializedNakedTypeConstraint<U>() where U : T
    {
        int testInt = 0;
        switch (testInt)
        {
            case 0:
                Console.WriteLine('0');
                goto case 3;
            case 3:
                Console.WriteLine("3!");
                break;
        }
        startLoop:
        if (testInt < 5)
        {
            testInt++;
            goto startLoop;
        }
        return new NakedTypeConstraint<U>();
    }

    enum TestEnum
    {
        None,
        Red,
        Blue
    }
    void Fo(int someInt)
    {
        Console.WriteLine(Enum.IsDefined(typeof(TestEnum), "Red"));
        var anotherInt = 42;
        if (anotherInt > 25) Console.WriteLine("lol");
    }
}
namespace CSharpInANutshell.Basics.NamespaceExample;

public class OuterNamespace
{
    private InnerNamespace.InnerNamespace _inner; // inner namespace has to be imported or fully qualified
    public static int MyInt { get; set; }

    static void NamespaceCollisionExample()
    {
        // because a Console class is defined in our current namespace,
        // we have to specify System.Console from the root namespace with global
        global::System.Console.WriteLine("Printing with global::System.Console.");
        
        // actually global:: is redundant here, as System. has no namespace collision
    }
}
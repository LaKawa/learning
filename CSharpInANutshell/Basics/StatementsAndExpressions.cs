namespace CSharpInANutshell.Basics;

public class StatementsAndExpressions
{
    /* Added most of these as flash cards instead of writing code examples
       as I'm already deeply familiar with the topics, or it's more conceptual.
     */
    public static void PrintFibonacci(int numbers)
    {
        // for loop: initialization clause, condition clause, iteration clause
        for (int i = 0, prevFib = 1, curFib = 1; i < numbers; i++)
        {
            Console.WriteLine($"Iteration {i}: {curFib}");
            try
            {
                var newFib = checked (prevFib + curFib);
                prevFib = curFib;
                curFib = newFib;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow!");
                break;
            }
        }
    }
}
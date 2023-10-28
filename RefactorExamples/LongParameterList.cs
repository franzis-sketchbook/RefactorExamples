namespace RefactorExamples;

public class LongParameterList
{
    public static void LongParameterListMethod(DateOnly From, DateOnly To, string LName, string Price, string CName)
    {
        Console.WriteLine($"{CName} has bought {LName} licenses for {Price} per license between {From} and {To}.");
    }
}

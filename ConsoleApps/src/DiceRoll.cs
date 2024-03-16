namespace ConsoleApps.SourceCode;
public class DiceRoll
{
    public static int Roll(int max)
    {
        return Random.Shared.Next(max) + 1;
    }
}

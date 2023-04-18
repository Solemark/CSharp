namespace ConsoleApps.SourceCode;
public class DiceRoll
{
    public static int diceRoll(int max)
    {
        return Random.Shared.Next(max) + 1;
    }
}

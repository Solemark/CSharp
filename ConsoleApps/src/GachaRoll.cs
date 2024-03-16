namespace ConsoleApps.SourceCode;
public class GachaRoll
{
    public static string Roll(string game)
    {
        return game switch
        {
            "FGO" => Play(100, 100, 5, "FGO"),
            "AK" => Play(50, 100, 6, "AK"),
            "GI" => Play(60, 90, 5, "GI"),
            _ => "Unknown game!",
        };
    }

    private static string Play(int rate, int pity, int rarity, string game, int rolls = 0)
    {
        int roll = Random.Shared.Next(1, rate + 1);
        if (roll == rate)
        {
            return string.Format("It took {0} rolls to get a {1} in {2}", rolls, rarity, game);
        }
        if (rolls == pity)
        {
            return string.Format("You hit pity at {0} rolls for your {1} in {2}", pity, rarity, game);
        }
        return Play(rate, pity, rarity, game, rolls + 1);
    }
}

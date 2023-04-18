namespace ConsoleApps.SourceCode;
public class GachaRoll
{
    public static string gachaRoll(string game)
    {
        int rolls = 0;
        int currentRoll = 0;
        int rate = 0;
        int pity = 0;
        string rarity = "";

        switch (game)
        {
            case "FGO":
                rate = 100;
                pity = 100;
                rarity = "5*";
                break;
            case "AK":
                rate = 50;
                pity = 100;
                rarity = "6*";
                break;
            case "GI":
                rate = 60;
                pity = 90;
                rarity = "5*";
                break;
            default:
                return "Unknown game!";
        }

        while (true)
        {
            rolls++;
            currentRoll = Random.Shared.Next(1, rate + 1);
            if (currentRoll == rate)
            {
                return String.Format("It took {0} rolls to get a {1} in {2}", rolls, rarity, game);
            }
            if (rolls == pity)
            {
                return String.Format("You hit pity at {0} rolls for your {1} in {2}", pity, rarity, game);
            }
        }
    }
}

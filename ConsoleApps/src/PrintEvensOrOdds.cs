namespace ConsoleApps.SourceCode;
public class PrintEvensOrOdds
{
    public static string printEvens(int max)
    {
        string output = "";
        for (int i = 0; i <= max; i++)
        {
            if (i % 2 == 0)
            {
                output += String.Format("{0}\n", i);
            }
        }
        return output;
    }

    public static string printOdds(int max)
    {
        string output = "";
        for (int i = 0; i <= max; i++)
        {
            if (i % 2 != 0)
            {
                output += String.Format("{0}\n", i);
            }
        }
        return output;
    }
}

namespace ConsoleApps.SourceCode;
public class MultiplicationTables
{
    public static List<string> run(int number, int max)
    {
        List<string> output = new List<string>();
        string value = "";
        for (int i = 0; i <= max; i++)
        {
            value = String.Format("{0} x {1} = {2}", number, i, (number * i));
            output.Add(value);
        }
        return output;
    }
}


namespace ConsoleApps.SourceCode;
public class MultiplicationTables
{
    public static List<string> Run(int number, int max, int i = 0, List<string>? output = null)
    {
        output ??= [];
        if (i > max)
        {
            return output;
        }
        output.Add(string.Format("{0} x {1} = {2}", number, i, number * i));
        return Run(number, max, i + 1, output);
    }
}

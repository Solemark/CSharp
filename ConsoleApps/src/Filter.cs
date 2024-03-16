namespace ConsoleApps.SourceCode;
public class Filter
{
    public static List<int> Negative(List<int> input)
    {
        return input.Where(i => i >= 0).ToList();
    }

    public static List<int> Positive(List<int> input)
    {
        return input.Where(i => i <= 0).ToList();
    }
}

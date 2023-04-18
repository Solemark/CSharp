namespace ConsoleApps.SourceCode;
public class FilterNegative
{
    public static List<int> filterNegative(List<int> input)
    {
        input = input.Where(i => i >= 0).ToList();
        return input;
    }
}

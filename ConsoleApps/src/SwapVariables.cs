namespace ConsoleApps.SourceCode;
public class SwapVariables
{
    public static (int, int) Swap(int x, int y)
    {
        (x, y) = (y, x);
        return (x, y);
    }
}

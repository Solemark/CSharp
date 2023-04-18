namespace ConsoleApps.SourceCode;
public class SwapVariables
{
    public static (int, int) run(int x, int y)
    {
        (x, y) = (y, x);
        return (x, y);
    }
}

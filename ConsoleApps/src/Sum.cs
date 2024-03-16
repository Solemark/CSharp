namespace ConsoleApps.SourceCode;
public class Sum
{
    public static int Array(int[] array)
    {
        int total = 0;
        for (int i = 0; i <= array.Length; i++)
        {
            total += i;
        }
        return total;
    }

    public static int List(int[] list)
    {
        int total = 0;
        for (int i = 0; i <= list.Length; i++)
        {
            total += i;
        }
        return total;
    }
}

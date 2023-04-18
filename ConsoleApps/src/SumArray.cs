namespace ConsoleApps.SourceCode;
public class SumArray
{
    public static int sumArray(int[] array)
    {
        int total = 0;
        for (int i = 0; i <= array.Length; i++)
        {
            total += i;
        }
        return total;
    }

    public static int sumList(List<int> list)
    {
        int total = 0;
        for (int i = 0; i <= list.Count; i++)
        {
            total += i;
        }
        return total;
    }
}

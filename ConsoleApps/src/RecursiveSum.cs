namespace ConsoleApps.SourceCode;
public class RecursiveSum
{
    public static int Numbers(int number, int total)
    {
        if (number <= 0)
        {
            return total;
        }
        else
        {
            total += number;
            return Numbers(number - 1, total);
        }
    }

    public static int Array(int[] list, int number, int total)
    {
        if (number <= 0)
        {
            return total;
        }
        else
        {
            total += list[number - 1];
            return Array(list, number - 1, total);
        }
    }
}

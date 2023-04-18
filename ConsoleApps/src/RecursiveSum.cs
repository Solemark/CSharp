namespace ConsoleApps.SourceCode;
public class RecursiveSum
{
    public static int sumNumbers(int number, int total)
    {
        if (number <= 0)
        {
            return total;
        }
        else
        {
            total += number;
            return sumNumbers(number - 1, total);
        }
    }

    public static int sumArray(List<int> list, int number, int total)
    {
        if (number <= 0)
        {
            return total;
        }
        else
        {
            total += list[number - 1];
            return sumArray(list, number - 1, total);
        }
    }
}

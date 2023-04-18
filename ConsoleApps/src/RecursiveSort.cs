namespace ConsoleApps.SourceCode;
public class RecursiveSort
{
    public static List<int> insertionSort(List<int> list, int count)
    {
        if (count <= 1)
        {
            return list;
        }
        else
        {
            insertionSort(list, count - 1);
            int current = list[count - 1];
            int i = count - 2;
            while (i >= 0 && list[i] > current)
            {
                list[i + 1] = list[i];
                i--;
                list[i + 1] = current;
            }
        }
        return list;
    }
}

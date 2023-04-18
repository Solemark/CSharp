namespace ConsoleApps.SourceCode;
public class ReverseArray
{
    public static int[] reverseArray(int[] array)
    {
        int end = array.Length - 1;
        int x = 0;
        int y = 0;
        for (int i = 0; i <= end; i++, end--)
        {
            x = array[i];
            y = array[end];
            array[i] = y;
            array[end] = x;
        }
        return array;
    }

    public static List<int> reverseList(List<int> list)
    {
        int end = list.Count - 1;
        int x = 0;
        int y = 0;
        for (int i = 0; i <= end; i++, end--)
        {
            x = list[i];
            y = list[end];
            list[i] = y;
            list[end] = x;
        }
        return list;
    }
}
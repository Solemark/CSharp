namespace ConsoleApps.SourceCode;
public class RecursiveSort
{
    public static int[] insertionSort(int[] input, int count)
    {
        if (count <= 1)
        {
            return input;
        }
        else
        {
            insertionSort(input, count - 1);
            int current = input[count - 1];
            int i = count - 2;
            while (i >= 0 && input[i] > current)
            {
                input[i + 1] = input[i];
                i--;
                input[i + 1] = current;
            }
        }
        return input;
    }
}

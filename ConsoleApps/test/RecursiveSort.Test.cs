namespace ConsoleApps.Unittest;
public class TestRecursiveSort
{
    [Fact]
    public void TestInsertionSort()
    {
        int[] input = new int[] { 9, 7, 5, 3, 1, 8, 6, 4, 2, 0 };
        int[] expect = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] result = RecursiveSort.insertionSort(input, input.Length);
        Assert.Equal(expect, result);
    }
}

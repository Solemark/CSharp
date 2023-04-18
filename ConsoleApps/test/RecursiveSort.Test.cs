namespace ConsoleApps.Unittest;
public class TestRecursiveSort
{
    [Fact]
    public void TestInsertionSort()
    {
        List<int> expect = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        List<int> list = new List<int>() { 9, 7, 5, 3, 1, 8, 6, 4, 2, 0 };
        List<int> result = RecursiveSort.insertionSort(list, list.Count);
        Assert.Equal(expect, result);
    }
}

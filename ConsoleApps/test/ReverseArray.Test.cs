namespace ConsoleApps.Unittest;
public class TestReverseArray
{
    [Fact]
    public void TestReverseArrayFunction()
    {
        int[] expect = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] arr = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        int[] result = ReverseArray.reverseArray(arr);
        Assert.Equal(expect, result);
    }

    [Fact]
    public void TestReverseList()
    {
        List<int> expect = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> list = new List<int>() { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        List<int> result = ReverseArray.reverseList(list);
        Assert.Equal(expect, result);
    }
}

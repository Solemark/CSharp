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
        int[] input = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        int[] expect = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] result = ReverseArray.reverseList(input);
        Assert.Equal(expect, result);
    }
}

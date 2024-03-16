namespace ConsoleApps.Unittest;
public class TestReverse
{
    [Fact]
    public void TestReverseArrayFunction()
    {
        int[] expect = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        int[] arr = [10, 9, 8, 7, 6, 5, 4, 3, 2, 1];
        int[] result = Reverse.Array(arr);
        Assert.Equal(expect, result);
    }

    [Fact]
    public void TestReverseList()
    {
        int[] input = [10, 9, 8, 7, 6, 5, 4, 3, 2, 1];
        int[] expect = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        int[] result = Reverse.List(input);
        Assert.Equal(expect, result);
    }
}

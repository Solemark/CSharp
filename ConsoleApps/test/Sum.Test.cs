namespace ConsoleApps.Unittest;
public class TestSum
{
    [Fact]
    public void TestSumArrayFunction()
    {
        int expect = 55;
        int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        int result = Sum.Array(arr);

        Assert.Equal(expect, result);
    }

    [Fact]
    public void TestSumListFunction()
    {
        int expect = 55;
        int[] list = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        int result = Sum.List(list);

        Assert.Equal(expect, result);
    }
}

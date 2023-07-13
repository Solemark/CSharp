namespace ConsoleApps.Unittest;
public class TestSumArray
{
    [Fact]
    public void TestSumArrayFunction()
    {
        int expect = 55;
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int result = SumArray.sumArray(arr);

        Assert.Equal(expect, result);
    }

    [Fact]
    public void TestSumListFunction()
    {
        int expect = 55;
        int[] list = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int result = SumArray.sumList(list);

        Assert.Equal(expect, result);
    }
}

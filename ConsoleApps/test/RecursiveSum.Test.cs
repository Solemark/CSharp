namespace ConsoleApps.Unittest;
public class TestRecursiveSum
{
    [Fact]
    public void TestRecursiveSumNumbers()
    {
        int expect = 55;
        int result = RecursiveSum.sumNumbers(10, 0);
        Assert.Equal(expect, result);
    }

    [Fact]
    public void TestRecursiveSumArray()
    {
        int expect = 55;
        int result = RecursiveSum.sumArray(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 10, 0);
        Assert.Equal(expect, result);
    }
}

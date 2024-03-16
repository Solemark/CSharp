namespace ConsoleApps.Unittest;
public class TestRecursiveSum
{
    [Fact]
    public void TestRecursiveSumNumbers()
    {
        int expect = 55;
        int result = RecursiveSum.Numbers(10, 0);
        Assert.Equal(expect, result);
    }

    [Fact]
    public void TestRecursiveSumArray()
    {
        int[] input = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        int expect = 55;
        int result = RecursiveSum.Array(input, 10, 0);
        Assert.Equal(expect, result);
    }
}

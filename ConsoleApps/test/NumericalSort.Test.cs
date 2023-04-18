namespace ConsoleApps.Unittest;
public class TestNumericalSort
{
    [Fact]
    public void TestNumericalSortArray()
    {
        List<int> input = new List<int>() { 5, 3, 6, 7, 8, 9, 1, 4, 10, 2 };
        List<int> expect = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> result = NumericalSort.run(input);
        Assert.Equal(expect, result);
    }
}

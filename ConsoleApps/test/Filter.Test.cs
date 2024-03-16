namespace ConsoleApps.Unittest;
public class TestFilter
{
    [Fact]
    public void TestFilterNegativeItemsFromList()
    {
        List<int> expect = [1, 8, 4, 9, 10];
        List<int> result = Filter.Negative([1, -2, -3, -6, -7, 8, 4, 9, 10, -5]);

        Assert.Equal(expect, result);
    }

    [Fact]
    public void TestFilterPositiveItemsFromList()
    {
        List<int> expect = [-2, -3, -6, -7, -5];
        List<int> result = Filter.Positive([1, -2, -3, -6, -7, 8, 4, 9, 10, -5]);

        Assert.Equal(expect, result);
    }
}

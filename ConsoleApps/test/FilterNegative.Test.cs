namespace ConsoleApps.Unittest;
public class TestFilterNegative
{
    [Fact]
    public void TestFilterNegativeItemsFromList()
    {
        List<int> expect = new List<int>() { 1, 8, 4, 9, 10 };
        List<int> result = FilterNegative.filterNegative(new List<int>() { 1, -2, -3, -6, -7, 8, 4, 9, 10, -5 });

        Assert.Equal(expect, result);
    }
}

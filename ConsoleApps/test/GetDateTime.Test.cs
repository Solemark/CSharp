namespace ConsoleApps.Unittest;
public class TestGetDateTime
{
    [Fact]
    public void TestGetDayReturns22nd()
    {
        const string expect = "22nd";
        string result = GetDateTime.getDay(22);
        Assert.Equal(expect, result);
    }

    [Fact]
    public void TestGetMonthReturnsApril()
    {
        const string expect = "April";
        string result = GetDateTime.getMonth(4);
        Assert.Equal(expect, result);
    }

    [Fact]
    public void TestGetCurrentDate()
    {
        const string expect = "It is Thursday the 23rd of March, 2023";
        string result = GetDateTime.checkDate();
        Assert.Equal(expect, result);
    }
}

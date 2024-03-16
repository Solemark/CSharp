namespace ConsoleApps.Unittest;
public class TestGetDateTime
{
    [Fact]
    public void TestGetDayReturns22nd()
    {
        const string expect = "22nd";
        string result = GetDateTime.GetDay(22);
        Assert.Equal(expect, result);
    }

    [Fact]
    public void TestGetMonthReturnsApril()
    {
        const string expect = "April";
        string result = GetDateTime.GetMonth(4);
        Assert.Equal(expect, result);
    }

    [Fact]
    public void TestGetCurrentDate()
    {
        DateTime date = DateTime.Now;
        string expect = string.Format(
            "It is {0} the {1} of {2}, {3}",
            date.DayOfWeek,
            GetDateTime.GetDay(date.Day),
            GetDateTime.GetMonth(date.Month),
            date.Year
        );
        string result = GetDateTime.CheckDate();
        Assert.Equal(expect, result);
    }
}

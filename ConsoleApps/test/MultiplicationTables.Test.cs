namespace ConsoleApps.Unittest;
public class TestMultiplicationTables
{
    [Fact]
    public void TestSixTimesTables()
    {
        List<string> expect = new List<string>(){
            "6 x 0 = 0",
            "6 x 1 = 6",
            "6 x 2 = 12",
            "6 x 3 = 18",
            "6 x 4 = 24",
            "6 x 5 = 30",
            "6 x 6 = 36",
            "6 x 7 = 42",
            "6 x 8 = 48",
            "6 x 9 = 54",
            "6 x 10 = 60",
            "6 x 11 = 66",
            "6 x 12 = 72",
        };
        List<string> result = MultiplicationTables.run(6, 12);
        Assert.Equal(expect, result);
    }
}
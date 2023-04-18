namespace ConsoleApps.Unittest;
public class TestPrintEvensOrOdds
{
    [Fact]
    public void TestPrintEvens()
    {
        string expect = "0\n2\n4\n6\n8\n10\n";
        string result = PrintEvensOrOdds.printEvens(10);
        Assert.Equal(expect, result);
    }

    [Fact]
    public void TestPrintOdds()
    {
        string expect = "1\n3\n5\n7\n9\n";
        string result = PrintEvensOrOdds.printOdds(10);
        Assert.Equal(expect, result);
    }
}

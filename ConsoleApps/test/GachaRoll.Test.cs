namespace ConsoleApps.Unittest;
public class TestGachaRoll
{
    [Fact]
    public void TestGachaRollFGO()
    {
        const string expect = "FGO";
        string result = GachaRoll.gachaRoll(expect);
        Assert.Contains(expect, result);
    }

    [Fact]
    public void TestGachaRollAK()
    {
        const string expect = "AK";
        string result = GachaRoll.gachaRoll(expect);
        Assert.Contains(expect, result);
    }

    [Fact]
    public void TestGachaRollGI()
    {
        const string expect = "GI";
        string result = GachaRoll.gachaRoll(expect);
        Assert.Contains(expect, result);
    }
}

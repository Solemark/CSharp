namespace ConsoleApps.Unittest;
public class TestGachaRoll
{
    private static string[] GetData()
    {
        return ["FGO", "AK", "GI"];
    }

    [Fact]
    public void TestGachaRollGame()
    {
        string[] data = GetData();
        foreach (string item in data)
        {
            string result = GachaRoll.Roll(item);
            Assert.Contains(item, result);
        }
    }
}

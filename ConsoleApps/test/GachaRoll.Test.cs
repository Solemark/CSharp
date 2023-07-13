namespace ConsoleApps.Unittest;
public class TestGachaRoll
{
    private string[] getData()
    {
        return new string[] { "FGO", "AK", "GI" };
    }

    [Fact]
    public void testGachaRoll()
    {
        string[] data = getData();
        foreach (string item in data)
        {
            string result = GachaRoll.gachaRoll(item);
            Assert.Contains(item, result);
        }
    }
}

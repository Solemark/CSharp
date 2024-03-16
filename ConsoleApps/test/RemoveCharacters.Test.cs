namespace ConsoleApps.Unittest;
public class TestRemoveCharacters
{
    [Fact]
    public void TestRemoveCharactersFromString()
    {
        string expect = "HeoWord";
        string result = RemoveCharacters.Run("Hello World", ["l", " "]);
        Assert.Equal(expect, result);
    }
}

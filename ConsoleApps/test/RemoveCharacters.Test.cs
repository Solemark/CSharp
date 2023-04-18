namespace ConsoleApps.Unittest;
public class TestRemoveCharacters
{
    [Fact]
    public void TestRemoveCharactersFromString()
    {
        string expect = "HeoWord";
        string result = RemoveCharacters.run("Hello World", new List<string>() { "l", " " });
        Assert.Equal(expect, result);
    }
}

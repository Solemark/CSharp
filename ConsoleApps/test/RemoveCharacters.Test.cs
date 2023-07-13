namespace ConsoleApps.Unittest;
public class TestRemoveCharacters
{
    [Fact]
    public void TestRemoveCharactersFromString()
    {
        string expect = "HeoWord";
        string result = RemoveCharacters.run("Hello World", new string[] { "l", " " });
        Assert.Equal(expect, result);
    }
}

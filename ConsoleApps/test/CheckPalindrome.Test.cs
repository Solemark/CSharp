namespace ConsoleApps.Unittest;
public class TestCheckPalindrome
{
    [Fact]
    public void TestPalindrome()
    {
        bool result = CheckPalindrome.run("DAD");
        Assert.True(result, "Expected: true, recieved: false");
    }

    [Fact]
    public void TestPalindromeCaseSensitive()
    {
        bool result = CheckPalindrome.run("Dad");
        Assert.False(result, "Expected: false, recieved: true");
    }
}

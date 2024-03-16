namespace ConsoleApps.Unittest;
public class TestCheckPalindrome
{
    [Fact]
    public void TestPalindrome()
    {
        bool result = CheckPalindrome.Check("DAD");
        Assert.True(result, "Expected: true, recieved: false");
    }

    [Fact]
    public void TestPalindromeCaseSensitive()
    {
        bool result = CheckPalindrome.Check("Dad");
        Assert.False(result, "Expected: false, recieved: true");
    }
}

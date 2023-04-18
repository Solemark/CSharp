namespace ConsoleApps.Unittest;
public class TestHelloWorld
{
    [Fact]
    public void TestHelloWorldString()
    {
        string expect = "Hello World! How are you today?";
        string result = HelloWorld.Greet();
        Assert.Equal(expect, result);
    }
}

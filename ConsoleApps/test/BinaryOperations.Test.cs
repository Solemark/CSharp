namespace ConsoleApps.Unittest;
public class TestBinaryOperations
{
    [Fact]
    public void TestBinaryAdditionPositive()
    {
        string expect = "1010";
        string result = BinaryOperations.BinaryAddition("101", "101");
        Assert.Equal(expect, result);
    }

    [Fact]
    public void TestBinaryAdditionNegative()
    {
        string expect = "11111111111110110";
        string result = BinaryOperations.BinaryAddition("1111111111111011", "1111111111111011");
        Assert.Equal(expect, result);
    }

    [Fact]
    public void TestBinarySubtractionPositive()
    {
        string expect = "0";
        string result = BinaryOperations.BinarySubtraction("101", "101");
        Assert.Equal(expect, result);
    }

    [Fact]
    public void TestBinarySubtractionNegative()
    {
        string expect = "1111111111110110";
        string result = BinaryOperations.BinarySubtraction("1111111111111011", "1111111111111011");
        Assert.Equal(expect, result);
    }
}

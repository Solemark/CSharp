namespace ConsoleApps.Unittest;
public class TestSwapVariables
{
    [Fact]
    public void TestSwapVariablesFunction()
    {
        (int, int) expect = (2, 1);
        (int, int) result = SwapVariables.Swap(1, 2);
        Assert.Equal(expect, result);
    }
}

namespace ConsoleApps.Unittest;
public class TestDiceRoll
{
    private static int[] GetTestData()
    {
        return [20, 10, 8, 6, 4];
    }

    [Fact]
    public void testDiceRoll()
    {
        int[] data = GetTestData();
        foreach (var number in data)
        {
            int expect = number;
            int result = DiceRoll.Roll(number);
            Assert.InRange(result, 1, expect);
        }
    }
}

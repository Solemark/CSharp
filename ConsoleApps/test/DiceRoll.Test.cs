namespace ConsoleApps.Unittest;
public class TestDiceRoll
{
    private int[] getTestData()
    {
        return new int[] { 20, 10, 8, 6, 4 };
    }

    [Fact]
    public void testDiceRoll()
    {
        int[] data = getTestData();
        foreach (var number in data)
        {
            int expect = number;
            int result = DiceRoll.diceRoll(number);
            Assert.InRange(result, 1, expect);
        }
    }
}

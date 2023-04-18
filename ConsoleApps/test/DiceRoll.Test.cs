namespace ConsoleApps.Unittest;
public class TestDiceRoll
{
    [Fact]
    public void TestD20()
    {
        int expect = 20;
        int result = DiceRoll.diceRoll(expect);

        Assert.InRange(result, 1, expect);
    }

    [Fact]
    public void TestD10()
    {
        int expect = 10;
        int result = DiceRoll.diceRoll(expect);

        Assert.InRange(result, 1, expect);
    }

    [Fact]
    public void TestD8()
    {
        int expect = 8;
        int result = DiceRoll.diceRoll(expect);

        Assert.InRange(result, 1, expect);
    }

    [Fact]
    public void TestD6()
    {
        int expect = 6;
        int result = DiceRoll.diceRoll(expect);

        Assert.InRange(result, 1, expect);
    }

    [Fact]
    public void TestD4()
    {
        int expect = 4;
        int result = DiceRoll.diceRoll(expect);

        Assert.InRange(result, 1, expect);
    }
}

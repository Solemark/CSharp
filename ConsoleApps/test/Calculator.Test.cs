namespace ConsoleApps.Unittest;
public class TestCalculator
{
    [Fact]
    public void TestAdditionIsPositive()
    {
        float expect = 10;
        float result = Calculator.addition(5, 5);

        Assert.Equal(expect, result);
    }

    [Fact]
    public void TestAdditionIsNegative()
    {
        float expect = -10;
        float result = Calculator.addition(-5, -5);

        Assert.Equal(expect, result);
    }

    [Fact]
    public void TestSubtractionIsPositive()
    {
        float expect = 0;
        float result = Calculator.subtraction(5, 5);

        Assert.Equal(expect, result);
    }

    [Fact]
    public void TestSubtractionIsNegative()
    {
        float expect = 0;
        float result = Calculator.subtraction(-5, -5);

        Assert.Equal(expect, result);
    }

    [Fact]
    public void TestMultiplicationIsPositive()
    {
        float expect = 25;
        float result = Calculator.multiplication(5, 5);

        Assert.Equal(expect, result);
    }

    [Fact]
    public void TestMultiplicationIsNegative()
    {
        float expect = 25;
        float result = Calculator.multiplication(-5, -5);

        Assert.Equal(expect, result);
    }

    [Fact]
    public void TestDivisionIsPositive()
    {
        float expect = 1;
        float result = Calculator.division(5, 5);

        Assert.Equal(expect, result);
    }

    [Fact]
    public void TestDivisionIsNegative()
    {
        float expect = 1;
        float result = Calculator.division(-5, -5);

        Assert.Equal(expect, result);
    }
}

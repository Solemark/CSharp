namespace ConsoleApps.Unittest;
public class TestCalculator
{
    private static float[][] getTestData()
    {
        return [
            [5, 5],
            [5, -5],
            [-5, -5]
        ];
    }

    [Fact]
    public void TestAddition()
    {
        float[][] data = getTestData();
        foreach (var item in data)
        {
            float expect = item[0] + item[1];
            float result = Calculator.Addition(item[0], item[1]);
            Assert.Equal(expect, result);
        }
    }
    [Fact]
    public void TestSubtraction()
    {
        float[][] data = getTestData();
        foreach (var item in data)
        {
            float expect = item[0] - item[1];
            float result = Calculator.Subtraction(item[0], item[1]);
            Assert.Equal(expect, result);
        }
    }

    [Fact]
    public void TestMultiplication()
    {
        float[][] data = getTestData();
        foreach (var item in data)
        {
            float expect = item[0] * item[1];
            float result = Calculator.Multiplication(item[0], item[1]);
            Assert.Equal(expect, result);
        }
    }

    [Fact]
    public void TestDivision()
    {
        float[][] data = getTestData();
        foreach (var item in data)
        {
            float expect = item[0] / item[1];
            float result = Calculator.Division(item[0], item[1]);
            Assert.Equal(expect, result);
        }
    }
}

namespace ConsoleApps.Unittest;
public class TestCalculator
{
    private float[][] getTestData()
    {
        return new float[][]{
            new float[]{5, 5},
            new float[]{5, -5},
            new float[]{-5, -5}
        };
    }

    [Fact]
    public void testAddition()
    {
        float[][] data = getTestData();
        foreach (var item in data)
        {
            float expect = item[0] + item[1];
            float result = Calculator.addition(item[0], item[1]);
            Assert.Equal(expect, result);
        }
    }
    [Fact]
    public void testSubtraction()
    {
        float[][] data = getTestData();
        foreach (var item in data)
        {
            float expect = item[0] - item[1];
            float result = Calculator.subtraction(item[0], item[1]);
            Assert.Equal(expect, result);
        }
    }

    [Fact]
    public void testMultiplication()
    {
        float[][] data = getTestData();
        foreach (var item in data)
        {
            float expect = item[0] * item[1];
            float result = Calculator.multiplication(item[0], item[1]);
            Assert.Equal(expect, result);
        }
    }

    [Fact]
    public void testDivision()
    {
        float[][] data = getTestData();
        foreach (var item in data)
        {
            float expect = item[0] / item[1];
            float result = Calculator.division(item[0], item[1]);
            Assert.Equal(expect, result);
        }
    }
}

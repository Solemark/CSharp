namespace ConsoleApps.Unittest;
public class TestCircles
{
    [Fact]
    public void TestCorrectCircleCircumference()
    {
        float expect = (float)62.8318558;
        float result = Circles.getCircumference(10);
        Assert.Equal(expect, result);
    }

    [Fact]
    public void TestZeroCircleCircumference()
    {
        float expect = 0;
        float result = Circles.getCircumference(0);
        Assert.Equal(expect, result);
    }

    [Fact]
    public void TestOneCircleCircumference()
    {
        float expect = (float)(Math.PI * 2);
        float result = Circles.getCircumference(1);
        Assert.Equal(expect, result);
    }

    [Fact]
    public void TestCorrectCircleArea()
    {
        float expect = (float)314.159271;
        float result = Circles.getArea(10);
        Assert.Equal(expect, result);
    }

    [Fact]
    public void TestZeroCircleArea()
    {
        float expect = 0;
        float result = Circles.getArea(0);
        Assert.Equal(expect, result);
    }

    [Fact]
    public void TestOneCircleArea()
    {
        float expect = (float)Math.PI;
        float result = Circles.getArea(1);
        Assert.Equal(expect, result);
    }
}

namespace ConsoleApps.Unittest;
public class TestCircles
{
    private static float[][] GetTestCircumferenceData()
    {
        return [
            [62.8318558F, 10],
            [0F, 0],
            [((float)Math.PI * 2), 1],
        ];
    }

    private static float[][] GetTestAreaData()
    {
        return [
            [314.159271F, 10],
            [0, 0],
            [(float)Math.PI, 1],
        ];
    }

    [Fact]
    public void TestGetCircumference()
    {
        float[][] data = GetTestCircumferenceData();
        foreach (var item in data)
        {
            float expect = item[0];
            float result = Circles.GetCircumference(item[1]);
            Assert.Equal(expect, result);
        }
    }

    [Fact]
    public void TestGetArea()
    {
        float[][] data = GetTestAreaData();
        foreach (var item in data)
        {
            float expect = item[0];
            float result = Circles.GetArea(item[1]);
            Assert.Equal(expect, result);
        }
    }
}

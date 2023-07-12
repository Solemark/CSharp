namespace ConsoleApps.Unittest;
public class TestCircles
{
    private float[][] getTestCircumferenceData()
    {
        return new float[][]{
            new float[]{62.8318558F, 10},
            new float[]{0F, 0},
            new float[]{((float)Math.PI * 2), 1},
        };
    }

    private float[][] getTestAreaData()
    {
        return new float[][]{
            new float[]{314.159271F, 10},
            new float[]{0, 0},
            new float[]{(float)Math.PI, 1},
        };
    }

    [Fact]
    public void testGetCircumference()
    {
        float[][] data = getTestCircumferenceData();
        foreach (var item in data)
        {
            float expect = item[0];
            float result = Circles.getCircumference(item[1]);
            Assert.Equal(expect, result);
        }
    }

    [Fact]
    public void testGetArea()
    {
        float[][] data = getTestAreaData();
        foreach (var item in data)
        {
            float expect = item[0];
            float result = Circles.getArea(item[1]);
            Assert.Equal(expect, result);
        }
    }
}

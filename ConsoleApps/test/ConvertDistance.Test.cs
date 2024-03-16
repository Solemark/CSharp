namespace ConsoleApps.Unittest;
public class TestConvertDistance
{
    [Fact]
    public void TestConvertKmToMiles()
    {
        float expect = (float)6.213712;
        float result = ConvertDistance.Convert(10);
        Assert.Equal(expect, result);
    }

    [Fact]
    public void TestConvertMilesToKm()
    {
        float expect = (float)16.0934391;
        float result = ConvertDistance.Convert(10, "mtk");
        Assert.Equal(expect, result);
    }
}

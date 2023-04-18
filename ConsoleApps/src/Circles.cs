namespace ConsoleApps.SourceCode;
public class Circles
{
    public static float getCircumference(float radius)
    {
        if (radius <= 0)
        {
            return 0;
        }
        else
        {
            return 2 * float.Pi * radius;
        }
    }

    public static float getArea(float radius)
    {
        if (radius <= 0)
        {
            return 0;
        }
        else
        {
            return float.Pi * (radius * radius);
        }
    }
}

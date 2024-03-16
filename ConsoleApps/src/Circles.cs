namespace ConsoleApps.SourceCode;
public class Circles
{
    public static float GetCircumference(float radius)
    {
        return radius <= 0 ? 0 : 2 * float.Pi * radius;
    }

    public static float GetArea(float radius)
    {
        return radius <= 0 ? 0 : float.Pi * (radius * radius);
    }
}

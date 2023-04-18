namespace ConsoleApps.SourceCode;
public class ConvertDistance
{
    public static float run(float distance, string key = "ktm")
    {
        if (key == "ktm")
        {
            return (float)(distance * 0.6213712);
        }
        else
        {
            return (float)(distance * 1.609344);
        }
    }
}

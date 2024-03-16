namespace ConsoleApps.SourceCode;
public class ConvertDistance
{
    public static float Convert(float distance, string key = "ktm")
    {
        return key == "ktm" ? (float)(distance * 0.6213712) : (float)(distance * 1.609344);
    }
}

namespace ConsoleApps.SourceCode;
public class RemoveCharacters
{
    public static string run(string str, string[] characters)
    {
        foreach (var character in characters)
        {
            str = str.Replace(character, "");
        }
        return str;
    }
}

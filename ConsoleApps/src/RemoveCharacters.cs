namespace ConsoleApps.SourceCode;
public class RemoveCharacters
{
    public static string Run(string str, string[] characters)
    {
        foreach (string character in characters)
        {
            str = str.Replace(character, "");
        }
        return str;
    }
}

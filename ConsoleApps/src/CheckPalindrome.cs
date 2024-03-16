namespace ConsoleApps.SourceCode;
public class CheckPalindrome
{
    public static bool Check(string str)
    {
        int c = str.Length - 1;
        for (int i = 0; i < c; i++, c--)
        {
            if (str[i] != str[c])
            {
                return false;
            }
        }
        return true;
    }
}

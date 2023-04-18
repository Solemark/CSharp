namespace ConsoleApps.SourceCode;
public class BinaryOperations
{
    public static string BinaryAddition(string a, string b)
    {
        int x = Convert.ToInt32(a, 2);
        int y = Convert.ToInt32(b, 2);
        return Convert.ToString((x + y), 2);
    }

    public static string BinarySubtraction(string a, string b)
    {
        int x = Convert.ToInt32(a, 2);
        int y = Convert.ToInt32(b, 2);
        return Convert.ToString((x - y), 2);
    }

    public static string BinaryMultiplication(string a, string b)
    {
        int x = Convert.ToInt32(a, 2);
        int y = Convert.ToInt32(b, 2);
        return Convert.ToString((x * y), 2);
    }

    public static string BinaryDivision(string a, string b)
    {
        int x = Convert.ToInt32(a, 2);
        int y = Convert.ToInt32(b, 2);
        return Convert.ToString((x / y), 2);
    }
}

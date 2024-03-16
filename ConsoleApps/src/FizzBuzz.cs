namespace ConsoleApps.SourceCode;
public class FizzBuzz
{
    public static string Play(int fizz, int buzz, int max, int i = 1, string output = "")
    {
        if (i > max)
        {
            return output;
        }
        string nstr = "";
        nstr += 0 == i % fizz ? "fizz" : "";
        nstr += 0 == i % buzz ? "buzz" : "";
        nstr += nstr == "" ? string.Format("{0}\n", i) : "\n";
        return Play(fizz, buzz, max, i + 1, output + nstr);
    }
}

namespace ConsoleApps.SourceCode;
public class FizzBuzz
{
    public static string fizzBuzz(int fizz, int buzz, int max)
    {
        string output = "";
        bool flag = false;
        for (int i = 1; i <= max; i++)
        {
            flag = false;
            if (0 == i % fizz)
            {
                flag = true;
                output += "fizz";
            }
            if (0 == i % buzz)
            {
                flag = true;
                output += "buzz";
            }
            if (!flag)
            {
                output += "" + i;
            }
            output += "\n";
        }
        return output;
    }
}

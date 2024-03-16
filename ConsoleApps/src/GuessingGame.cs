namespace ConsoleApps.SourceCode;
public class GuessingGame
{
    public static int GetNumber(int maxNumber)
    {
        return Random.Shared.Next(1, maxNumber + 1);
    }

    public static void Cli()
    {
        const int maxNumber = 100;
        int number = GetNumber(maxNumber);
        int input = 0;

        Console.WriteLine(string.Format("Enter a number between 1 & {0}", maxNumber));

        while (true)
        {
            Console.WriteLine("Enter your guess: ");
            input = int.Parse(Console.ReadLine() ?? "0");
            if (input == number)
            {
                Console.WriteLine("You win!");
                break;
            }
            if (input < number)
            {
                Console.WriteLine("Higher!");
            }
            else
            {
                Console.WriteLine("Lower!");
            }
        }
    }
}

namespace ConsoleApps.SourceCode;
public class GuessingGame
{
    public static int getNumber(int maxNumber)
    {
        return Random.Shared.Next(1, maxNumber + 1);
    }
    public static void cli()
    {
        const int maxNumber = 100;
        int number = getNumber(maxNumber);
        int? input = 0;

        Console.WriteLine(String.Format("Enter a number between 1 & {0}", maxNumber));

        while (true)
        {
            Console.WriteLine("Enter your guess: ");
            input = Int32.Parse(Console.ReadLine());
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

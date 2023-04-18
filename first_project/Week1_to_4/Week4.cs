namespace Program;
internal class Week4
{
    public static void run()
    {
        const int c = 3;
        int mark;
        int total = 0;
        string? name;
        float avgMark;

        Console.WriteLine("Mark Entry System\n");

        for (int i = 0; i < c; i++)
        {
            Console.Write("Enter student name: ");
            name = Console.ReadLine();

            Console.Write("Enter student mark (0-100): ");
            mark = Int32.Parse(Console.ReadLine());

            if (mark <= 49)
                Console.WriteLine("Student has failed (F)");
            else if (mark <= 64)
                Console.WriteLine("Student has passed (P)");
            else if (mark <= 64)
                Console.WriteLine("Student has recieved a Credit (C)");
            else if (mark <= 64)
                Console.WriteLine("Student has recieved a Distinction (D)");
            else
                Console.WriteLine("Student has recieved a High Distinction (HD)");
            total += mark;
        }
        avgMark = (float)(total / c);
        Console.WriteLine(String.Format("The average student mark is {0}", avgMark));
    }
}
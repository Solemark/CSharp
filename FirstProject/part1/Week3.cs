namespace Program;
internal class Week3
{
    public static void run()
    {
        int? grade = 0;

        Console.Write("Enter the student's grade (0-100)");
        grade = Int32.Parse(Console.ReadLine() ?? "0");

        if (grade <= 49)
            Console.WriteLine("Student has failed (F)");
        else if (grade <= 64)
            Console.WriteLine("Student has passed (P)");
        else if (grade <= 64)
            Console.WriteLine("Student has recieved a Credit (C)");
        else if (grade <= 64)
            Console.WriteLine("Student has recieved a Distinction (D)");
        else
            Console.WriteLine("Student has recieved a High Distinction (HD)");
    }
}

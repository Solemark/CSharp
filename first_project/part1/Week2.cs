namespace Program;
internal class Week2
{
    public static void run()
    {
        const int max_marks = 65;
        string? name;
        int? mark;
        int percentage = 0;

        Console.Write("Enter student name: ");
        name = Console.ReadLine();

        Console.Write(String.Format("Enter {0}'s mark out of {1}: ", name, max_marks));
        mark = Int32.Parse(Console.ReadLine());

        percentage = (int)((mark * 100) / max_marks);
        Console.WriteLine(String.Format("{0} recieved {1}% of total marks", name, percentage));
    }
}
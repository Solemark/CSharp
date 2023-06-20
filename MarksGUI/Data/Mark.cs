namespace MarksGUI.Data;

public class Mark
{
    public string? studentName { get; set; }
    public int? studentMark { get; set; }

    public string getGrade(int? mark)
    {
        if (mark < 50)
            return "F";
        else if (mark < 65)
            return "P";
        else if (mark < 75)
            return "C";
        else if (mark < 85)
            return "D";
        else
            return "HD";
    }
}

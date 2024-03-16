namespace MarksGUI.Data;

public class Mark
{
    public string? StudentName { get; set; }
    public int? StudentMark { get; set; }

    public string GetGrade()
    {
        if (StudentMark < 50)
            return "F";
        else if (StudentMark < 65)
            return "P";
        else if (StudentMark < 75)
            return "C";
        else if (StudentMark < 85)
            return "D";
        else
            return "HD";
    }
}

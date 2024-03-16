namespace ConsoleApps.SourceCode;
public class GetDateTime
{
    public static string CheckDate()
    {
        DateTime date = DateTime.Now;
        return string.Format("It is {0} the {1} of {2}, {3}", date.DayOfWeek, GetDay(date.Day), GetMonth(date.Month), date.Year);
    }

    public static string GetDay(int day)
    {
        return day switch
        {
            1 => day + "st",
            2 => day + "nd",
            3 => day + "rd",
            21 => day + "st",
            22 => day + "nd",
            23 => day + "rd",
            31 => day + "st",
            _ => day + "th",
        };
    }

    public static string GetMonth(int month)
    {
        return month switch
        {
            1 => "January",
            2 => "February",
            3 => "March",
            4 => "April",
            5 => "May",
            6 => "June",
            7 => "July",
            8 => "August",
            9 => "September",
            10 => "October",
            11 => "November",
            12 => "December",
            _ => "invalid month",
        };
    }
}

namespace ConsoleApps.SourceCode;
public class GetDateTime
{
    public static string checkDate()
    {
        DateTime date = DateTime.Now;
        return String.Format("It is {0} the {1} of {2}, {3}", date.DayOfWeek, getDay(date.Day), getMonth(date.Month), date.Year);
    }

    public static string getDay(int day)
    {
        switch (day)
        {
            case 1:
                return day + "st";
            case 2:
                return day + "nd";
            case 3:
                return day + "rd";
            case 21:
                return day + "st";
            case 22:
                return day + "nd";
            case 23:
                return day + "rd";
            case 31:
                return day + "st";
            default:
                return day + "th";
        }
    }

    public static string getMonth(int month)
    {
        switch (month)
        {
            case 1:
                return "January";
            case 2:
                return "February";
            case 3:
                return "March";
            case 4:
                return "April";
            case 5:
                return "May";
            case 6:
                return "June";
            case 7:
                return "July";
            case 8:
                return "August";
            case 9:
                return "September";
            case 10:
                return "October";
            case 11:
                return "November";
            case 12:
                return "December";
            default:
                return "invalid month";
        }
    }
}

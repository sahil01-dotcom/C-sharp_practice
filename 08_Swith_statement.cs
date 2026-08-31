//week day program using switch statement
using System;
public class _08_week_day
{
    public static void Main(string[] args)
    {
        string dayName;
        Console.Write("Enter the number of the day (1-7): ");
        int day = int.Parse(Console.ReadLine());

        switch (day)
        {
            case 1:
                dayName = "Monday";
                break;
            case 2:
                dayName = "Tuesday";
                break;
            case 3:
                dayName = "Wednesday";
                break;
            case 4:
                dayName = "Thursday";
                break;
            case 5:
                dayName = "Friday";
                break;
            case 6:
                dayName = "Saturday";
                break;
            case 7:
                dayName = "Sunday";
                break;
            default:
                dayName = "Invalid day number.";
                break;
        }Console.Write(dayName);
    }
}
//https://exercism.org/tracks/csharp/exercises/leap/
using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        if (year % 4 == 0)
        {
            if (year % 100 == 0 )
            {
                if(year % 400 == 0)
                    return true;
                else
                    return false;
            }
                return true;
        }
    return false;
    }
}
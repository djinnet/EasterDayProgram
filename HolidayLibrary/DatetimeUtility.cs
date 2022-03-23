using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayLibrary
{
    /// <summary>
    /// Utility for DateTime to calculate EasterSunday
    /// </summary>
    public static class DatetimeUtility
    {
        /*
         * Note from developer: 
         * The wiki version seems more complicated than it should be. The variables names are the same from the wiki.
         * I have also include an stackoverflow code that provide the same result, but better understanding of the variables.
         * However I will use the wiki version in the software, since it is in the requirements.
         */

        /// <summary>
        /// Calculate Easter Sunday for any given year.
        /// src.: https://stackoverflow.com/a/2510411/1233379
        /// </summary>
        /// <param name="year">The year to calculate Easter against.</param>
        /// <returns>a DateTime object containing the Easter month and day for the given year</returns>
        public static DateTime GetEasterSundayStackOverflow(int year)
        {
            int day = 0;
            int month = 0;

            int goldenNumber = year % 19;
            int century = year / 100;
            int NumberOfDaysBetweenEquinoxAndNextFullMoon = (century - (int)(century / 4) - (int)((8 * century + 13) / 25) + 19 * goldenNumber + 15) % 30;
            int NumberOfDaysBetweenFullmoonAfterEquinoxAndFirstSundayAfterFullmoon = NumberOfDaysBetweenEquinoxAndNextFullMoon - (int)(NumberOfDaysBetweenEquinoxAndNextFullMoon / 28) * (1 - (int)(NumberOfDaysBetweenEquinoxAndNextFullMoon / 28) * (int)(29 / (NumberOfDaysBetweenEquinoxAndNextFullMoon + 1)) * (int)((21 - goldenNumber) / 11));

            day = NumberOfDaysBetweenFullmoonAfterEquinoxAndFirstSundayAfterFullmoon - ((year + (int)(year / 4) + NumberOfDaysBetweenFullmoonAfterEquinoxAndFirstSundayAfterFullmoon + 2 - century + (int)(century / 4)) % 7) + 28;
            month = 3;

            if (day > 31)
            {
                month++;
                day -= 31;
            }

            return new DateTime(year, month, day);
        }

        /// <summary>
        /// Calculate Easter Sunday for any given year.
        /// src.: https://da.wikipedia.org/wiki/P%C3%A5ske
        /// </summary>
        /// <param name="year">The year to calculate Easter against.</param>
        /// <returns>a DateTime object containing the Easter month and day for the given year</returns>
        public static DateTime GetEasterSundayWIKI(int year)
        {
            
            int a = year % 19;
            int b = year / 100; 
            int c = year % 100;
            int d = b / 4;
            int e = b % 4;
            int f = (b + 8) / 25;
            int g = (b - f + 1) / 3;
            int h = (19 * a + b - d - g + 15) % 30;
            int i = c / 4;
            int k = c % 4;
            int l = (32 + 2 * e + 2 * i - h - k) % 7;
            int m = (a + 11 * h + 22 * l) / 451;

            int month = (h + l - 7 * m + 114) / 31;
            int day = (h + l - 7 * m + 114) % 31 + 1;
            return new DateTime(year, month, day);
        }
    }
}

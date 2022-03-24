using EasterDayProgram.HolidayLibrary.Abstract;
namespace EasterDayProgram.HolidayLibrary.Easter
{
    public class CatholicEaster : AbstractEasterDate
    {

        /// <summary>
        /// Gets the Catholic easter sunday for the requested year
        /// </summary>
        /// <param name="year">The year you want to know the Catholic Easter Sunday of</param>
        /// <returns>DateTime of Catholic Easter Sunday</returns>
        public override DateTime EasterSunday(int year)
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


        public override DateTime GoodFriday(int year)
        {
            return this.EasterSunday(year).AddDays(-2);
        }

    }
}

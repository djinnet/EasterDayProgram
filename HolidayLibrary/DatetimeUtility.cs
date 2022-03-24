using EasterDayProgram.HolidayLibrary.Easter;
namespace HolidayLibrary
{
    /// <summary>
    /// Utility for DateTime to calculate EasterSunday
    /// </summary>
    public static class DatetimeUtility
    {
        /*
         * Note from developer: 
         * This version is made after the test has ended. 
         * I want to improved the code quality & added the orthodox easter to the code, and is not really intended for submitted the final version of the test, since the final version required only Catholic Easter from wiki.
         * 
         */

        /// <summary>
        /// Calculate Easter Sunday for any given year and can provide Orthodox or Catholic easter date.
        /// </summary>
        /// <param name="year">The year to calculate Easter against.</param>
        /// <returns>a DateTime object containing the Easter month and day for the given year</returns>
        public static DateTime GetEasterSunday(int year, bool isOrthodox = false) => isOrthodox ? new OrthodoxEaster().EasterSunday(year) : new CatholicEaster().EasterSunday(year);

    }
}

using EasterDayProgram.HolidayLibrary.Abstract;
namespace EasterDayProgram.HolidayLibrary.Easter
{
    public class OrthodoxEaster : AbstractEasterDate
    {

        /// <summary>
        /// Gets the Orthodox easter sunday for the requested year
        /// </summary>
        /// <param name="year">The year you want to know the Orthodox Easter Sunday of</param>
        /// <returns>DateTime of Orthodox Easter Sunday</returns>
        public override DateTime EasterSunday(int year)
        {
            int a = year % 19;
            int b = year % 7;
            int c = year % 4;

            int d = (19 * a + 16) % 30;
            int e = (2 * c + 4 * b + 6 * d) % 7;
            int f = (19 * a + 16) % 30;
            int key = f + e + 3;

            int month = (key > 30) ? 5 : 4;
            int day = (key > 30) ? key - 30 : key;

            return new DateTime(year, month, day);
        }


        public override DateTime GoodFriday(int year)
        {
            return this.EasterSunday(year).AddDays(-2);
        }

    }
}

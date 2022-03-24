using EasterDayProgram.HolidayLibrary.Easter;
namespace EasterDayProgram.HolidayLibrary.Abstract
{
    /// <summary>
    /// Src: https://stackoverflow.com/a/36279634
    /// </summary>
    public abstract class AbstractEasterDate
    {
        public abstract DateTime EasterSunday(int year);
        public abstract DateTime GoodFriday(int year);

        public static AbstractEasterDate CreateInstance()
        {
            System.Globalization.CultureInfo ci = System.Globalization.CultureInfo.CurrentCulture;
            System.Globalization.RegionInfo ri = new System.Globalization.RegionInfo(ci.LCID);


            // https://msdn.microsoft.com/en-us/library/windows/desktop/dd374073(v=vs.85).aspx
            List<int> lsOrthodox = new List<int>{
                 0x10D // Serbia and Montenegro
                ,0x10E // Montenegro
                ,0x10F // Serbia
                ,0x19 // Bosnia and Herzegovina
                // ,0x46 // Estonia
                // ,0x4B // Czech Republic
                // ,0x4D // Finland
                ,0x62 // Greece
                // ,0x6D // Hungary
                ,0x79 // Iraq
                // ,0x8C // Latvia
                // ,0x8D // Lithuania
                // ,0x8F // Slovakia
                // ,0x98 // Moldova
                // ,0xD4 // Slovenia
                ,0x4CA2 // Macedonia, Former Yugoslav Republic of
                ,0xEB // Turkey
            };

            // if(ci == WesternSlavonicOrthodox)
            if (lsOrthodox.Contains(ri.GeoId)) return new OrthodoxEaster();


            // TODO: Correct for Armenia/Georgia ? ? ? 
            // if(ri.GeoId == 0x7 || ri.GeoId == 0x58) // 0x7: Armenia, 0x58: Georgia
            // return new CatholicEasterBunny();


            // if(ci == EasternSlavonic)
            string strMonthName = ci.DateTimeFormat.GetMonthName(8);
            if (System.Text.RegularExpressions.Regex.IsMatch(strMonthName, @"\p{IsCyrillic}"))
            {
                // there is at least one cyrillic character in the string
                return new OrthodoxEaster();
            }

            return new CatholicEaster();
        }
    }
}

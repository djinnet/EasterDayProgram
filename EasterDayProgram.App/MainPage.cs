using HolidayLibrary;
using System.Globalization;

namespace EasterDayProgram.App
{
    /// <summary>
    /// The main page
    /// </summary>
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This onclick function will get year from the datetimepicker inputfield,
        /// then it will calculate Easter sunday from the year within a function from library.
        /// Once we have the result from the easter, it will be formatted to Danish dateformat and set to result label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchForEaster_Click(object sender, EventArgs e)
        {
            //Get year
            int year = dateTimePicker1.Value.Year;

            //calculate year
            DateTime EasterSunday = DatetimeUtility.GetEasterSundayWIKI(year);

            //show the date in danish date format
            Result.Text = EasterSunday.ToString("dddd, dd MMMM yyyy", new CultureInfo("da-DK"));
        }
    }
}
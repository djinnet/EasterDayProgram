using HolidayLibrary;
using System.ComponentModel;
using System.Globalization;

namespace EasterDayProgram.App
{
    /// <summary>
    /// The main page
    /// </summary>
    public partial class MainPage : Form
    {
        // Default Culture for the application is da-DK (danish)
        private CultureInfo Culture = new CultureInfo("da-DK");
        
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
            SearchAfterEaster();
        }

        private void SearchAfterEaster()
        {
            //Get year
            int year = SelectYear.Value.Year;

            //Get Orthodox or Catholic.
            bool orthodox = orthodoxCheckbox.Checked;

            //Calculate year
            DateTime EasterSunday = DatetimeUtility.GetEasterSunday(year, orthodox);

            //show the date in danish date format
            Result.Text = EasterSunday.ToString("dddd, dd MMMM yyyy", Culture);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            LanguagesDropdown.Items.Add("Danish");
            LanguagesDropdown.Items.Add("English");
            LanguagesDropdown.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (LanguagesDropdown.SelectedItem.ToString())
            {
                case "Danish":
                    ChangeLanguage("da-DK");
                    Result.Text = string.Empty;
                    break;
                default:
                    ChangeLanguage("en-US");
                    Result.Text = string.Empty;
                    break;
            }
        }

        private void ChangeLanguage(string lang)
        {
            Culture = new CultureInfo(lang);

            foreach (var c in this.GetAllComponents())
            {
                if(c is Control control)
                {
                    ComponentResourceManager resources = new ComponentResourceManager(typeof(MainPage));
                    resources.ApplyResources(control, control.Name, new CultureInfo(lang));
                }
            }
        }
    }
}
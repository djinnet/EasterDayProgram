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
            int year = dateTimePicker1.Value.Year;

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
            comboBox1.Items.Add("Danish");
            comboBox1.Items.Add("English");
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Danish")
            {
                ChangeLanguage("da-DK");
                Result.Text = string.Empty;
            }
            else
            {
                ChangeLanguage("en-US");
                Result.Text = string.Empty;
            }
        }

        private void ChangeLanguage(string lang)
        {
            Culture = new CultureInfo(lang);

            foreach (var c in this.GetAllComponents())
            {
                if(c is Control)
                {
                    ComponentResourceManager resources = new ComponentResourceManager(typeof(MainPage));
                    resources.ApplyResources(((Control)c), ((Control)c).Name, new CultureInfo(lang));
                }
            }
        }
    }
}
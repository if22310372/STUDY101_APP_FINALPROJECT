using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDY101_APP_FINALPROJECT
{
    public partial class CALENDER_PAGE : Form
    {

        int month, year;

        public static int static_month, static_year;

        public CALENDER_PAGE()
        {
            InitializeComponent();
        }

        private void CALENDER_PAGE_Load(object sender, EventArgs e)
        {
            // Set initial month and year
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            // Display the days of the current month
            displayDays();
        }

        private void displayDays()
        {
            // Clear previous controls
            daycontainer.Controls.Clear();

            // Mengambil nama bulan
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblmonthyear.Text = monthname + " " + year;

            static_month = month;
            static_year = year;

            // Get the first day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);

            // Get the count of days in the month
            int days = DateTime.DaysInMonth(year, month);

            // Convert the start of the month to integer
            int dayoftheweek = (int)startofthemonth.DayOfWeek + 1;

            // Create blank user controls for leading spaces
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                daycontainer.Controls.Add(ucBlank);
            }

            // Create user controls for each day of the month
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                daycontainer.Controls.Add(ucDays);
            }
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            // Increment month
            month--;
            static_month = month;
            static_year = year;

            // Check if month exceeds December
            if (month < 1)
            {
                month = 12; // Reset to January
                year--;    // Increment year
            }

            // Display the days for the new month
            displayDays();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            // Increment month
            month++;
            static_month = month;
            static_year = year;

            // Check if month exceeds December
            if (month > 12)
            {
                month = 1; // Reset to January
                year++;    // Increment year
            }

            // Display the days for the new month
            displayDays();
        }
    }
}
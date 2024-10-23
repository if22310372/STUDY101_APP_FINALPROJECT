using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDY101_APP_FINALPROJECT
{
    public partial class UserControlDays : UserControl
    {
        public static int static_day;

        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            
        }

        public void days(int numday)
        {
            lbldays.Text = numday + "";

        }


        private void UserControlDays_Click(object sender, EventArgs e)
        {
            // Konversi lbldays.Text ke int dan simpan ke static_day
            if (int.TryParse(lbldays.Text, out int day))
            {
                static_day = day;
            }
            else
            {
                MessageBox.Show("Invalid day value.");
                return; // Hentikan eksekusi jika konversi gagal
            }

            ADD_EVENT_PAGE AddEventPage = new ADD_EVENT_PAGE();
            AddEventPage.Show();
        }
    }
}

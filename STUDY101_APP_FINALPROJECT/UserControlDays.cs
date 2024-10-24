using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace STUDY101_APP_FINALPROJECT
{
    public partial class UserControlDays : UserControl
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;

        public static int static_day;

        public UserControlDays()
        {
            alamat = "server=localhost; database=database_study101; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

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


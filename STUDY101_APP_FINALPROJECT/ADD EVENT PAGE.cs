using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace STUDY101_APP_FINALPROJECT
{
    public partial class ADD_EVENT_PAGE : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;

        public ADD_EVENT_PAGE()
        {
            alamat = "server=localhost; database=database_study101; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void ADD_EVENT_PAGE_Load(object sender, EventArgs e)
        {
            // Mengambil nilai bulan, hari, dan tahun
            int month = CALENDER_PAGE.static_month;
            int day = UserControlDays.static_day;
            int year = CALENDER_PAGE.static_year;

            // Membuat objek DateTime dengan aman
            DateTime eventDate = new DateTime(year, month, day);

            // Mengatur nilai DateTimePicker
            datepick.Value = eventDate;

            koneksi.Open();
            query = "SELECT DISTINCT calender_event FROM tbl_tracker"; // Ambil nilai unik
            perintah = new MySqlCommand(query, koneksi);
            MySqlDataReader reader = perintah.ExecuteReader();

            checkedListBoxevent.Items.Clear(); // Kosongkan sebelumnya

            while (reader.Read())
            {
                // Tambahkan type ke combobox
                checkedListBoxevent.Items.Add(reader["calender_event"].ToString());
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtevent.Text != "")
                {
                    // Mengambil tanggal dalam format yang sesuai
                    string eventDate = datepick.Value.ToString("yyyy-MM-dd");

                    // Cek apakah tanggal sudah ada di database
                    string checkQuery = string.Format("SELECT COUNT(*) FROM tbl_calender WHERE calender_date = '{0}'", eventDate);
                    koneksi.Open();
                    MySqlCommand checkCommand = new MySqlCommand(checkQuery, koneksi);
                    int count = Convert.ToInt32(checkCommand.ExecuteScalar());
                    koneksi.Close();

                    // Jika tanggal sudah ada
                    if (count > 0)
                    {
                        // Update dengan menambahkan event baru
                        string updateQuery = string.Format("UPDATE tbl_calender SET calender_event = CASE WHEN calender_event IS NULL THEN '{0}' ELSE CONCAT(calender_event, ', {0}') END WHERE calender_date = '{1}'", txtevent.Text, eventDate);
                        koneksi.Open();
                        MySqlCommand updateCommand = new MySqlCommand(updateQuery, koneksi);
                        int updateRes = updateCommand.ExecuteNonQuery();
                        koneksi.Close();

                        if (updateRes > 0)
                        {
                            MessageBox.Show("Event Added Successfully to Existing Date");
                        }
                        else
                        {
                            MessageBox.Show("Failed To Add Event to Existing Date");
                        }
                    }
                    else
                    {
                        // Jika tanggal tidak ada, insert baru
                        string insertQuery = string.Format("INSERT INTO tbl_calender (calender_date, calender_event) VALUES ('{0}', '{1}')", eventDate, txtevent.Text);
                        koneksi.Open();
                        MySqlCommand insertCommand = new MySqlCommand(insertQuery, koneksi);
                        int insertRes = insertCommand.ExecuteNonQuery();
                        koneksi.Close();

                        if (insertRes == 1)
                        {
                            MessageBox.Show("Event Added Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Failed To Add Event");
                        }
                    }

                    // Refresh data after adding
                    ADD_EVENT_PAGE_Load(null, null);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Make Sure To Input All Data!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class TRACKER_PAGE : Form
    {
        private string lastSelectedType;
        private string lastSelectedSubject;
        private bool isFiltering = false; // Menyimpan status apakah sedang memfilter

        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        public TRACKER_PAGE()
        {

            alamat = "server=localhost; database=database_study101; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void LoadSubjects()
        {
            try
            {
                koneksi.Open();
                query = "SELECT DISTINCT tracker_subject FROM tbl_tracker"; // Ambil nilai unik
                perintah = new MySqlCommand(query, koneksi);
                MySqlDataReader reader = perintah.ExecuteReader();

                comboboxsubjects.Items.Clear(); // Kosongkan sebelumnya

                while (reader.Read())
                {
                    // Tambahkan subject ke combobox
                    comboboxsubjects.Items.Add(reader["tracker_subject"].ToString());
                }

                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadTypes()
        {
            try
            {
                koneksi.Open();
                query = "SELECT DISTINCT tracker_type FROM tbl_tracker"; // Ambil nilai unik
                perintah = new MySqlCommand(query, koneksi);
                MySqlDataReader reader = perintah.ExecuteReader();

                comboBoxtype.Items.Clear(); // Kosongkan sebelumnya

                while (reader.Read())
                {
                    // Tambahkan type ke combobox
                    comboBoxtype.Items.Add(reader["tracker_type"].ToString());
                }

                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TRACKER_PAGE_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("select * from tbl_tracker");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
                dataGridView.DataSource = ds.Tables[0];
                dataGridView.Columns[0].Width = 100;
                dataGridView.Columns[0].HeaderText = "Subject";
                dataGridView.Columns[1].Width = 150;
                dataGridView.Columns[1].HeaderText = "Type";
                dataGridView.Columns[2].Width = 120;
                dataGridView.Columns[2].HeaderText = "Name";
                dataGridView.Columns[3].Width = 120;
                dataGridView.Columns[3].HeaderText = "Value";
                dataGridView.Columns[4].Width = 120;
                dataGridView.Columns[4].HeaderText = "Score";

                LoadSubjects();
                LoadTypes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private void btnfilter_Click(object sender, EventArgs e)
        {
            try
            {
                // Ambil nilai yang dipilih dari comboBoxtype
                lastSelectedType = comboBoxtype.Text; // Simpan jenis yang dipilih
                isFiltering = true; // Set status ke memfilter

                // Buat query SQL untuk memfilter data
                query = string.Format("SELECT * FROM tbl_tracker WHERE tracker_type = '{0}'", lastSelectedType);

                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                // Tampilkan data terfilter di DataGridView
                dataGridView.DataSource = ds.Tables[0];
                CalculateProgress(); // Hitung progress setelah memfilter data
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Ambil nilai yang dipilih dari comboboxsubjects
                string selectedSubject = comboboxsubjects.Text;

                // Buat query SQL untuk menghapus data
                query = string.Format("DELETE FROM tbl_tracker WHERE tracker_subject = '{0}'", selectedSubject);

                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                int res = perintah.ExecuteNonQuery();
                koneksi.Close();

                if (res > 0)
                {
                    MessageBox.Show("Data Deleted Successfully");
                    TRACKER_PAGE_Load(null, null); // Muat ulang data di DataGridView
                }
                else
                {
                    MessageBox.Show("Failed to Delete Data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {

        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            try
            {
                // Ambil nilai yang dipilih dari comboboxsubjects
                lastSelectedSubject = comboboxsubjects.Text; // Simpan subject yang dipilih
                isFiltering = false; // Set status ke tidak memfilter

                // Buat query SQL untuk mengambil data berdasarkan tracker_subject
                query = string.Format("SELECT * FROM tbl_tracker WHERE tracker_subject = '{0}'", lastSelectedSubject);

                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                // Tampilkan data di DataGridView
                dataGridView.DataSource = ds.Tables[0];
                CalculateProgress(); // Hitung progress berdasarkan subject setelah membuka data
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btndeleteSCORE_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboboxsubjects.Text != "" && txtname.Text != "")
                {
                    // Buat query SQL untuk menghapus data berdasarkan subject dan name
                    query = string.Format("DELETE FROM tbl_tracker WHERE tracker_subject = '{0}' AND tracker_name = '{1}'", comboboxsubjects.Text, txtname.Text);

                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();

                    if (res > 0)
                    {
                        MessageBox.Show($"Tracked value '{txtname.Text}' in the '{comboboxsubjects.Text}' subject deleted successfully.");
                        TRACKER_PAGE_Load(null, null);
                        txtname.Clear();
                        txtvalue.Clear();
                        txtscore.Clear();
                        txttype.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to Delete Data");
                    }
                }
                else
                {
                    MessageBox.Show("Make Sure To Input All Your Data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboboxsubjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CalculateProgress()
        {
            try
            {
                koneksi.Open();

                string query;
                if (isFiltering)
                {
                    // Hitung berdasarkan tracker_type
                    query = string.Format("SELECT SUM(tracker_value) AS TotalValue, SUM(tracker_score) AS TotalScore FROM tbl_tracker WHERE tracker_type = '{0}'", lastSelectedType);
                }
                else
                {
                    // Hitung berdasarkan tracker_subject
                    query = string.Format("SELECT SUM(tracker_value) AS TotalValue, SUM(tracker_score) AS TotalScore FROM tbl_tracker WHERE tracker_subject = '{0}'", lastSelectedSubject);
                }

                perintah = new MySqlCommand(query, koneksi);
                MySqlDataReader reader = perintah.ExecuteReader();

                if (reader.Read())
                {
                    double totalValue = reader.IsDBNull(0) ? 0 : reader.GetDouble("TotalValue");
                    double totalScore = reader.IsDBNull(1) ? 0 : reader.GetDouble("TotalScore");

                    // Menghitung persentase
                    if (totalValue > 0)
                    {
                        double percentage = (totalScore / totalValue) * 100;
                        lblprogress.Text = $"Progress: {percentage:F2}%"; // Format dua desimal
                    }
                    else
                    {
                        lblprogress.Text = "No values to calculate.";
                    }
                }

                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboboxsubjects.Text != "" && txtname.Text != "" && txtvalue.Text != "" && txtscore.Text != "")
                {
                    query = string.Format("insert into tbl_tracker values ('{0}','{1}','{2}','{3}','{4}');", comboboxsubjects.Text, txttype.Text, txtname.Text, txtvalue.Text, txtscore.Text);


                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();
                    if (res == 1)
                    {
                        MessageBox.Show("Data Inserted Succesfully");
                        TRACKER_PAGE_Load(null, null);

                        txtname.Clear();
                        txtvalue.Clear();
                        txtscore.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed To Insert Data");
                    }
                }
                else
                {
                    MessageBox.Show("Make Sure To Input All Your Data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

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
using System.Xml.Linq;

namespace STUDY101_APP_FINALPROJECT
{
    public partial class DIARY_PAGE : Form
    {
        private MySqlConnection koneksi;
        private string alamat;

        public DIARY_PAGE()
        {
            alamat = "server=localhost; database=database_study101; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                // Pastikan tidak ada input kosong
                if (!string.IsNullOrWhiteSpace(txtdiaryname.Text) && !string.IsNullOrWhiteSpace(richTextBoxdiarycontent.Text))
                {
                    // Cek apakah diary_name sudah ada di database
                    bool isDiaryNameExists = false;
                    string checkQuery = "SELECT diary_name FROM tbl_diary;";

                    // Gunakan koneksi yang sudah didefinisikan
                    koneksi.Open();

                    MySqlCommand checkCommand = new MySqlCommand(checkQuery, koneksi);
                    MySqlDataReader reader = checkCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        string diaryName = reader.GetString("diary_name");
                        if (diaryName.Equals(txtdiaryname.Text, StringComparison.OrdinalIgnoreCase))
                        {
                            isDiaryNameExists = true;
                            break;
                        }
                    }

                    reader.Close();

                    if (isDiaryNameExists)
                    {
                        // Jika ada, lakukan update
                        string updateQuery = "UPDATE tbl_diary SET diary_content = @diaryContent WHERE diary_name = @diaryName;";
                        MySqlCommand updateCommand = new MySqlCommand(updateQuery, koneksi);
                        updateCommand.Parameters.AddWithValue("@diaryContent", richTextBoxdiarycontent.Text);
                        updateCommand.Parameters.AddWithValue("@diaryName", txtdiaryname.Text);
                        int updateResult = updateCommand.ExecuteNonQuery();

                        if (updateResult > 0)
                        {
                            MessageBox.Show("Diary Updated Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Failed To Update Diary");
                        }
                    }
                    else
                    {
                        // Jika tidak ada, lakukan insert
                        string insertQuery = "INSERT INTO tbl_diary (diary_name, diary_content) VALUES (@diaryName, @diaryContent);";
                        MySqlCommand insertCommand = new MySqlCommand(insertQuery, koneksi);
                        insertCommand.Parameters.AddWithValue("@diaryName", txtdiaryname.Text);
                        insertCommand.Parameters.AddWithValue("@diaryContent", richTextBoxdiarycontent.Text);
                        int insertResult = insertCommand.ExecuteNonQuery();

                        if (insertResult > 0)
                        {
                            MessageBox.Show("Diary Saved Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Failed To Save Diary");
                        }
                    }

                    koneksi.Close();
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

        private void DIARY_PAGE_Load(object sender, EventArgs e)
        {
            // Kode untuk menginisialisasi halaman jika diperlukan
        }
    }
}
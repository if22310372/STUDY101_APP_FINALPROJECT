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
    public partial class LOGIN_PAGE : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        public LOGIN_PAGE()
        {
            alamat = "server=localhost; database=database_study101; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SIGNUP_PAGE SignUpPage =  new SIGNUP_PAGE();
            SignUpPage.Show();

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtusernameemail.Text = "";
            txtpassword.Text = "";
        }

        private void LOGIN_PAGE_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                query = string.Format("select * from tbl_user where user_username OR user_email = '{0}'", txtusernameemail.Text);
                ds.Clear();
                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                adapter.Fill(ds);
                koneksi.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow kolom in ds.Tables[0].Rows)
                    {
                        string sandi;
                        sandi = kolom["user_password"].ToString();
                        if (sandi == txtpassword.Text)
                        {
                            MAIN_MENU_PAGE MainMenuPage = new MAIN_MENU_PAGE();
                            MainMenuPage.Show();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Password");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Username or Email Not Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

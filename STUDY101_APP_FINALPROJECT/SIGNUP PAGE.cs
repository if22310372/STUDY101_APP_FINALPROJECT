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
    public partial class SIGNUP_PAGE : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        public SIGNUP_PAGE()
        {
            alamat = "server=localhost; database=database_study101; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void SIGNUP_PAGE_Load(object sender, EventArgs e)
        {

        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text != "" && txtemail.Text != "" && txtusername.Text != "" && txtpassword.Text != "")
                {
                    if (IsUsernameOrEmailExists(txtusername.Text, txtemail.Text))
                    {
                        query = string.Format("insert into tbl_user values ('{0}','{1}','{2}','{3}');", txtusername.Text, txtemail.Text, txtpassword.Text, txtname.Text);


                        koneksi.Open();
                        perintah = new MySqlCommand(query, koneksi);
                        adapter = new MySqlDataAdapter(perintah);
                        int res = perintah.ExecuteNonQuery();
                        koneksi.Close();
                        if (res == 1)
                        {
                            MessageBox.Show("You Have Sign Up");
                            SIGNUP_PAGE_Load(null, null);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Sign Up Failed!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username or email already registered!");
                    }
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

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpassword.Text = "";
            txtname.Text = "";
            txtemail.Text = "";
        }

        private bool IsUsernameOrEmailExists(string username, string email)
        {
            string query = "SELECT COUNT(*) FROM tbl_user WHERE username = @username OR email = @email;";

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@email", email);

                try
                {
                    koneksi.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count == 0;
                }
                catch (Exception ex)
                {
                    return true; 
                }
                finally
                {
                    if (koneksi.State == System.Data.ConnectionState.Open)
                    {
                        koneksi.Close();
                    }
                }
            }
        }
    }
}

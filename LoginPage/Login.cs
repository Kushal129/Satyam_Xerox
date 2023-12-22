using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;
using CRUD;

namespace LoginPage
{
    public partial class Login : Form
    {

        //SqlConnection con = new SqlConnection(SQLConnectionClass.ConReturn());
        //SqlCommand cmd = new SqlCommand();
        MySqlConnection con = new MySqlConnection(SQLConnectionClass.ConnectionString);
        MySqlCommand cmd = new MySqlCommand();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*   private void button3_Click(object sender, EventArgs e)
           {
               if (txt_username.Text == "")
               {
                   MessageBox.Show("Enter The Username ");

               }
               else if (txt_password.Text == "")
               {
                   MessageBox.Show("Enter The Passowrd");
               }
               else
               {
                   try
                   {

                       //SqlConnection con = new SqlConnection(SQLConnectionClass.ConReturn());
                       SqlConnection con = new SqlConnection(SQLConnectionClass.ConnectionString);
                       //SqlConnection con = new SqlConnection("Data Source=LAPTOP-867BHLVP;Initial Catalog=Satyam;Integrated Security=True");
                       SqlCommand cmd = new SqlCommand("select * from tbl_login where username = @username and password = @password", con);
                       cmd.Parameters.AddWithValue("@username", txt_username.Text);
                       cmd.Parameters.AddWithValue("@Password", txt_password.Text);
                       Storage.username = txt_username.Text;
                       Storage.password = txt_password.Text;

                       SqlDataAdapter da = new SqlDataAdapter(cmd);
                       DataTable dt = new DataTable();

                       da.Fill(dt);

                       if (dt.Rows.Count > 0)
                       {
                           MessageBox.Show("Login Successfull..");
                           //second form
                           Home f2 = new Home();
                           f2.Show();
                           this.Hide();

                       }
                       else
                       {
                           MessageBox.Show("Username or Password is invalid ");

                       }
                   }
                   catch (Exception ex)
                   {
                       MessageBox.Show(" " + ex);

                   }
               }
           }
        */
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_username.Text))
            {
                MessageBox.Show("Enter The Username");
            }
            else if (string.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Enter The Password");
            }
            else
            {
                try
                {
                    using (MySqlConnection con = new MySqlConnection(SQLConnectionClass.ConnectionString))
                    {
                        con.Open();

                        using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_login WHERE username = @username AND password = @password", con))
                        {
                            cmd.Parameters.AddWithValue("@username", txt_username.Text);
                            cmd.Parameters.AddWithValue("@password", txt_password.Text);

                            Storage.username = txt_username.Text;
                            Storage.password = txt_password.Text;

                            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                da.Fill(dt);

                                if (dt.Rows.Count > 0)
                                {
                                    MessageBox.Show("Login Successful..");

                                    // Second form
                                    Home f2 = new Home();
                                    f2.Show();
                                    Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Username or Password is invalid");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void check_password_view_CheckedChanged(object sender, EventArgs e)
        {
            if (check_password_view.Checked)
            {
                
                txt_password.PasswordChar = '\0'; 

                System.Threading.Timer timer = new System.Threading.Timer(HidePassword, null, 600, Timeout.Infinite); 
            }
            else
            { 
                txt_password.PasswordChar = '*';
            }
        }
        private void HidePassword(object state)
        {
            
            txt_password.Invoke((MethodInvoker)(() =>
            {
                txt_password.PasswordChar = '*';
                check_password_view.Checked = false; 
            }));
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace LoginPage
{
     class SQLConnectionClass
    {
        //public static string ConReturn() => @"Data Source=(LocalDB)\v11.0;AttachDbFilename=SatyamXerox.mdf;Integrated Security=True";
        public static string ConnectionString => "Server=localhost;Database=satyamxerox;User ID=root;Password=;";

        public static void TestConnection()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    MessageBox.Show("Database connection successful!", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection failed! Error: {ex.Message}", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

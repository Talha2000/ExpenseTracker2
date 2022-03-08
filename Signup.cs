using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace ExpenseTracker2
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(Program.connString);
        private void Signup_Load(object sender, EventArgs e)
        {
            
        }
        private void SignupButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Program.connString))
            {
                try
                {
                    conn.Open();
                    string query = "insert into Login(username, password) values(@name, @pass)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Pass", txtPass.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // We should log the error somewhere, 
                    // for this example let's just show a message
                    MessageBox.Show("ERROR:" + ex.Message);
                }
            }

            //conn.Open();
            //SqlCommand cmd = new SqlCommand("usp_Login", conn);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@Name", txtName.Text);
            //cmd.Parameters.AddWithValue("@Pass", txtPass.Text);
            //conn.Close();
        }

        private void ReturnLogin_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }
    }
}

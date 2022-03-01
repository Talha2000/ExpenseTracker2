using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con = "Data Source=DESKTOP-TH286H6;Initial Catalog=ExpenseTrackerDB;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            String username, user_password;

            username = txtName.Text;
            user_password = txtPass.Text;

            try
            {
                String query = "SELECT * FROM New_Login WHERE username = '" + txtName.Text + "' AND password = '" + txtPass.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    username = txtName.Text;
                    user_password = txtPass.Text;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                con.Close();
            }
        }
    }
}

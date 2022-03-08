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
        SqlConnection con = new SqlConnection (@"Data Source=DESKTOP-TH286H6;Initial Catalog=ExpenseTrackerDB;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // login button
            String username, password;

            username = txtName.Text;
            password = txtPass.Text;

            try
            {
                String query = "SELECT * FROM Login WHERE username = '" + txtName.Text + "' AND password = '" + txtPass.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txtName.Text;
                    password = txtPass.Text;

                    //page that needs to load next
                    Form2 main = new Form2();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details");
                    txtName.Clear();
                    txtPass.Clear();

                    txtName.Focus();
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

        private void button2_Click(object sender, EventArgs e)
        {
            // Signup button
            Signup sign = new Signup();
            sign.Show();
            this.Hide();
        }
    }
}

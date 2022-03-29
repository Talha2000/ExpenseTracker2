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
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string loginQuery = "SELECT * FROM Login WHERE username = '" + txtName.Text + "' AND password = '" + txtPass.Text + "'";
            cmd = new SqlCommand(loginQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();

            // Save current user
            string current_user = txtName.Text;

            if (dr.Read() == true)
            {
                new Form2(current_user).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, please try again", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Text = "";
                txtPass.Text = "";
                txtName.Focus();
            }
            con.Close();
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


// login button
//String username, password;

//username = txtName.Text;
//password = txtPass.Text;

//try
//{
//String query = "SELECT * FROM Login WHERE username = '" + txtName.Text + "' AND password = '" + txtPass.Text + "' AND ID'";
//SqlDataAdapter sda = new SqlDataAdapter(query, con);
//        string sql = "SELECT * FROM Login WHERE username = '" + txtName.Text + "' AND password = '" + txtPass.Text + "'";
//        cm = new SqlCommand(sql, con);
//        var dr = cm.ExecuteReader();
//        if (dr.Read()) // Read() returns TRUE if there are records to read, or FALSE if there is nothing
//        {
//            fname = dr["fullname"];
//            UserID = dr["ID"].ToString();

//            DataTable dtable = new DataTable();
//        sda.Fill(dtable);

//        if (dtable.Rows.Count > 0)
//        {
//            username = txtName.Text;
//            password = txtPass.Text;

//            //page that needs to load next
//            Form2 main = new Form2();
//            main.Show();
//            this.Hide();
//        }
//        else
//        {
//            MessageBox.Show("Invalid login details");
//            txtName.Clear();
//            txtPass.Clear();

//            txtName.Focus();
//        }
//    }
//    catch
//    {
//        MessageBox.Show("Error");
//    }
//    finally
//    {
//        con.Close();
//    }
//}
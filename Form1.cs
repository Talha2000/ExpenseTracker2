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
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        public Form1()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=DESKTOP-TH286H6;Initial Catalog=ExpenseTrackerDB;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-TH286H6;Initial Catalog=ExpenseTrackerDB;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("INSERT into User_Info (name) VALUES (@Name)", con);
            cmd.Parameters.Add("@Name", txtName.Text);
            cmd.ExecuteNonQuery();

            //SqlConnection con = new SqlConnection(conString);
            //con.Open();
            //if (con.State == System.Data.ConnectionState.Open)
            //string q = "insert into User_Info(name)values('" + txtName.Text.ToString() + "')";
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "INSERT into User_Info(name)values('" + txtName.Text.ToString() + "')";
            //cmd.Connection = con;



            // cmd.ExecuteNonQuery();
            // MessageBox.Show("Connection successful");
        }
    }
}

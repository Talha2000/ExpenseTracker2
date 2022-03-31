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
    public partial class FormEntry : Form
    {
        string user;
        public FormEntry()
        {
            InitializeComponent();
        }

        public FormEntry(string curr_user)
        {
            InitializeComponent();
            user = curr_user;
            Console.WriteLine(user);
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TH286H6;Initial Catalog=ExpenseTrackerDB;Integrated Security=True");

        void SaveData()
        {
            SqlCommand command = new SqlCommand("select ID as 'id', username as 'Name', Item as 'item_type', Amount as 'amount', " +
                                                "EntryDate as 'Date' from UserEntry where username = '" + user + "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            //dataGridView1.DataSource = dt;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            SaveData();
        }

        //SqlConnection conn = new SqlConnection(Program.connString);
        private void enterValues_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            //check that no text boxes are left empty
            if (itemBox.TextLength == 0 || amountBox.TextLength == 0)
            {
                MessageBox.Show("Fill out all required parts of the form");
                itemBox.Focus();
            }
            else
            {
                //check that int required text boxes are only given numbers
                if (!int.TryParse(amountBox.Text, out _))
                {
                    MessageBox.Show("Amount section must be a number");
                }
                else
                {
                    Console.Write(user);
                    Console.Write(itemBox);
                    Console.Write(amountBox);
                    Console.Write(currentDate);
                    con.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO UserEntry values ('" + user + "','" + itemBox.Text + "','" + int.Parse(amountBox.Text) + "','" + currentDate + "')", con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfully Inserted Values!");
                    con.Close();
                    SaveData();
                    itemBox.Text = "";
                    amountBox.Text = "";
                    //comboBox1.SelectedItem = null;
                    //clearDate();
                    itemBox.Focus();
                }
            }
            // Save the ID and UserID from both tables into variables
            // Check if they are the same
            // Insert new values into table for corresponding ID
            //string query = "SELECT * FROM Login WHERE ";
            //string sql = string.format("SELECT * FROM Login WHERE Username='{0}' AND Password='{1}'", txtUser.Text, txtPass.Text);
            //cm = new SqlCommand(sql, cn);
            //var dr = cm.ExecuteReader();
            //if (dr.Read()) // Read() returns TRUE if there are records to read, or FALSE if there is nothing
            //{
            //    fname = dr["fullname"];
            //    UserID = dr["ID"].ToString();


                //using (SqlConnection conn = new SqlConnection(Program.connString))
                //{
                //    {
                //        try
                //        {
                //            conn.Open();
                //            string query = "insert into UserEntry(Item, Amount, EntryDate) values(@Item, @Amount, @EntryDate)";
                //            using (SqlCommand cmd = new SqlCommand(query, conn))
                //            {
                //                cmd.Parameters.AddWithValue("@Item", itemBox.Text);
                //                cmd.Parameters.AddWithValue("@Amount", amountBox.Text);
                //                cmd.Parameters.AddWithValue("@EntryDate", currentDate);
                //                cmd.ExecuteNonQuery();
                //            }
                //        }
                //        catch (Exception ex)
                //        {
                //            // We should log the error somewhere, 
                //            MessageBox.Show("ERROR: hello" + ex.Message);
                //        }
                //    }
                //}
            }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }
    }
}


//private void button1_Click(object sender, EventArgs e)
//{
//    // login button
//    String username, password;

//    username = txtName.Text;
//    password = txtPass.Text;

//    try
//    {
//        String query = "SELECT * FROM Login WHERE username = '" + txtName.Text + "' AND password = '" + txtPass.Text + "'";
//        SqlDataAdapter sda = new SqlDataAdapter(query, con);

//        DataTable dtable = new DataTable();
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
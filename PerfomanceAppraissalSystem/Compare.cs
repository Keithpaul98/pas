using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PerfomanceAppraissalSystem
{
    public partial class Compare : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Compare()
        {
            server = "localhost";
            database = "PerformanceAppraissalSystem";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString); 

            InitializeComponent();
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the  
                //error number.              
                //The two most common error numbers when connecting are as follows:   
                //0: Cannot connect to server.       
                //1045: Invalid user name and/or password.     
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        } 




        private void kuona()
        {
            if (this.OpenConnection() == true)
            {
                try
                {
                    String query = "Select e.Firstname, e.Lastname, r.Rating, r.Period, r.Year, e.Department, e.JobTitle FROM employees e, ratings r Where e.EmployeeID = r.EmployeeID and e.EmployeeID = '" + txtCompEmpID2.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(dr["Firstname"].ToString());
                        item.SubItems.Add(dr["Lastname"].ToString());
                        item.SubItems.Add(dr["Rating"].ToString());
                        item.SubItems.Add(dr["Period"].ToString());
                        item.SubItems.Add(dr["Year"].ToString());
                        item.SubItems.Add(dr["Department"].ToString());
                        item.SubItems.Add(dr["JobTitle"].ToString());

                        listView1.Items.Add(item);
                    }
                    this.CloseConnection();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("user cannot be displayed" + ex.Message);
                }
            }
        }

        private void wona()
        {
            if (this.OpenConnection() == true)
            {
                try
                {
                    String query1 = "Select e.Firstname, e.Lastname, r.Rating, r.Period, r.Year, e.Department, e.JobTitle FROM employees e, ratings r Where e.EmployeeID = r.EmployeeID and e.EmployeeID = '" + txtCompEmpID.Text + "'";
                    MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                    cmd1.ExecuteNonQuery();
                    MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);

                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        ListViewItem items = new ListViewItem(dr1["Firstname"].ToString());
                        items.SubItems.Add(dr1["Lastname"].ToString());                     
                        items.SubItems.Add(dr1["Rating"].ToString());
                        items.SubItems.Add(dr1["Period"].ToString());
                        items.SubItems.Add(dr1["Year"].ToString());
                        items.SubItems.Add(dr1["Department"].ToString());
                        items.SubItems.Add(dr1["JobTitle"].ToString());

                        listView2.Items.Add(items);
                    }
                    this.CloseConnection();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("users cannnot be compared" + ex.Message);
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCompEmpID.Text == "" || txtCompEmpID.Text == "")
            {
                MessageBox.Show("Please, enter employee ID for employees to be compared");
            }
            else
            {
                wona();
                kuona();
                MessageBox.Show("Here are your employee details");
            }



            clear();
        }

        void clear()
        { }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void cmdTask_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tasks t = new Tasks();
            t.Show();
        }

        private void cmdRatings_Click(object sender, EventArgs e)
        {
             this.Hide();
            BossBoardRating BBR = new BossBoardRating();
            BBR.Show();
        
        }

        private void cmdEvalu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Evaluations ev = new Evaluations();
            ev.Show();
        }

        private void cmdPReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report Pr = new Report();
            Pr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login L = new Login();
            L.Show();
        }

        private void cmdCompare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Compare c = new Compare();
            c.Show();
        }

        private void cmdPReport_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Report pr = new Report();
            pr.Show();
        }

        private void cmdEvalu_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Evaluations E = new Evaluations();
            E.Show();
        }

        private void cmdHome_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void cmdRatings_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            BossBoardRating BBR = new BossBoardRating();
            BBR.Show();
        
        }

        private void cmdTask_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Tasks t = new Tasks();
            t.Show();
        }

        private void cmdLogout_Click(object sender, EventArgs e)
        {

            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void cmdHelp_Click(object sender, EventArgs e)
        {

            Help.ShowHelp(this, "UserManual.chm");
        }
    }
}

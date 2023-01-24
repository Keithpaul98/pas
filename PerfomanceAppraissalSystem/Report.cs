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
    public partial class Report : Form
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Report()
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

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void cmdRatings_Click(object sender, EventArgs e)
        {
            this.Hide();
            BossBoardRating r = new BossBoardRating();
            r.Show();
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

        private void cmdLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void cmdTask_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tasks t = new Tasks();
            t.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdCompare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Compare c = new Compare();
            c.Show();
        }

        private void cmdHelp_Click(object sender, EventArgs e)
        {

            Help.ShowHelp(this, "UserManual.chm");
        }

        private void cmdReport_Click(object sender, EventArgs e)
        {
         
                if (this.OpenConnection() == true)
                {
                    try
                    {
                        String query = "select r.Rating, r.Period, r.Year, e.JobTitle, e.Firstname, e.Lastname , e.Department From employees e, ratings r where e.EmployeeID = r.EmployeeID and e.EmployeeID  = '" + txtEmployeeIDReport.Text + "'";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        foreach (DataRow dr in dt.Rows)
                        {
                            ListViewItem item = new ListViewItem(dr["Rating"].ToString());
                            item.SubItems.Add(dr["Period"].ToString());
                            item.SubItems.Add(dr["Year"].ToString());
                            item.SubItems.Add(dr["JobTitle"].ToString());
                            item.SubItems.Add(dr["Firstname"].ToString());
                            item.SubItems.Add(dr["Lastname"].ToString());
                            item.SubItems.Add(dr["Department"].ToString());
                           

                            listView1.Items.Add(item);
                        }
                        this.CloseConnection();
                        MessageBox.Show("Here is your report");


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can't display report" + ex.Message);
                    }
                }

            }
        }
    }


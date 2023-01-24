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
    public partial class EmployeeTask : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public EmployeeTask()
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
            EmployeeHome Eh = new EmployeeHome();
            Eh.Show();
        }

        private void cmdRatings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ratings r = new Ratings();
            r.Show();
        }

        private void cmdTask_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeTask t = new EmployeeTask();
            t.Show();
        }

        private void cmdEvalu_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeEvaluations ev = new EmployeeEvaluations();
            ev.Show();
        }

        private void cmdPReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeReport PR = new EmployeeReport();
            PR.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void cmdChangeTask_Click(object sender, EventArgs e)
        {

            if (this.OpenConnection() == true)
            {

                try
                {
                    String query = "UPDATE tasks SET taskstatus ='" + cmbStatus.Text + "' WHERE taskID= '" + txtTaskID.Text + "' ";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    MessageBox.Show("Task updated");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Task cannot be updated" + ex.Message);
                }

                clear();

            }
        }

        private void clear()
        { }

        private void cmdAddTask_Click(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "Completed task")
            {
                if (this.OpenConnection() == true)
                {
                    try
                    {
                        String query = "INSERT INTO tasks (taskID, taskname, taskstatus) VALUES('" + txtTaskID.Text + "','" + txtTaskname.Text + "','" + cmbStatus.Text + "')";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        this.CloseConnection();
                        MessageBox.Show("Task added");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Task not added" + ex.Message);
                    }

                    clear();

                }
            }

            else if (cmbStatus.Text == "Incomplete task")
            {
                if (this.OpenConnection() == true)
                {
                    try
                    {
                        String query = "INSERT INTO tasks (taskID, Taskname, taskstatus) VALUES('" + txtTaskID.Text + "','" + txtTaskname.Text + "','" + cmbStatus.Text + "')";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        this.CloseConnection();
                        MessageBox.Show("Task added");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Task not added" + ex.Message);
                    }

                    clear();

                }
            }
        }

        private void cmdRemoveTask_Click(object sender, EventArgs e)
        {
            if (this.OpenConnection() == true)
            {
                try
                {
                    String query = "DELETE FROM tasks WHERE TaskID = '" + txtTaskID.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    MessageBox.Show("Task deleted");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Task cannot be deleted" + ex.Message);
                }

                clear();

            }
        }

        private void cmdViewTasks_Click(object sender, EventArgs e)
        {
            if (this.OpenConnection() == true)
            {

                try
                {
                    String query = "Select * FROM tasks where taskID = '"+txtTaskID.Text+"' ";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    //used to list items in the database on in the listview
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["taskID"].ToString());
                        item.SubItems.Add(reader["taskname"].ToString());
                        item.SubItems.Add(reader["taskstatus"].ToString());

                        listView1.Items.Add(item);
                    }
                    this.CloseConnection();

                    MessageBox.Show("Task can be viewed");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Task cannot be viewed" + ex.Message);
                }

                clear();

            }
        }

        private void cmdHelp_Click(object sender, EventArgs e)
        {

            Help.ShowHelp(this, "UserManual.chm");
        }
    }
}

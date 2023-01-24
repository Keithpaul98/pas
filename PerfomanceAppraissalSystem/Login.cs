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
    public partial class Login : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Login()
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


        private void cmdLogin_Click(object sender, EventArgs e)
        {
            if (cmbUserType.Text == "Boss")
            {
                try
                {
                    //if (this.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand("Select * from employees where EmployeeID = '" + this.txtEmpIDLog.Text + "' and Password = '" + this.txtLogPwd.Text + "'", connection);
                        MySqlDataReader myreader;
                        connection.Open();
                        myreader = cmd.ExecuteReader();
                        int count = 0;
                        while (myreader.Read())
                        {
                            count = count + 1;
                        }
                        if (count == 1)
                        {
                            MessageBox.Show("login successful");
                            this.Hide();
                            Home h = new Home();
                            h.Show();
                        }

                        else if (count > 1)
                        {
                            MessageBox.Show("login not successful duplicated details");
                        }

                        else
                            MessageBox.Show("login not successful");
                        connection.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (cmbUserType.Text == "Employee")
            {
                try
                {
                   // if (this.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand("Select * from employees where EmployeeID = '" + this.txtEmpIDLog.Text + "' and Password = '" + this.txtLogPwd.Text + "'", connection);
                        MySqlDataReader myreader;
                        connection.Open();
                        myreader = cmd.ExecuteReader();
                        int count = 0;
                        while (myreader.Read())
                        {
                            count = count + 1;
                        }
                        if (count == 1)
                        {
                            MessageBox.Show("login chanchn");
                            this.Hide();
                            EmployeeHome Eh = new EmployeeHome();
                            Eh.Show();
                        }

                        else if (count > 1)
                        {
                            MessageBox.Show("login not successful duplicate chnchn");
                        }

                        else
                            MessageBox.Show("login not successful");
                        connection.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            if (cmbUserType.Text == "Board")
            {
                try
                {
                    {
                        MySqlCommand cmd = new MySqlCommand("Select * from employees where EmployeeID = '" + this.txtEmpIDLog.Text + "' and Password = '" + this.txtLogPwd.Text + "'", connection);
                        MySqlDataReader myreader;
                        connection.Open();
                        myreader = cmd.ExecuteReader();
                        int count = 0;
                        while (myreader.Read())
                        {
                            count = count + 1;
                        }
                        if (count == 1)
                        {
                            MessageBox.Show("login chanchn");
                            this.Hide();
                            Home h = new Home();
                            h.Show();
                        }

                        else if (count > 1)
                        {
                            MessageBox.Show("login not successful duplicate chnchn");
                        }

                        else
                            MessageBox.Show("login not successful");
                        connection.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
              

       }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdReset_Click(object sender, EventArgs e)
        {
            //Change to another page
            this.Hide();
            Register r = new Register();
            r.Show();
        }
        }

    }

﻿using System;
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
    public partial class Home : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Home()
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



        private void cmdCompare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Compare c = new Compare();
            c.Show();
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
            Evaluations E = new Evaluations();
            E.Show();
        }

        private void cmdPReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report pr = new Report();
            pr.Show();
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

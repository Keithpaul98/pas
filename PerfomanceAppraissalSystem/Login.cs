using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace PerfomanceAppraissalSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            // Get the DatabaseManager instance
            DatabaseManager dbManager = DatabaseManager.Instance;
            
            // Validate input fields
            if (string.IsNullOrEmpty(txtEmpIDLog.Text) || string.IsNullOrEmpty(txtLogPwd.Text))
            {
                MessageBox.Show("Please enter both Employee ID and Password");
                return;
            }

            // Determine user type based on radio button selection
            string userType = "Employee"; // Default
            if (rdBoss.Checked)
            {
                userType = "Boss";
            }
            else if (rdBoard.Checked)
            {
                userType = "Board";
            }

            try
            {
                // Use DatabaseManager to authenticate user
                bool isAuthenticated = dbManager.AuthenticateUser(txtEmpIDLog.Text, txtLogPwd.Text, userType);
                
                if (isAuthenticated)
                {
                    // Authentication successful, proceed based on user type
                    if (rdBoss.Checked)
                    {
                        // Check if user exists in bosses table
                        Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
                            { "@employeeId", txtEmpIDLog.Text }
                        };
                        
                        DataTable bossTable = dbManager.ExecuteQuery(
                            "SELECT * FROM bosses WHERE EmployeeID = @employeeId", 
                            parameters);
                        
                        if (bossTable.Rows.Count > 0)
                        {
                            // User is a boss, open boss form
                            this.Hide();
                            Home home = new Home();
                            home.Show();
                        }
                        else
                        {
                            MessageBox.Show("You are not registered as a boss");
                        }
                    }
                    else if (rdEmployee.Checked)
                    {
                        // User is an employee, open employee form
                        this.Hide();
                        EmployeeHome employeeHome = new EmployeeHome();
                        employeeHome.Show();
                    }
                    else if (rdBoard.Checked)
                    {
                        // Check if user exists in boardmembers table
                        Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
                            { "@employeeId", txtEmpIDLog.Text }
                        };
                        
                        DataTable boardTable = dbManager.ExecuteQuery(
                            "SELECT * FROM boardmembers WHERE EmployeeID = @employeeId", 
                            parameters);
                        
                        if (boardTable.Rows.Count > 0)
                        {
                            // User is a board member, open board form
                            this.Hide();
                            BoardHome boardHome = new BoardHome();
                            boardHome.Show();
                        }
                        else
                        {
                            MessageBox.Show("You are not registered as a board member");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message);
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

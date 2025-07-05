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
    public partial class Register : Form
    {
        private NpgsqlConnection connection;
        private string server;
        private string database;
        private string username;
        private string password;

        public Register()
        {
            server = "localhost";
            database = "PerformanceAppraissalSystem";
            username = "postgres"; 
            password = ""; 
            string connectionString;
            connectionString = "Host=" + server + ";Database=" +
            database + ";Username=" + username + ";Password=" + password + ";";
            connection = new NpgsqlConnection(connectionString);


            InitializeComponent();
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (NpgsqlException ex)
            {
                switch (ex.SqlState)
                {
                    case "08001":
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;
                    case "28P01":
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        MessageBox.Show("Database error: " + ex.Message);
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
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            if (txtEmpID.Text == "" || txtFname.Text == "" || txtLname.Text == "" ||txtEmail.Text == "" || txtJobTitle.Text == "" || txtPassword.Text == "" || txtConfirmPwd.Text == "")
                MessageBox.Show("Fill the mandatory fields");
            else if (txtPassword.Text != txtConfirmPwd.Text)
                MessageBox.Show("Passwords do not match");
            else
            {
                string gender;

                if (rdbFemale.Checked == true)
                {
                    gender = "Female";

                    DateTime dt = dateTimePicker1.Value.Date;

                    if (cmbDepartment.Text == "Domestic Taxes")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Email, Gender, DateOfBirth, Department, Password) VALUES(@empId, @fname, @lname, @email, @gender, @dob, @dept, @pwd)";
                                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                                cmd.Parameters.AddWithValue("@empId", txtEmpID.Text);
                                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                                cmd.Parameters.AddWithValue("@gender", gender);
                                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                                cmd.Parameters.AddWithValue("@dept", cmbDepartment.Text);
                                cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                this.Hide();
                                Login l = new Login();
                                l.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("user not registered" + ex.Message);
                            }
                        }
                    }

                    else if (cmbDepartment.Text == "Customs and Excise Taxes")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth, Password) VALUES(@empId, @fname, @lname, @dept, @jobTitle, @email, @gender, @dob, @pwd)";
                                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                                cmd.Parameters.AddWithValue("@empId", txtEmpID.Text);
                                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                                cmd.Parameters.AddWithValue("@dept", cmbDepartment.Text);
                                cmd.Parameters.AddWithValue("@jobTitle", txtJobTitle.Text);
                                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                                cmd.Parameters.AddWithValue("@gender", gender);
                                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                                cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                this.Hide();
                                Login l = new Login();
                                l.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("user not registered" + ex.Message);
                            }
                        }
                    }

                    else if (cmbDepartment.Text == "Audit")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth, Password) VALUES(@empId, @fname, @lname, @dept, @jobTitle, @email, @gender, @dob, @pwd)";
                                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                                cmd.Parameters.AddWithValue("@empId", txtEmpID.Text);
                                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                                cmd.Parameters.AddWithValue("@dept", cmbDepartment.Text);
                                cmd.Parameters.AddWithValue("@jobTitle", txtJobTitle.Text);
                                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                                cmd.Parameters.AddWithValue("@gender", gender);
                                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                                cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                this.Hide();
                                Login l = new Login();
                                l.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("user not registered" + ex.Message);
                            }
                        }
                    }

                    else if (cmbDepartment.Text == "Internal Affairs")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth, Password) VALUES(@empId, @fname, @lname, @dept, @jobTitle, @email, @gender, @dob, @pwd)";
                                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                                cmd.Parameters.AddWithValue("@empId", txtEmpID.Text);
                                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                                cmd.Parameters.AddWithValue("@dept", cmbDepartment.Text);
                                cmd.Parameters.AddWithValue("@jobTitle", txtJobTitle.Text);
                                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                                cmd.Parameters.AddWithValue("@gender", gender);
                                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                                cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                this.Hide();
                                Login l = new Login();
                                l.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("user not registered" + ex.Message);
                            }
                        }
                    }

                    else if (cmbDepartment.Text == "Administration")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth, Password) VALUES(@empId, @fname, @lname, @dept, @jobTitle, @email, @gender, @dob, @pwd)";
                                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                                cmd.Parameters.AddWithValue("@empId", txtEmpID.Text);
                                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                                cmd.Parameters.AddWithValue("@dept", cmbDepartment.Text);
                                cmd.Parameters.AddWithValue("@jobTitle", txtJobTitle.Text);
                                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                                cmd.Parameters.AddWithValue("@gender", gender);
                                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                                cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                this.Hide();
                                Login l = new Login();
                                l.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("user not registered" + ex.Message);
                            }
                        }
                    }

                    else if (cmbDepartment.Text == "Finance")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth, Password) VALUES(@empId, @fname, @lname, @dept, @jobTitle, @email, @gender, @dob, @pwd)";
                                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                                cmd.Parameters.AddWithValue("@empId", txtEmpID.Text);
                                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                                cmd.Parameters.AddWithValue("@dept", cmbDepartment.Text);
                                cmd.Parameters.AddWithValue("@jobTitle", txtJobTitle.Text);
                                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                                cmd.Parameters.AddWithValue("@gender", gender);
                                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                                cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                this.Hide();
                                Login l = new Login();
                                l.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("user not registered" + ex.Message);
                            }
                        }
                    }

                    else if (cmbDepartment.Text == "Supply Chain Management")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth, Password) VALUES(@empId, @fname, @lname, @dept, @jobTitle, @email, @gender, @dob, @pwd)";
                                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                                cmd.Parameters.AddWithValue("@empId", txtEmpID.Text);
                                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                                cmd.Parameters.AddWithValue("@dept", cmbDepartment.Text);
                                cmd.Parameters.AddWithValue("@jobTitle", txtJobTitle.Text);
                                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                                cmd.Parameters.AddWithValue("@gender", gender);
                                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                                cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                this.Hide();
                                Login l = new Login();
                                l.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("user not registered" + ex.Message);
                            }
                        }
                    }

                    else if (cmbDepartment.Text == "Tax Investigation")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth, Password) VALUES(@empId, @fname, @lname, @dept, @jobTitle, @email, @gender, @dob, @pwd)";
                                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                                cmd.Parameters.AddWithValue("@empId", txtEmpID.Text);
                                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                                cmd.Parameters.AddWithValue("@dept", cmbDepartment.Text);
                                cmd.Parameters.AddWithValue("@jobTitle", txtJobTitle.Text);
                                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                                cmd.Parameters.AddWithValue("@gender", gender);
                                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                                cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                this.Hide();
                                Login l = new Login();
                                l.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("user not registered" + ex.Message);
                            }
                        }
                    }

                    else if (cmbDepartment.Text == "Human Resource")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth, Password) VALUES(@empId, @fname, @lname, @dept, @jobTitle, @email, @gender, @dob, @pwd)";
                                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                                cmd.Parameters.AddWithValue("@empId", txtEmpID.Text);
                                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                                cmd.Parameters.AddWithValue("@dept", cmbDepartment.Text);
                                cmd.Parameters.AddWithValue("@jobTitle", txtJobTitle.Text);
                                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                                cmd.Parameters.AddWithValue("@gender", gender);
                                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                                cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                this.Hide();
                                Login l = new Login();
                                l.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("user not registered" + ex.Message);
                            }
                        }
                    }

                    else if (cmbDepartment.Text == "Cooperate Affairs")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth, Password) VALUES(@empId, @fname, @lname, @dept, @jobTitle, @email, @gender, @dob, @pwd)";
                                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                                cmd.Parameters.AddWithValue("@empId", txtEmpID.Text);
                                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                                cmd.Parameters.AddWithValue("@dept", cmbDepartment.Text);
                                cmd.Parameters.AddWithValue("@jobTitle", txtJobTitle.Text);
                                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                                cmd.Parameters.AddWithValue("@gender", gender);
                                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                                cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                this.Hide();
                                Login l = new Login();
                                l.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("user not registered" + ex.Message);
                            }
                        }
                    }

                    else if (cmbDepartment.Text == "Risk Enterprise")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth, Password) VALUES(@empId, @fname, @lname, @dept, @jobTitle, @email, @gender, @dob, @pwd)";
                                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                                cmd.Parameters.AddWithValue("@empId", txtEmpID.Text);
                                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                                cmd.Parameters.AddWithValue("@dept", cmbDepartment.Text);
                                cmd.Parameters.AddWithValue("@jobTitle", txtJobTitle.Text);
                                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                                cmd.Parameters.AddWithValue("@gender", gender);
                                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                                cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                this.Hide();
                                Login l = new Login();
                                l.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("user not registered" + ex.Message);
                            }
                        }
                    }

                    else if (cmbDepartment.Text == "Information Communication Technology")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth, Password) VALUES(@empId, @fname, @lname, @dept, @jobTitle, @email, @gender, @dob, @pwd)";
                                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                                cmd.Parameters.AddWithValue("@empId", txtEmpID.Text);
                                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                                cmd.Parameters.AddWithValue("@dept", cmbDepartment.Text);
                                cmd.Parameters.AddWithValue("@jobTitle", txtJobTitle.Text);
                                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                                cmd.Parameters.AddWithValue("@gender", gender);
                                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                                cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                this.Hide();
                                Login l = new Login();
                                l.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("user not registered" + ex.Message);
                            }
                        }
                    }

                    else
                    {
                        MessageBox.Show("Select department");
                    }
                }

                else if (rdbMale.Checked == true)
                {
                    gender = "Male";

                    DateTime dt = dateTimePicker1.Value.Date;

                    if (cmbDepartment.Text == "Domestic Taxes")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Email, Gender, DateOfBirth, Department, Password) VALUES(@empId, @fname, @lname, @email, @gender, @dob, @dept, @pwd)";
                                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                                cmd.Parameters.AddWithValue("@empId", txtEmpID.Text);
                                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                                cmd.Parameters.AddWithValue("@gender", gender);
                                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                                cmd.Parameters.AddWithValue("@dept", cmbDepartment.Text);
                                cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                this.Hide();
                                Login l = new Login();
                                l.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("user not registered" + ex.Message);
                            }
                        }
                    }

                    else if (cmbDepartment.Text == "Customs and Excise Taxes")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth, Password) VALUES(@empId, @fname, @lname, @dept, @jobTitle, @email, @gender, @dob, @pwd)";
                                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                                cmd.Parameters.AddWithValue("@empId", txtEmpID.Text);
                                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                                cmd.Parameters.AddWithValue("@dept", cmbDepartment.Text);
                                cmd.Parameters.AddWithValue("@jobTitle", txtJobTitle.Text);
                                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                                cmd.Parameters.AddWithValue("@gender", gender);
                                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                                cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                this.Hide();
                                Login l = new Login();
                                l.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("user not registered" + ex.Message);
                            }
                        }
                    }

                    else if (cmbDepartment.Text == "Audit")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth, Password) VALUES(@empId, @fname, @lname, @dept, @jobTitle, @email, @gender, @dob, @pwd)";
                                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                                cmd.Parameters.AddWithValue("@empId", txtEmpID.Text);
                                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                                cmd.Parameters.AddWithValue("@dept", cmbDepartment.Text);
                                cmd.Parameters.AddWithValue("@jobTitle", txtJobTitle.Text);
                                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                                cmd.Parameters.AddWithValue("@gender", gender);
                                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                                cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                this.Hide();
                                Login l = new Login();
                                l.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("user not registered" + ex.Message);
                            }
                        }
                    }

                    else if (cmbDepartment.Text == "Internal Affairs")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth, Password) VALUES(@empId, @fname, @lname, @dept, @jobTitle, @email, @gender, @dob, @pwd)";
                                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                                cmd.Parameters.AddWithValue("@empId", txtEmpID.Text);
                                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                                cmd.Parameters.AddWithValue("@dept", cmbDepartment.Text);
                                cmd.Parameters.AddWithValue("@jobTitle", txtJobTitle.Text);
                                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                                cmd.Parameters.AddWithValue("@gender", gender);
                                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                                cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                this.Hide();
                                Login l = new Login();
                                l.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("user not registered" + ex.Message);
                            }
                        }
                    }

                    else if (cmbDepartment.Text == "Administration")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth, Password) VALUES(@empId, @fname, @lname, @dept, @jobTitle, @email, @gender, @dob, @pwd)";
                                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                                cmd.Parameters.AddWithValue("@empId", txtEmpID.Text);
                                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                                cmd.Parameters.AddWithValue("@dept", cmbDepartment.Text);
                                cmd.Parameters.AddWithValue("@jobTitle", txtJobTitle.Text);
                                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                                cmd.Parameters.AddWithValue("@gender", gender);
                                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                                cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                this.Hide();
                                Login l = new Login();
                                l.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("user not registered" + ex.Message);
                            }
                        }
                    }

                    else if (cmbDepartment.Text == "Finance")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth, Password) VALUES(@empId, @fname, @lname, @dept, @jobTitle, @email, @gender, @dob, @pwd)";
                                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                                cmd.Parameters.AddWithValue("@empId", txtEmpID.Text);
                                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                                cmd.Parameters.AddWithValue("@dept", cmbDepartment.Text);
                                cmd.Parameters.AddWithValue("@jobTitle", txtJobTitle.Text);
                                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                                cmd.Parameters.AddWithValue("@gender", gender);
                                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                                cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                this.Hide();
                                Login l = new Login();
                                l.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("user not registered" + ex.Message);
                            }
                        }
                    }

                    else if (cmbDepartment.Text == "Supply Chain Management")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth, Password) VALUES(@empId, @fname, @lname, @dept, @jobTitle, @email, @gender, @dob, @pwd)";
                                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                                cmd.Parameters.AddWithValue("@empId", txtEmpID.Text);
                                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                                cmd.Parameters.AddWithValue("@dept", cmbDepartment.Text);
                                cmd.Parameters.AddWithValue("@jobTitle", txtJobTitle.Text);
                                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                                cmd.Parameters.AddWithValue("@gender", gender);
                                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                                cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                this.Hide();
                                Login l = new Login();
                                l.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("user not registered" + ex.Message);
                            }
                        }
                    }

                    else if (cmbDepartment.Text == "Tax Investigation")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth, Password) VALUES(@empId, @fname, @lname, @dept, @jobTitle, @email, @gender, @dob, @pwd)";
                                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                                cmd.Parameters.AddWithValue("@empId", txtEmpID.Text);
                                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                                cmd.Parameters.AddWithValue("@dept", cmbDepartment.Text);
                                cmd.Parameters.AddWithValue("@jobTitle", txtJobTitle.Text);
                                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                                cmd.Parameters.AddWithValue("@gender", gender);
                                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                                cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                this.Hide();
                                Login l = new Login();
                                l.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("user not registered" + ex.Message);
                            }
                        }
                    }

                    else if (cmbDepartment.Text == "Human Resource")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth, Password) VALUES(@empId, @fname, @lname, @dept, @jobTitle, @email, @gender, @dob, @pwd)";
                                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                                cmd.Parameters.AddWithValue("@empId", txtEmpID.Text);
                                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                                cmd.Parameters.AddWithValue("@dept", cmbDepartment.Text);
                                cmd.Parameters.AddWithValue("@jobTitle", txtJobTitle.Text);
                                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                                cmd.Parameters.AddWithValue("@gender", gender);
                                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                                cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                this.Hide();
                                Login l = new Login();
                                l.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("user not registered" + ex.Message);
                            }
                        }
                    }

                    else if (cmbDepartment.Text == "Cooperate Affairs")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth, Password) VALUES(@empId, @fname, @lname, @dept, @jobTitle, @email, @gender, @dob, @pwd)";
                                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                                cmd.Parameters.AddWithValue("@empId", txtEmpID.Text);
                                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                                cmd.Parameters.AddWithValue("@dept", cmbDepartment.Text);
                                cmd.Parameters.AddWithValue("@jobTitle", txtJobTitle.Text);
                                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                                cmd.Parameters.AddWithValue("@gender", gender);
                                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                                cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                this.Hide();
                                Login l = new Login();
                                l.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("user not registered" + ex.Message);
                            }
                        }
                    }

                    else if (cmbDepartment.Text == "Risk Enterprise")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth, Password) VALUES(@empId, @fname, @lname, @dept, @jobTitle, @email, @gender, @dob, @pwd)";
                                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                                cmd.Parameters.AddWithValue("@empId", txtEmpID.Text);
                                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                                cmd.Parameters.AddWithValue("@dept", cmbDepartment.Text);
                                cmd.Parameters.AddWithValue("@jobTitle", txtJobTitle.Text);
                                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                                cmd.Parameters.AddWithValue("@gender", gender);
                                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                                cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                this.Hide();
                                Login l = new Login();
                                l.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("user not registered" + ex.Message);
                            }
                        }
                    }

                    else if (cmbDepartment.Text == "Information Communication Technology")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth, Password) VALUES(@empId, @fname, @lname, @dept, @jobTitle, @email, @gender, @dob, @pwd)";
                                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                                cmd.Parameters.AddWithValue("@empId", txtEmpID.Text);
                                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                                cmd.Parameters.AddWithValue("@dept", cmbDepartment.Text);
                                cmd.Parameters.AddWithValue("@jobTitle", txtJobTitle.Text);
                                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                                cmd.Parameters.AddWithValue("@gender", gender);
                                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                                cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                this.Hide();
                                Login l = new Login();
                                l.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("user not registered" + ex.Message);
                            }
                        }
                    }

                    else
                    {
                        MessageBox.Show("Select department");
                    }
                }

                else
                {
                    MessageBox.Show("Select gender");
                }
            }
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class Register : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Register()
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

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            //to ensure that the fields are not empty
            if (txtEmpID.Text == "" || txtFname.Text == "" || txtLname.Text == "" ||txtEmail.Text == "" || txtJobTitle.Text == "" || txtPassword.Text == "" || txtConfirmPwd.Text == "")
                MessageBox.Show("Fill the mandatory fields");
            //ensure that the passwords match
            else if (txtPassword.Text != txtConfirmPwd.Text)
                MessageBox.Show("Passwords do not match");
            //insert the information in the fields sothat they can be stored in the database
            else
            {
                string gender;

                if (rdbFemale.Checked == true)
                {
                    gender = "Female";

                    DateTime dt = dateTimePicker1.Value.Date;

                    //if user select department Domestic Taxes
                    if (cmbDepartment.Text == "Domestic Taxes")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Email, Gender, DateOfBirth, Department, Password) VALUES('" + txtEmpID.Text + "','" + txtFname.Text + "', '" + txtLname.Text + "','" + txtEmail.Text + "','" + gender + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + cmbDepartment.Text + "','" + txtPassword.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                //Change to another page
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


                        //if user select department Customs and Excise Taxes
                    else if (cmbDepartment.Text == "Customs and Excise Taxes")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth,  Password) VALUES('" + txtEmpID.Text + "','" + txtFname.Text + "', '" + txtLname.Text + "','" + cmbDepartment.Text + "', '" + txtJobTitle.Text + "','" + txtEmail.Text + "','" + gender + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + txtPassword.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");


                                //Change to another page
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


                        //if user select department Audit
                    else if (cmbDepartment.Text == "Audit")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth,  Password) VALUES('" + txtEmpID.Text + "','" + txtFname.Text + "', '" + txtLname.Text + "','" + cmbDepartment.Text + "', '" + txtJobTitle.Text + "','" + txtEmail.Text + "','" + gender + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + txtPassword.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                //Change to another page
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



                        //if user select department Internal Affairs
                    else if (cmbDepartment.Text == "Internal Affairs")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth,  Password) VALUES('" + txtEmpID.Text + "','" + txtFname.Text + "', '" + txtLname.Text + "','" + cmbDepartment.Text + "', '" + txtJobTitle.Text + "','" + txtEmail.Text + "','" + gender + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + txtPassword.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");


                                //Change to another page
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



                        //if user select department Administration
                    else if (cmbDepartment.Text == "Administration")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth,  Password) VALUES('" + txtEmpID.Text + "','" + txtFname.Text + "', '" + txtLname.Text + "','" + cmbDepartment.Text + "', '" + txtJobTitle.Text + "','" + txtEmail.Text + "','" + gender + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + txtPassword.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");


                                //Change to another page
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


                        //if user select department Finance
                    else if (cmbDepartment.Text == "Finance")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth,  Password) VALUES('" + txtEmpID.Text + "','" + txtFname.Text + "', '" + txtLname.Text + "','" + cmbDepartment.Text + "', '" + txtJobTitle.Text + "','" + txtEmail.Text + "','" + gender + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + txtPassword.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");


                                //Change to another page
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


                        //if user select department Supply Chain Management
                    else if (cmbDepartment.Text == "Supply Chain Management")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth,  Password) VALUES('" + txtEmpID.Text + "','" + txtFname.Text + "', '" + txtLname.Text + "','" + cmbDepartment.Text + "', '" + txtJobTitle.Text + "','" + txtEmail.Text + "','" + gender + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + txtPassword.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                //Change to another page
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


                        //if user select department Tax Investigation
                    else if (cmbDepartment.Text == "Tax Investigation")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth,  Password) VALUES('" + txtEmpID.Text + "','" + txtFname.Text + "', '" + txtLname.Text + "','" + cmbDepartment.Text + "', '" + txtJobTitle.Text + "','" + txtEmail.Text + "','" + gender + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + txtPassword.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");


                                //Change to another page
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



                        //if user select department Human Resource
                    else if (cmbDepartment.Text == "Human Resource")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth,  Password) VALUES('" + txtEmpID.Text + "','" + txtFname.Text + "', '" + txtLname.Text + "','" + cmbDepartment.Text + "', '" + txtJobTitle.Text + "','" + txtEmail.Text + "','" + gender + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + txtPassword.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");


                                //Change to another page
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


                        //if user select department Cooperate Affairs
                    else if (cmbDepartment.Text == "Cooperate Affairs")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth,  Password) VALUES('" + txtEmpID.Text + "','" + txtFname.Text + "', '" + txtLname.Text + "','" + cmbDepartment.Text + "', '" + txtJobTitle.Text + "','" + txtEmail.Text + "','" + gender + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + txtPassword.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");


                                //Change to another page
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


                        //if user select department Risk Enterprise
                    else if (cmbDepartment.Text == "Risk Enterprise")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth,  Password) VALUES('" + txtEmpID.Text + "','" + txtFname.Text + "', '" + txtLname.Text + "','" + cmbDepartment.Text + "', '" + txtJobTitle.Text + "','" + txtEmail.Text + "','" + gender + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + txtPassword.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");


                                //Change to another page
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


                        //if user select department Information Communication Technology
                    else if (cmbDepartment.Text == "Information Communication Technology")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth,  Password) VALUES('" + txtEmpID.Text + "','" + txtFname.Text + "', '" + txtLname.Text + "','" + cmbDepartment.Text + "', '" + txtJobTitle.Text + "','" + txtEmail.Text + "','" + gender + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + txtPassword.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                //Change to another page
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
                        MessageBox.Show("Select depertment");
                    }
                }


                else if (rdbMale.Checked == true)
                {
                    gender = "Male";

                    DateTime dt = dateTimePicker1.Value.Date;

                    //if user select department Domestic Taxes
                    if (cmbDepartment.Text == "Domestic Taxes")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO users (EmployeeID, Firstname, Lastname, Email, Gender, DateOfBirth, Department, Password) VALUES('" + txtEmpID.Text + "','" + txtFname.Text + "', '" + txtLname.Text + "','" + txtEmail.Text + "','" + gender + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + cmbDepartment.Text + "','" + txtPassword.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                //Change to another page
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


                    //if user select department Customs and Excise Taxes
                    else if (cmbDepartment.Text == "Customs and Excise Taxes")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth,  Password) VALUES('" + txtEmpID.Text + "','" + txtFname.Text + "', '" + txtLname.Text + "','" + cmbDepartment.Text + "', '" + txtJobTitle.Text + "','" + txtEmail.Text + "','" + gender + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + txtPassword.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                //Change to another page
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


                    //if user select department Audit
                    else if (cmbDepartment.Text == "Audit")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth,  Password) VALUES('" + txtEmpID.Text + "','" + txtFname.Text + "', '" + txtLname.Text + "','" + cmbDepartment.Text + "', '" + txtJobTitle.Text + "','" + txtEmail.Text + "','" + gender + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + txtPassword.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                //Change to another page
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



                    //if user select department Internal Affairs
                    else if (cmbDepartment.Text == "Internal Affairs")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth,  Password) VALUES('" + txtEmpID.Text + "','" + txtFname.Text + "', '" + txtLname.Text + "','" + cmbDepartment.Text + "', '" + txtJobTitle.Text + "','" + txtEmail.Text + "','" + gender + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + txtPassword.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                //Change to another page
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



                    //if user select department Administration
                    else if (cmbDepartment.Text == "Administration")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth,  Password) VALUES('" + txtEmpID.Text + "','" + txtFname.Text + "', '" + txtLname.Text + "','" + cmbDepartment.Text + "', '" + txtJobTitle.Text + "','" + txtEmail.Text + "','" + gender + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + txtPassword.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                //Change to another page
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


                    //if user select department Finance
                    else if (cmbDepartment.Text == "Finance")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth,  Password) VALUES('" + txtEmpID.Text + "','" + txtFname.Text + "', '" + txtLname.Text + "','" + cmbDepartment.Text + "', '" + txtJobTitle.Text + "','" + txtEmail.Text + "','" + gender + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + txtPassword.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                //Change to another page
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


                    //if user select department Supply Chain Management
                    else if (cmbDepartment.Text == "Supply Chain Management")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth,  Password) VALUES('" + txtEmpID.Text + "','" + txtFname.Text + "', '" + txtLname.Text + "','" + cmbDepartment.Text + "', '" + txtJobTitle.Text + "','" + txtEmail.Text + "','" + gender + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + txtPassword.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                //Change to another page
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


                    //if user select department Tax Investigation
                    else if (cmbDepartment.Text == "Tax Investigation")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth,  Password) VALUES('" + txtEmpID.Text + "','" + txtFname.Text + "', '" + txtLname.Text + "','" + cmbDepartment.Text + "', '" + txtJobTitle.Text + "','" + txtEmail.Text + "','" + gender + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + txtPassword.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                //Change to another page
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



                    //if user select department Human Resource
                    else if (cmbDepartment.Text == "Human Resource")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth,  Password) VALUES('" + txtEmpID.Text + "','" + txtFname.Text + "', '" + txtLname.Text + "','" + cmbDepartment.Text + "', '" + txtJobTitle.Text + "','" + txtEmail.Text + "','" + gender + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + txtPassword.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                //Change to another page
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


                    //if user select department Cooperate Affairs
                    else if (cmbDepartment.Text == "Cooperate Affairs")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth,  Password) VALUES('" + txtEmpID.Text + "','" + txtFname.Text + "', '" + txtLname.Text + "','" + cmbDepartment.Text + "', '" + txtJobTitle.Text + "','" + txtEmail.Text + "','" + gender + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + txtPassword.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                //Change to another page
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


                    //if user select department Risk Enterprise
                    else if (cmbDepartment.Text == "Risk Enterprise")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth,  Password) VALUES('" + txtEmpID.Text + "','" + txtFname.Text + "', '" + txtLname.Text + "','" + cmbDepartment.Text + "', '" + txtJobTitle.Text + "','" + txtEmail.Text + "','" + gender + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + txtPassword.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                //Change to another page
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


                    //if user select department Information Communication Technology
                    else if (cmbDepartment.Text == "Information Communication Technology")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth,  Password) VALUES('" + txtEmpID.Text + "','" + txtFname.Text + "', '" + txtLname.Text + "','" + cmbDepartment.Text + "', '" + txtJobTitle.Text + "','" + txtEmail.Text + "','" + gender + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + txtPassword.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("user registered");

                                //Change to another page
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
            //Change to another page
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


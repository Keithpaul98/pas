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
        private DatabaseManager dbManager;

        public Register()
        {
            InitializeComponent();
            dbManager = DatabaseManager.Instance;
        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrEmpty(txtEmpID.Text) || string.IsNullOrEmpty(txtFname.Text) || 
                string.IsNullOrEmpty(txtLname.Text) || string.IsNullOrEmpty(txtEmail.Text) || 
                string.IsNullOrEmpty(txtPwd.Text) || string.IsNullOrEmpty(txtJobTitle.Text))
            {
                MessageBox.Show("Please fill in all required fields");
                return;
            }

            try
            {
                // Get gender selection
                string gender = "Male";
                if (rdbFemale.Checked)
                {
                    gender = "Female";
                }

                // Get department selection
                string department = cmbDepartment.Text;
                
                // Register the employee using DatabaseManager
                bool success = dbManager.RegisterEmployee(
                    txtEmpID.Text,
                    txtFname.Text,
                    txtLname.Text,
                    department,
                    txtJobTitle.Text,
                    txtEmail.Text,
                    gender,
                    dateTimePicker1.Value,
                    txtPassword.Text
                );
                
                if (success)
                {
                    MessageBox.Show("Registration successful");
                    this.Hide();
                    Login login = new Login();
                    login.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration error: " + ex.Message);
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

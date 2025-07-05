using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfomanceAppraissalSystem
{
    public partial class Compare : Form
    {
        // Reference to the DatabaseManager singleton
        private readonly DatabaseManager dbManager;

        public Compare()
        {
            // Get the DatabaseManager instance
            dbManager = DatabaseManager.Instance;

            InitializeComponent();
        }

        private void kuona()
        {
            try
            {
                // Input validation
                if (string.IsNullOrEmpty(txtCompEmpID2.Text))
                {
                    MessageBox.Show("Please enter Employee ID for the second employee.", 
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Clear previous results
                listView1.Items.Clear();

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@employeeId", txtCompEmpID2.Text }
                };

                DataTable dt = dbManager.ExecuteQuery(
                    "SELECT e.Firstname, e.Lastname, r.Rating, r.Period, r.Year, e.Department, e.JobTitle " +
                    "FROM employees e, ratings r " +
                    "WHERE e.EmployeeID = r.EmployeeID AND e.EmployeeID = @employeeId",
                    parameters
                );

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No data found for employee ID: " + txtCompEmpID2.Text, 
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving employee data: " + ex.Message, 
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void wona()
        {
            try
            {
                // Input validation
                if (string.IsNullOrEmpty(txtCompEmpID.Text))
                {
                    MessageBox.Show("Please enter Employee ID for the first employee.", 
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Clear previous results
                listView2.Items.Clear();

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@employeeId", txtCompEmpID.Text }
                };

                DataTable dt = dbManager.ExecuteQuery(
                    "SELECT e.Firstname, e.Lastname, r.Rating, r.Period, r.Year, e.Department, e.JobTitle " +
                    "FROM employees e, ratings r " +
                    "WHERE e.EmployeeID = r.EmployeeID AND e.EmployeeID = @employeeId",
                    parameters
                );

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No data found for employee ID: " + txtCompEmpID.Text, 
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem items = new ListViewItem(dr["Firstname"].ToString());
                    items.SubItems.Add(dr["Lastname"].ToString());                     
                    items.SubItems.Add(dr["Rating"].ToString());
                    items.SubItems.Add(dr["Period"].ToString());
                    items.SubItems.Add(dr["Year"].ToString());
                    items.SubItems.Add(dr["Department"].ToString());
                    items.SubItems.Add(dr["JobTitle"].ToString());

                    listView2.Items.Add(items);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving employee data: " + ex.Message, 
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCompEmpID.Text) || string.IsNullOrEmpty(txtCompEmpID2.Text))
            {
                MessageBox.Show("Please enter employee IDs for both employees to be compared.", 
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            wona();
            kuona();
            
            if (listView1.Items.Count > 0 && listView2.Items.Count > 0)
            {
                MessageBox.Show("Employee details retrieved successfully.", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            clear();
        }

        void clear()
        {
            // Add code to clear form fields if needed
        }

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

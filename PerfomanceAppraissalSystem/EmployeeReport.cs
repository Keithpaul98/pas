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
    public partial class EmployeeReport : Form
    {
        // Reference to the DatabaseManager singleton
        private readonly DatabaseManager dbManager;

        public EmployeeReport()
        {
            // Get the DatabaseManager instance
            dbManager = DatabaseManager.Instance;

            InitializeComponent();
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

        private void cmdPReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeReport PR = new EmployeeReport();
            PR.Show();
        }

        private void cmdEvalu_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeEvaluations ev = new EmployeeEvaluations();
            ev.Show();
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

        private void cmdCompare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Compare c = new Compare();
            c.Show();
        }

        private void cmdReport_Click(object sender, EventArgs e)
        {
            // Input validation
            if (string.IsNullOrEmpty(txtEmployeeIDReport.Text))
            {
                MessageBox.Show("Please enter an Employee ID.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Clear previous results
                listView1.Items.Clear();

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@employeeId", txtEmployeeIDReport.Text }
                };

                DataTable dt = dbManager.ExecuteQuery(
                    "SELECT r.Rating, r.Period, r.Year, e.JobTitle, e.Firstname, e.Lastname, e.Department " +
                    "FROM employees e, ratings r " +
                    "WHERE e.EmployeeID = r.EmployeeID AND e.EmployeeID = @employeeId",
                    parameters
                );

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No report data found for the specified employee.", 
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

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

                MessageBox.Show("Report generated successfully.", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message, 
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

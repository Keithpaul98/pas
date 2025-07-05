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
    public partial class EmployeeEvaluations : Form
    {
        // Reference to the DatabaseManager singleton
        private readonly DatabaseManager dbManager;

        public EmployeeEvaluations()
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

        private void cmdLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void cmdCheckEvaluation_Click(object sender, EventArgs e)
        {
            // Input validation
            if (string.IsNullOrEmpty(txtEmployeeIDEvaluation.Text))
            {
                MessageBox.Show("Please enter an Employee ID.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt;
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                
                // Clear previous results
                listView1.Items.Clear();

                if (ckbxAllevaluations.Checked)
                {
                    // Query for all evaluations
                    parameters.Add("@employeeId", txtEmployeeIDEvaluation.Text);
                    
                    dt = dbManager.ExecuteQuery(
                        "SELECT r.Rating, r.Period, r.Year, e.JobTitle, e.Firstname, e.Lastname, " +
                        "r.CommentContent, r.Commenter " +
                        "FROM employees e, ratings r " +
                        "WHERE e.EmployeeID = r.EmployeeID AND e.EmployeeID = @employeeId",
                        parameters
                    );
                }
                else
                {
                    // Input validation for specific evaluation
                    if (string.IsNullOrEmpty(cmbSelectEvaluation.Text) || 
                        string.IsNullOrEmpty(cmbEvaluationType.Text))
                    {
                        MessageBox.Show("Please select both Year and Period for the evaluation.", 
                            "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
                    // Query for specific evaluation period
                    parameters.Add("@employeeId", txtEmployeeIDEvaluation.Text);
                    parameters.Add("@year", cmbSelectEvaluation.Text);
                    parameters.Add("@period", cmbEvaluationType.Text);
                    
                    dt = dbManager.ExecuteQuery(
                        "SELECT r.Rating, r.Period, r.Year, e.JobTitle, e.Firstname, e.Lastname, " +
                        "r.CommentContent, r.Commenter " +
                        "FROM employees e, ratings r " +
                        "WHERE e.EmployeeID = r.EmployeeID AND r.Year = @year " +
                        "AND r.Period = @period AND e.EmployeeID = @employeeId",
                        parameters
                    );
                }

                // Check if any results were found
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No evaluations found for the specified criteria.", 
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Populate the ListView with results
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["Rating"].ToString());
                    item.SubItems.Add(dr["Period"].ToString());
                    item.SubItems.Add(dr["Year"].ToString());
                    item.SubItems.Add(dr["JobTitle"].ToString());
                    item.SubItems.Add(dr["Firstname"].ToString());
                    item.SubItems.Add(dr["Lastname"].ToString());
                    item.SubItems.Add(dr["CommentContent"].ToString());
                    item.SubItems.Add(dr["Commenter"].ToString());

                    listView1.Items.Add(item);
                }

                MessageBox.Show("Evaluations retrieved successfully.", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving evaluations: " + ex.Message, 
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdHelp_Click(object sender, EventArgs e)
        {
            // User manual function
            Help.ShowHelp(this, "UserManual.chm");
        }
    }
}

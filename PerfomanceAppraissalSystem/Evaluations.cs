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
    public partial class Evaluations : Form
    {
        // Reference to the DatabaseManager
        private DatabaseManager dbManager;

        public Evaluations()
        {
            // Get the DatabaseManager instance
            dbManager = DatabaseManager.Instance;

            InitializeComponent();
        }

        private void Evaluations_Load(object sender, EventArgs e)
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

        private void cmdLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void cmdCheckEvaluation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmployeeIDEvaluation.Text))
            {
                MessageBox.Show("Please enter an Employee ID");
                return;
            }

            try
            {
                // Clear the list view before adding new items
                listView1.Items.Clear();

                // Create parameters dictionary for the query
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@employeeId", txtEmployeeIDEvaluation.Text }
                };

                string query;
                
                if (ckbxAllevaluations.Checked)
                {
                    // Query for all evaluations
                    query = @"SELECT r.Rating, r.Period, r.Year, e.JobTitle, e.Firstname, e.Lastname, 
                             r.CommentContent, r.Commenter 
                             FROM employees e, ratings r 
                             WHERE e.EmployeeID = r.EmployeeID AND e.EmployeeID = @employeeId";
                }
                else
                {
                    // Query for specific period and year
                    if (string.IsNullOrEmpty(cmbSelectEvaluation.Text) || string.IsNullOrEmpty(cmbEvaluationType.Text))
                    {
                        MessageBox.Show("Please select both Year and Period for evaluation");
                        return;
                    }

                    query = @"SELECT r.Rating, r.Period, r.Year, e.JobTitle, e.Firstname, e.Lastname, 
                             r.CommentContent, r.Commenter 
                             FROM employees e, ratings r 
                             WHERE e.EmployeeID = r.EmployeeID 
                             AND r.Year = @year 
                             AND r.Period = @period 
                             AND e.EmployeeID = @employeeId";

                    parameters.Add("@year", cmbSelectEvaluation.Text);
                    parameters.Add("@period", cmbEvaluationType.Text);
                }

                // Execute the query using DatabaseManager
                DataTable evaluationTable = dbManager.ExecuteQuery(query, parameters);

                // Populate the list view with the results
                foreach (DataRow row in evaluationTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row["Rating"].ToString());
                    item.SubItems.Add(row["Period"].ToString());
                    item.SubItems.Add(row["Year"].ToString());
                    item.SubItems.Add(row["JobTitle"].ToString());
                    item.SubItems.Add(row["Firstname"].ToString());
                    item.SubItems.Add(row["Lastname"].ToString());
                    item.SubItems.Add(row["CommentContent"].ToString());
                    item.SubItems.Add(row["Commenter"].ToString());

                    listView1.Items.Add(item);
                }

                if (evaluationTable.Rows.Count > 0)
                {
                    MessageBox.Show("Here is your evaluation");
                }
                else
                {
                    MessageBox.Show("No evaluations found for the specified criteria");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving evaluations: " + ex.Message);
            }
        }

        private void cmbEvaluationType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdCompare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Compare c = new Compare();
            c.Show();
        }

        private void cmdHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "UserManual.chm");
        }
    }
}

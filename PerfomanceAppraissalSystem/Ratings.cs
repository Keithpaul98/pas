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
    public partial class Ratings : Form
    {
        // Reference to the DatabaseManager singleton
        private readonly DatabaseManager dbManager;

        public Ratings()
        {
            // Get the DatabaseManager instance
            dbManager = DatabaseManager.Instance;

            InitializeComponent();
        }

        private void cmdAddRating_Click(object sender, EventArgs e)
        {
            // Input validation
            if (string.IsNullOrEmpty(txtRatingID.Text) || 
                string.IsNullOrEmpty(cmbSelectRating.Text) || 
                string.IsNullOrEmpty(cmbRatingPeriod.Text) || 
                string.IsNullOrEmpty(txtYearRating.Text) || 
                string.IsNullOrEmpty(txtEmployeeID.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Create parameters dictionary for the query
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@ratingsId", txtRatingID.Text },
                    { "@rating", cmbSelectRating.Text },
                    { "@period", cmbRatingPeriod.Text },
                    { "@year", txtYearRating.Text },
                    { "@employeeId", txtEmployeeID.Text }
                };

                // Execute the insert query using DatabaseManager
                int rowsAffected = dbManager.ExecuteNonQuery(
                    "INSERT INTO ratings (ratingsID, Rating, Period, Year, EmployeeID) " +
                    "VALUES (@ratingsId, @rating, @period, @year, @employeeId)",
                    parameters
                );

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Rating added successfully.", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Clear form fields after successful addition
                    ClearFormFields();
                }
                else
                {
                    MessageBox.Show("Failed to add rating. Please try again.", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding rating: " + ex.Message, "Database Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFormFields()
        {
            // Clear form fields after successful operation
            txtRatingID.Clear();
            cmbSelectRating.SelectedIndex = -1;
            cmbRatingPeriod.SelectedIndex = -1;
            txtYearRating.Clear();
            txtEmployeeID.Clear();
        }

        private void cmdTask_Click(object sender, EventArgs e)
        {
            EmployeeTask t = new EmployeeTask();
            t.Show();
            this.Hide();
        }

        private void cmdRatings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ratings r = new Ratings();
            r.Show();
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
            EmployeeReport Pr = new EmployeeReport();
            Pr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeHome Eh = new EmployeeHome();
            Eh.Show();
        }

        private void cmdViewRating_Click(object sender, EventArgs e)
        {
            try
            {
                // Input validation
                if (string.IsNullOrEmpty(txtEmployeeID.Text) || 
                    string.IsNullOrEmpty(txtYearRating.Text) || 
                    string.IsNullOrEmpty(cmbRatingPeriod.Text))
                {
                    MessageBox.Show("Please enter Employee ID, Year, and Period to view ratings.", 
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@employeeId", txtEmployeeID.Text },
                    { "@year", txtYearRating.Text },
                    { "@period", cmbRatingPeriod.Text }
                };

                // Use ExecuteQuery method from DatabaseManager
                DataTable dt = dbManager.ExecuteQuery(
                    "SELECT e.Firstname, e.Lastname, e.Department, r.Rating, r.Period, r.Year " +
                    "FROM employees e, ratings r " +
                    "WHERE e.EmployeeID = r.EmployeeID AND e.EmployeeID = @employeeId AND r.Year = @year AND r.Period = @period",
                    parameters
                );

                listView1.Items.Clear();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No ratings found for the specified criteria.", "Information", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["Firstname"].ToString());
                    item.SubItems.Add(dr["Lastname"].ToString());
                    item.SubItems.Add(dr["Department"].ToString());
                    item.SubItems.Add(dr["Rating"].ToString());     
                    item.SubItems.Add(dr["Period"].ToString());
                    item.SubItems.Add(dr["Year"].ToString());

                    listView1.Items.Add(item);
                }

                MessageBox.Show("Ratings retrieved successfully.", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving ratings: " + ex.Message, "Database Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdUpdateRatings_Click(object sender, EventArgs e)
        {
            try
            {
                // Input validation
                if (string.IsNullOrEmpty(cmbSelectRating.Text) || 
                    string.IsNullOrEmpty(cmbRatingPeriod.Text) || 
                    string.IsNullOrEmpty(txtYearRating.Text) || 
                    string.IsNullOrEmpty(txtEmployeeID.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@rating", cmbSelectRating.Text },
                    { "@period", cmbRatingPeriod.Text },
                    { "@year", txtYearRating.Text },
                    { "@employeeId", txtEmployeeID.Text }
                };

                int rowsAffected = dbManager.ExecuteNonQuery(
                    "UPDATE ratings SET Rating = @rating WHERE Period = @period AND Year = @year AND EmployeeID = @employeeId",
                    parameters
                );

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Rating updated successfully.", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Clear form fields after successful update
                    ClearFormFields();
                }
                else
                {
                    MessageBox.Show("No ratings found to update. Please check your criteria.", "Information", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating rating: " + ex.Message, "Database Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "UserManual.chm");
        }
    }
}

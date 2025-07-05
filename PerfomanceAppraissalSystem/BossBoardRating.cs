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
    public partial class BossBoardRating : Form
    {
        // Reference to the DatabaseManager
        private DatabaseManager dbManager;

        public BossBoardRating()
        {
            // Get the DatabaseManager instance
            dbManager = DatabaseManager.Instance;

            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tasks t = new Tasks();
            t.Show();
        }

        private void cmdRating_Click(object sender, EventArgs e)
        {
            this.Hide();
            BossBoardRating BBR = new BossBoardRating();
            BBR.Show();
        }

        private void cmdEvaluations_Click(object sender, EventArgs e)
        {
            this.Hide();
            Evaluations E = new Evaluations();
            E.Show();
        }

        private void cmdProduceReport_Click(object sender, EventArgs e)
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

        private void cmdHomepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void cmdCompare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Compare c = new Compare();
            c.Show();
        }

        private void cmdAddRating_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrEmpty(txtRatingID.Text) || 
                string.IsNullOrEmpty(cmbSelectRating.Text) || 
                string.IsNullOrEmpty(cmbRatingPeriod.Text) || 
                string.IsNullOrEmpty(txtYearRating.Text) || 
                string.IsNullOrEmpty(txtCommenter.Text) || 
                string.IsNullOrEmpty(txtComments.Text) || 
                string.IsNullOrEmpty(txtEmployeeID.Text))
            {
                MessageBox.Show("Please fill in all required fields");
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
                    { "@commenter", txtCommenter.Text },
                    { "@commentContent", txtComments.Text },
                    { "@employeeId", txtEmployeeID.Text }
                };

                // Execute the insert query using DatabaseManager
                int rowsAffected = dbManager.ExecuteNonQuery(
                    "INSERT INTO ratings (ratingsID, Rating, Period, Year, Commenter, CommentContent, EmployeeID) " +
                    "VALUES (@ratingsId, @rating, @period, @year, @commenter, @commentContent, @employeeId)",
                    parameters
                );

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Rating added successfully");
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Rating could not be added");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding rating: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            txtRatingID.Text = "";
            cmbSelectRating.SelectedIndex = -1;
            cmbRatingPeriod.SelectedIndex = -1;
            txtYearRating.Text = "";
            txtCommenter.Text = "";
            txtComments.Text = "";
            txtEmployeeID.Text = "";
        }

        private void cmdViewRating_Click(object sender, EventArgs e)
        {
            ViewRating();
            MessageBox.Show("Your rating details");
        }

        private void ViewRating()
        {
            try
            {
                // Create parameters dictionary for the query
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@employeeId", txtEmployeeID.Text },
                    { "@year", txtYearRating.Text },
                    { "@period", cmbRatingPeriod.Text }
                };

                // Execute the select query using DatabaseManager
                DataTable dt = dbManager.ExecuteSelectQuery(
                    "Select e.Firstname, e.Lastname,  e.Department, r.Rating, r.Period, r.Year FROM employees e, ratings r Where e.EmployeeID = r.EmployeeID and e.EmployeeID = @employeeId and r.Year = @year and r.Period = @period",
                    parameters
                );

                // Populate the list view with the query results
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ratings cannot be displayed: " + ex.Message);
            }
        }

        private void cmdUpdateRatings_Click(object sender, EventArgs e)
        {
            try
            {
                // Create parameters dictionary for the query
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@rating", cmbSelectRating.Text },
                    { "@period", cmbRatingPeriod.Text },
                    { "@year", txtYearRating.Text },
                    { "@employeeId", txtEmployeeID.Text }
                };

                // Execute the update query using DatabaseManager
                int rowsAffected = dbManager.ExecuteNonQuery(
                    "UPDATE ratings SET Rating = @rating WHERE Period = @period AND Year = @year AND EmployeeID = @employeeId",
                    parameters
                );

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Ratings updated successfully");
                }
                else
                {
                    MessageBox.Show("Ratings could not be updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating ratings: " + ex.Message);
            }
        }

        private void cmdHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "UserManual.chm");
        }
    }
}

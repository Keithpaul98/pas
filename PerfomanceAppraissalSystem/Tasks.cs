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
    public partial class Tasks : Form
    {
        // Reference to the DatabaseManager
        private DatabaseManager dbManager;

        public Tasks()
        {
            // Get the DatabaseManager instance
            dbManager = DatabaseManager.Instance;

            InitializeComponent();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home H = new Home();
            H.Show();
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
            BossBoardRating r = new BossBoardRating();
            r.Show();
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
            Report re = new Report();
            re.Show();
        }

        private void cmdAddTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaskID.Text) || string.IsNullOrEmpty(txtTaskname.Text) || string.IsNullOrEmpty(cmbStatus.Text))
            {
                MessageBox.Show("Please fill in all required fields");
                return;
            }

            try
            {
                // Create parameters dictionary for the query
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@taskId", txtTaskID.Text },
                    { "@taskName", txtTaskname.Text },
                    { "@taskStatus", cmbStatus.Text }
                };

                // Execute the insert query using DatabaseManager
                int rowsAffected = dbManager.ExecuteNonQuery(
                    "INSERT INTO tasks (taskID, taskname, taskstatus) VALUES (@taskId, @taskName, @taskStatus)",
                    parameters
                );

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Task added successfully");
                    clear();
                }
                else
                {
                    MessageBox.Show("Task could not be added");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding task: " + ex.Message);
            }
        }

        void clear()
        {
            txtTaskID.Text = "";
            txtTaskname.Text = "";
            cmbStatus.SelectedIndex = -1;
        }

        private void cmdRemoveTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaskID.Text))
            {
                MessageBox.Show("Please enter a Task ID to delete");
                return;
            }

            try
            {
                // Create parameters dictionary for the query
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@taskId", txtTaskID.Text }
                };

                // Execute the delete query using DatabaseManager
                int rowsAffected = dbManager.ExecuteNonQuery(
                    "DELETE FROM tasks WHERE TaskID = @taskId",
                    parameters
                );

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Task deleted successfully");
                    clear();
                }
                else
                {
                    MessageBox.Show("Task not found or could not be deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting task: " + ex.Message);
            }
        }

        private void cmdChangeTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaskID.Text) || string.IsNullOrEmpty(cmbStatus.Text))
            {
                MessageBox.Show("Please enter a Task ID and select a status");
                return;
            }

            try
            {
                // Create parameters dictionary for the query
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@taskId", txtTaskID.Text },
                    { "@taskStatus", cmbStatus.Text }
                };

                // Execute the update query using DatabaseManager
                int rowsAffected = dbManager.ExecuteNonQuery(
                    "UPDATE tasks SET taskstatus = @taskStatus WHERE taskID = @taskId",
                    parameters
                );

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Task updated successfully");
                    clear();
                }
                else
                {
                    MessageBox.Show("Task not found or could not be updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating task: " + ex.Message);
            }
        }

        private void cmdViewTasks_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear the list view before adding new items
                listView1.Items.Clear();

                // Create parameters dictionary for the query
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                
                // If task ID is provided, filter by it
                string query = "SELECT * FROM tasks";
                if (!string.IsNullOrEmpty(txtTaskID.Text))
                {
                    query += " WHERE taskID = @taskId";
                    parameters.Add("@taskId", txtTaskID.Text);
                }

                // Execute the select query using DatabaseManager
                DataTable taskTable = dbManager.ExecuteQuery(query, parameters);

                // Populate the list view with the results
                foreach (DataRow row in taskTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row["taskID"].ToString());
                    item.SubItems.Add(row["taskname"].ToString());
                    item.SubItems.Add(row["taskstatus"].ToString());

                    listView1.Items.Add(item);
                }

                if (taskTable.Rows.Count > 0)
                {
                    MessageBox.Show("Tasks loaded successfully");
                }
                else
                {
                    MessageBox.Show("No tasks found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error viewing tasks: " + ex.Message);
            }
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }
    }
}

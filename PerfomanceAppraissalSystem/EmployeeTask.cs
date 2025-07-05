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
    public partial class EmployeeTask : Form
    {
        // Reference to the DatabaseManager singleton
        private readonly DatabaseManager dbManager;

        public EmployeeTask()
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void cmdChangeTask_Click(object sender, EventArgs e)
        {
            // Input validation
            if (string.IsNullOrEmpty(txtTaskID.Text) || string.IsNullOrEmpty(cmbStatus.Text))
            {
                MessageBox.Show("Please enter Task ID and select a Status.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@taskId", txtTaskID.Text },
                    { "@status", cmbStatus.Text }
                };

                int rowsAffected = dbManager.ExecuteNonQuery(
                    "UPDATE tasks SET taskstatus = @status WHERE taskID = @taskId",
                    parameters
                );

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Task updated successfully.", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                else
                {
                    MessageBox.Show("No task found with the specified ID.", "Information", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating task: " + ex.Message, 
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear()
        {
            txtTaskID.Clear();
            txtTaskname.Clear();
            cmbStatus.SelectedIndex = -1;
            listView1.Items.Clear();
        }

        private void cmdAddTask_Click(object sender, EventArgs e)
        {
            // Input validation
            if (string.IsNullOrEmpty(txtTaskID.Text) || 
                string.IsNullOrEmpty(txtTaskname.Text) || 
                string.IsNullOrEmpty(cmbStatus.Text))
            {
                MessageBox.Show("Please enter Task ID, Task Name, and select a Status.", 
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@taskId", txtTaskID.Text },
                    { "@taskName", txtTaskname.Text },
                    { "@status", cmbStatus.Text }
                };

                int rowsAffected = dbManager.ExecuteNonQuery(
                    "INSERT INTO tasks (taskID, taskname, taskstatus) VALUES (@taskId, @taskName, @status)",
                    parameters
                );

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Task added successfully.", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding task: " + ex.Message, 
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdRemoveTask_Click(object sender, EventArgs e)
        {
            // Input validation
            if (string.IsNullOrEmpty(txtTaskID.Text))
            {
                MessageBox.Show("Please enter Task ID to delete.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@taskId", txtTaskID.Text }
                };

                int rowsAffected = dbManager.ExecuteNonQuery(
                    "DELETE FROM tasks WHERE TaskID = @taskId",
                    parameters
                );

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Task deleted successfully.", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                else
                {
                    MessageBox.Show("No task found with the specified ID.", "Information", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting task: " + ex.Message, 
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdViewTasks_Click(object sender, EventArgs e)
        {
            // Input validation
            if (string.IsNullOrEmpty(txtTaskID.Text))
            {
                MessageBox.Show("Please enter Task ID to view.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Clear previous results
                listView1.Items.Clear();

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@taskId", txtTaskID.Text }
                };

                DataTable dt = dbManager.ExecuteQuery(
                    "SELECT * FROM tasks WHERE taskID = @taskId",
                    parameters
                );

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row["taskID"].ToString());
                        item.SubItems.Add(row["taskname"].ToString());
                        item.SubItems.Add(row["taskstatus"].ToString());

                        listView1.Items.Add(item);
                    }
                    MessageBox.Show("Tasks retrieved successfully.", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No task found with the specified ID.", "Information", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error viewing task: " + ex.Message, 
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "UserManual.chm");
        }
    }
}

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
    public partial class EmployeeHome : Form
    {
        // Reference to the DatabaseManager singleton
        private readonly DatabaseManager dbManager;

        public EmployeeHome()
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
        private void EmployeeHome_Load(object sender, EventArgs e)
        {

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

        private void cmdHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "UserManual.chm");
        }
    }
}

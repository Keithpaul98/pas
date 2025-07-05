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
    public partial class Home : Form
    {
        // Reference to the DatabaseManager
        private DatabaseManager dbManager;

        public Home()
        {
            // Get the DatabaseManager instance
            dbManager = DatabaseManager.Instance;

            InitializeComponent();
        }

        private void cmdCompare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Compare c = new Compare();
            c.Show();
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
            Evaluations E = new Evaluations();
            E.Show();
        }

        private void cmdPReport_Click(object sender, EventArgs e)
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

        private void cmdHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "UserManual.chm");
        }
    }
}

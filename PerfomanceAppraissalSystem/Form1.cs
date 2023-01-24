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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            //Change to another page
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            //Change to another page
            this.Hide();
            Register r = new Register();
            r.Show();
        }
    }
}

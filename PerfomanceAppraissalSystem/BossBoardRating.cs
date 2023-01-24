using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PerfomanceAppraissalSystem
{


    public partial class BossBoardRating : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public BossBoardRating()
        {
            server = "localhost";
            database = "PerformanceAppraissalSystem";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString); 

            InitializeComponent();
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the  
                //error number.              
                //The two most common error numbers when connecting are as follows:   
                //0: Cannot connect to server.       
                //1045: Invalid user name and/or password.     
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }


        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
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

            if (txtRatingID.Text == "" || cmbSelectRating.Text == "" || cmbRatingPeriod.Text == "" || txtYearRating.Text == "" || txtCommenter.Text == "" || txtComments.Text == "" || txtEmployeeID.Text == "")
                MessageBox.Show("Please Fill empty fields");


            else
            {
                if (cmbSelectRating.Text == "0/10")
                {
                    if (cmbRatingPeriod.Text == "January-June")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO ratings (ratingsID, Rating, Period, Year, Commenter, CommentContent, EmployeeID) VALUES('" + txtRatingID.Text + "', '" + cmbSelectRating.Text + "', '" + cmbRatingPeriod.Text + "', '" + txtYearRating.Text + "', '" + txtCommenter.Text + "','" + txtComments.Text + "','" + txtEmployeeID.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("Rating added");


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("rating not added" + ex.Message);
                            }
                        }
                    }


                    if (cmbRatingPeriod.Text == "July-December")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO ratings (ratingsID, Rating, Period, Year, Commenter, CommentContent, EmployeeID) VALUES('" + txtRatingID.Text + "', '" + cmbSelectRating.Text + "', '" + cmbRatingPeriod.Text + "', '" + txtYearRating.Text + "', '" + txtCommenter.Text + "','" + txtComments.Text + "','" + txtEmployeeID.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("Rating added");


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("rating not added" + ex.Message);
                            }
                        }
                    }
                }



                //rating 1
                if (cmbSelectRating.Text == "1/10")
                {
                    if (cmbRatingPeriod.Text == "January-June")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO ratings (ratingsID, Rating, Period, Year, Commenter, CommentContent, EmployeeID) VALUES('" + txtRatingID.Text + "', '" + cmbSelectRating.Text + "', '" + cmbRatingPeriod.Text + "', '" + txtYearRating.Text + "', '" + txtCommenter.Text + "','" + txtComments.Text + "','" + txtEmployeeID.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("Rating added");


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("rating not added" + ex.Message);
                            }
                        }
                    }


                    if (cmbRatingPeriod.Text == "July-December")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO ratings (ratingsID, Rating, Period, Year, Commenter, CommentContent, EmployeeID) VALUES('" + txtRatingID.Text + "', '" + cmbSelectRating.Text + "', '" + cmbRatingPeriod.Text + "', '" + txtYearRating.Text + "', '" + txtCommenter.Text + "','" + txtComments.Text + "','" + txtEmployeeID.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("Rating added");


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("rating not added" + ex.Message);
                            }
                        }
                    }
                }


                //select rating 2
                if (cmbSelectRating.Text == "2/10")
                {
                    if (cmbRatingPeriod.Text == "January-June")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO ratings (ratingsID, Rating, Period, Year, Commenter, CommentContent, EmployeeID) VALUES('" + txtRatingID.Text + "', '" + cmbSelectRating.Text + "', '" + cmbRatingPeriod.Text + "', '" + txtYearRating.Text + "', '" + txtCommenter.Text + "','" + txtComments.Text + "','" + txtEmployeeID.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("Rating added");


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("rating not added" + ex.Message);
                            }
                        }
                    }


                    if (cmbRatingPeriod.Text == "July-December")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO ratings (ratingsID, Rating, Period, Year, Commenter, CommentContent, EmployeeID) VALUES('" + txtRatingID.Text + "', '" + cmbSelectRating.Text + "', '" + cmbRatingPeriod.Text + "', '" + txtYearRating.Text + "', '" + txtCommenter.Text + "','" + txtComments.Text + "','" + txtEmployeeID.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("Rating added");


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("rating not added" + ex.Message);
                            }
                        }
                    }
                }


                //select rating 3
                if (cmbSelectRating.Text == "3/10")
                {
                    if (cmbRatingPeriod.Text == "January-June")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO ratings (ratingsID, Rating, Period, Year, Commenter, CommentContent, EmployeeID) VALUES('" + txtRatingID.Text + "', '" + cmbSelectRating.Text + "', '" + cmbRatingPeriod.Text + "', '" + txtYearRating.Text + "', '" + txtCommenter.Text + "','" + txtComments.Text + "','" + txtEmployeeID.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("Rating added");


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("rating not added" + ex.Message);
                            }
                        }
                    }


                    if (cmbRatingPeriod.Text == "July-December")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO ratings (ratingsID, Rating, Period, Year, Commenter, CommentContent, EmployeeID) VALUES('" + txtRatingID.Text + "', '" + cmbSelectRating.Text + "', '" + cmbRatingPeriod.Text + "', '" + txtYearRating.Text + "', '" + txtCommenter.Text + "','" + txtComments.Text + "','" + txtEmployeeID.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("Rating added");


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("rating not added" + ex.Message);
                            }
                        }
                    }
                }



                //select rating  4
                if (cmbSelectRating.Text == "4/10")
                {
                    if (cmbRatingPeriod.Text == "January-June")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO ratings (ratingsID, Rating, Period, Year, Commenter, CommentContent, EmployeeID) VALUES('" + txtRatingID.Text + "', '" + cmbSelectRating.Text + "', '" + cmbRatingPeriod.Text + "', '" + txtYearRating.Text + "', '" + txtCommenter.Text + "','" + txtComments.Text + "','" + txtEmployeeID.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("Rating added");


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("rating not added" + ex.Message);
                            }
                        }
                    }


                    if (cmbRatingPeriod.Text == "July-December")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO ratings (ratingsID, Rating, Period, Year, Commenter, CommentContent, EmployeeID) VALUES('" + txtRatingID.Text + "', '" + cmbSelectRating.Text + "', '" + cmbRatingPeriod.Text + "', '" + txtYearRating.Text + "', '" + txtCommenter.Text + "','" + txtComments.Text + "','" + txtEmployeeID.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("Rating added");


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("rating not added" + ex.Message);
                            }
                        }
                    }
                }


                //select rating 5
                if (cmbSelectRating.Text == "5/10")
                {
                    if (cmbRatingPeriod.Text == "January-June")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO ratings (ratingsID, Rating, Period, Year, Commenter, CommentContent, EmployeeID) VALUES('" + txtRatingID.Text + "', '" + cmbSelectRating.Text + "', '" + cmbRatingPeriod.Text + "', '" + txtYearRating.Text + "', '" + txtCommenter.Text + "','" + txtComments.Text + "','" + txtEmployeeID.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("Rating added");


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("rating not added" + ex.Message);
                            }
                        }
                    }


                    if (cmbRatingPeriod.Text == "July-December")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO ratings (ratingsID, Rating, Period, Year, Commenter, CommentContent, EmployeeID) VALUES('" + txtRatingID.Text + "', '" + cmbSelectRating.Text + "', '" + cmbRatingPeriod.Text + "', '" + txtYearRating.Text + "', '" + txtCommenter.Text + "','" + txtComments.Text + "','" + txtEmployeeID.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("Rating added");


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("rating not added" + ex.Message);
                            }
                        }
                    }
                }


                //select rating 6
                if (cmbSelectRating.Text == "6/10")
                {
                    if (cmbRatingPeriod.Text == "January-June")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO ratings (ratingsID, Rating, Period, Year, Commenter, CommentContent, EmployeeID) VALUES('" + txtRatingID.Text + "', '" + cmbSelectRating.Text + "', '" + cmbRatingPeriod.Text + "', '" + txtYearRating.Text + "', '" + txtCommenter.Text + "','" + txtComments.Text + "','" + txtEmployeeID.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("Rating added");


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("rating not added" + ex.Message);
                            }
                        }
                    }


                    if (cmbRatingPeriod.Text == "July-December")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO ratings (ratingsID, Rating, Period, Year, Commenter, CommentContent, EmployeeID) VALUES('" + txtRatingID.Text + "', '" + cmbSelectRating.Text + "', '" + cmbRatingPeriod.Text + "', '" + txtYearRating.Text + "', '" + txtCommenter.Text + "','" + txtComments.Text + "','" + txtEmployeeID.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("Rating added");


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("rating not added" + ex.Message);
                            }
                        }
                    }
                }


                //select rating 7

                if (cmbSelectRating.Text == "7/10")
                {
                    if (cmbRatingPeriod.Text == "January-June")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO ratings (ratingsID, Rating, Period, Year, Commenter, CommentContent, EmployeeID) VALUES('" + txtRatingID.Text + "', '" + cmbSelectRating.Text + "', '" + cmbRatingPeriod.Text + "', '" + txtYearRating.Text + "', '" + txtCommenter.Text + "','" + txtComments.Text + "','" + txtEmployeeID.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("Rating added");


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("rating not added" + ex.Message);
                            }
                        }
                    }


                    if (cmbRatingPeriod.Text == "July-December")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO ratings (ratingsID, Rating, Period, Year, Commenter, CommentContent, EmployeeID) VALUES('" + txtRatingID.Text + "', '" + cmbSelectRating.Text + "', '" + cmbRatingPeriod.Text + "', '" + txtYearRating.Text + "', '" + txtCommenter.Text + "','" + txtComments.Text + "','" + txtEmployeeID.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("Rating added");


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("rating not added" + ex.Message);
                            }
                        }
                    }
                }

                //select rating 8
                if (cmbSelectRating.Text == "8/10")
                {
                    if (cmbRatingPeriod.Text == "January-June")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO ratings (ratingsID, Rating, Period, Year, Commenter, CommentContent, EmployeeID) VALUES('" + txtRatingID.Text + "', '" + cmbSelectRating.Text + "', '" + cmbRatingPeriod.Text + "', '" + txtYearRating.Text + "', '" + txtCommenter.Text + "','" + txtComments.Text + "','" + txtEmployeeID.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("Rating added");


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("rating not added" + ex.Message);
                            }
                        }
                    }


                    if (cmbRatingPeriod.Text == "July-December")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO ratings (ratingsID, Rating, Period, Year, Commenter, CommentContent, EmployeeID) VALUES('" + txtRatingID.Text + "', '" + cmbSelectRating.Text + "', '" + cmbRatingPeriod.Text + "', '" + txtYearRating.Text + "', '" + txtCommenter.Text + "','" + txtComments.Text + "','" + txtEmployeeID.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("Rating added");


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("rating not added" + ex.Message);
                            }
                        }
                    }
                }


                // select rating 9
                if (cmbSelectRating.Text == "9/10")
                {
                    if (cmbRatingPeriod.Text == "January-June")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO ratings (ratingsID, Rating, Period, Year, Commenter, CommentContent, EmployeeID) VALUES('" + txtRatingID.Text + "', '" + cmbSelectRating.Text + "', '" + cmbRatingPeriod.Text + "', '" + txtYearRating.Text + "', '" + txtCommenter.Text + "','" + txtComments.Text + "','" + txtEmployeeID.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("Rating added");


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("rating not added" + ex.Message);
                            }
                        }
                    }


                    if (cmbRatingPeriod.Text == "July-December")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO ratings (ratingsID, Rating, Period, Year, Commenter, CommentContent, EmployeeID) VALUES('" + txtRatingID.Text + "', '" + cmbSelectRating.Text + "', '" + cmbRatingPeriod.Text + "', '" + txtYearRating.Text + "', '" + txtCommenter.Text + "','" + txtComments.Text + "','" + txtEmployeeID.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("Rating added");


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("rating not added" + ex.Message);
                            }
                        }
                    }
                }


                //10
                if (cmbSelectRating.Text == "10/10")
                {
                    if (cmbRatingPeriod.Text == "January-June")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO ratings (ratingsID, Rating, Period, Year, Commenter, CommentContent, EmployeeID) VALUES('" + txtRatingID.Text + "', '" + cmbSelectRating.Text + "', '" + cmbRatingPeriod.Text + "', '" + txtYearRating.Text + "', '" + txtCommenter.Text + "','" + txtComments.Text + "','" + txtEmployeeID.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("Rating added");


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("rating not added" + ex.Message);
                            }
                        }
                    }


                    if (cmbRatingPeriod.Text == "July-December")
                    {
                        if (this.OpenConnection() == true)
                        {
                            try
                            {
                                String query = "INSERT INTO ratings (ratingsID, Rating, Period, Year, Commenter, CommentContent, EmployeeID) VALUES('" + txtRatingID.Text + "', '" + cmbSelectRating.Text + "', '" + cmbRatingPeriod.Text + "', '" + txtYearRating.Text + "', '" + txtCommenter.Text + "','" + txtComments.Text + "','" + txtEmployeeID.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                                this.CloseConnection();
                                MessageBox.Show("Rating added");


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("rating not added" + ex.Message);
                            }
                        }
                    }

                }

            }
        }

        private void cmdViewRating_Click(object sender, EventArgs e)
        {

            ViewRating();
            MessageBox.Show("Your rating details");
        }

        private void ViewRating()
        {
            if (this.OpenConnection() == true)
            {
                try
                {
                    String query = "Select e.Firstname, e.Lastname,  e.Department, r.Rating, r.Period, r.Year FROM employees e, ratings r Where e.EmployeeID = r.EmployeeID and e.EmployeeID = '" + txtEmployeeID.Text + "' and r.Year = '" + txtYearRating.Text + "' and r.Period = '" + cmbRatingPeriod.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

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
                    this.CloseConnection();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ratings cannot be displayed" + ex.Message);
                }
            }
        }

        private void cmdUpdateRatings_Click(object sender, EventArgs e)
        {

            if (this.OpenConnection() == true)
            {

                try
                {
                    String query = "UPDATE ratings SET  Rating='" + cmbSelectRating.Text + "' WHERE Period= '" + cmbRatingPeriod.Text + "' and Year = '" + txtYearRating.Text + "' and EmployeeID ='" + txtEmployeeID.Text + "' ";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    MessageBox.Show("Ratings updated");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ratings cannot be updated" + ex.Message);
                }
            }
        }

        private void cmdHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "UserManual.chm");
        }
    }
}

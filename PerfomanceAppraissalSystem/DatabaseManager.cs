using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace PerfomanceAppraissalSystem
{
    /// <summary>
    /// DatabaseManager handles all database operations for the Performance Appraisal System.
    /// It provides methods for connection management, authentication, and CRUD operations.
    /// </summary>
    public class DatabaseManager
    {
        // Singleton instance
        private static DatabaseManager _instance;
        
        // Database connection parameters
        private string _server;
        private string _database;
        private string _username;
        private string _password;
        private string _connectionString;
        private NpgsqlConnection _connection;

        /// <summary>
        /// Private constructor to prevent direct instantiation
        /// </summary>
        private DatabaseManager()
        {
            _server = "localhost";
            _database = "PerformanceAppraissalSystem";
            _username = "postgres"; // Change this to your PostgreSQL username
            _password = ""; // Change this to your PostgreSQL password
            _connectionString = $"Host={_server};Database={_database};Username={_username};Password={_password};";
            _connection = new NpgsqlConnection(_connectionString);
        }

        /// <summary>
        /// Gets the singleton instance of DatabaseManager
        /// </summary>
        public static DatabaseManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DatabaseManager();
                }
                return _instance;
            }
        }

        /// <summary>
        /// Opens the database connection
        /// </summary>
        /// <returns>True if connection opened successfully, false otherwise</returns>
        public bool OpenConnection()
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }
                return true;
            }
            catch (NpgsqlException ex)
            {
                // PostgreSQL error codes
                switch (ex.SqlState)
                {
                    case "08001": // Unable to connect to server
                        MessageBox.Show("Cannot connect to server. Contact administrator");
                        break;
                    case "28P01": // Invalid password
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        MessageBox.Show("Database error: " + ex.Message);
                        break;
                }
                return false;
            }
        }

        /// <summary>
        /// Closes the database connection
        /// </summary>
        /// <returns>True if connection closed successfully, false otherwise</returns>
        public bool CloseConnection()
        {
            try
            {
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
                return true;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Authenticates a user based on employee ID, password, and user type
        /// </summary>
        /// <param name="employeeId">Employee ID</param>
        /// <param name="password">Password</param>
        /// <param name="userType">User type (Boss, Employee, Board)</param>
        /// <returns>True if authentication successful, false otherwise</returns>
        public bool AuthenticateUser(string employeeId, string password, string userType)
        {
            bool isAuthenticated = false;
            
            try
            {
                if (this.OpenConnection())
                {
                    // Use parameterized query for security
                    string query = "SELECT * FROM employees WHERE EmployeeID = @employeeId AND Password = @password";
                    NpgsqlCommand cmd = new NpgsqlCommand(query, _connection);
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);
                    cmd.Parameters.AddWithValue("@password", password);
                    
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        int count = 0;
                        while (reader.Read())
                        {
                            count++;
                        }
                        
                        if (count == 1)
                        {
                            isAuthenticated = true;
                        }
                        else if (count > 1)
                        {
                            MessageBox.Show("Login not successful - duplicate user details found");
                        }
                        else
                        {
                            MessageBox.Show("Login not successful - invalid credentials");
                        }
                    }
                    
                    this.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Authentication error: " + ex.Message);
            }
            
            return isAuthenticated;
        }

        /// <summary>
        /// Registers a new employee in the database
        /// </summary>
        /// <param name="employeeId">Employee ID</param>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="department">Department</param>
        /// <param name="jobTitle">Job title</param>
        /// <param name="email">Email</param>
        /// <param name="gender">Gender</param>
        /// <param name="dateOfBirth">Date of birth</param>
        /// <param name="password">Password</param>
        /// <returns>True if registration successful, false otherwise</returns>
        public bool RegisterEmployee(string employeeId, string firstName, string lastName, 
                                    string department, string jobTitle, string email, 
                                    string gender, DateTime dateOfBirth, string password)
        {
            try
            {
                if (this.OpenConnection())
                {
                    string query = "INSERT INTO employees (EmployeeID, Firstname, Lastname, Department, JobTitle, Email, Gender, DateOfBirth, Password) " +
                                  "VALUES (@empId, @fname, @lname, @dept, @jobTitle, @email, @gender, @dob, @pwd)";
                    
                    NpgsqlCommand cmd = new NpgsqlCommand(query, _connection);
                    cmd.Parameters.AddWithValue("@empId", employeeId);
                    cmd.Parameters.AddWithValue("@fname", firstName);
                    cmd.Parameters.AddWithValue("@lname", lastName);
                    cmd.Parameters.AddWithValue("@dept", department);
                    cmd.Parameters.AddWithValue("@jobTitle", jobTitle);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@dob", dateOfBirth);
                    cmd.Parameters.AddWithValue("@pwd", password);
                    
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration error: " + ex.Message);
            }
            
            return false;
        }

        /// <summary>
        /// Executes a non-query SQL command (INSERT, UPDATE, DELETE)
        /// </summary>
        /// <param name="query">SQL query</param>
        /// <param name="parameters">Dictionary of parameter names and values</param>
        /// <returns>Number of rows affected</returns>
        public int ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
        {
            int rowsAffected = 0;
            
            try
            {
                if (this.OpenConnection())
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(query, _connection);
                    
                    // Add parameters if provided
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }
                    
                    rowsAffected = cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            
            return rowsAffected;
        }

        /// <summary>
        /// Executes a query and returns a DataTable
        /// </summary>
        /// <param name="query">SQL query</param>
        /// <param name="parameters">Dictionary of parameter names and values</param>
        /// <returns>DataTable containing query results</returns>
        public DataTable ExecuteQuery(string query, Dictionary<string, object> parameters = null)
        {
            DataTable dataTable = new DataTable();
            
            try
            {
                if (this.OpenConnection())
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(query, _connection);
                    
                    // Add parameters if provided
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }
                    
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                    
                    this.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            
            return dataTable;
        }

        /// <summary>
        /// Executes a scalar query and returns a single value
        /// </summary>
        /// <param name="query">SQL query</param>
        /// <param name="parameters">Dictionary of parameter names and values</param>
        /// <returns>Object containing the first column of the first row</returns>
        public object ExecuteScalar(string query, Dictionary<string, object> parameters = null)
        {
            object result = null;
            
            try
            {
                if (this.OpenConnection())
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(query, _connection);
                    
                    // Add parameters if provided
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }
                    
                    result = cmd.ExecuteScalar();
                    this.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            
            return result;
        }
    }
}

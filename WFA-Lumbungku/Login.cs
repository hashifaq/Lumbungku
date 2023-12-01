using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace WFA_Lumbungku
{
    public partial class Login : Form
    {
        private const string ConnectionString = "Host=rain.db.elephantsql.com;Port=5432;Username=xlkrufuv;Password=QetnzAz_gisckBoMl6z4CRuwpKpYPLY2;Database=xlkrufuv";

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            if (ValidateLogin(username, password))
            {
                // Successful login
                string name = GetUserName(username);
                string location = GetUserLocation(username);

                Dashboard dashboard = new Dashboard(username, name, location);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                // Failed login
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }



        private string GetUserName(string username)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "SELECT name FROM pengguna WHERE username = @username";
                        command.Parameters.AddWithValue("@username", username);

                        object result = command.ExecuteScalar();

                        return result != null ? result.ToString() : string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetUserName: {ex.Message}");
                return string.Empty;
            }
        }

        private string GetUserLocation(string username)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "SELECT lokasi FROM pengguna WHERE username = @username";
                        command.Parameters.AddWithValue("@username", username);

                        object result = command.ExecuteScalar();

                        return result != null ? result.ToString() : string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetUserLocation: {ex.Message}");
                return string.Empty;
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT COUNT(*) FROM pengguna WHERE username = @username AND password = @password";
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

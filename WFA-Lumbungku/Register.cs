using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace WFA_Lumbungku
{
    public partial class Register : Form
    {
        private const string ConnectionString = "Host=rain.db.elephantsql.com;Port=5432;Username=xlkrufuv;Password=QetnzAz_gisckBoMl6z4CRuwpKpYPLY2;Database=xlkrufuv";

        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text;
            string lokasi = cbRegion.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(lokasi))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (IsUsernameExists(username))
            {
                MessageBox.Show("Username already exists. Please choose a different username.");
                return;
            }
            if (RegisterUser(name, username, password, lokasi))
            {
                MessageBox.Show("Registration successful. You can now log in.");
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.");
            }
        }

        private bool IsUsernameExists(string username)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT COUNT(*) FROM pengguna WHERE username = @username";
                    command.Parameters.AddWithValue("@username", username);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        private bool RegisterUser(string name, string username, string password, string lokasi)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT INTO pengguna (username, password, name, lokasi) VALUES (@username, @password, @name, @lokasi)";
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@lokasi", lokasi);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}

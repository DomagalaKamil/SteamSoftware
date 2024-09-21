using System;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace SteamApp
{
    public partial class LoginForm : Form
    {
        // Connection string to connect to your MySQL database
        private string connectionString = "Server=localhost;Database=steam_user_data;User ID=root;Password=password;Pooling=false;";

        public LoginForm()
        {
            InitializeComponent();

            // Attach the login button click event handler
            this.signInButton.Click += new System.EventHandler(this.loginButton_Click);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registerButton_Click(object sender, System.EventArgs e)
        {
            accountCreation accountCreation = new accountCreation();
            accountCreation.Show();
        }

        private void recoveryFormBtn_Click(object sender, System.EventArgs e)
        {
            recoveryFrom recoveryFrom = new recoveryFrom();
            recoveryFrom.Show();
        }

        private void loginTextBox_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void rememberMeCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        // Added method for login button click event
        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = loginTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both a username and password.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Use parameterized query to prevent SQL injection
                    string query = "SELECT COUNT(1) FROM User WHERE Username = @username AND Password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 1)
                    {
                        MessageBox.Show("Login successful!");

                        // Proceed to the main application form
                        MainForm mainForm = new MainForm(username);
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username or password is incorrect.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}

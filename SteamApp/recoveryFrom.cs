using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Make sure to install this NuGet package for MySQL

namespace SteamApp
{
    public partial class recoveryFrom : Form
    {
        public recoveryFrom()
        {
            InitializeComponent();
        }

        private void recoveryFrom_Load(object sender, EventArgs e)
        {

        }

        private void namePanelBtn_Click(object sender, EventArgs e)
        {
            optionsPanel.Visible = false;
            nameRecoveryPanel.Visible = true;
        }

        private void passwordPanelBtn_Click(object sender, EventArgs e)
        {
            optionsPanel.Visible = false;
            passwordRecoveryPanel.Visible = true;
        }

        private void passwordBackBtn_Click(object sender, EventArgs e)
        {
            passwordRecoveryPanel.Visible = false;
            optionsPanel.Visible = true;
        }

        private void nameBackBtn_Click(object sender, EventArgs e)
        {
            nameRecoveryPanel.Visible = false;
            optionsPanel.Visible = true;
        }

        private void passwordRecoveryPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void recoverNameBtn_Click(object sender, EventArgs e)
        {
            // Get the email from the TextBox
            string userEmail = emailRecoveryTxt.Text;

            // Check if the email exists and retrieve the username
            string username = GetUsernameByEmail(userEmail);

            if (username != null)
            {
                // Send an email to the user with their username
                SendRecoveryEmail(userEmail, username);
            }
            else
            {
                MessageBox.Show("No account found with that email address.", "Email Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetUsernameByEmail(string email)
        {
            string username = null;

            // Define your MySQL connection string (update this to your actual database details)
            string connectionString = "Server=localhost;Database=steam_user_data;User ID=root;Password=password;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // SQL query to retrieve the username by email
                    string query = "SELECT username FROM User WHERE email = @Email";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);

                        // Execute the query and read the result
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve the username
                                username = reader["username"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving username: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return username;
        }

        private void SendRecoveryEmail(string toEmail, string content)
        {
            string fromEmail = "";  // Replace with your email
            string password = "";      // Replace with your email app password
            string subject = "Steam - Password Recovery";
            string body = $"Hello,\n\n{content}\n\nRegards,\nSteam Support";

            try
            {
                MailMessage message = new MailMessage();
                message.To.Add(toEmail);
                message.From = new MailAddress(fromEmail);
                message.Subject = subject;
                message.Body = body;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential(fromEmail, password);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                smtp.Send(message);

                MessageBox.Show("An email has been sent with your new password.", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateRandomPassword()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder password = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < 12; i++)
            {
                password.Append(chars[random.Next(chars.Length)]);
            }
            return password.ToString();
        }

        private bool UpdateUserPassword(string username, string newPassword)
        {
            bool isUpdated = false;
            string connectionString = "Server=localhost;Database=steam_user_data;User ID=root;Password=password;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // SQL query to update the user's password
                    string query = "UPDATE User SET password = @Password WHERE username = @Username";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Password", newPassword);
                        cmd.Parameters.AddWithValue("@Username", username);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            isUpdated = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating password: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isUpdated;
        }

        private void passRecoveryBtn_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string username = nameTextBox.Text;

            // Check if the email and username match
            if (CheckIfAccountExists(email, username))
            {
                // Generate a new password
                string newPassword = GenerateRandomPassword();

                // Update the password in the database
                if (UpdateUserPassword(username, newPassword))
                {
                    // Send an email with the new password
                    SendRecoveryEmail(email, $"We have set a new temporary password for you: {newPassword}");
                }
                else
                {
                    MessageBox.Show("Error updating password. Please try again.", "Password Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The provided email and username do not match.", "Account Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckIfAccountExists(string email, string username)
        {
            bool accountExists = false;
            string connectionString = "Server=localhost;Database=steam_user_data;User ID=root;Password=password;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // SQL query to check if the email and username match
                    string query = "SELECT COUNT(*) FROM User WHERE email = @Email AND username = @Username";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Username", username);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0)
                        {
                            accountExists = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking account: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return accountExists;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

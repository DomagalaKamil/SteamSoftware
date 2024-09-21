using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace SteamApp
{
    public partial class accountCreation : Form
    {
        // Make Random a static field to avoid duplicate numbers in quick succession
        private static Random rnd = new Random();
        int vCode;

        public accountCreation()
        {
            InitializeComponent();

            // Hide the password as dots (or any character you choose)
            passwordTextBox.PasswordChar = '•';
            confirmPasswordTextBox.PasswordChar = '•';
        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string confirmEmail = confirmEmailTextBox.Text;
            string username = usernameTextBox.Text;
            string phoneNumber = phoneTextBox.Text;

            // Check if the email is in valid format
            if (!IsValidEmail(email))
            {
                MessageBox.Show("The email address is not in the correct format. Please provide a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop further execution if email is invalid
            }

            // Check if email and confirmation email match
            if (email != confirmEmail)
            {
                MessageBox.Show("The email addresses do not match. Please ensure both email fields are the same.", "Email Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop further execution if emails do not match
            }

            // Check if email, username, or phone number already exist in the database
            string errorMessage = CheckIfDetailsAreTaken(email, username, phoneNumber);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop further execution if email, username, or phone number are already taken
            }

            // Generate a random 4-digit verification code
            vCode = rnd.Next(1000, 10000); // Generates a number between 1000 and 9999

            string from, pass, mail;
            from = ""; //Your App Email
            mail = vCode.ToString();
            pass = ""; // Your App Password
            MailMessage message = new MailMessage();
            message.To.Add(email);
            message.From = new MailAddress(from);
            message.Body = "Your verification code is: " + vCode.ToString();
            message.Subject = "Steam - Verification Code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Verification email sent!", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                continueBtn.Enabled = true;
                verificationCodeTxt.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Method to validate if the email is in the correct format
        private bool IsValidEmail(string email)
        {
            // Regular expression to validate email format
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        // Method to check if the email, username, or phone number are already taken
        private string CheckIfDetailsAreTaken(string email, string username, string phoneNumber)
        {
            string result = null;

            // Define the MySQL connection string (update this to your actual database credentials)
            string connectionString = "Server=localhost;Database=steam_user_data;User ID=root;Password=password;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if email is already taken
                    string emailQuery = "SELECT COUNT(*) FROM User WHERE email = @Email";
                    using (MySqlCommand emailCmd = new MySqlCommand(emailQuery, conn))
                    {
                        emailCmd.Parameters.AddWithValue("@Email", email);
                        int emailCount = Convert.ToInt32(emailCmd.ExecuteScalar());
                        if (emailCount > 0)
                        {
                            return "This email is already taken. Please use a different email.";
                        }
                    }

                    // Check if username is already taken
                    string usernameQuery = "SELECT COUNT(*) FROM User WHERE username = @Username";
                    using (MySqlCommand usernameCmd = new MySqlCommand(usernameQuery, conn))
                    {
                        usernameCmd.Parameters.AddWithValue("@Username", username);
                        int usernameCount = Convert.ToInt32(usernameCmd.ExecuteScalar());
                        if (usernameCount > 0)
                        {
                            return "This username is already taken. Please choose a different username.";
                        }
                    }

                    // Check if phone number is already taken (skip if phone number is empty)
                    if (!string.IsNullOrEmpty(phoneNumber))
                    {
                        string phoneQuery = "SELECT COUNT(*) FROM User WHERE phone_number = @PhoneNumber";
                        using (MySqlCommand phoneCmd = new MySqlCommand(phoneQuery, conn))
                        {
                            phoneCmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                            int phoneCount = Convert.ToInt32(phoneCmd.ExecuteScalar());
                            if (phoneCount > 0)
                            {
                                return "This phone number is already registered. Please use a different phone number.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking user details: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "There was a database error.";
            }

            return result; // Return null if everything is OK
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            if (verificationCodeTxt.Text == vCode.ToString())
            {
                emailPanel.Visible = false;
                detailsPanel.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid verification code. Please try again.", "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text; // Hash this before storing in a real application
            string confirmPassword = confirmPasswordTextBox.Text;
            DateTime dob = dobDatePicker.Value;
            string phoneNumber = phoneTextBox.Text;

            // Check if password and confirm password match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please ensure both password fields are the same.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop further execution if passwords don't match
            }

            // Check if email, username, or phone number already exist in the database
            string errorMessage = CheckIfDetailsAreTaken(email, username, phoneNumber);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop further execution if email, username, or phone number are already taken
            }

            // Call a method to save user information to the database
            SaveUserToDatabase(email, username, password, dob, phoneNumber);
        }

        private void SaveUserToDatabase(string email, string username, string password, DateTime dob, string phoneNumber)
        {
            // Define the MySQL connection string (update this to your actual database credentials)
            string connectionString = "Server=localhost;Database=steam_user_data;User ID=root;Password=password;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Insert query to add new user into the User table
                    string query = "INSERT INTO User (email, username, password, dob, phone_number) " +
                                   "VALUES (@Email, @Username, @Password, @DOB, @PhoneNumber)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password); // In a real app, hash the password
                        cmd.Parameters.AddWithValue("@DOB", dob.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@PhoneNumber", string.IsNullOrEmpty(phoneNumber) ? DBNull.Value : (object)phoneNumber);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User registered successfully!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to register the user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle potential errors
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

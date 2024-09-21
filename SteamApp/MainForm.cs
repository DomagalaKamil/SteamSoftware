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

namespace SteamApp
{
    public partial class MainForm : Form
    {
        private string username;

        public MainForm(string username)
        {
            InitializeComponent();

            // Store the username passed from the login form
            this.username = username;

            // Retrieve and display the user's nickname from the database
            RetrieveAndDisplayNickname();


            // Subscribe to the MouseDown event to detect clicks outside the dropdown
            this.MouseDown += MainForm_MouseDown;
        }

        // Method to retrieve the nickname from the database
        private void RetrieveAndDisplayNickname()
        {
            string connectionString = "Server=localhost;Database=steam_user_data;User ID=root;Password=password;";
            string nickname = null;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Query to get the nickname based on the username
                    string query = "SELECT nickname FROM User WHERE username = @Username";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Pass the username as a parameter to prevent SQL injection
                        cmd.Parameters.AddWithValue("@Username", username);

                        // Execute the query and get the nickname
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            nickname = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving nickname: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // If a nickname was found, display it, otherwise show an error
            if (!string.IsNullOrEmpty(nickname))
            {
                nameMenu.Text = nickname;
            }
            else
            {
                MessageBox.Show("Nickname not found for the user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool expand = false;

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void menuTimer_Tick(object sender, EventArgs e)
        {
            if (!expand)
            {
                dropDownContainer.Height += 15;
                if (dropDownContainer.Height >= dropDownContainer.MaximumSize.Height)
                {
                    menuTimer.Stop();
                    expand = true;
                }
            }
            else
            {
                dropDownContainer.Height = 31; // Smooth closing
                if (dropDownContainer.Height <= 0)
                {
                    menuTimer.Stop();
                    expand = false;
                }
            }
        }

        private void SteamButtonMenu_Click(object sender, EventArgs e)
        {
            menuTimer.Start();
        }

        // This method handles clicks outside the dropdown area
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            // Check if the dropdown is open
            if (expand)
            {
                dropDownContainer.Height = 31; // Smooth closing
                expand = false;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            SettingsForm SettingsForm = new SettingsForm();
            SettingsForm.Show();
        }
    }
}

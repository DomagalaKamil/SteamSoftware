using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

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
        }

        private void emailPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            // Generate a random 4-digit verification code
            vCode = rnd.Next(1000, 10000); // Generates a number between 1000 and 9999

            string to, from, pass, mail;
            to = emailTextBox.Text;
            from = "Your email";
            mail = vCode.ToString();
            pass = "Your app password"; // Your App Password
            MailMessage message = new MailMessage();
            message.To.Add(to);
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
                MessageBox.Show("Email sent!", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                continueBtn.Enabled = true;
                verificationCodeTxt.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
    }
}

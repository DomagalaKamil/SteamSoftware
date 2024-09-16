using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}

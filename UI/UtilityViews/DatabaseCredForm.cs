using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidDb26_2025CS127.UI.UtilityForms
{
    public partial class DatabaseCredForm : Form
    {
        public string ServerAddress;
        public string Port;
        public string Password;
        public string DatabaseName;
        public string DatabaseUser;
        public string DatabasePassword;
        public DatabaseCredForm()
        {
            InitializeComponent();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            this.ServerAddress = serverAddressTextBox.Text;
            this.Port = portTextBox.Text;
            this.Password = dbPasswordTextBox.Text;
            this.DatabaseName = dbNameTextBox.Text;
            this.DatabaseUser = dbUserTextBox.Text;
            this.DatabasePassword = dbPasswordTextBox.Text;

            this.DialogResult = DialogResult.OK;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicDatabase
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        Settings settings = new();

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            settings.Read();
            connectionTextBox.Text = settings.connectionString;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            settings.connectionString = connectionTextBox.Text;
            settings.Write();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

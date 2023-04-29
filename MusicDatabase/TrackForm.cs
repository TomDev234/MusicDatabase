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
    public partial class TrackForm : Form
    {
        Track? track = null;
        public TrackForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            track = null;
            idLabel.Text = string.Empty;
            trackNameTextBox.Text = string.Empty;
            trackNumberTextBox.Text = string.Empty;
            trackVideoURLTextBox.Text = string.Empty;
            trackLyricsTextBox.Text = string.Empty;
        }
    }
}

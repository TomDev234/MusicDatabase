using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MusicDatabase.Delegates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MusicDatabase
{
    public partial class TrackForm : Form
    {
        public Delegates.EditTrackCallback trackCallback;
        List<Album> albums;
        int[] albumIDs;
        public Track? track = null;
        public TrackForm()
        {
            InitializeComponent();
        }

        private void TrackForm_Load(object sender, EventArgs e)
        {
            idLabel.Text = track.ID.ToString();
            trackNameTextBox.Text = track.Name;
            trackNumberTextBox.Text = track.Number.ToString();
            trackVideoURLTextBox.Text = track.VideoURL;
            trackLyricsTextBox.Text = track.Lyrics;
            // get Albums
            DatabaseController databaseController = new();
            albums = databaseController.getAllAlbums();
            // init Combobox
            int i = 0;
            albumIDs = new int[albums.Count];
            albumIDComboBox.BeginUpdate();
            foreach (var album in albums)
            {
                albumIDComboBox.Items.Add(album.ID.ToString() + "-" + album.Albumname);
                albumIDs[i] = album.ID;
                i++;
            }
            albumIDComboBox.EndUpdate();
            // find albumÍD in albumIDs
            int index = Array.IndexOf(albumIDs, track.AlbumID);
            albumIDComboBox.SelectedIndex = index;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Track track = new();
            track.Name = trackNameTextBox.Text;
            track.Number = int.Parse(trackNumberTextBox.Text);
            track.VideoURL = trackVideoURLTextBox.Text;
            track.Lyrics = trackLyricsTextBox.Text;
            track.AlbumID = albumIDs[albumIDComboBox.SelectedIndex];
            DatabaseController databaseController = new DatabaseController();
            if (databaseController.trackExists(track))
            {
                MessageBox.Show("Track already exists!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int rows = databaseController.insertTrack(track);
                if (rows == 0)
                    MessageBox.Show("Adding the Track failed Error!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Track Added", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Track track = new();
            track.ID = int.Parse(idLabel.Text);
            track.Name = trackNameTextBox.Text;
            track.Number = int.Parse(trackNumberTextBox.Text);
            track.VideoURL = trackVideoURLTextBox.Text;
            track.Lyrics = trackLyricsTextBox.Text;
            track.AlbumID = albumIDs[albumIDComboBox.SelectedIndex];
            DatabaseController databaseController = new DatabaseController();
            if (!databaseController.trackExists(track.ID))
            {
                MessageBox.Show("Track does not exist Error!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int rows = databaseController.updateTrack(track);
                if (rows == 0)
                    MessageBox.Show("Updating the Track failed Error!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Track updated", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (track != null)
            {
                string message = String.Format("Do you want to delete Track {0}?", track.ID);
                if (MessageBox.Show(message, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DatabaseController databaseController = new DatabaseController();
                    int rows = databaseController.deleteTrack(track.ID);
                    message = String.Format("{0} Item(s) deleted", rows);
                    MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void TrackForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            trackCallback();
        }
    }
}

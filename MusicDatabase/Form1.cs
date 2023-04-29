using System.Windows.Forms;

namespace MusicDatabase
{
    public partial class Form1 : Form
    {
        BindingSource albumBindingSource = new();
        BindingSource tracksBindingSource = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void loadDatabaseButton_Click(object sender, EventArgs e)
        {
            DatabaseController databaseController = new();
            albumBindingSource.DataSource = databaseController.getAllAlbums();
            dataGridView1.DataSource = albumBindingSource;
        }

        private void editDatabaseButton_Click(object sender, EventArgs e)
        {
            Album album = null;
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Table is empty", "Music Database");
            }
            else
            {
                int currentRow = dataGridView1.CurrentRow.Index;
                int albumID = (int)dataGridView1.Rows[currentRow].Cells[0].Value;
                DatabaseController databaseController = new();
                album = databaseController.getAlbum(albumID);
                AlbumForm albumForm = new();
                albumForm.album = album;
                albumForm.Show();
            }
        }

        private void editTrackButton_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {

                int currentRow = dataGridView2.CurrentRow.Index;

                MessageBox.Show("Current Row = " + currentRow);

            }
            TrackForm trackForm = new();
            trackForm.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void searchDatabaseButton_Click(object sender, EventArgs e)
        {
            DatabaseController databaseController = new DatabaseController();
            albumBindingSource.DataSource = databaseController.searchTitles(searchDatabaseTextBox.Text);
            dataGridView1.DataSource = albumBindingSource;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int clickedRow = dataGridView.CurrentRow.Index;
            string? imageURL = dataGridView.Rows[clickedRow].Cells[4].Value.ToString();
            pictureBox1.Load(imageURL);
            DatabaseController databaseController = new();
            tracksBindingSource.DataSource = databaseController.getTracksUsingJoin((int)dataGridView.Rows[clickedRow].Cells[0].Value);
            dataGridView2.DataSource = tracksBindingSource;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int clickedRow = dataGridView.CurrentRow.Index;
            string? videoURL = dataGridView.Rows[clickedRow].Cells[4].Value.ToString();
            if (videoURL != null)
            {
                VideoPlayer videoPlayer = new VideoPlayer();
                videoPlayer.webView = webView21;
                videoPlayer.videoURL = videoURL;
                videoPlayer.InitiateBrowser();
            }       
        }
    }
}
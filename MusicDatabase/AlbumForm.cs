﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MusicDatabase.Delegates;

namespace MusicDatabase
{
    public partial class AlbumForm : Form
    {
        public Album? album = null;
        public AlbumForm()
        {
            InitializeComponent();
        }
        private void AlbumForm_Load(object sender, EventArgs e)
        {
            if (album != null)
            {
                idLabel.Text = album.ID.ToString();
                albumNameTextBox.Text = album.Albumname;
                artistTextBox.Text = album.Artistname;
                yearTextBox.Text = album.Year.ToString();
                imageURLTextBox.Text = album.ImageURL;
                descriptionTextBox.Text = album.Description;
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            Album album = new();
            album.Albumname = albumNameTextBox.Text;
            album.Artistname = artistTextBox.Text;
            album.Year = int.Parse(yearTextBox.Text);
            album.ImageURL = imageURLTextBox.Text;
            album.Description = descriptionTextBox.Text;
            DatabaseController databaseController = new DatabaseController();
            if (databaseController.albumExists(album))
            {
                MessageBox.Show("Album already exists!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int rows = databaseController.insertAlbum(album);
                if (rows == 0)
                    MessageBox.Show("Adding the Album failed Error!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Album Added", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Album album = new();
            album.ID = int.Parse(idLabel.Text);
            album.Albumname = albumNameTextBox.Text;
            album.Artistname = artistTextBox.Text;
            album.Year = int.Parse(yearTextBox.Text);
            album.ImageURL = imageURLTextBox.Text;
            album.Description = descriptionTextBox.Text;
            DatabaseController databaseController = new DatabaseController();
            if (!databaseController.albumExists(album.ID))
            {
                MessageBox.Show("Album does not exist Error!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int rows = databaseController.updateAlbum(album);
                if (rows == 0)
                    MessageBox.Show("Updating the Album failed Error!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Album updated", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (album != null)
            {
                string message = String.Format("Do you want to delete Album {0} with all Tracks?", album.ID);
                if (MessageBox.Show(message, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DatabaseController databaseController = new DatabaseController();
                    int rows = databaseController.deleteAlbum(album.ID);
                    message = String.Format("{0} Item(s) deleted", rows);
                    MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            album = null;
            idLabel.Text = string.Empty;
            albumNameTextBox.Text = string.Empty;
            artistTextBox.Text = string.Empty;
            yearTextBox.Text = string.Empty;
            imageURLTextBox.Text = string.Empty;
            descriptionTextBox.Text = string.Empty;
        }

        private void AlbumForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Delegates.albumCallback();
        }
    }
}

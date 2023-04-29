namespace MusicDatabase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            loadDatabaseButton = new Button();
            editDatabaseButton = new Button();
            searchDatabaseButton = new Button();
            editTrackButton = new Button();
            searchDatabaseTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(660, 220);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 281);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(660, 227);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // loadDatabaseButton
            // 
            loadDatabaseButton.Location = new Point(12, 252);
            loadDatabaseButton.Name = "loadDatabaseButton";
            loadDatabaseButton.Size = new Size(75, 23);
            loadDatabaseButton.TabIndex = 2;
            loadDatabaseButton.Text = "Load";
            loadDatabaseButton.UseVisualStyleBackColor = true;
            loadDatabaseButton.Click += loadDatabaseButton_Click;
            // 
            // editDatabaseButton
            // 
            editDatabaseButton.Location = new Point(93, 252);
            editDatabaseButton.Name = "editDatabaseButton";
            editDatabaseButton.Size = new Size(75, 23);
            editDatabaseButton.TabIndex = 3;
            editDatabaseButton.Text = "Edit";
            editDatabaseButton.UseVisualStyleBackColor = true;
            editDatabaseButton.Click += editDatabaseButton_Click;
            // 
            // searchDatabaseButton
            // 
            searchDatabaseButton.Location = new Point(597, 251);
            searchDatabaseButton.Name = "searchDatabaseButton";
            searchDatabaseButton.Size = new Size(75, 23);
            searchDatabaseButton.TabIndex = 4;
            searchDatabaseButton.Text = "Search";
            searchDatabaseButton.UseVisualStyleBackColor = true;
            searchDatabaseButton.Click += searchDatabaseButton_Click;
            // 
            // editTrackButton
            // 
            editTrackButton.Location = new Point(12, 514);
            editTrackButton.Name = "editTrackButton";
            editTrackButton.Size = new Size(75, 23);
            editTrackButton.TabIndex = 5;
            editTrackButton.Text = "Edit";
            editTrackButton.UseVisualStyleBackColor = true;
            editTrackButton.Click += editTrackButton_Click;
            // 
            // searchDatabaseTextBox
            // 
            searchDatabaseTextBox.Location = new Point(174, 252);
            searchDatabaseTextBox.Name = "searchDatabaseTextBox";
            searchDatabaseTextBox.Size = new Size(417, 23);
            searchDatabaseTextBox.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(678, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 234);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(678, 266);
            webView21.Name = "webView21";
            webView21.Size = new Size(249, 242);
            webView21.TabIndex = 8;
            webView21.ZoomFactor = 1D;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(938, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { settingsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(116, 22);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 545);
            Controls.Add(webView21);
            Controls.Add(pictureBox1);
            Controls.Add(searchDatabaseTextBox);
            Controls.Add(editTrackButton);
            Controls.Add(searchDatabaseButton);
            Controls.Add(editDatabaseButton);
            Controls.Add(loadDatabaseButton);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Music Database";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button loadDatabaseButton;
        private Button editDatabaseButton;
        private Button searchDatabaseButton;
        private Button editTrackButton;
        private TextBox searchDatabaseTextBox;
        private PictureBox pictureBox1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
    }
}
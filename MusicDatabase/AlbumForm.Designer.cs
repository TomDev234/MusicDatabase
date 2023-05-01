namespace MusicDatabase
{
    partial class AlbumForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            idLabel = new Label();
            label6 = new Label();
            clearButton = new Button();
            deleteButton = new Button();
            updateButton = new Button();
            addButton = new Button();
            descriptionTextBox = new TextBox();
            imageURLTextBox = new TextBox();
            yearTextBox = new TextBox();
            artistTextBox = new TextBox();
            albumNameTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(idLabel);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(clearButton);
            groupBox1.Controls.Add(deleteButton);
            groupBox1.Controls.Add(updateButton);
            groupBox1.Controls.Add(addButton);
            groupBox1.Controls.Add(descriptionTextBox);
            groupBox1.Controls.Add(imageURLTextBox);
            groupBox1.Controls.Add(yearTextBox);
            groupBox1.Controls.Add(artistTextBox);
            groupBox1.Controls.Add(albumNameTextBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(446, 220);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Album";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(104, 16);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(49, 15);
            idLabel.TabIndex = 15;
            idLabel.Text = "ID Label";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 16);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 14;
            label6.Text = "ID";
            // 
            // clearButton
            // 
            clearButton.Location = new Point(347, 187);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 13;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(266, 187);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 12;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(185, 187);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 23);
            updateButton.TabIndex = 11;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(104, 187);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 10;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(104, 158);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(336, 23);
            descriptionTextBox.TabIndex = 9;
            // 
            // imageURLTextBox
            // 
            imageURLTextBox.Location = new Point(104, 129);
            imageURLTextBox.Name = "imageURLTextBox";
            imageURLTextBox.Size = new Size(336, 23);
            imageURLTextBox.TabIndex = 8;
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(104, 100);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(336, 23);
            yearTextBox.TabIndex = 7;
            // 
            // artistTextBox
            // 
            artistTextBox.Location = new Point(104, 71);
            artistTextBox.Name = "artistTextBox";
            artistTextBox.Size = new Size(336, 23);
            artistTextBox.TabIndex = 6;
            // 
            // albumNameTextBox
            // 
            albumNameTextBox.Location = new Point(104, 42);
            albumNameTextBox.Name = "albumNameTextBox";
            albumNameTextBox.Size = new Size(336, 23);
            albumNameTextBox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 161);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 132);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 3;
            label4.Text = "Image URL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 103);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 2;
            label3.Text = "Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 74);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Artist";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 45);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // AlbumForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 243);
            Controls.Add(groupBox1);
            Name = "AlbumForm";
            Text = "Music Database Album";
            FormClosed += AlbumForm_FormClosed;
            Load += AlbumForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button clearButton;
        private Button deleteButton;
        private Button updateButton;
        private Button addButton;
        private TextBox descriptionTextBox;
        private TextBox imageURLTextBox;
        private TextBox yearTextBox;
        private TextBox artistTextBox;
        private TextBox albumNameTextBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label idLabel;
    }
}
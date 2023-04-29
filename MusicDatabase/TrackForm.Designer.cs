namespace MusicDatabase
{
    partial class TrackForm
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
            clearButton = new Button();
            deleteButton = new Button();
            updateButton = new Button();
            addButton = new Button();
            trackLyricsTextBox = new TextBox();
            trackVideoURLTextBox = new TextBox();
            trackNumberTextBox = new TextBox();
            trackNameTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(clearButton);
            groupBox1.Controls.Add(deleteButton);
            groupBox1.Controls.Add(updateButton);
            groupBox1.Controls.Add(addButton);
            groupBox1.Controls.Add(trackLyricsTextBox);
            groupBox1.Controls.Add(trackVideoURLTextBox);
            groupBox1.Controls.Add(trackNumberTextBox);
            groupBox1.Controls.Add(trackNameTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(446, 166);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Track";
            // 
            // clearButton
            // 
            clearButton.Location = new Point(347, 132);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 13;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(266, 132);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 12;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(185, 132);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 23);
            updateButton.TabIndex = 11;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Location = new Point(104, 132);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 10;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // trackLyricsTextBox
            // 
            trackLyricsTextBox.Location = new Point(104, 103);
            trackLyricsTextBox.Name = "trackLyricsTextBox";
            trackLyricsTextBox.Size = new Size(336, 23);
            trackLyricsTextBox.TabIndex = 8;
            // 
            // trackVideoURLTextBox
            // 
            trackVideoURLTextBox.Location = new Point(104, 74);
            trackVideoURLTextBox.Name = "trackVideoURLTextBox";
            trackVideoURLTextBox.Size = new Size(336, 23);
            trackVideoURLTextBox.TabIndex = 7;
            // 
            // trackNumberTextBox
            // 
            trackNumberTextBox.Location = new Point(104, 45);
            trackNumberTextBox.Name = "trackNumberTextBox";
            trackNumberTextBox.Size = new Size(336, 23);
            trackNumberTextBox.TabIndex = 6;
            // 
            // trackNameTextBox
            // 
            trackNameTextBox.Location = new Point(104, 16);
            trackNameTextBox.Name = "trackNameTextBox";
            trackNameTextBox.Size = new Size(336, 23);
            trackNameTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 106);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Lyrics";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 77);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Video URL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 48);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // TrackForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 191);
            Controls.Add(groupBox1);
            Name = "TrackForm";
            Text = "Music Database Track";
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
        private TextBox trackLyricsTextBox;
        private TextBox trackVideoURLTextBox;
        private TextBox trackNumberTextBox;
        private TextBox trackNameTextBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
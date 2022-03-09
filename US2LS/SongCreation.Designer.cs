namespace US2LS
{
    partial class SongCreation
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
            this.musicSetButton = new System.Windows.Forms.Button();
            this.musicTextBox = new System.Windows.Forms.TextBox();
            this.coverTextBox = new System.Windows.Forms.TextBox();
            this.lyricsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundTextBox = new System.Windows.Forms.TextBox();
            this.coverSetButton = new System.Windows.Forms.Button();
            this.lyricsSetButton = new System.Windows.Forms.Button();
            this.backgroundSetButton = new System.Windows.Forms.Button();
            this.finalizeSongButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.songImportProgressBar = new System.Windows.Forms.ProgressBar();
            this.videoSetButton = new System.Windows.Forms.Button();
            this.videoTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // musicSetButton
            // 
            this.musicSetButton.Location = new System.Drawing.Point(404, 5);
            this.musicSetButton.Name = "musicSetButton";
            this.musicSetButton.Size = new System.Drawing.Size(49, 23);
            this.musicSetButton.TabIndex = 0;
            this.musicSetButton.Text = "Set";
            this.musicSetButton.UseVisualStyleBackColor = true;
            this.musicSetButton.Click += new System.EventHandler(this.musicSetButton_Click);
            // 
            // musicTextBox
            // 
            this.musicTextBox.Location = new System.Drawing.Point(95, 5);
            this.musicTextBox.Name = "musicTextBox";
            this.musicTextBox.ReadOnly = true;
            this.musicTextBox.Size = new System.Drawing.Size(303, 23);
            this.musicTextBox.TabIndex = 4;
            // 
            // coverTextBox
            // 
            this.coverTextBox.Location = new System.Drawing.Point(95, 34);
            this.coverTextBox.Name = "coverTextBox";
            this.coverTextBox.ReadOnly = true;
            this.coverTextBox.Size = new System.Drawing.Size(303, 23);
            this.coverTextBox.TabIndex = 5;
            // 
            // lyricsTextBox
            // 
            this.lyricsTextBox.Location = new System.Drawing.Point(95, 63);
            this.lyricsTextBox.Name = "lyricsTextBox";
            this.lyricsTextBox.ReadOnly = true;
            this.lyricsTextBox.Size = new System.Drawing.Size(303, 23);
            this.lyricsTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Music*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cover art*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "UltraStar TXT*:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "BG Image:";
            // 
            // backgroundTextBox
            // 
            this.backgroundTextBox.Location = new System.Drawing.Point(95, 93);
            this.backgroundTextBox.Name = "backgroundTextBox";
            this.backgroundTextBox.ReadOnly = true;
            this.backgroundTextBox.Size = new System.Drawing.Size(303, 23);
            this.backgroundTextBox.TabIndex = 11;
            // 
            // coverSetButton
            // 
            this.coverSetButton.Location = new System.Drawing.Point(404, 34);
            this.coverSetButton.Name = "coverSetButton";
            this.coverSetButton.Size = new System.Drawing.Size(49, 23);
            this.coverSetButton.TabIndex = 12;
            this.coverSetButton.Text = "Set";
            this.coverSetButton.UseVisualStyleBackColor = true;
            this.coverSetButton.Click += new System.EventHandler(this.coverSetButton_Click);
            // 
            // lyricsSetButton
            // 
            this.lyricsSetButton.Location = new System.Drawing.Point(404, 63);
            this.lyricsSetButton.Name = "lyricsSetButton";
            this.lyricsSetButton.Size = new System.Drawing.Size(49, 23);
            this.lyricsSetButton.TabIndex = 13;
            this.lyricsSetButton.Text = "Set";
            this.lyricsSetButton.UseVisualStyleBackColor = true;
            this.lyricsSetButton.Click += new System.EventHandler(this.lyricsSetButton_Click);
            // 
            // backgroundSetButton
            // 
            this.backgroundSetButton.Location = new System.Drawing.Point(404, 93);
            this.backgroundSetButton.Name = "backgroundSetButton";
            this.backgroundSetButton.Size = new System.Drawing.Size(49, 23);
            this.backgroundSetButton.TabIndex = 14;
            this.backgroundSetButton.Text = "Set";
            this.backgroundSetButton.UseVisualStyleBackColor = true;
            this.backgroundSetButton.Click += new System.EventHandler(this.backgroundSetButton_Click);
            // 
            // finalizeSongButton
            // 
            this.finalizeSongButton.Location = new System.Drawing.Point(12, 233);
            this.finalizeSongButton.Name = "finalizeSongButton";
            this.finalizeSongButton.Size = new System.Drawing.Size(441, 23);
            this.finalizeSongButton.TabIndex = 15;
            this.finalizeSongButton.Text = "Add song!";
            this.finalizeSongButton.UseVisualStyleBackColor = true;
            this.finalizeSongButton.Click += new System.EventHandler(this.finalizeSongButton_ClickAsync);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "* This is required in order to add the song";
            // 
            // songImportProgressBar
            // 
            this.songImportProgressBar.Location = new System.Drawing.Point(12, 212);
            this.songImportProgressBar.Name = "songImportProgressBar";
            this.songImportProgressBar.Size = new System.Drawing.Size(441, 15);
            this.songImportProgressBar.TabIndex = 17;
            // 
            // videoSetButton
            // 
            this.videoSetButton.Location = new System.Drawing.Point(404, 122);
            this.videoSetButton.Name = "videoSetButton";
            this.videoSetButton.Size = new System.Drawing.Size(49, 23);
            this.videoSetButton.TabIndex = 20;
            this.videoSetButton.Text = "Set";
            this.videoSetButton.UseVisualStyleBackColor = true;
            this.videoSetButton.Click += new System.EventHandler(this.videoSetButton_Click);
            // 
            // videoTextBox
            // 
            this.videoTextBox.Location = new System.Drawing.Point(95, 122);
            this.videoTextBox.Name = "videoTextBox";
            this.videoTextBox.ReadOnly = true;
            this.videoTextBox.Size = new System.Drawing.Size(303, 23);
            this.videoTextBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Music video*:";
            // 
            // SongCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 314);
            this.Controls.Add(this.videoSetButton);
            this.Controls.Add(this.videoTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.songImportProgressBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.finalizeSongButton);
            this.Controls.Add(this.backgroundSetButton);
            this.Controls.Add(this.lyricsSetButton);
            this.Controls.Add(this.coverSetButton);
            this.Controls.Add(this.backgroundTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lyricsTextBox);
            this.Controls.Add(this.coverTextBox);
            this.Controls.Add(this.musicTextBox);
            this.Controls.Add(this.musicSetButton);
            this.Name = "SongCreation";
            this.Text = "SongCreation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button musicSetButton;
        private TextBox musicTextBox;
        private TextBox coverTextBox;
        private TextBox lyricsTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox backgroundTextBox;
        private Button coverSetButton;
        private Button lyricsSetButton;
        private Button backgroundSetButton;
        private Button finalizeSongButton;
        private Label label5;
        private ProgressBar songImportProgressBar;
        private Button videoSetButton;
        private TextBox videoTextBox;
        private Label label6;
    }
}
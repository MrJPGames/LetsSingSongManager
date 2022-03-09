namespace US2LS
{
    partial class Main
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
            this.addSongButton = new System.Windows.Forms.Button();
            this.songDataTable = new System.Windows.Forms.DataGridView();
            this.UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createPatchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.songDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // addSongButton
            // 
            this.addSongButton.Location = new System.Drawing.Point(12, 420);
            this.addSongButton.Name = "addSongButton";
            this.addSongButton.Size = new System.Drawing.Size(380, 23);
            this.addSongButton.TabIndex = 0;
            this.addSongButton.Text = "Add Song";
            this.addSongButton.UseVisualStyleBackColor = true;
            this.addSongButton.Click += new System.EventHandler(this.addSongButton_Click);
            // 
            // songDataTable
            // 
            this.songDataTable.AllowUserToAddRows = false;
            this.songDataTable.AllowUserToDeleteRows = false;
            this.songDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UID,
            this.SongTitle,
            this.Artist,
            this.Year,
            this.Genre});
            this.songDataTable.Location = new System.Drawing.Point(12, 12);
            this.songDataTable.Name = "songDataTable";
            this.songDataTable.RowTemplate.Height = 25;
            this.songDataTable.Size = new System.Drawing.Size(776, 402);
            this.songDataTable.TabIndex = 1;
            // 
            // UID
            // 
            this.UID.HeaderText = "UID";
            this.UID.Name = "UID";
            this.UID.ReadOnly = true;
            // 
            // SongTitle
            // 
            this.SongTitle.HeaderText = "Song title";
            this.SongTitle.Name = "SongTitle";
            this.SongTitle.ReadOnly = true;
            this.SongTitle.Width = 250;
            // 
            // Artist
            // 
            this.Artist.HeaderText = "Artist";
            this.Artist.Name = "Artist";
            this.Artist.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.HeaderText = "Release Year";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            // 
            // createPatchButton
            // 
            this.createPatchButton.Location = new System.Drawing.Point(398, 420);
            this.createPatchButton.Name = "createPatchButton";
            this.createPatchButton.Size = new System.Drawing.Size(390, 23);
            this.createPatchButton.TabIndex = 2;
            this.createPatchButton.Text = "Create Let\'s Sing Patch";
            this.createPatchButton.UseVisualStyleBackColor = true;
            this.createPatchButton.Click += new System.EventHandler(this.createPatchButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.createPatchButton);
            this.Controls.Add(this.songDataTable);
            this.Controls.Add(this.addSongButton);
            this.Name = "Main";
            this.Text = "UltraStar to Let\'s Sing song importer";
            ((System.ComponentModel.ISupportInitialize)(this.songDataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button addSongButton;
        private DataGridView songDataTable;
        private DataGridViewTextBoxColumn UID;
        private DataGridViewTextBoxColumn SongTitle;
        private DataGridViewTextBoxColumn Artist;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Genre;
        private Button createPatchButton;
    }
}
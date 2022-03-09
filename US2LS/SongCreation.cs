using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace US2LS
{
    public partial class SongCreation : Form
    {
        public SongCreation()
        {
            InitializeComponent();
        }

        private string getFilePath(string filter)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All files (*.*)|*.*|" + filter;
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    return openFileDialog.FileName;
                }
                else
                {
                    return "";
                }
            }
        }

        private void musicSetButton_Click(object sender, EventArgs e)
        {
            musicTextBox.Text = getFilePath("Music files (*.mp3;*.m4a;*.ogg;*.wav;*.flac)|*.mp3;*.m4a;*.ogg;*.wav;*.flac");
        }

        private void coverSetButton_Click(object sender, EventArgs e)
        {
            coverTextBox.Text = getFilePath("Image files (*.png;*.jpg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp");
        }

        private void lyricsSetButton_Click(object sender, EventArgs e)
        {
            lyricsTextBox.Text = getFilePath("UltraStar TXT (*.txt)|*.txt");

        }

        private void backgroundSetButton_Click(object sender, EventArgs e)
        {
            backgroundTextBox.Text = getFilePath("Image files (*.png;*.jpg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp");
        }

        private void videoSetButton_Click(object sender, EventArgs e)
        {
            videoTextBox.Text = getFilePath("Video files (*.m4v;*.mp4;*.avi;*.wmv)|*.m4v;*.mp4;*.avi;*.wmv");
        }

        private void finalizeSongButton_ClickAsync(object sender, EventArgs e)
        {
            if (lyricsTextBox.Text == "" || 
                coverTextBox.Text == "" ||
                musicTextBox.Text == "")
            {
                return;
            }
            ImportSong();
            this.Close();
        }

        private async Task ImportSong()
        {
            string curDir = Directory.GetCurrentDirectory();
            string baseDir = curDir + "\\songs";

            Song song = new Song(lyricsTextBox.Text);
            string outDir = baseDir + "\\" + song.SongUID;
            Directory.CreateDirectory(outDir);
            await SongImporterLogic.GenerateMetaData(song, outDir);
            songImportProgressBar.Value = 5;
            songImportProgressBar.Invalidate();
            this.Refresh();
            await SongImporterLogic.ImportCover(coverTextBox.Text, outDir);
            songImportProgressBar.Value = 10;
            songImportProgressBar.Invalidate();
            this.Refresh();
            await SongImporterLogic.ImportVideo(videoTextBox.Text, outDir);
            songImportProgressBar.Value = 60;
            songImportProgressBar.Invalidate();
            this.Refresh();
            await SongImporterLogic.ImportAudio(musicTextBox.Text, outDir);
            songImportProgressBar.Value = 95;
            songImportProgressBar.Invalidate();
            this.Refresh();
            await SongImporterLogic.ImportLyrics(lyricsTextBox.Text, outDir);
            songImportProgressBar.Value = 100;
            songImportProgressBar.Invalidate();
            this.Refresh();
        }
    }
}

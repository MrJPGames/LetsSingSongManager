using System.Xml;

namespace US2LS
{
    public partial class Main : Form
    {
        private string baseDir;
        public Main()
        {
            string curDir = Directory.GetCurrentDirectory();
            baseDir = curDir + "\\songs";
            Directory.CreateDirectory(baseDir);
            InitializeComponent();
            UpdateSongList();
        }

        private void UpdateSongList()
        {
            string[] directories = Directory.GetDirectories(baseDir);

            songDataTable.Rows.Clear();

            foreach (string dir in directories)
            {
                XmlDataDocument xmldoc = new XmlDataDocument();
                FileStream fs = new FileStream(dir + "\\meta.xml", FileMode.Open, FileAccess.Read);
                xmldoc.Load(fs);
                string songTitle = xmldoc.GetElementsByTagName("Title")[0].InnerText;
                string songYear = xmldoc.GetElementsByTagName("Year")[0].InnerText;
                string songArtist = xmldoc.GetElementsByTagName("Artist")[0].InnerText;
                string songGenre = xmldoc.GetElementsByTagName("Genre")[0].InnerText;

                string UID = (new DirectoryInfo(dir)).Name;

                songDataTable.Rows.Add(UID, songTitle, songArtist, songYear, songGenre);
            }
        }

        private void addSongButton_Click(object sender, EventArgs e)
        {
            SongCreation sc = new SongCreation();
            sc.ShowDialog();
            UpdateSongList();
        }

        private void createPatchButton_Click(object sender, EventArgs e)
        {
            SongExporter se = new SongExporter();
            se.ExportSongs();
            MessageBox.Show("Exporting finished!");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace US2LS
{
    internal class SongExporter
    {
        string coreTitleId = "0100CC30149B8000";
        string dlcTitleId = "0100CC30149B9001";

        string patchPath = "\\sd\\atmosphere\\contents";

        public SongExporter()
        {

        }

        public SongExporter(string coreId, string dlcId)
        {
            coreTitleId = coreId;
            dlcTitleId = dlcId;
        }

        public void ExportSongs()
        {
            string curDir = Directory.GetCurrentDirectory();
            string baseDir = curDir + "\\songs";
            string exportDir = curDir + patchPath;

            string songsTsv = File.ReadAllText(curDir + "\\resources\\" + coreTitleId + ".tsv");
            string names = File.ReadAllText(curDir + "\\resources\\" + dlcTitleId + ".txt");


            // Create all relevant directories:
            Directory.CreateDirectory(exportDir + "\\" + coreTitleId + "\\romfs\\Data\\StreamingAssets");
            Directory.CreateDirectory(exportDir + "\\" + dlcTitleId + "\\romfs\\Songs\\audio");
            Directory.CreateDirectory(exportDir + "\\" + dlcTitleId + "\\romfs\\Songs\\audio_preview");
            Directory.CreateDirectory(exportDir + "\\" + dlcTitleId + "\\romfs\\Songs\\backgrounds\\InGameLoading");
            Directory.CreateDirectory(exportDir + "\\" + dlcTitleId + "\\romfs\\Songs\\backgrounds\\Result");
            Directory.CreateDirectory(exportDir + "\\" + dlcTitleId + "\\romfs\\Songs\\covers");
            Directory.CreateDirectory(exportDir + "\\" + dlcTitleId + "\\romfs\\Songs\\videos");
            Directory.CreateDirectory(exportDir + "\\" + dlcTitleId + "\\romfs\\Songs\\vxla");

            // Add all song specific files (and update internal "DBs")
            string[] directories = Directory.GetDirectories(baseDir);

            int incrementer = 160;

            foreach (string dir in directories)
            {
                // Read metadata (needed for generation)
                XmlDataDocument xmldoc = new XmlDataDocument();
                FileStream fs = new FileStream(dir + "\\meta.xml", FileMode.Open, FileAccess.Read);
                xmldoc.Load(fs);
                string songTitle = xmldoc.GetElementsByTagName("Title")[0].InnerText;
                string songYear = xmldoc.GetElementsByTagName("Year")[0].InnerText;
                string songArtist = xmldoc.GetElementsByTagName("Artist")[0].InnerText;

                string UID = (new DirectoryInfo(dir)).Name;

                fs.Close();

                // Update DLC table
                songsTsv += "\nx\t" + incrementer + "\t" + UID + "\t" + songArtist + "\t" + songTitle + "\t" + songYear + "\t1\tx\tx\tx\tx\t1\tRATIO_16_9\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t";
                incrementer++;

                // Update DLC's name list
                names += UID + "\n";

                // Copy music
                File.Copy(dir + "\\music.ogg", exportDir + "\\" + dlcTitleId + "\\romfs\\Songs\\audio\\" + UID + ".ogg");
                File.Copy(dir + "\\music.ogg", exportDir + "\\" + dlcTitleId + "\\romfs\\Songs\\audio_preview\\" + UID + "_preview.ogg");

                // Copy BG (if it exists)
                if (File.Exists(dir + "\\background.png"))
                {
                    File.Copy(dir + "\\background.png", exportDir + "\\" + dlcTitleId + "\\romfs\\Songs\\backgrounds\\InGameLoading\\" + UID + "_InGameLoading.png");
                    File.Copy(dir + "\\background.png", exportDir + "\\" + dlcTitleId + "\\romfs\\Songs\\backgrounds\\Result\\" + UID + "_Result.png");
                }
                else
                {
                    File.Copy(curDir + "\\resources\\background.png", exportDir + "\\" + dlcTitleId + "\\romfs\\Songs\\backgrounds\\InGameLoading\\" + UID + "_InGameLoading.png");
                    File.Copy(curDir + "\\resources\\background.png", exportDir + "\\" + dlcTitleId + "\\romfs\\Songs\\backgrounds\\Result\\" + UID + "_Result.png");
                }

                // Copy cover
                File.Copy(dir + "\\cover.png", exportDir + "\\" + dlcTitleId + "\\romfs\\Songs\\covers\\" + UID + ".png");

                // Copy video
                File.Copy(dir + "\\video.mp4", exportDir + "\\" + dlcTitleId + "\\romfs\\Songs\\videos\\" + UID + ".mp4");

                // Copy lyrics (vxla)
                File.Copy(dir + "\\lyrics.vxla", exportDir + "\\" + dlcTitleId + "\\romfs\\Songs\\vxla\\" + UID + ".vxla");

                // Copy metadata
                File.Copy(dir + "\\meta.xml", exportDir + "\\" + dlcTitleId + "\\romfs\\" + UID + "_meta.xml");
            }

            // Write internal DBs
            File.WriteAllText(exportDir + "\\" + coreTitleId + "\\romfs\\Data\\StreamingAssets\\SongsDLC.tsv", songsTsv);
            File.WriteAllText(exportDir + "\\" + dlcTitleId + "\\romfs\\name.txt", names);
        }
    }
}

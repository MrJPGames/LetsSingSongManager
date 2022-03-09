using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US2LS
{
    internal class Song
    {
        public string SongUID;
        public string SongTitle;
        public string SongArtist;
        public string SongReleaseYear;
        public string SongGenre;

        public Song(string ultrastarTxtFilePath)
        {
            SongUID = String.Concat(Guid.NewGuid().ToString("N").Select(c => (char)(c + 17)));
            SongTitle = "Unknown Title";
            SongArtist = "Unknown Artist";
            SongReleaseYear = "2000";
            SongGenre = "Unknown";

            string ultrastarTxt = File.ReadAllText(ultrastarTxtFilePath);
            string[] lines = ultrastarTxt.Split('\n');

            foreach (string line in lines)
            {
                if (line[0] == '#')
                {
                    string[] tagValPair = line.Split(':');
                    switch (tagValPair[0])
                    {
                        case "#ARTIST":
                            SongArtist = tagValPair[1].Replace("\n", "").Replace("\r", "");
                            break;
                        case "#TITLE":
                            SongTitle = tagValPair[1].Replace("\n", "").Replace("\r", "");
                            break;
                        case "#GENRE":
                            SongGenre = tagValPair[1].Replace("\n", "").Replace("\r", "");
                            break;
                        case "#YEAR":
                            SongReleaseYear = tagValPair[1].Replace("\n", "").Replace("\r", "");
                            break;
                        default:
                            Console.WriteLine("Encountered unsupported tag: " + tagValPair[0] + " with value: " + tagValPair[1]);
                            break;
                    }
                }
            }
        }

        public Song(string uid, string title, string artist, string year, string genre)
        {
            SongUID = uid;
            SongTitle = title;
            SongArtist = artist;
            SongReleaseYear = year;
            SongGenre = genre;
        }
    }
}

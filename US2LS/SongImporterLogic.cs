using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US2LS
{
    internal static class SongImporterLogic
    {
        public async static Task GenerateMetaData(Song songData, string outDir)
        {
            string meta = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n" +
                      "<DLCSong xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">\n" +
                      "  <Genre>" + songData.SongGenre + "</Genre>\n" +
                      "  <Id>" + songData.SongUID + "</Id>\n" +
                      "  <Uid>999</Uid>\n" +
                      "  <Artist>" + songData.SongArtist + " </Artist>\n" +
                      "  <Title>" + songData.SongTitle + "</Title>\n" +
                      "  <Year>" + songData.SongReleaseYear + "</Year>\n" +
                      "  <Ratio>Ratio_16_9</Ratio>\n" +
                      "  <Difficulty>Difficulty2</Difficulty>\n" +
                      "  <Feat />\n" +
                      "  <Line1>" + songData.SongArtist + "</Line1>\n" +
                      "  <Line2 />\n" +
                      "</DLCSong>";

            File.WriteAllText(outDir + "\\meta.xml", meta, Encoding.UTF8);
        }

        public async static Task ImportVideo(string videoInPath, string outDir)
        {
            string ffmpegArgs = "-i \"" + videoInPath + "\" \"" + outDir + "\\video.mp4\"";
            StartExternelProcess("ffmpeg", ffmpegArgs);
        }

        public async static Task ImportAudio(string musicInPath, string outDir)
        {
            string ffmpegArgs = "-i \"" + musicInPath + "\" \"" + outDir + "\\music.ogg\"";
            StartExternelProcess("ffmpeg", ffmpegArgs);
        }

        public async static Task ImportLyrics(string ultrastarTxtPath, string outDir)
        {
            string args = "ultrastar2singit.py \"" + ultrastarTxtPath + "\" -s newSong";
            StartExternelProcess("python3", args);
            File.Move("newSong.vxla", outDir + "\\lyrics.vxla");
        }

        // Resize image and (if needed) convert to png
        public async static Task ImportCover(string coverPath, string outDir)
        {
            Image coverImage = Image.FromFile(coverPath);
            Bitmap outImage = ResizeImage(coverImage, 200, 200);
            outImage.Save(outDir + "\\cover.png", ImageFormat.Png);
        }

        private static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private static void StartExternelProcess(string cmd, string args)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = cmd;
            startInfo.Arguments = args;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = false;
            startInfo.RedirectStandardInput = false;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            Process processTemp = new Process();
            processTemp.StartInfo = startInfo;
            try
            {
                processTemp.Start();
                processTemp.StandardOutput.ReadToEnd();
                processTemp.WaitForExit();
                return;
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}

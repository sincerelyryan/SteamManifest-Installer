using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace SteamManifest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebClient wc = new WebClient();
            Console.Title = "Steam Manifest Downloader";
            Console.WriteLine("Enter Steam App ID");
            string appid = Console.ReadLine();
            string folderPath = AppDomain.CurrentDomain.BaseDirectory;
            wc.DownloadFile($"https://codeload.github.com/SSMGAlt/ManifestHub2/zip/refs/heads/{appid}", $"{appid}.zip");
            string zipPath = folderPath + $"{appid}.zip";
            ZipFile.ExtractToDirectory(zipPath, folderPath);
            File.Delete(zipPath);
        }
    }
}

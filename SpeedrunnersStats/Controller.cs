using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedrunnersStats
{
    public partial class Controller
    {
        public Settings settings;
        private List<List<Player>> players;

        public Controller()
        {
            players = new List<List<Player>>();
            settings = new Settings();
            bool invalidData = true;
            bool invalidDumps = true;
            if (File.Exists("SpeedrunnersStatsSettings.txt"))
            {
                StreamReader sr = new StreamReader("SpeedrunnersStatsSettings.txt");
                try
                {
                    bool itemHolder = bool.Parse(sr.ReadLine());
                    bool playerHolder = bool.Parse(sr.ReadLine());
                    bool activeHolder = bool.Parse(sr.ReadLine());
                    string dataHolder = sr.ReadLine();
                    string dumpHolder = sr.ReadLine();
                    if (Directory.Exists(dataHolder)) MessageBox.Show("Data location invalid");
                    else invalidData = false;

                    if (!File.Exists(dumpHolder)) MessageBox.Show("Dump location invalid");
                    else invalidDumps = false;
                    settings.complexItems = itemHolder;
                    settings.complexPlayers = playerHolder;
                    settings.foregroundLoading = activeHolder;
                    settings.dataPath = dataHolder;
                    settings.dumpSource = dumpHolder;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error encountered. Invalid settings file. Load aborted.");
                }
            }
            if (invalidData)
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                while (dialog.ShowDialog() != DialogResult.OK)
                {

                }
            }
            if (invalidDumps)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Text file | *.txt";
                while (dialog.ShowDialog() != DialogResult.OK)
                {

                }
            }
        }
        public void onKill()
        {
            StreamWriter sw = new StreamWriter("SpeedrunnersStatsSettings");
            sw.WriteLine(settings.complexItems.ToString());
            sw.WriteLine(settings.complexPlayers.ToString());
            sw.WriteLine(settings.foregroundLoading.ToString());
            sw.WriteLine(settings.dataPath);
            sw.WriteLine(settings.dumpSource);
        }
    }
}

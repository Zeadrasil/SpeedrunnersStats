using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedrunnersStats
{
    public struct Settings
    {
        public bool complexItems = false;
        public bool complexPlayers = false;
        public bool foregroundLoading = true;
        public string dataPath = "";
        public string dumpSource = "";
        public Settings() { }
        public Settings copy()
        {
            Settings settings = new Settings();
            settings.complexItems = complexItems;
            settings.complexPlayers = complexPlayers;
            settings.foregroundLoading = foregroundLoading;
            settings.dataPath = dataPath;
            settings.dumpSource = dumpSource;
            return settings;
        }
    }
}

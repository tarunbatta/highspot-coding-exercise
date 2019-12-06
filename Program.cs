using System;
using highspot.Entity;
using highspot.Helper;
using Newtonsoft.Json;

namespace highspot
{
    class Program
    {
        static void Main(string[] args)
        {
            string file_mixtape = "mixtape-data.json";
            string file_changes = "changes.json";
            string file_output = "output.json";

            if (args != null && args.Length > 0)
            {
                file_mixtape = args.Length > 0 ? args[0] : file_mixtape;
                file_changes = args.Length > 1 ? args[1] : file_changes;
                file_output = args.Length > 2 ? args[2] : file_output;
            }

            string mixTapeData = Utility.ReadFile(Config.folder_assets + file_mixtape);
            Mixtape mt = JsonConvert.DeserializeObject<Mixtape>(mixTapeData);

            string changesData = Utility.ReadFile(Config.folder_assets + file_changes);
            Change c = JsonConvert.DeserializeObject<Change>(changesData);









            
        }
    }
}

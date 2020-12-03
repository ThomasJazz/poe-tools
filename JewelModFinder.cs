using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace thomasjazz.poetools
{
    public class JewelModFinder
    {
        public IoHelper Helper = new IoHelper();
        public static void Main(string[] args)
        {
            JewelModFinder jmf = new JewelModFinder();
            jmf.Run();
        }

        public void Run()
        {
            // Load all jewel mods
            string jewelModPath = @"Data\JewelMods\jewel-mods.json";
            string modJson = System.IO.File.ReadAllText(jewelModPath);
            Dictionary<string, Mod> jewelMods = JsonConvert.DeserializeObject<Dictionary<string, Mod>>(modJson);

            // Load all mod types
            string modTypePath = @"Sample\mod_types.json";
            string typeJson = System.IO.File.ReadAllText(modTypePath);
            Dictionary<string, ModType> modTypes = JsonConvert.DeserializeObject<Dictionary<string, ModType>>(typeJson);

            Dictionary<string, ModType> jewelModTypes = new Dictionary<string, ModType>();
            List<string> searchTags = new List<string>()
            {
                "sword"
            };

        }
    }
}
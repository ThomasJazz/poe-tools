using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

public class IoHelper
{
    public IoHelper()
    {

    }

    public void WriteObjJsonToFile(string filePath, Object obj)
    {
        string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }

    public void SeparateByTag()
    {
        string json = System.IO.File.ReadAllText(@"Sample\mods.json");

        Dictionary<string, Mod> mods = JsonConvert.DeserializeObject<Dictionary<string, Mod>>(json);
        Console.WriteLine();
        
        List<Dictionary<string, Mod>> jewelMods = new List<Dictionary<string, Mod>>();
        
        
        foreach(KeyValuePair<string, Mod> mod in mods)
        {
            string name = mod.Key;
            Mod val = mod.Value;
            Dictionary<string, Mod> modInfo = new Dictionary<string, Mod>() {{name, val}};

            if (val.Type.Contains("ForJewel"))
                jewelMods.Add(modInfo);
        }

        Console.WriteLine();

        this.WriteObjJsonToFile(@"Data\JewelMods\jewel_mods.json", jewelMods);
    }
}
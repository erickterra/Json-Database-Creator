using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Web;
using System.Windows.Forms;
using Newtonsoft.Json;

public class JsonHandler
{
    public JsonDictionary jd = new JsonDictionary();

    public void GravarJson(JsonDictionary itemData)
    {   
        string jsonQuery = JsonConvert.SerializeObject(itemData, Formatting.Indented);
        File.WriteAllText(Globals.filePath + Globals.fileName, jsonQuery);
    }

    public JsonDictionary ReadJson()
    {
        Debug.WriteLine("Lendo...");
        string jsonToString = File.ReadAllText(Globals.filePath + Globals.fileName);
        return JsonConvert.DeserializeObject<JsonDictionary>(jsonToString);
    }
}

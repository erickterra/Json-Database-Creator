using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Web;
using Newtonsoft.Json;

public class JsonHandler
{
    public JsonDictionary jd = new JsonDictionary();
    public
    string directory = Globals.directory;
    string fileName = Globals.fileName;
    public JsonHandler()
    {
    }

    public void GravarJson(JsonDictionary itemData)
    {
        
        string jsonQuery = JsonConvert.SerializeObject(itemData, Formatting.Indented);
        File.WriteAllText(directory + fileName, jsonQuery);

    }

    public JsonDictionary ReadJson()
    {
        Debug.WriteLine("Lendo...");
        string jsonToString = File.ReadAllText(directory + fileName);
        return JsonConvert.DeserializeObject<JsonDictionary>(jsonToString);
    }
}

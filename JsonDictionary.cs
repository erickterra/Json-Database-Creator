using System;
using System.Collections;
using System.Collections.Generic;
using System.Web;

[Serializable]
public class JsonDictionary
{
    public List<Item> database;
    public List<Consumable> consumables;
    public List<Weapons> weapons;
    public List<Armor> armors;

    public JsonDictionary()
    {
        database = new List<Item>();
        consumables = new List<Consumable>();
        weapons = new List<Weapons>();
        armors = new List<Armor>();
    }
}

using System;
using System.Web;

[Serializable]

public class Item
{
    public string itemName;
    public int itemID;
    public string itemDesc;
    public string itemType;
    public bool itemStack;
    public int itemMaxStack;
    public string itemRarity;


    public Item(string name, int ID, string desc, string type, bool isStackable, int maxStack, string rarity)
    {
        itemName = name;
        itemID = ID;
        itemDesc = desc;
        itemType = type;
        itemStack = isStackable;
        itemMaxStack = maxStack;
        itemRarity = rarity;

    }

    public Item()
    {
        itemID = -1;
    }
}

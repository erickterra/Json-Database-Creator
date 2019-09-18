using System;
using System.Web;

[Serializable]
public class Armor
{
    public int idItem;
    public string armorType;
    public int defense;
    public int speed;
    public int slots;
   

    public Armor(int idItem, string armorType, int defense, int speed, int slots)
    {
        this.idItem = idItem;
        this.armorType = armorType;
        this.defense = defense;
        this.speed = speed;
        this.slots = slots;
    }
}
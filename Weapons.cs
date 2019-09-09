using System;
using System.Web;

[Serializable]
public class Weapons
{
    public int idItem;
    public string weaponType;
    public int attack;
    public int range;

    public Weapons(int idItem, string weaponType, int attack, int range)
    {
        this.idItem = idItem;
        this.weaponType = weaponType;
        this.attack = attack;
        this.range = range;
    }
}
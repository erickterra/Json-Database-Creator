using System;
using System.Web;

[Serializable]
public class Weapons
{
    public int idItem;
    public string weaponType;
    public int attack;
    public int range;
    public string hold;

    public Weapons(int idItem, string weaponType, int attack, int range, string hold)
    {
        this.idItem = idItem;
        this.weaponType = weaponType;
        this.attack = attack;
        this.range = range;
        this.hold = hold;

    }
}
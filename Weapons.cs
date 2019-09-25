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
    public decimal fireRate;
    public decimal reloadSpeed;
    public string ammo;

    public Weapons(int idItem, string weaponType, int attack, int range, string hold,decimal fireRate, decimal reloadSpeed, string ammo)
    {
        this.idItem = idItem;
        this.weaponType = weaponType;
        this.attack = attack;
        this.range = range;
        this.hold = hold;
        this.reloadSpeed = reloadSpeed;
        this.fireRate = fireRate;
        this.ammo = ammo;

    }
}
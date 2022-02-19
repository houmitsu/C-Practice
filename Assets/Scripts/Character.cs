using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Weapon
{
    public string name;
    public int damage;

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    public void PrintWeaponStats()
    {
        Debug.LogFormat("Weapon: {0} - {1} DMB", name, damage);
    }
}

//public struct warBow
//{
//    Weapon huntingBow = new Weapon("Hunting Bow", 105);
//    Weapon warBow = hunitingBow;
//}

public class Character
{
    public string name;
    public int exp = 0;

    public Character()
    {
        name = "未設定";
    }

    public Character(string name)
    {
        this.name = name;
    }

    public void PrintStatsInfo()
    {
        Debug.LogFormat("Hero: {0} - {1} EXP", name, exp);
    }
}




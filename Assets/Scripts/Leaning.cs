using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Character hero = new Character();
        //Debug.LogFormat("Hero: {0} - {1} EXP", hero.name, hero.exp);
        Character hero2 = hero;
        hero2.name = "Sir Krane the Brave";
        
        hero.PrintStatsInfo();
        hero2.PrintStatsInfo();

        //Character heroine = new Character("アガサ");
        //heroine.PrintStatsInfo();



        //Weapon huntingBow = new Weapon("Hunting Bow", 105);

        //huntingBow.PrintWeaponStats();
        //warBow.PrintWeaponStats;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

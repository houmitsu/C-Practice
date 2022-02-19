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
        hero.PrintStatsInfo();

        Character heroine = new Character("アガサ");
        heroine.PrintStatsInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

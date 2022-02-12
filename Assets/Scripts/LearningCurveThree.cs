using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurveThree : MonoBehaviour
{
    public bool hasDungeonKey = false;
    public string weaponType = "Arcane Staff";

    // Start is called before the first frame update
    void Start()
    {
        if(!hasDungeonKey)
        {
            Debug.Log("秘密の鍵がなければ入れませんぞ");
        }

        if(weaponType != "LongSword")
        {
            Debug.Log("その武器ではいけませんなぁ");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

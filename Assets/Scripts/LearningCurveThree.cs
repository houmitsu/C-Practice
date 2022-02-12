using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurveThree : MonoBehaviour
{
    public bool weaponEquipped = true;
    public string weaponType = "Londsword";

    // Start is called before the first frame update
    void Start()
    {
        if(weaponEquipped)
        {
            if(weaponType == "Londsword")
            {
                Debug.Log("女王陛下ばんざい！");
            }
        }
        else
        {
            Debug.Log("素手では鎧武者に勝てぬぞ");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

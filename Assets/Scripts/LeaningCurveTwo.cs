using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaningCurveTwo : MonoBehaviour
{
    public bool hasDungeonKey = true;

    // Start is called before the first frame update
    void Start()
    {
        if(hasDungeonKey)
        {
            Debug.Log("秘密の鍵をお持ちだね。通りなさい。");
        }
        else
        {
            Debug.Log("戦士よ、身の証を立てねば通せぬぞ。");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

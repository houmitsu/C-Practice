using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaningCurveTwo : MonoBehaviour
{
    public int currentGold = 32;

    // Start is called before the first frame update
    void Start()
    {
        if (currentGold > 50)
        {
            Debug.Log("旦那は金持ちだね。スリに注意しなさいよ。");
        }
        else if (currentGold < 15) 
        {
            Debug.Log("ちぇ。しけてやがる。またな");
        }
        else
        {
            Debug.Log("ちょうどいい額だ。いただくぜ。");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
